using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class EndscopeDetails
    {
        public EndscopeDetails(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); date = DateTime.Now; }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(service) && newValue != null)
            {
                if (this.admission != null)
                {
                    if (this.admission.Patient.Nationality == Patient.Nationalitys.مصر)
                    {
                        this.price = ((Service)newValue).Price;
                    }
                    else
                    {
                        this.price = ((Service)newValue).Price * Convert.ToDecimal(1.5);
                    }
                }
                else if (this.Endscope != null)
                {
                    if (this.Endscope.Patient != null && this.Endscope.Patient.Nationality != Patient.Nationalitys.مصر)
                    {
                        this.price = ((Service)newValue).Price * Convert.ToDecimal(1.5);
                        
                    }
                    else
                    {
                        this.price = ((Service)newValue).Price;
                    }
                }
            }
        }

    }

}
