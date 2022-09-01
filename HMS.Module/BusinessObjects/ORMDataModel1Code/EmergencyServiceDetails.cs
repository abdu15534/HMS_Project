using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

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


                if (this.Emergency != null)
                {
                    if (this.Emergency.Patient != null && this.Emergency.Patient.Nationality != Patient.Nationalitys.مصر)
                    {
                        this.Price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.Emergency.Patient.Contract.PricList).First().Price * Convert.ToDecimal(1.5);

                    }
                    else
                    {
                        this.Price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.Emergency.Patient.Contract.PricList).First().Price * Convert.ToDecimal(1);
                    }
                }
            }
        }
    }
    }
    
