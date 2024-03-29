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

    public partial class ServiceDetails : XPBaseObject
    {
        int fID;
        [Indexed(@"Stay", Name = @"Index1", Unique = true)]
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Admission fStay;
        [Association(@"ServiceDetailsReferencesAdmission")]
        public Admission Stay
        {
            get { return fStay; }
            set { SetPropertyValue<Admission>(nameof(Stay), ref fStay, value); }
        }
        Emergency femergency;
        [Association(@"ServiceDetailsReferencesEmergency")]
        public Emergency emergency
        {
            get { return femergency; }
            set { SetPropertyValue<Emergency>(nameof(emergency), ref femergency, value); }
        }
        Service fService;
        [DevExpress.Persistent.Base.DataSourceCriteria("ServiceType = 19 || ServiceType = 18")]
        public Service Service
        {
            get { return fService; }
            set { SetPropertyValue<Service>(nameof(Service), ref fService, value); }
        }
        decimal fprice;
        public decimal price
        {
            get { return fprice; }
            set { SetPropertyValue<decimal>(nameof(price), ref fprice, value); }
        }
        DateTime fdate;
        public DateTime date
        {
            get { return fdate; }
            set { SetPropertyValue<DateTime>(nameof(date), ref fdate, value); }
        }
        Appointment fappointment;
        public Appointment appointment
        {
            get { return fappointment; }
            set { SetPropertyValue<Appointment>(nameof(appointment), ref fappointment, value); }
        }
        Package fPackage;
        public Package Package
        {
            get { return fPackage; }
            set { SetPropertyValue<Package>(nameof(Package), ref fPackage, value); }
        }
    }

}
