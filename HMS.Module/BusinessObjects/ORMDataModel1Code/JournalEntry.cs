using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class JournalEntry
    {
        public JournalEntry(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); post = false; date = DateTime.Now; }

        public void Post(bool post)
        {
            if (!post)
            {
                    foreach (JournalDetails item in JournalDetailsCollection)
                    {
                        if (item.credit > 0)
                            item.account.credit += item.credit;

                        else
                            item.account.debit += item.debit;
                    }

                this.post = true;
            }

            else
            {
                    foreach (JournalDetails item in JournalDetailsCollection)
                    {
                        if (item.credit > 0)
                            item.account.credit -= item.credit;

                        else
                            item.account.debit -= item.debit;
                    }
                
                this.post = false;
            }
        }

        public void DeleteDetails()
        {
           // Post(true);
            var x = Session.Query<JournalDetails>().Where(p => p.journal == this);
            foreach(JournalDetails item in x)
            {
                item.Delete();
            }
        }
    }
}

