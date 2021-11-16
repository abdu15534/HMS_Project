using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class TransferProduct
    {
        public TransferProduct(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction();}

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (propertyName == nameof(StockProduct))
            {
                //this.QuantityC = Session.Query<StockProduct>.Where(p => p == ); this.StockTransfer.FromWarehouse.StockProducts.Where.firstUnitQuantity;
            }
            //if (propertyName == nameof(Approved))
            //{
            //    this.QuantityC = this.StockProduct.firstUnitQuantity;
            //}
        }

        }

}
