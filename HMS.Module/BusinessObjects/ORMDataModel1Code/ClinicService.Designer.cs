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

    public partial class ClinicService : XPObject
    {
        int fID;
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        decimal fPrice;
        public decimal Price
        {
            get { return fPrice; }
            set { SetPropertyValue<decimal>(nameof(Price), ref fPrice, value); }
        }
        Clinc fClinic;
        public Clinc Clinic
        {
            get { return fClinic; }
            set { SetPropertyValue<Clinc>(nameof(Clinic), ref fClinic, value); }
        }
    }

}
