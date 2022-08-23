using DevExpress.Xpo;
using System;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class ClinicServiceDetail
    {
        public ClinicServiceDetail(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Date = DateTime.Now;

        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (propertyName == nameof(ClinicService) && ClinicService != null)
            {
                if (this.Appointment != null)
                {
                    if (this.Appointment.Patient.Nationality == Patient.Nationalitys.مصر)
                    {
                        this.price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.Appointment.Patient.Contract.PricList).First().Price;
                    }
                    else
                    {
                        this.price = ((Service)newValue).PriceListDetails.Where(p => p.PriceList == this.Appointment.Patient.Contract.PricList).First().Price * Convert.ToDecimal(1.5);
                    }
                }
            }
        }
    }

}
