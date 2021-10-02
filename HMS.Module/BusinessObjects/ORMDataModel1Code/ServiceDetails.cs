using DevExpress.ExpressApp;
using DevExpress.Xpo;
using System;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    public partial class ServiceDetails
    {
        public ServiceDetails(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); date = DateTime.Now; }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if(propertyName == nameof(Service) && Service != null)
            {
                if (this.Stay != null)
                {
                    if (this.Stay.Patient.Nationality == Patient.Nationalitys.مصر)
                    {
                        this.price = ((Service)newValue).Price;
                    }
                    else
                    {
                        this.price = ((Service)newValue).Price * Convert.ToDecimal(1.5);
                    }
                }
                else if (this.emergency != null)
                {
                    if (this.emergency.Patient != null && this.emergency.Patient.Nationality != Patient.Nationalitys.مصر)
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

        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsDeleted)
                if (this.Service == null)
                    this.Delete();
        }
    }

}
