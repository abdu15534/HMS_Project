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
    public partial class EmergencyServiceDetails : XPBaseObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Emergency fEmergency;
        [Association(@"EmergencyServiceDetailsReferencesEmergency")]
        [DevExpress.Persistent.Base.DataSourceCriteria("ServiceType = 6"),]
        public Emergency Emergency
        {
            get { return fEmergency; }
            set { SetPropertyValue<Emergency>(nameof(Emergency), ref fEmergency, value); }
        }
        Service fService;
        [DevExpress.Persistent.Base.DataSourceCriteria("Departmet.Name = 'الطوارئ' ")]
        public Service Service
        {
            get { return fService; }
            set { SetPropertyValue<Service>(nameof(Service), ref fService, value); }
        }
        decimal fPrice;
        public decimal Price
        {
            get { return fPrice; }
            set { SetPropertyValue<decimal>(nameof(Price), ref fPrice, value); }
        }
        DateTime fdate;
        public DateTime date
        {
            get { return fdate; }
            set { SetPropertyValue<DateTime>(nameof(date), ref fdate, value); }
        }
    }

}
