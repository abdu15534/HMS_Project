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
    public partial class ConsultantDetails : XPBaseObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Consultant fConsultant;
        public Consultant Consultant
        {
            get { return fConsultant; }
            set { SetPropertyValue<Consultant>(nameof(Consultant), ref fConsultant, value); }
        }
        Admission fAdmission;
        [Association(@"ConsultantDetailsReferencesAdmission")]
        public Admission Admission
        {
            get { return fAdmission; }
            set { SetPropertyValue<Admission>(nameof(Admission), ref fAdmission, value); }
        }
        decimal fPrice;
        public decimal Price
        {
            get { return fPrice; }
            set { SetPropertyValue<decimal>(nameof(Price), ref fPrice, value); }
        }
        DateTime fDate;
        public DateTime Date
        {
            get { return fDate; }
            set { SetPropertyValue<DateTime>(nameof(Date), ref fDate, value); }
        }
        Package fPackage;
        public Package Package
        {
            get { return fPackage; }
            set { SetPropertyValue<Package>(nameof(Package), ref fPackage, value); }
        }
    }

}
