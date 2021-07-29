using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class Service
    {
        public Service(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        ServiceTypes serviceType;

        public ServiceTypes ServiceType
        {
            get => serviceType;
            set => SetPropertyValue(nameof(ServiceType), ref serviceType, value);
        }


    }
    public enum ServiceTypes
    {
        Tests, Endoscopy, Xrays, Oxygen, Other, Blood, Deceased
    }

}
