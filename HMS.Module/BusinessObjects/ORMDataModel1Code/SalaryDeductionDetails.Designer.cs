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

    public partial class SalaryDeductionDetails : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        Employee femployee;
        public Employee employee
        {
            get { return femployee; }
            set { SetPropertyValue<Employee>(nameof(employee), ref femployee, value); }
        }
        decimal fpayPerHour;
        public decimal payPerHour
        {
            get { return fpayPerHour; }
            set { SetPropertyValue<decimal>(nameof(payPerHour), ref fpayPerHour, value); }
        }
        DateTime fdate;
        public DateTime date
        {
            get { return fdate; }
            set { SetPropertyValue<DateTime>(nameof(date), ref fdate, value); }
        }
        int fdeductionDays;
        public int deductionDays
        {
            get { return fdeductionDays; }
            set { SetPropertyValue<int>(nameof(deductionDays), ref fdeductionDays, value); }
        }
        int fdeductionHours;
        public int deductionHours
        {
            get { return fdeductionHours; }
            set { SetPropertyValue<int>(nameof(deductionHours), ref fdeductionHours, value); }
        }
        decimal fdeductionOthers;
        public decimal deductionOthers
        {
            get { return fdeductionOthers; }
            set { SetPropertyValue<decimal>(nameof(deductionOthers), ref fdeductionOthers, value); }
        }
        decimal ftotalDeduction;
        public decimal totalDeduction
        {
            get { return ftotalDeduction; }
            set { SetPropertyValue<decimal>(nameof(totalDeduction), ref ftotalDeduction, value); }
        }
        string fnote;
        public string note
        {
            get { return fnote; }
            set { SetPropertyValue<string>(nameof(note), ref fnote, value); }
        }
        SalaryDeduction fSalaryDeduction;
        [Association(@"SalaryDeductionDetailsReferencesSalaryDeduction")]
        public SalaryDeduction SalaryDeduction
        {
            get { return fSalaryDeduction; }
            set { SetPropertyValue<SalaryDeduction>(nameof(SalaryDeduction), ref fSalaryDeduction, value); }
        }
    }

}
