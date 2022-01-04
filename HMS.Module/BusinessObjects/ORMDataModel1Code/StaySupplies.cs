using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    [DefaultClassOptions]
    public partial class StaySupplies
    {
        public StaySupplies(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); quantity = 0; date = DateTime.Now; }
        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (propertyName == nameof(quantity) && supplyProduct != null)
            {
                Int32 newVal = Convert.ToInt32(newValue);
                Int32 oldVal = Convert.ToInt32(oldValue);

                if (newVal > oldVal)
                {
                    Int32 totalVal = newVal - oldVal;
                    if ((supplyProduct.firstUnitQuantity) * supplyProduct.product.unitAmount + supplyProduct.secondUnitQuantity >= totalVal)
                        supplyProduct.secondUnitQuantity -= newVal - oldVal;
                    else
                    {
                        fquantity = (supplyProduct.firstUnitQuantity) * supplyProduct.product.unitAmount + supplyProduct.secondUnitQuantity;
                        supplyProduct.firstUnitQuantity = 0;
                        supplyProduct.secondUnitQuantity = 0;
                    }
                }
                else
                {
                    supplyProduct.secondUnitQuantity += oldVal - newVal;
                }
            }

            if (propertyName == nameof(supplyProduct))
            {
                if (oldValue != null)
                {
                    var med = oldValue as StockProduct;
                    med.secondUnitQuantity += quantity;
                    fquantity = 0;
                }

                else fquantity = 0;

                var medic = newValue as StockProduct;
                if (medic != null)
                {
                    if (this.Stay != null)
                    {
                        if (this.Stay.Patient.Nationality == Patient.Nationalitys.مصر)
                        {
                            price = medic.product.sellingPrice / medic.product.unitAmount;
                        }
                        else
                        {
                            price = medic.product.sellingPrice / medic.product.unitAmount;
                            price = price * Convert.ToDecimal(1.5);
                        }
                    }
                    else if (this.emergency != null)
                    {
                        if (this.emergency.Patient != null && this.emergency.Patient.Nationality != Patient.Nationalitys.مصر)
                        {
                            price = medic.product.sellingPrice / medic.product.unitAmount;
                            price = price * Convert.ToDecimal(1.5);

                        }
                        else
                        {
                            price = medic.product.sellingPrice / medic.product.unitAmount;
                        }
                    }
                    
                }
            }

            if (supplyProduct != null && supplyProduct.product != null && supplyProduct.product.purchasingPrice != 0)
            {
                profit = Convert.ToDecimal((double)((price - (supplyProduct.product.purchasingPrice / supplyProduct.product.unitAmount))) * quantity);
            }
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsDeleted)
                if (this.supplyProduct == null || quantity == 0)
                    this.Delete();
            //if (Stay != null)
            //{
            //    IEnumerable<PackageDetail> packages = Stay.reception.PackageDetails.Where(o => o.Applyed);
            //    if (packages != null)
            //    {
            //        foreach (PackageDetail item in packages)
            //        {
            //            item.ApplyPackageToMedicalSupplies();
            //        }
            //    }
            //}

        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            if (supplyProduct != null && !IsLoading && quantity != 0)
                this.supplyProduct.secondUnitQuantity += quantity;
        }

    }

}
