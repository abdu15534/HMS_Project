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
    public partial class PurchaseRequestDetail : XPBaseObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Product fProduct;
        public Product Product
        {
            get { return fProduct; }
            set { SetPropertyValue<Product>(nameof(Product), ref fProduct, value); }
        }
        double fRequstedAmount;
        public double RequstedAmount
        {
            get { return fRequstedAmount; }
            set { SetPropertyValue<double>(nameof(RequstedAmount), ref fRequstedAmount, value); }
        }
        double fQuantity;
        public double Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<double>(nameof(Quantity), ref fQuantity, value); }
        }
        string fNotes;
        public string Notes
        {
            get { return fNotes; }
            set { SetPropertyValue<string>(nameof(Notes), ref fNotes, value); }
        }
        PurchaseRequest fPurchaseRequest;
        [Association(@"PurchaseRequestDetailReferencesPurchaseRequest")]
        public PurchaseRequest PurchaseRequest
        {
            get { return fPurchaseRequest; }
            set { SetPropertyValue<PurchaseRequest>(nameof(PurchaseRequest), ref fPurchaseRequest, value); }
        }
        bool fApproved;
        public bool Approved
        {
            get { return fApproved; }
            set { SetPropertyValue<bool>(nameof(Approved), ref fApproved, value); }
        }
    }

}
