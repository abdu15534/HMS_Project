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
    public partial class SalaryPayment : XPBaseObject
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
        JournalEntry fjournalEntry;
        public JournalEntry journalEntry
        {
            get { return fjournalEntry; }
            set { SetPropertyValue<JournalEntry>(nameof(journalEntry), ref fjournalEntry, value); }
        }
        Section fsection;
        public Section section
        {
            get { return fsection; }
            set { SetPropertyValue<Section>(nameof(section), ref fsection, value); }
        }
        bool fpost;
        public bool post
        {
            get { return fpost; }
            set { SetPropertyValue<bool>(nameof(post), ref fpost, value); }
        }
        string fstatement;
        public string statement
        {
            get { return fstatement; }
            set { SetPropertyValue<string>(nameof(statement), ref fstatement, value); }
        }
        Account fpaymentAccount;
        public Account paymentAccount
        {
            get { return fpaymentAccount; }
            set { SetPropertyValue<Account>(nameof(paymentAccount), ref fpaymentAccount, value); }
        }
        [Association(@"SalaryDetailsReferencesSalaryDocument"), Aggregated]
        public XPCollection<SalaryPaymentDetails> SalaryDetailsCollection { get { return GetCollection<SalaryPaymentDetails>(nameof(SalaryDetailsCollection)); } }
    }

}
