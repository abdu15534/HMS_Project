using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class EmergencyServiceDetails
    {
        public EmergencyServiceDetails(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); date = DateTime.Now; }
        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(Service) && newValue != null)
            {
                //if (this.Emergency.Patient.Nationality == Patient.Nationalitys.مصر)
                //{
                //    this.Price = ((Service)newValue).Price;
                //}
                //else
                //{
                //    this.Price = ((Service)newValue).Price * Convert.ToDecimal(1.5);
                //}
            }
        }
    }
    
}
