using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using System.Linq;
using System.Windows.Forms;

namespace XafDataModel.Module.BusinessObjects.test2
{
    
    public partial class PurchasingOrder
    {
        public PurchasingOrder(Session session) : base(session) { }
        public override void AfterConstruction() 
        {
            base.AfterConstruction();
            isConfirmed = false;
            paymentAccount = Session.FindObject<Account>(new BinaryOperator("accountNumber", 104020001));

            journalEntry = new JournalEntry(Session);
            journalEntry.date = DateTime.Now;

            date = DateTime.Now;
            inventory = Session.Query<Inventory>().First();
            supplierAccount = Session.FindObject<Account>(new BinaryOperator("accountNumber", 207010001));
        }

        OrderTypes orderType;

        public OrderTypes OrderType
        {
            get => orderType;
            set => SetPropertyValue(nameof(OrderType), ref orderType, value);
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            if(isConfirmed)
            {
                OrderConfirm(false);
            }
            this.journalEntry.Delete();
        }
        protected override void OnSaving()
        {
            base.OnSaving();
            foreach (var item in PurchasingOrderDetails.ToList())
            {
                if (item.amount == 0)
                    item.Delete();
            }

            if (OrderType == OrderTypes.OnCredit || OrderType == OrderTypes.BeginningInventory || OrderType == OrderTypes.PurchasingOrder || OrderType == OrderTypes.OnCreditSalesReturns)
                paid = 0;
            if (OrderType == OrderTypes.InCash || OrderType == OrderTypes.IncashSalesReturns)
                paid = totalOrder;


            journalEntry.type = this.GetType().ToString();
            journalEntry.objectKey = this.id.ToString();
            journalEntry.date = this.date;

            TotalOrderChangeFlag();
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (!(propertyName == nameof(totalOrder) && oldValue == newValue))
            {
                TotalOrderChangeFlag();
            }
        }

        protected override void OnSaved()
        {
            base.OnSaved();
        }

