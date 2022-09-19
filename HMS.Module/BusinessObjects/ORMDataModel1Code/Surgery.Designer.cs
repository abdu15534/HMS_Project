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

    public partial class Surgery : PackageDetail
    {
        Patient fPatient;
        public Patient Patient
        {
            get { return fPatient; }
            set { SetPropertyValue<Patient>(nameof(Patient), ref fPatient, value); }
        }
        SurgeryPackage fSurgeryPackage;
        public SurgeryPackage SurgeryPackage
        {
            get { return fSurgeryPackage; }
            set { SetPropertyValue<SurgeryPackage>(nameof(SurgeryPackage), ref fSurgeryPackage, value); }
        }
        DateTime fDate;
        public DateTime Date
        {
            get { return fDate; }
            set { SetPropertyValue<DateTime>(nameof(Date), ref fDate, value); }
        }
        decimal fSurgeonsFees;
        public decimal SurgeonsFees
        {
            get { return fSurgeonsFees; }
            set { SetPropertyValue<decimal>(nameof(SurgeonsFees), ref fSurgeonsFees, value); }
        }
        decimal fAnesthesiaFees;
        public decimal AnesthesiaFees
        {
            get { return fAnesthesiaFees; }
            set { SetPropertyValue<decimal>(nameof(AnesthesiaFees), ref fAnesthesiaFees, value); }
        }
        decimal fAssistantFees;
        public decimal AssistantFees
        {
            get { return fAssistantFees; }
            set { SetPropertyValue<decimal>(nameof(AssistantFees), ref fAssistantFees, value); }
        }
        decimal fRoomOpeningFee;
        public decimal RoomOpeningFee
        {
            get { return fRoomOpeningFee; }
            set { SetPropertyValue<decimal>(nameof(RoomOpeningFee), ref fRoomOpeningFee, value); }
        }
        ReceptionDesk fRecption;
        [Association(@"SurgeryReferencesReceptionDesk")]
        public ReceptionDesk Recption
        {
            get { return fRecption; }
            set { SetPropertyValue<ReceptionDesk>(nameof(Recption), ref fRecption, value); }
        }
        Department fDepartment;
        public Department Department
        {
            get { return fDepartment; }
            set { SetPropertyValue<Department>(nameof(Department), ref fDepartment, value); }
        }
        [PersistentAlias("Iif([StaySuppliesCollection][].Sum([total]) Is Null, 0.0m, [StaySuppliesCollection][].Sum([total]))")]
        public decimal SurgerySuppliesSum
        {
            get { return (decimal)(EvaluateAlias(nameof(SurgerySuppliesSum))); }
        }
        [Association(@"StaySuppliesReferencesSurgery"), Aggregated]
        public XPCollection<StaySupplies> StaySuppliesCollection { get { return GetCollection<StaySupplies>(nameof(StaySuppliesCollection)); } }
    }

}
