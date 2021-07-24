using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    [DefaultProperty("number")]
    public partial class bed
    {
        public bed(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); isAvailable = true; }


    }

}
