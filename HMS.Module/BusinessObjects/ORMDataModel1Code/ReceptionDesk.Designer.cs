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

    public partial class ReceptionDesk : XPBaseObject
    {
        int fenterID;
        [Key(true)]
        public int enterID
        {
            get { return fenterID; }
            set { SetPropertyValue<int>(nameof(enterID), ref fenterID, value); }
        }
        DateTime fdateEnter;
        [DevExpress.Persistent.Validation.RuleRequiredField]
        public DateTime dateEnter
        {
            get { return fdateEnter; }
            set { SetPropertyValue<DateTime>(nameof(dateEnter), ref fdateEnter, value); }
        }
        DateTime fdateLeave;
        public DateTime dateLeave
        {
            get { return fdateLeave; }
            set { SetPropertyValue<DateTime>(nameof(dateLeave), ref fdateLeave, value); }
        }
        Patient fpatient;
        [DevExpress.Persistent.Base.DataSourceCriteria("!InStay AND !InEmergency"), DevExpress.Persistent.Validation.RuleRequiredField]
        public Patient patient
        {
            get { return fpatient; }
            set { SetPropertyValue<Patient>(nameof(patient), ref fpatient, value); }
        }
        JournalEntry fjournalEntry;
        public JournalEntry journalEntry
        {
            get { return fjournalEntry; }
            set { SetPropertyValue<JournalEntry>(nameof(journalEntry), ref fjournalEntry, value); }
        }
        string fnote;
        [Size(SizeAttribute.Unlimited)]
        public string note
        {
            get { return fnote; }
            set { SetPropertyValue<string>(nameof(note), ref fnote, value); }
        }
        Room froom;
        [DevExpress.Persistent.Base.DataSourceCriteria(" Status='@This.Section' "), DevExpress.Persistent.Validation.RuleRequiredField]
        public Room room
        {
            get { return froom; }
            set { SetPropertyValue<Room>(nameof(room), ref froom, value); }
        }
        bed fbed;
        [DevExpress.Persistent.Base.DataSourceCriteria("room == '@This.room' AND isAvailable  "), DevExpress.Persistent.Validation.RuleRequiredField
]
        public bed bed
        {
            get { return fbed; }
            set { SetPropertyValue<bed>(nameof(bed), ref fbed, value); }
        }
        Admission fcurrentStay;
        public Admission currentStay
        {
            get { return fcurrentStay; }
            set { SetPropertyValue<Admission>(nameof(currentStay), ref fcurrentStay, value); }
        }
        bool fisDischarged;
        [DevExpress.Persistent.Base.VisibleInDetailView(false)]
        public bool isDischarged
        {
            get { return fisDischarged; }
            set { SetPropertyValue<bool>(nameof(isDischarged), ref fisDischarged, value); }
        }
        decimal ftotal;
        public decimal total
        {
            get { return ftotal; }
            set { SetPropertyValue<decimal>(nameof(total), ref ftotal, value); }
        }
        decimal fDiscount;
        public decimal Discount
        {
            get { return fDiscount; }
            set { SetPropertyValue<decimal>(nameof(Discount), ref fDiscount, value); }
        }
        bool fIsDiscounted;
        public bool IsDiscounted
        {
            get { return fIsDiscounted; }
            set { SetPropertyValue<bool>(nameof(IsDiscounted), ref fIsDiscounted, value); }
        }
        double fServiceRate;
        public double ServiceRate
        {
            get { return fServiceRate; }
            set { SetPropertyValue<double>(nameof(ServiceRate), ref fServiceRate, value); }
        }
        decimal fmedication;
        public decimal medication
        {
            get { return fmedication; }
            set { SetPropertyValue<decimal>(nameof(medication), ref fmedication, value); }
        }
        decimal fServiceFee;
        public decimal ServiceFee
        {
            get { return fServiceFee; }
            set { SetPropertyValue<decimal>(nameof(ServiceFee), ref fServiceFee, value); }
        }
        decimal famount;
        public decimal amount
        {
            get { return famount; }
            set { SetPropertyValue<decimal>(nameof(amount), ref famount, value); }
        }
        bool fDeceasedPackageApplyed;
        public bool DeceasedPackageApplyed
        {
            get { return fDeceasedPackageApplyed; }
            set { SetPropertyValue<bool>(nameof(DeceasedPackageApplyed), ref fDeceasedPackageApplyed, value); }
        }
        [PersistentAlias("[amountC] * ToDecimal([ServiceRate] / 100)")]
        public decimal? ServiceFeeC
        {
            get { return (decimal?)(EvaluateAlias(nameof(ServiceFeeC))); }
        }
        [PersistentAlias("Iif([Admissions][].Sum([medicationSum]) Is Null, 0.0m, [Admissions][].Sum([medicationSum]))")]
        public decimal medicationC
        {
            get { return (decimal)(EvaluateAlias(nameof(medicationC))); }
        }
        [PersistentAlias("Iif([Admissions][].Sum([stayTotalSum]) Is Null, 0.0m, [Admissions][].Sum([stayTotalSum]) - Iif([PackageDetails][[Applyed] = True].Sum([NormalRoomTotal]) Is Null, 0.0m, [PackageDetails][[Applyed] = True].Sum([NormalRoomTotal])))")]
        public decimal amountC
        {
            get { return (decimal)(EvaluateAlias(nameof(amountC))); }
        }
        [PersistentAlias("[amountC] - [Discount] + [medicationC] + [ServiceFeeC] + [StampPrice] + Iif([PackageDetails][[Applyed] = True].Sum([price]) Is Null, 0.0m, [PackageDetails][[Applyed] = True].Sum([price]))")]
        public decimal totalC
        {
            get { return (decimal)(EvaluateAlias(nameof(totalC))); }
        }
        decimal fStampPrice;
        public decimal StampPrice
        {
            get { return fStampPrice; }
            set { SetPropertyValue<decimal>(nameof(StampPrice), ref fStampPrice, value); }
        }
        [PersistentAlias("Iif([PaymentsCollection][].Sum([amount]) = null, [totalC], [totalC] - [PaymentsCollection][].Sum([amount]))")]
        public decimal Balance
        {
            get { return (decimal)(EvaluateAlias(nameof(Balance))); }
        }
        [Association(@"AdmissionReferencesReceptionDesk")]
        public XPCollection<Admission> Admissions { get { return GetCollection<Admission>(nameof(Admissions)); } }
        [Association(@"PackageDetailReferencesReceptionDesk")]
        public XPCollection<PackageDetail> PackageDetails { get { return GetCollection<PackageDetail>(nameof(PackageDetails)); } }
        [Association(@"PaymentsReferencesReceptionDesk")]
        public XPCollection<Payments> PaymentsCollection { get { return GetCollection<Payments>(nameof(PaymentsCollection)); } }
        [Association(@"SurgeryReferencesReceptionDesk")]
        public XPCollection<Surgery> Surgeries { get { return GetCollection<Surgery>(nameof(Surgeries)); } }
    }

}
