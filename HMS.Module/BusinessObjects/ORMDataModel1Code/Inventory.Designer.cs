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

    public partial class Inventory : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fID;
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>(nameof(ID), ref fID, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        Employee fEmployee;
        public Employee Employee
        {
            get { return fEmployee; }
            set { SetPropertyValue<Employee>(nameof(Employee), ref fEmployee, value); }
        }
        Department fDepartment;
        [Association(@"InventoryReferencesDepartment")]
        public Department Department
        {
            get { return fDepartment; }
            set { SetPropertyValue<Department>(nameof(Department), ref fDepartment, value); }
        }
        WearhouseType fWearhouseType;
        [Association(@"InventoryReferencesWearhouseType")]
        public WearhouseType WearhouseType
        {
            get { return fWearhouseType; }
            set { SetPropertyValue<WearhouseType>(nameof(WearhouseType), ref fWearhouseType, value); }
        }
        [Association(@"StockProductReferencesInventory"), Aggregated]
        public XPCollection<StockProduct> StockProducts { get { return GetCollection<StockProduct>(nameof(StockProducts)); } }
    }

}
