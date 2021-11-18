using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Persistent.Validation;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XafDataModel.Module.BusinessObjects.test2;
using static XafDataModel.Module.BusinessObjects.test2.PurchasingOrder;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PurchasingController : ViewController
    {
        public PurchasingController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void Confirmed_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var order = View.CurrentObject as PurchasingOrder;
            order.OrderConfirm(true);
        }

        private void UnConfirmed_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var order = View.CurrentObject as PurchasingOrder;
            order.OrderConfirm(false);
        }


        private void NeededItems_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.NeededItems report = new reports.NeededItems();
            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void RefundDocument_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.RefundDocument report = new reports.RefundDocument();
            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void BuyingInvoice_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.BuyingInvoice report = new reports.BuyingInvoice();
            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void BuyingOrder_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.BuyingOrder report = new reports.BuyingOrder();
            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void PurchasingOrder_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.PurchasingOrder report = new reports.PurchasingOrder();

            var curr = View.CurrentObject as PurchasingOrder;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
            {
                Supplier supplier = ObjectSpace.FindObject<Supplier>(new BinaryOperator("FullName", curr.supplierAccount.accountName));
                if(supplier != null)
                {
                    report.Parameters["moblie"].Value = supplier.PhoneNumbers[0].Number.ToString();
                    report.Parameters["address"].Value = supplier.Address1.FullAddress;
                }



                string orderType = "";
                switch (curr.OrderType)
                {
                    case OrderTypes.InCash:
                        orderType = "مشتريات نقدية";
                        break;
                    case OrderTypes.Partial:
                        orderType = "مشتريات جزئية";
                        break;
                    case OrderTypes.OnCredit:
                        orderType = "مشتريات اجلة";
                        break;
                    case OrderTypes.IncashSalesReturns:
                        orderType = "مردودات مشتريات نقدية";
                        break;
                    case OrderTypes.PartialSalesReturns:
                        orderType = "مردودات مشتريات جزئية";
                        break;
                    case OrderTypes.OnCreditSalesReturns:
                        orderType = "مردودات مشتريات اجلة";
                        break;
                    case OrderTypes.PositiveStockTalking:
                        orderType = "زيادة جرد مخزون";
                        break;
                    case OrderTypes.NegativeStockTalking:
                        orderType = "عجز جرد مخزون";
                        break;
                    case OrderTypes.PurchasingOrder:
                        orderType = "طلبية شراء";
                        break;
                }
                string totalOrderN2C = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.totalOrder), "جنيه", "قرش") + " فقط لاغير ";
                report.Parameters["parameter1"].Value = ((PurchasingOrder)View.CurrentObject).id;
                report.Parameters["statement"].Value = curr.statement;
                report.Parameters["orderType"].Value = orderType;
                report.Parameters["totalOrderN2C"].Value = totalOrderN2C;

            }

            report.ShowPreviewDialog();
        }

      

        private void SarfWQabd_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ReceiptVoucherReport report = new reports.ReceiptVoucherReport();

            var curr = View.CurrentObject as receiptClientBond;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((receiptClientBond)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void OrderJournalReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.InventoryOperations report = new reports.InventoryOperations();

            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void OrderJournalReport_Execute_1(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.JournalEntryReport report = new reports.JournalEntryReport();

            var curr = View.CurrentObject as PurchasingOrder;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
            {
                PermissionPolicyUser user;
                if (SecuritySystem.CurrentUser != null)
                {
                    user = ObjectSpace.GetObjectByKey<PermissionPolicyUser>(SecuritySystem.CurrentUserId);
                    report.Parameters["user"].Value = user.UserName;
                }

                report.Parameters["parameter1"].Value = ((PurchasingOrder)View.CurrentObject).journalEntry.ID;
            }

            report.ShowPreviewDialog();
        }

        private void AcceptAllRequest_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curr = View.CurrentObject as PurchaseRequest;

            var requstedAndApproved = curr.PurchaseRequestDetails;
            var purchaseOrder = ObjectSpace.CreateObject<PurchasingOrder>();
            curr.Order = purchaseOrder;
            purchaseOrder.inventory = curr.Warehouse;
            foreach(var i in requstedAndApproved)
            {
                i.Approved = true;
                var purchaseOrderDetail = ObjectSpace.CreateObject<PurchasingOrderDetail>();
                purchaseOrderDetail.product = i.Product;
                purchaseOrderDetail.quantity = i.RequstedAmount;
                purchaseOrderDetail.price = 1;
                purchaseOrderDetail.puchasingOrder = purchaseOrder;
                curr.Approved = true;
            }
            ObjectSpace.CommitChanges();
        }

       

        private void CancelPurchaseRequest_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curr = View.CurrentObject as PurchaseRequest;

            var requstedAndApproved = curr.PurchaseRequestDetails;
            var purchaseOrder = ObjectSpace.GetObjectByKey(typeof(PurchasingOrder),curr.Order.id);
            ObjectSpace.Delete(purchaseOrder);
            curr.Order = null;
            foreach (var i in requstedAndApproved)
            {
                i.Approved = false;
                //var purchaseOrderDetail = ObjectSpace.CreateObject<PurchasingOrderDetail>();
                //purchaseOrderDetail.product = i.Product;
                //purchaseOrderDetail.quantity = 1;
                //purchaseOrderDetail.price = 1;
                //purchaseOrderDetail.puchasingOrder = purchaseOrder;
                curr.Approved = false;
            }
            ObjectSpace.CommitChanges();
        }

        private void RequestReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

        }

        private void AcceptSomeOFTheRequest_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curr = View.CurrentObject as PurchaseRequest;

            var requstedAndApproved = curr.PurchaseRequestDetails.Where(p => p.Approved == true);
            var purchaseOrder = ObjectSpace.CreateObject<PurchasingOrder>();
            curr.Order = purchaseOrder;
            purchaseOrder.inventory = curr.Warehouse;
            foreach (var i in requstedAndApproved)
            {
                i.Approved = true;
                var purchaseOrderDetail = ObjectSpace.CreateObject<PurchasingOrderDetail>();
                purchaseOrderDetail.product = i.Product;
                purchaseOrderDetail.quantity = i.RequstedAmount;
                purchaseOrderDetail.price = 1;
                purchaseOrderDetail.puchasingOrder = purchaseOrder;
                curr.Approved = true;
            }
            ObjectSpace.CommitChanges();
        }
    }
}
