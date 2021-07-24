using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class PurchasingOrderDetail
    {
        public PurchasingOrderDetail(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction();  }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
        }


        protected override void OnSaved()
        {
            base.OnSaved();
            try
            {
                this.puchasingOrder.TotalOrderChangeFlag();
            }
            catch
            {

            }
        }
    }

}
