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

    public partial class Clinc : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string fName;
        [DevExpress.Persistent.Validation.RuleRequiredField]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fdescription;
        public string description
        {
            get { return fdescription; }
            set { SetPropertyValue<string>(nameof(description), ref fdescription, value); }
        }
        Employee finCharge;
        [DevExpress.Persistent.Base.DataSourceCriteria(" section= 6"), DevExpress.Persistent.Validation.RuleRequiredField,]
        public Employee inCharge
        {
            get { return finCharge; }
            set { SetPropertyValue<Employee>(nameof(inCharge), ref finCharge, value); }
        }
    }

}
