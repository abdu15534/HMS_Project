﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    [DevExpress.Persistent.Base.DefaultClassOptions]
    public partial class Test : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        DateTime fdate;
        public DateTime date
        {
            get { return fdate; }
            set { SetPropertyValue<DateTime>(nameof(date), ref fdate, value); }
        }
        string fnote;
        [Size(SizeAttribute.Unlimited)]
        public string note
        {
            get { return fnote; }
            set { SetPropertyValue<string>(nameof(note), ref fnote, value); }
        }
        [PersistentAlias("Iif([TestDetailsCollection][].Sum([price]) Is Null, 0.0m, [TestDetailsCollection][].Sum([price]))")]
        public decimal total
        {
            get { return (decimal)(EvaluateAlias(nameof(total))); }
        }
        Patient fPatient;
        [Association(@"TestReferencesPatient")]
        public Patient Patient
        {
            get { return fPatient; }
            set { SetPropertyValue<Patient>(nameof(Patient), ref fPatient, value); }
        }
        bool fPaid;
        public bool Paid
        {
            get { return fPaid; }
            set { SetPropertyValue<bool>(nameof(Paid), ref fPaid, value); }
        }
        bool fComplete;
        public bool Complete
        {
            get { return fComplete; }
            set { SetPropertyValue<bool>(nameof(Complete), ref fComplete, value); }
        }
        JournalEntry fjournal;
        public JournalEntry journal
        {
            get { return fjournal; }
            set { SetPropertyValue<JournalEntry>(nameof(journal), ref fjournal, value); }
        }
        [Association(@"TestDetailsReferencesTest"), Aggregated]
        public XPCollection<TestDetails> TestDetailsCollection { get { return GetCollection<TestDetails>(nameof(TestDetailsCollection)); } }
    }

}
