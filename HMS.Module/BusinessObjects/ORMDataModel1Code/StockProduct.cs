using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    [DefaultProperty("product.barCode")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    public partial class StockProduct
    {
        public StockProduct(Session session) : base(session) { }
        public override void AfterConstruction() 
        { 
            base.AfterConstruction(); 
        }


        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if(propertyName == nameof(secondUnitQuantity))
            {
                double oldVal = Convert.ToDouble(oldValue);
                double newVal = Convert.ToDouble(newValue);
                if ( newVal >= this.product.unitAmount)
                {
                        this.firstUnitQuantity += ((newVal - (newVal % this.product.unitAmount)) / (this.product.unitAmount));
                        this.secondUnitQuantity = (newVal % this.product.unitAmount);                   
                }

                if ( newVal < 0)
                {
                    this.firstUnitQuantity -= (((-1 * newVal) - ((-1 * newVal) % this.product.unitAmount)) / (this.product.unitAmount)) + 1;
                    this.secondUnitQuantity = (this.product.unitAmount - ((-1 * newVal) % this.product.unitAmount));

                    //this.secondUnitQuantity = ((-1 * newVal) % this.product.unitAmount) != 0 ? this.secondUnitQuantity =this.product.unitAmount -  (-1 * newVal) : 0;
                }
            }
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            //var suppleis = Session.Query<StaySupplies>().Where(p => p.supplyProduct == this).ToList();
            //Session.Delete(suppleis);

            //var transfers = Session.Query<TransferProduct>().Where(p => p.StockProduct == this).ToList();
            Session.Delete(this.TransferProducts);
            Session.Delete(this.StaySuppliesCollection);

        }
    }

}
