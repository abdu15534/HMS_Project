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

    public partial class Appointment : DevExpress.Persistent.BaseImpl.Event
    {
        int fid;
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        Patient fPatient;
        [Association(@"AppointmentReferencesPatient")]
        [DevExpress.Persistent.Validation.RuleRequiredField,]
        public Patient Patient
        {
            get { return fPatient; }
            set { SetPropertyValue<Patient>(nameof(Patient), ref fPatient, value); }
        }
        Clinc fclinc;
        [DevExpress.Persistent.Validation.RuleRequiredField,]
        public Clinc clinc
        {
            get { return fclinc; }
            set { SetPropertyValue<Clinc>(nameof(clinc), ref fclinc, value); }
        }
        decimal fExaminationPrice;
        public decimal ExaminationPrice
        {
            get { return fExaminationPrice; }
            set { SetPropertyValue<decimal>(nameof(ExaminationPrice), ref fExaminationPrice, value); }
        }
        Employee fDoctor;
        [Association(@"AppointmentReferencesEmployee")]
        [DevExpress.Persistent.Base.DataSourceCriteria(" section= 6 AND Clinic= '@This.clinc' "),
DevExpress.Persistent.Validation.RuleRequiredField]
        public Employee Doctor
        {
            get { return fDoctor; }
            set { SetPropertyValue<Employee>(nameof(Doctor), ref fDoctor, value); }
        }
        [DevExpress.Persistent.Base.ImmediatePostData]
        [PersistentAlias("Iif([Patient] Is Null, 0, DateDiffYear([Patient.DateOfBrith], Today()))")]
        public int PatientAge
        {
            get { return (int)(EvaluateAlias(nameof(PatientAge))); }
        }
        [PersistentAlias("Iif([ClinicServiceDetails][].Sum([price]) Is Null, [ExaminationPrice], [ClinicServiceDetails][].Sum([price]) + [ExaminationPrice])")]
        public decimal total
        {
            get { return (decimal)(EvaluateAlias(nameof(total))); }
        }
        bool fPending;
        public bool Pending
        {
            get { return fPending; }
            set { SetPropertyValue<bool>(nameof(Pending), ref fPending, value); }
        }
        bool fComplete;
        public bool Complete
        {
            get { return fComplete; }
            set { SetPropertyValue<bool>(nameof(Complete), ref fComplete, value); }
        }
        int fTicketNumber;
        [ColumnDefaultValue(0)]
        [DevExpress.Xpo.DisplayName(@"Ticket Number")]
        public int TicketNumber
        {
            get { return fTicketNumber; }
            set { SetPropertyValue<int>(nameof(TicketNumber), ref fTicketNumber, value); }
        }
        Discount fdiscountPercentage;
        [Association(@"AppointmentReferencesDiscount")]
        public Discount discountPercentage
        {
            get { return fdiscountPercentage; }
            set { SetPropertyValue<Discount>(nameof(discountPercentage), ref fdiscountPercentage, value); }
        }
        decimal fTotalAfterDiscount;
        public decimal TotalAfterDiscount
        {
            get { return fTotalAfterDiscount; }
            set { SetPropertyValue<decimal>(nameof(TotalAfterDiscount), ref fTotalAfterDiscount, value); }
        }
        [PersistentAlias("[total] - [discountPercentage.Percentage] % 100 * [total]")]
        public decimal? afterDiscount
        {
            get { return (decimal?)(EvaluateAlias(nameof(afterDiscount))); }
        }
        [Association(@"ClinicServiceDetailReferencesAppointment"), Aggregated]
        public XPCollection<ClinicServiceDetail> ClinicServiceDetails { get { return GetCollection<ClinicServiceDetail>(nameof(ClinicServiceDetails)); } }
        [Association(@"PaymentsReferencesAppointment"), Aggregated]
        public XPCollection<Payments> PaymentsCollection { get { return GetCollection<Payments>(nameof(PaymentsCollection)); } }
    }

}
