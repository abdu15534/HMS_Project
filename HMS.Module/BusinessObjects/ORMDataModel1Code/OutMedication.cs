using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class OutMedication
    {
        public OutMedication(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); this.Date = DateTime.Now; }
    }

}
