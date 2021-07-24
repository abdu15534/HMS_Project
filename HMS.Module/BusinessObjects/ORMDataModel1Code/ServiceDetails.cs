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
                price = Service.Price;
            }
        }
    }

}
