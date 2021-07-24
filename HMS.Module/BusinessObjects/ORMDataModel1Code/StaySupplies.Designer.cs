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

    public partial class StaySupplies : XPBaseObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Admission fStay;
        [Indexed(@"supplyProduct", Name = @"Index1", Unique = true)]
        [Association(@"StockDetailsReferencesStay")]
        public Admission Stay
        {
            get { return fStay; }
            set { SetPropertyValue<Admission>(nameof(Stay), ref fStay, value); }
        }
        Emergency femergency;
        [Association(@"StaySuppliesReferencesEmergency")]
        public Emergency emergency
        {
            get { return femergency; }
            set { SetPropertyValue<Emergency>(nameof(emergency), ref femergency, value); }
        }
        double fquantity;
        public double quantity
        {
            get { return fquantity; }
            set { SetPropertyValue<double>(nameof(quantity), ref fquantity, value); }
        }
        StockProduct fsupplyProduct;
        [DevExpress.Persistent.Base.DataSourceCriteria("Inventory.Name =='Stock'")]
        public StockProduct supplyProduct
        {
            get { return fsupplyProduct; }
            set { SetPropertyValue<StockProduct>(nameof(supplyProduct), ref fsupplyProduct, value); }
        }
        DateTime fdate;
        public DateTime date
        {
            get { return fdate; }
            set { SetPropertyValue<DateTime>(nameof(date), ref fdate, value); }
        }
        decimal fprice;
        public decimal price
        {
            get { return fprice; }
            set { SetPropertyValue<decimal>(nameof(price), ref fprice, value); }
        }
        decimal fprofit;
        public decimal profit
        {
            get { return fprofit; }
            set { SetPropertyValue<decimal>(nameof(profit), ref fprofit, value); }
        }
        [PersistentAlias("Iif([supplyProduct] = null, ToDecimal(0), [price] * ToDecimal([quantity]))")]
        public decimal total
        {
            get { return (decimal)(EvaluateAlias(nameof(total))); }
        }
    }

}
