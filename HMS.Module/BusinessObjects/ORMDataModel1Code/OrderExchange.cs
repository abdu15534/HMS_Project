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
    public partial class OrderExchange
    {
        public OrderExchange(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
