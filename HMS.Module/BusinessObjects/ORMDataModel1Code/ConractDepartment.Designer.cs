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
    public partial class ConractDepartment : XPBaseObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Conratct fContract;
        [Association(@"ConractDepartmentReferencesConratct")]
        public Conratct Contract
        {
            get { return fContract; }
            set { SetPropertyValue<Conratct>(nameof(Contract), ref fContract, value); }
        }
        Department fDepartment;
        public Department Department
        {
            get { return fDepartment; }
            set { SetPropertyValue<Department>(nameof(Department), ref fDepartment, value); }
        }
        double fDiscount;
        public double Discount
        {
            get { return fDiscount; }
            set { SetPropertyValue<double>(nameof(Discount), ref fDiscount, value); }
        }
    }

}
