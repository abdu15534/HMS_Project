using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class XraysDetails
    {
        public XraysDetails(Session session) : base(session) { }
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
                        this.price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.admission.Patient.Contract.PricList).First().Price;
                    }
                    else
                    {
                        this.price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.admission.Patient.Contract.PricList).First().Price * Convert.ToDecimal(1.5);
                    }
                }
                else if (this.Xrays != null)
                {
                    if (this.Xrays.Patient != null && this.Xrays.Patient.Nationality != Patient.Nationalitys.مصر)
                    {
                        this.price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.Xrays.Patient.Contract.PricList).First().Price * Convert.ToDecimal(1.5);

                    }
                    else
                    {
                        this.price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.Xrays.Patient.Contract.PricList).First().Price;
                    }
                }
                else if (this.Emergency != null)
                {
                    if (this.Emergency.Patient != null && this.Emergency.Patient.Nationality != Patient.Nationalitys.مصر)
                    {
                        this.price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.Emergency.Patient.Contract.PricList).First().Price * Convert.ToDecimal(1.5);

                    }
                    else
                    {
                        this.price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.Emergency.Patient.Contract.PricList).First().Price;
                    }
                }
            }
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsDeleted)
                if (this.service == null)
                    this.Delete();
            if (admission != null)
            {
                IEnumerable<PackageDetail> packages = admission.reception.PackageDetails.Where(o => o.Applyed);
                if (packages != null)
                {
                    foreach (PackageDetail item in packages)
                    {
                        item.ApplyPackageToXrays();
                    }
                }
            }
        }
    }

}
