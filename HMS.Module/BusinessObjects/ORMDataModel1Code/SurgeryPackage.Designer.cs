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

    public partial class SurgeryPackage : Package
    {
        decimal fSurgeonsFees;
        public decimal SurgeonsFees
        {
            get { return fSurgeonsFees; }
            set { SetPropertyValue<decimal>(nameof(SurgeonsFees), ref fSurgeonsFees, value); }
        }
        double fAnesthesiaFeeRate;
        public double AnesthesiaFeeRate
        {
            get { return fAnesthesiaFeeRate; }
            set { SetPropertyValue<double>(nameof(AnesthesiaFeeRate), ref fAnesthesiaFeeRate, value); }
        }
        double fAssistantFeeRate;
        public double AssistantFeeRate
        {
            get { return fAssistantFeeRate; }
            set { SetPropertyValue<double>(nameof(AssistantFeeRate), ref fAssistantFeeRate, value); }
        }
        decimal fopeningFee;
        public decimal openingFee
        {
            get { return fopeningFee; }
            set { SetPropertyValue<decimal>(nameof(openingFee), ref fopeningFee, value); }
        }
        SurgicalCategory fSurgeryCategory;
        public SurgicalCategory SurgeryCategory
        {
            get { return fSurgeryCategory; }
            set { SetPropertyValue<SurgicalCategory>(nameof(SurgeryCategory), ref fSurgeryCategory, value); }
        }
    }

}
