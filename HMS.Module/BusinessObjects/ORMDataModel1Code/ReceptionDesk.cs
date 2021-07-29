﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using static XafDataModel.Module.BusinessObjects.test2.Admission;
using System.Linq;
using DevExpress.Persistent.Base;
using System.Windows.Forms;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class ReceptionDesk
    {
        public ReceptionDesk(Session session) : base(session) { section = statusType.normal; }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.DeceasedPackageApplyed = false;
            dateEnter = DateTime.Now;
            this.ServiceRate = 12;
            currentStay = new Admission(Session);
            journalEntry = new JournalEntry(Session);
            

        }

        public enum dischargeTypes { فيالمستشفى , Healthy, وفاة, Other }

        dischargeTypes reasonForDischarge;

        public dischargeTypes ReasonForDischarge
        {
            get => reasonForDischarge;
            set => SetPropertyValue(nameof(ReasonForDischarge), ref reasonForDischarge, value);
        }

        statusType section;

        public statusType Section
        {
            get => section;
            set => SetPropertyValue(nameof(Section), ref section, value);
        }

        


        protected override void OnDeleting()
        {
            base.OnDeleting();
            journalEntry.Post(true);
            this.journalEntry.Delete();
            this.patient.InStay = false;
            this.currentStay = null;
        }

        protected override void OnSaving()
        {
            journalEntry.type = this.GetType().ToString();
            journalEntry.objectKey = this.enterID.ToString();

            base.OnSaving();
            if(this.patient.InStay ==false && this.isDischarged == false)
            {
                this.patient.InStay = true;
            }
            if(reasonForDischarge == dischargeTypes.وفاة && DeceasedPackageApplyed == false)
            {
                var l = Session.Query<Service>().Where(p => p.ServiceType == ServiceTypes.Deceased);
                foreach (var item in l)
                {
                    //if (!(Session is NestedUnitOfWork)
                    //    && (Session.DataLayer != null)
                    //       && Session.IsNewObject(this)
                    //           && (Session.ObjectLayer is SimpleObjectLayer))
                    //            {

                                    ServiceDetails deceassedService = new ServiceDetails(Session);
                                    deceassedService.Stay = this.currentStay;
                                    deceassedService.Service = item;
                                    deceassedService.Save();

                                //}
                    
                }
                DeceasedPackageApplyed = true;
            }
            if (this.Session.IsNewObject(this))
            {
                currentStay.Status = this.Section;
                currentStay.Room = this.room;
                currentStay.bed = this.bed;
                currentStay.Patient = this.patient;
                currentStay.StayStart = DateTime.Now;
                currentStay.reception = this;
            }
            CalculateTotal();
            if(!IsDeleted)
            {
                if (journalEntry.JournalDetailsCollection.Count > 0)
                {
                    journalEntry.Post(true);
                }

                journalEntry.DeleteDetails();
                SetJournal();
                journalEntry.Post(false);
            }
            if(this.IsDiscounted == true)
            {
                this.IsDiscounted = false;
            }
            //this.patient.InStay = true;

        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            CalculateTotal();
            
        }

        public void CalculateTotal()
        {
            
            decimal totalWithoutDiscount;
            decimal sumation;
            this.medication = Admissions.Sum(p => p.medicationSum);
            if (patient.Nationality == Patient.Nationalitys.Egypt)
            {
                sumation = Admissions.Sum(p => p.stayTotalSum);
            }
            else
            {
                sumation = Admissions.Sum(p => p.stayTotalSum)* Convert.ToDecimal(1.5);
            }
            this.amount = sumation;
            this.ServiceFee = sumation * Convert.ToDecimal((this.ServiceRate / 100));
            
            
        

            totalWithoutDiscount = sumation + this.ServiceFee;

            this.total = totalWithoutDiscount - Discount;
            this.total = this.total + medication;
        }

        public void CheckOut()
        {
            foreach (var item in Admissions)
            {
                if (item.IsDischarged != true)
                {
                    MessageBox.Show("يجب انهاء جميع الاقامات اولا", "اقامات غير منتهية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if(this.Admissions.Sum(p=>p.stayTotalSum) > this.PaymentsCollection.Sum(p => p.amount))
            {
                MessageBox.Show("الرجاء السداد اولا", "لم تسدد جميع المستحقات ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (reasonForDischarge == dischargeTypes.فيالمستشفى)
            {
                MessageBox.Show("يجب تحديد سبب الخروج اولا", "لم يتم تحديد سبب الخروج ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CalculateTotal();
            if (journalEntry.JournalDetailsCollection.Count > 0)
            {
                journalEntry.Post(true);
            }
            journalEntry.DeleteDetails();
            SetJournal();
            journalEntry.Post(false);
            dateLeave = DateTime.Now;
            isDischarged = true;
            this.patient.InStay = false;
        }


        public void SetJournal()
        {
            

            journalEntry.date = DateTime.Now;
            string statement = $"اقامة بالقسم الداخلي كود دخول : {this.enterID} للسادة / {this.patient.FullName}";
            journalEntry.statement = statement;

            var accPatient = new JournalDetails(Session);
            accPatient.account = this.patient.account;
            accPatient.debit = total;
            accPatient.statement = statement;
            accPatient.journal = this.journalEntry;

            if (this.Admissions.Sum(p => p.roomStaySum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060001"));
                accRoomStay.credit = this.Admissions.Sum(p => p.roomStaySum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.medicalCareSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060006"));
                accRoomStay.credit = this.Admissions.Sum(p => p.medicalCareSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.MedicalSupervisionSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060002"));
                accRoomStay.credit = this.Admissions.Sum(p => p.MedicalSupervisionSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.medicationSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060007"));
                accRoomStay.credit = this.Admissions.Sum(p => p.medicationSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.suppliesSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060008"));
                accRoomStay.credit = this.Admissions.Sum(p => p.suppliesSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.testsSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060009"));
                accRoomStay.credit = this.Admissions.Sum(p => p.testsSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.xraysSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060012"));
                accRoomStay.credit = this.Admissions.Sum(p => p.xraysSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.endscopesSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060014"));
                accRoomStay.credit = this.Admissions.Sum(p => p.endscopesSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.servicesSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060015"));
                accRoomStay.credit = this.Admissions.Sum(p => p.servicesSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            if (this.Admissions.Sum(p => p.companionSum) > 0)
            {
                var accRoomStay = new JournalDetails(Session);
                accRoomStay.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", "401060016"));
                accRoomStay.credit = this.Admissions.Sum(p => p.companionSum);
                accRoomStay.statement = statement;
                accRoomStay.journal = this.journalEntry;
            }


            //Rest of accounts
        }


        /*        IList<Admission> admissions;

                public IList<Admission> Admissions
                {
                    get => Session.Query<Admission>().Where( p => p.enterID == this.enterID).ToList();
                }*/
    }

}