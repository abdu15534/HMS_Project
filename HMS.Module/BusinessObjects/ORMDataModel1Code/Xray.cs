using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class Xrays
    {
        public Xrays(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction();
            journal = new JournalEntry(Session);
            date = DateTime.Now;
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            journal.Post(true);
            this.journal.Delete();
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            this.date = DateTime.Now;
        }

    }

}