        public void TotalOrderChangeFlag()
        {
            try
            {
                decimal totalAmount = Session.Query<PurchasingOrderDetail>().Where(p => p.puchasingOrder == this).Sum(p => p.amount);
                decimal _discount = ((decimal)discount / 100m) * totalAmount;
                decimal _vat = ((decimal)VAT / 100m) * totalAmount;
                decimal _tax = ((decimal)tax / 100m) * totalAmount;
                decimal totalOrderBeforeTax = totalAmount + purchasingServices - _discount;
                totalOrder = totalOrderBeforeTax + _vat - _tax ;
            }
            catch
            {
                MessageBox.Show("Error", "Something wen wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalOrder = 0.0m;
            }
            finally
            {
                if (OrderType == OrderTypes.OnCredit || OrderType == OrderTypes.BeginningInventory || OrderType == OrderTypes.PurchasingOrder || OrderType == OrderTypes.OnCreditSalesReturns)
                    paid = 0;
                if (OrderType == OrderTypes.InCash || OrderType == OrderTypes.IncashSalesReturns)
                    paid = totalOrder;
            }
        }


        public enum OrderTypes
        {
            [ImageName("BO_ORDER")]BeginningInventory, InCash, Partial, OnCredit, IncashSalesReturns, PartialSalesReturns, OnCreditSalesReturns , PositiveStockTalking, NegativeStockTalking , PurchasingOrder
        }

        public void OrderConfirm(bool add)
        {
            if (add)
            {
                journalEntry.DeleteDetails();
                SetJournalDetails();
                journalEntry.Post(false);
                isConfirmed = true;
            }

            else
            {
                journalEntry.Post(true);
                isConfirmed = false;
            }

            foreach (PurchasingOrderDetail item in PurchasingOrderDetails.ToList())
            {
                var stockProductList = Session.Query<StockProduct>().Where(p => p.Inventory == this.inventory).Where(p => p.product == item.product).ToList();
                
                StockProduct stockProduct;
                if (stockProductList.Count == 0)
                {
                    stockProduct = new StockProduct(Session);
                    stockProduct.Inventory = this.inventory;
                    stockProduct.product = item.product;
                }
                else
                    stockProduct = stockProductList[0];

                //Oppiste the order operation
                if (!InventoryOperationType())
                {
                    if (add)
                        add = false;

                    else
                        add = true;
                }


                if(add)
                {
                    //Update stock quantity
                    stockProduct.firstUnitQuantity += item.quantity;

                    //Calculate product purchasing weigted price
                    //select all product orders if isConfirmed
                    if(OrderType != OrderTypes.PositiveStockTalking && OrderType != OrderTypes.NegativeStockTalking)
                    {
                        var numerator = 0m;
                        var newMedicenPrice = 0m;
                        if (this.inventory.InventoryType == Inventory.InventoryTypes.Pharmacy)
                        {
                            newMedicenPrice = Session.Query<PurchasingOrderDetail>().Where(o => o.product == stockProduct.product && (o.puchasingOrder.isConfirmed == true || o.puchasingOrder == this)).Sum(p => p.price * Convert.ToDecimal(p.quantity));
                            numerator = Session.Query<PurchasingOrderDetail>().Where(o => o.product == stockProduct.product && (o.puchasingOrder.isConfirmed == true || o.puchasingOrder == this)).Sum(p => (p.price - (p.price * Convert.ToDecimal(Convert.ToDouble(p.Discount) / 100))) * Convert.ToDecimal(p.quantity));
                        }
                        else
                        {
                            numerator = Session.Query<PurchasingOrderDetail>().Where(o => o.product == stockProduct.product && (o.puchasingOrder.isConfirmed == true || o.puchasingOrder == this)).Sum(p => p.price * Convert.ToDecimal(p.quantity));
                        }
                            
                        var denominator = Session.Query<PurchasingOrderDetail>().Where(o => o.product == stockProduct.product && (o.puchasingOrder.isConfirmed == true || o.puchasingOrder == this)).Sum(p => Convert.ToDecimal(p.quantity));
                        if (denominator == 0)
                            stockProduct.product.purchasingPrice = 0;
                        else
                            stockProduct.product.purchasingPrice = numerator / denominator;
                            if(this.inventory.InventoryType == Inventory.InventoryTypes.Stock)
                            {
                                if(stockProduct.product.purchasingPrice >= Convert.ToDecimal(0) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(5))
                                {
                                stockProduct.product.sellingPrice = stockProduct.product.purchasingPrice * Convert.ToDecimal(3);
                                }
                            else if(stockProduct.product.purchasingPrice >= Convert.ToDecimal(6) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(10))
                                {
                                stockProduct.product.sellingPrice = stockProduct.product.purchasingPrice * Convert.ToDecimal(2.5);
                                }
                                else if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(11) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(20))
                                {
                                stockProduct.product.sellingPrice = stockProduct.product.purchasingPrice * Convert.ToDecimal(2);
                                }
                                else if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(21) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(30))
                                {
                                stockProduct.product.sellingPrice = stockProduct.product.purchasingPrice * Convert.ToDecimal(1.7);
                                }
                            else if(stockProduct.product.purchasingPrice >= Convert.ToDecimal(31) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(40))
                                {
                                stockProduct.product.sellingPrice = stockProduct.product.purchasingPrice * Convert.ToDecimal(1.5);
                            }
                            else if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(41) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(50))
                            {
                                stockProduct.product.sellingPrice = stockProduct.product.purchasingPrice * Convert.ToDecimal(1.35);
                            }
                            else
                                {
                                stockProduct.product.sellingPrice = stockProduct.product.purchasingPrice * Convert.ToDecimal(1.3);
                            }
                        }
                        else
                        {
                            if(denominator != 0m) 
                            {
                                stockProduct.product.sellingPrice = newMedicenPrice / denominator;
                            }
                            else
                            {
                                stockProduct.product.sellingPrice = newMedicenPrice;
                            }
                            
                        }
                    }
                }
                else
                {
                    //Update stock quantity
                    stockProduct.firstUnitQuantity -= item.quantity;

                    //Calculate product purchasing weigted price
                    //select all product orders if isConfirmed
                    if (OrderType != OrderTypes.PositiveStockTalking && OrderType != OrderTypes.NegativeStockTalking)
                    {
                        var numerator = Session.Query<PurchasingOrderDetail>().Where(o => o.product == stockProduct.product && (o.puchasingOrder.isConfirmed == true && o.puchasingOrder != this)).Sum(p => p.price * Convert.ToDecimal(p.quantity));
                        var denominator = Session.Query<PurchasingOrderDetail>().Where(o => o.product == stockProduct.product && (o.puchasingOrder.isConfirmed == true && o.puchasingOrder != this)).Sum(p => Convert.ToDecimal(p.quantity));
                        if (denominator == 0)
                            stockProduct.product.purchasingPrice = 0;
                        else
                            stockProduct.product.purchasingPrice = numerator / denominator;
                        if (this.inventory.InventoryType == Inventory.InventoryTypes.Stock)
                        {
                            if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(0) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(5))
                            {
                                stockProduct.product.purchasingPrice *= Convert.ToDecimal(3);
                            }
                            else if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(6) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(10))
                            {
                                stockProduct.product.purchasingPrice *= Convert.ToDecimal(2.5);
                            }
                            else if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(11) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(20))
                            {
                                stockProduct.product.purchasingPrice *= Convert.ToDecimal(2);
                            }
                            else if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(21) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(30))
                            {
                                stockProduct.product.purchasingPrice *= Convert.ToDecimal(1.7);
                            }
                            else if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(31) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(40))
                            {
                                stockProduct.product.purchasingPrice *= Convert.ToDecimal(1.5);
                            }
                            else if (stockProduct.product.purchasingPrice >= Convert.ToDecimal(41) && stockProduct.product.purchasingPrice <= Convert.ToDecimal(50))
                            {
                                stockProduct.product.purchasingPrice *= Convert.ToDecimal(1.35);
                            }
                            else
                            {
                                stockProduct.product.purchasingPrice *= Convert.ToDecimal(1.3);
                            }
                        }

                    }
                }
            }
        }

        public bool InventoryOperationType()
        {
            if(orderType == OrderTypes.BeginningInventory || OrderType == OrderTypes.InCash || OrderType == OrderTypes.Partial || OrderType == OrderTypes.OnCredit || OrderType == OrderTypes.PositiveStockTalking)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetJournalDetails()
        {

            if(orderType == OrderTypes.BeginningInventory)
            {
                this.statement = $"مخزون اول المدة رقم {this.id}";

                var acc1 = new JournalDetails(Session);
                acc1.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 102010001));
                acc1.debit = this.PurchasingOrderDetails.Sum(p => p.amount);
                acc1.statement = $"مخزون اول المدة رقم {this.id}";
                acc1.journal = this.journalEntry;

                var acc2 = new JournalDetails(Session);
                acc2.account = this.paymentAccount;
                acc2.credit = this.PurchasingOrderDetails.Sum(p => p.amount);
                acc2.statement = $"مخزون اول المدة رقم {this.id}";
                acc2.journal = this.journalEntry;
            }
            
            if (OrderType == OrderTypes.InCash || OrderType == OrderTypes.Partial || OrderType == OrderTypes.OnCredit  )
            {
                switch (OrderType)
                {
                    case OrderTypes.InCash:
                        this.statement = $"مشتريات نقدية رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                        break;
                    case OrderTypes.Partial:
                        this.statement = $"مشتريات جزئية رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                        break;
                    case OrderTypes.OnCredit:
                        this.statement = $"مشتريات اجلة رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                        break;
                }

                this.journalEntry.statement = this.statement;
                
                var acc1 = new JournalDetails(Session);
                acc1.account = Session.FindObject<Account>(new BinaryOperator("accountNumber" , 304010001));
                acc1.debit = this.PurchasingOrderDetails.Sum(p => p.amount);
                acc1.statement = this.statement;
                acc1.journal = this.journalEntry;

                var acc2 = new JournalDetails(Session);
                acc2.account = this.supplierAccount;
                acc2.credit = totalOrder;
                acc2.statement = this.statement;
                acc2.journal = this.journalEntry;

                if(paid > 0)
                {
                    var acc3 = new JournalDetails(Session);
                    acc3.account = this.supplierAccount;
                    acc3.debit = paid;
                    acc3.statement = $"دفعة سداد لمشتريات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc3.journal = this.journalEntry;

                    var acc4 = new JournalDetails(Session);
                    acc4.account = this.paymentAccount;
                    acc4.credit = paid;
                    acc4.statement = $"دفعة سداد لمشتريات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc4.journal = this.journalEntry;
                }

                if(purchasingServices > 0)
                {
                    var acc5 = new JournalDetails(Session);
                    acc5.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 303010002));
                    acc5.debit = purchasingServices;
                    acc5.statement = $"مشتريات خدمات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc5.journal = this.journalEntry;
                }

                if(discount > 0)
                {
                    var acc6 = new JournalDetails(Session);
                    acc6.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 304010003));
                    acc6.credit = ((decimal)discount / 100m) * (this.PurchasingOrderDetails.Sum(p => p.amount));
                    acc6.statement = $"خصم متكسب عن مشتريات خدمات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc6.journal = this.journalEntry;
                }

                if(VAT > 0)
                {
                    var acc7 = new JournalDetails(Session);
                    acc7.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 207040002));
                    acc7.debit = ((decimal)VAT / 100m) * (this.PurchasingOrderDetails.Sum(p => p.amount));
                    acc7.statement = $"ضريبة قيمة مضافة عن مشتريات خدمات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc7.journal = this.journalEntry;
                }

                if(tax > 0)
                {
                    var acc8 = new JournalDetails(Session);
                    acc8.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 207040003));
                    acc8.credit = ((decimal)tax / 100m) * (this.PurchasingOrderDetails.Sum(p => p.amount));
                    acc8.statement = $"ضريبة أ.ت.ص مستقطة من الغير عن مشتريات خدمات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc8.journal = this.journalEntry;
                }
            }

            if (OrderType == OrderTypes.IncashSalesReturns || OrderType == OrderTypes.PartialSalesReturns|| OrderType == OrderTypes.OnCreditSalesReturns)
            {
                switch (OrderType)
                {
                    case OrderTypes.IncashSalesReturns:
                        this.statement = $"مردودات مشتريات نقدية رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                        break;
                    case OrderTypes.PartialSalesReturns:
                        this.statement = $"مردودات مشتريات جزئية رقم  : {this.id} من السادة / {this.supplierAccount.accountName}";
                        break;
                    case OrderTypes.OnCreditSalesReturns:
                        this.statement = $"مردودات مشتريات اجلة رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                        break;
                }

                this.journalEntry.statement = this.statement;

                var acc1 = new JournalDetails(Session);
                acc1.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 304010002));
                acc1.credit = this.PurchasingOrderDetails.Sum(p => p.amount);
                acc1.statement = this.statement;
                acc1.journal = this.journalEntry;

                var acc2 = new JournalDetails(Session);
                acc2.account = this.supplierAccount;
                acc2.debit = totalOrder;
                acc2.statement = this.statement;
                acc2.journal = this.journalEntry;

                if (paid > 0)
                {
                    var acc3 = new JournalDetails(Session);
                    acc3.account = this.supplierAccount;
                    acc3.credit = paid;
                    acc3.statement = $"دفعة سداد لمردودات مشتريات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc3.journal = this.journalEntry;

                    var acc4 = new JournalDetails(Session);
                    acc4.account = this.paymentAccount;
                    acc4.debit = paid;
                    acc4.statement = $"دفعة سداد لمردودات مشتريات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc4.journal = this.journalEntry;
                }

                if (purchasingServices > 0)
                {
                    var acc5 = new JournalDetails(Session);
                    acc5.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 303010002));
                    acc5.credit = purchasingServices;
                    acc5.statement = $"مردودات مشتريات خدمات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc5.journal = this.journalEntry;
                }

                if (discount > 0)
                {
                    var acc6 = new JournalDetails(Session);
                    acc6.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 304010003));
                    acc6.debit = ((decimal)discount / 100m) * (this.PurchasingOrderDetails.Sum(p => p.amount));
                    acc6.statement = $"خصم متكسب عن مردودات مشتريات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc6.journal = this.journalEntry;
                }


                if (tax > 0)
                {
                    var acc8 = new JournalDetails(Session);
                    acc8.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 207040003));
                    acc8.debit = ((decimal)tax / 100m) * (this.PurchasingOrderDetails.Sum(p => p.amount));
                    acc8.statement = $"ضريبة أ.ت.ص مستقطة من الغير عن مردودات مشتريات رقم : {this.id} من السادة / {this.supplierAccount.accountName}";
                    acc8.journal = this.journalEntry;
                }
            }

            if (orderType == OrderTypes.PositiveStockTalking)
            {
                this.statement = $"زيادة جرد مخزون رقم {this.id}";

                var acc1 = new JournalDetails(Session);
                acc1.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 102010001));
                acc1.debit = this.PurchasingOrderDetails.Sum(p => p.amount);
                acc1.statement = $"زيادة جرد مخزون رقم {this.id}";
                acc1.journal = this.journalEntry;
                
                var acc2 = new JournalDetails(Session);
                acc2.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 403030008));
                acc2.credit = this.PurchasingOrderDetails.Sum(p => p.amount);
                acc2.statement = $"زيادة جرد مخزون رقم {this.id}";
                acc2.journal = this.journalEntry;
            }

            if (orderType == OrderTypes.NegativeStockTalking)
            {
                this.statement = $"عجز جرد مخزون رقم {this.id}";

                var acc1 = new JournalDetails(Session);
                acc1.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 305030003));
                acc1.debit = this.PurchasingOrderDetails.Sum(p => p.amount);
                acc1.statement = $"عجز جرد مخزون رقم {this.id}";
                acc1.journal = this.journalEntry;

                var acc2 = new JournalDetails(Session);
                acc2.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 102010001));
                acc2.credit = this.PurchasingOrderDetails.Sum(p => p.amount);
                acc2.statement = $"عجز جرد مخزون رقم {this.id}";
                acc2.journal = this.journalEntry;
            }

        }
    }

}
