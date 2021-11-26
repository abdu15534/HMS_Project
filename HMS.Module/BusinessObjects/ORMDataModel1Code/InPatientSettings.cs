using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Validation;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [RuleObjectExists("AnotherSingletonExists2", DefaultContexts.Save, "True", InvertResult = true,
    CustomMessageTemplate = "Another Singleton already exists.")]
    [RuleCriteria("CannotDeleteSingleton2", DefaultContexts.Delete, "False",
    CustomMessageTemplate = "Cannot delete Singleton.")]
    public partial class InPatientSettings
    {
        public InPatientSettings(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
