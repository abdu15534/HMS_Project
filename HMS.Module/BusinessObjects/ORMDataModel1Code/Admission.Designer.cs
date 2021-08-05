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

    [Persistent(@"Stay")]
    public partial class Admission : XPBaseObject
    {
        int fadmissionID;
        [Key(true)]
        [Persistent(@"StayID")]
        [DevExpress.Persistent.Validation.RuleRequiredField]
        public int admissionID
        {
            get { return fadmissionID; }
            set { SetPropertyValue<int>(nameof(admissionID), ref fadmissionID, value); }
        }
        Patient fPatient;
        [Association(@"StayReferencesPatient")]
        [DevExpress.Persistent.Base.DataSourceCriteria(" InStay = false"),
]
        public Patient Patient
        {
            get { return fPatient; }
            set { SetPropertyValue<Patient>(nameof(Patient), ref fPatient, value); }
        }
        Room fRoom;
        [DevExpress.Persistent.Base.DataSourceCriteria(" Status='@This.Status' ")]
        public Room Room
        {
            get { return fRoom; }
            set { SetPropertyValue<Room>(nameof(Room), ref fRoom, value); }
        }
        bed fbed;
        [DevExpress.Persistent.Base.DataSourceCriteria("room == '@This.Room' AND isAvailable  ")
]
        public bed bed
        {
            get { return fbed; }
            set { SetPropertyValue<bed>(nameof(bed), ref fbed, value); }
        }
        Employee fdoctor;
        [DevExpress.Persistent.Base.DataSourceCriteria(" section= 6")]
        public Employee doctor
        {
            get { return fdoctor; }
            set { SetPropertyValue<Employee>(nameof(doctor), ref fdoctor, value); }
        }
        string ffinalDiagnosis;
        [Size(SizeAttribute.Unlimited)]
        public string finalDiagnosis
        {
            get { return ffinalDiagnosis; }
            set { SetPropertyValue<string>(nameof(finalDiagnosis), ref ffinalDiagnosis, value); }
        }
        string ffirstDiagnosis;
        [Size(SizeAttribute.Unlimited)]
        public string firstDiagnosis
        {
            get { return ffirstDiagnosis; }
            set { SetPropertyValue<string>(nameof(firstDiagnosis), ref ffirstDiagnosis, value); }
        }
        DateTime fStayStart;
        public DateTime StayStart
        {
            get { return fStayStart; }
            set { SetPropertyValue<DateTime>(nameof(StayStart), ref fStayStart, value); }
        }
        DateTime fStayEnd;
        public DateTime StayEnd
        {
            get { return fStayEnd; }
            set { SetPropertyValue<DateTime>(nameof(StayEnd), ref fStayEnd, value); }
        }
        [PersistentAlias("[StayStart]")]
        public DateTime date
        {
            get { return (DateTime)(EvaluateAlias(nameof(date))); }
        }
        ReceptionDesk freception;
        [Association(@"AdmissionReferencesReceptionDesk")]
        public ReceptionDesk reception
        {
            get { return freception; }
            set { SetPropertyValue<ReceptionDesk>(nameof(reception), ref freception, value); }
        }
        bool ftransferFlag;
        public bool transferFlag
        {
            get { return ftransferFlag; }
            set { SetPropertyValue<bool>(nameof(transferFlag), ref ftransferFlag, value); }
        }
        bool ftransferDayCount;
        public bool transferDayCount
        {
            get { return ftransferDayCount; }
            set { SetPropertyValue<bool>(nameof(transferDayCount), ref ftransferDayCount, value); }
        }
        bool fIsDischarged;
        [ColumnDefaultValue(false)]
        [DevExpress.Persistent.Base.VisibleInDetailView(false)]
        public bool IsDischarged
        {
            get { return fIsDischarged; }
            set { SetPropertyValue<bool>(nameof(IsDischarged), ref fIsDischarged, value); }
        }
        [PersistentAlias("Iif([StayMedicications][].Sum([total]) Is Null, 0.0m, [StayMedicications][].Sum([total]))")]
        public decimal medicationSum
        {
            get { return (decimal)(EvaluateAlias(nameof(medicationSum))); }
        }
        [PersistentAlias("Iif([StockDetailsCollection][].Sum([total]) Is Null, 0.0m, [StockDetailsCollection][].Sum([total]))")]
        public decimal suppliesSum
        {
            get { return (decimal)(EvaluateAlias(nameof(suppliesSum))); }
        }
        [PersistentAlias("Iif([ServiceDetailsCollection][].Sum([price]) Is Null, 0.0m, [ServiceDetailsCollection][].Sum([price]))")]
        public decimal servicesSum
        {
            get { return (decimal)(EvaluateAlias(nameof(servicesSum))); }
        }
        [PersistentAlias("Iif([CompanionDetailsCollection][].Sum([price]) Is Null, 0.0m, [CompanionDetailsCollection][].Sum([price]))")]
        public decimal companionSum
        {
            get { return (decimal)(EvaluateAlias(nameof(companionSum))); }
        }
        [PersistentAlias("Iif([EndscopeDetailsCollection][].Sum([price]) Is Null, 0.0m, [EndscopeDetailsCollection][].Sum([price]))")]
        public decimal endscopesSum
        {
            get { return (decimal)(EvaluateAlias(nameof(endscopesSum))); }
        }
        [PersistentAlias("Iif([TestDetailsCollection][].Sum([price]) Is Null, 0.0m, [TestDetailsCollection][].Sum([price]))")]
        public decimal testsSum
        {
            get { return (decimal)(EvaluateAlias(nameof(testsSum))); }
        }
        [PersistentAlias("Iif([XraysDetailsCollection][].Sum([price]) Is Null, 0.0m, [XraysDetailsCollection][].Sum([price]))")]
        public decimal xraysSum
        {
            get { return (decimal)(EvaluateAlias(nameof(xraysSum))); }
        }
        int ftotalDays;
        public int totalDays
        {
            get { return ftotalDays; }
            set { SetPropertyValue<int>(nameof(totalDays), ref ftotalDays, value); }
        }
        [PersistentAlias("[stayTotalSum]")]
        public decimal amount
        {
            get { return (decimal)(EvaluateAlias(nameof(amount))); }
        }
        bool fignoreFirstDay;
        public bool ignoreFirstDay
        {
            get { return fignoreFirstDay; }
            set { SetPropertyValue<bool>(nameof(ignoreFirstDay), ref fignoreFirstDay, value); }
        }
        decimal froomStaySum;
        public decimal roomStaySum
        {
            get { return froomStaySum; }
            set { SetPropertyValue<decimal>(nameof(roomStaySum), ref froomStaySum, value); }
        }
        decimal fmedicalCareSum;
        public decimal medicalCareSum
        {
            get { return fmedicalCareSum; }
            set { SetPropertyValue<decimal>(nameof(medicalCareSum), ref fmedicalCareSum, value); }
        }
        decimal fMedicalSupervisionSum;
        public decimal MedicalSupervisionSum
        {
            get { return fMedicalSupervisionSum; }
            set { SetPropertyValue<decimal>(nameof(MedicalSupervisionSum), ref fMedicalSupervisionSum, value); }
        }
        [PersistentAlias("[companionSum] + [servicesSum] + [suppliesSum] + [endscopesSum] + [testsSum] + [xraysSum] + [MedicalSupervisionSum] + [medicalCareSum] + [roomStaySum]")]
        public decimal stayTotalSum
        {
            get { return (decimal)(EvaluateAlias(nameof(stayTotalSum))); }
        }
        decimal froomStayCost;
        public decimal roomStayCost
        {
            get { return froomStayCost; }
            set { SetPropertyValue<decimal>(nameof(roomStayCost), ref froomStayCost, value); }
        }
        decimal froomCareCost;
        public decimal roomCareCost
        {
            get { return froomCareCost; }
            set { SetPropertyValue<decimal>(nameof(roomCareCost), ref froomCareCost, value); }
        }
        decimal froomSupervisionCost;
        public decimal roomSupervisionCost
        {
            get { return froomSupervisionCost; }
            set { SetPropertyValue<decimal>(nameof(roomSupervisionCost), ref froomSupervisionCost, value); }
        }
        [Association(@"SupervisionDetailsReferencesAdmission")]
        public XPCollection<SupervisionDetails> SupervisionDetailsCollection { get { return GetCollection<SupervisionDetails>(nameof(SupervisionDetailsCollection)); } }
        [Association(@"StayMedicicationReferencesStay"), Aggregated]
        public XPCollection<StayMedications> StayMedicications { get { return GetCollection<StayMedications>(nameof(StayMedicications)); } }
        [Association(@"StockDetailsReferencesStay"), Aggregated]
        public XPCollection<StaySupplies> StockDetailsCollection { get { return GetCollection<StaySupplies>(nameof(StockDetailsCollection)); } }
        [Association(@"ServiceDetailsReferencesStay"), Aggregated]
        public XPCollection<ServiceDetails> ServiceDetailsCollection { get { return GetCollection<ServiceDetails>(nameof(ServiceDetailsCollection)); } }
        [Association(@"EndscopeDetailsReferencesAdmission"), Aggregated]
        public XPCollection<EndscopeDetails> EndscopeDetailsCollection { get { return GetCollection<EndscopeDetails>(nameof(EndscopeDetailsCollection)); } }
        [Association(@"CompanionDetailsReferencesAdmission"), Aggregated]
        public XPCollection<CompanionDetails> CompanionDetailsCollection { get { return GetCollection<CompanionDetails>(nameof(CompanionDetailsCollection)); } }
        [Association(@"TestDetailsReferencesAdmission"), Aggregated]
        public XPCollection<TestDetails> TestDetailsCollection { get { return GetCollection<TestDetails>(nameof(TestDetailsCollection)); } }
        [Association(@"XraysDetailsReferencesAdmission"), Aggregated]
        public XPCollection<XraysDetails> XraysDetailsCollection { get { return GetCollection<XraysDetails>(nameof(XraysDetailsCollection)); } }
    }

}
