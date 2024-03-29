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

    public partial class Product : XPBaseObject
    {
        int fid;
        [Key]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string fname;
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>(nameof(name), ref fname, value); }
        }
        decimal fpurchasingPrice;
        public decimal purchasingPrice
        {
            get { return fpurchasingPrice; }
            set { SetPropertyValue<decimal>(nameof(purchasingPrice), ref fpurchasingPrice, value); }
        }
        decimal fsellingPrice;
        public decimal sellingPrice
        {
            get { return fsellingPrice; }
            set { SetPropertyValue<decimal>(nameof(sellingPrice), ref fsellingPrice, value); }
        }
        Category fcategory;
        [Association(@"ProductReferencesCategory")]
        public Category category
        {
            get { return fcategory; }
            set { SetPropertyValue<Category>(nameof(category), ref fcategory, value); }
        }
        string fbarCode;
        public string barCode
        {
            get { return fbarCode; }
            set { SetPropertyValue<string>(nameof(barCode), ref fbarCode, value); }
        }
        ProductUnit fpurchasingUnit;
        public ProductUnit purchasingUnit
        {
            get { return fpurchasingUnit; }
            set { SetPropertyValue<ProductUnit>(nameof(purchasingUnit), ref fpurchasingUnit, value); }
        }
        ProductUnit fsellUnit;
        public ProductUnit sellUnit
        {
            get { return fsellUnit; }
            set { SetPropertyValue<ProductUnit>(nameof(sellUnit), ref fsellUnit, value); }
        }
        int funitAmount;
        public int unitAmount
        {
            get { return funitAmount; }
            set { SetPropertyValue<int>(nameof(unitAmount), ref funitAmount, value); }
        }
        double fTempQuantity;
        public double TempQuantity
        {
            get { return fTempQuantity; }
            set { SetPropertyValue<double>(nameof(TempQuantity), ref fTempQuantity, value); }
        }
        [Association(@"PurchasingOrderDetailReferencesProduct"), Aggregated]
        public XPCollection<PurchasingOrderDetail> PurchasingOrderDetails { get { return GetCollection<PurchasingOrderDetail>(nameof(PurchasingOrderDetails)); } }
        [Association(@"PurchaseRequestDetailReferencesProduct"), Aggregated]
        public XPCollection<PurchaseRequestDetail> PurchaseRequestDetails { get { return GetCollection<PurchaseRequestDetail>(nameof(PurchaseRequestDetails)); } }
        [Association(@"StockProductReferencesProduct"), Aggregated]
        public XPCollection<StockProduct> StockProducts { get { return GetCollection<StockProduct>(nameof(StockProducts)); } }
    }

}
