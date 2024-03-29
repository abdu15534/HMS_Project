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

    [DevExpress.ExpressApp.DefaultListViewOptions(DevExpress.ExpressApp.MasterDetailMode.ListViewOnly, true, DevExpress.ExpressApp.NewItemRowPosition.Bottom)]
    public partial class EndscopeDetails : XPBaseObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        Admission fadmission;
        [Association(@"EndscopeDetailsReferencesAdmission")]
        public Admission admission
        {
            get { return fadmission; }
            set { SetPropertyValue<Admission>(nameof(admission), ref fadmission, value); }
        }
        Service fservice;
        [DevExpress.Persistent.Base.DataSourceCriteria("ServiceType = 3"), DevExpress.Xpo.DisplayName("Endscope")]
        public Service service
        {
            get { return fservice; }
            set { SetPropertyValue<Service>(nameof(service), ref fservice, value); }
        }
        decimal fprice;
        public decimal price
        {
            get { return fprice; }
            set { SetPropertyValue<decimal>(nameof(price), ref fprice, value); }
        }
        Endscope fEndscope;
        [Association(@"EndscopeDetailsReferencesEndscope")]
        public Endscope Endscope
        {
            get { return fEndscope; }
            set { SetPropertyValue<Endscope>(nameof(Endscope), ref fEndscope, value); }
        }
        DateTime fdate;
        public DateTime date
        {
            get { return fdate; }
            set { SetPropertyValue<DateTime>(nameof(date), ref fdate, value); }
        }
        Emergency fEmergency;
        [Association(@"EndscopeDetailsReferencesEmergency")]
        public Emergency Emergency
        {
            get { return fEmergency; }
            set { SetPropertyValue<Emergency>(nameof(Emergency), ref fEmergency, value); }
        }
        Package fPackage;
        public Package Package
        {
            get { return fPackage; }
            set { SetPropertyValue<Package>(nameof(Package), ref fPackage, value); }
        }
    }

}
