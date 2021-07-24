using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultProperty("accountName")]
    public partial class SubAccount
    {
        public SubAccount(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); credit = 0; debit = 0; }
    }

}
