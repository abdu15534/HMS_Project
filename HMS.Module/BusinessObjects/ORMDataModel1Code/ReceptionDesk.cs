using System;
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
using System.Collections;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class ReceptionDesk
    {
        public ReceptionDesk(Session session) : base(session) { section = statusType.normal; }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            InPatientSettings settingObj = Session.Query<InPatientSettings>().First();
            this.DeceasedPackageApplyed = false;
            dateEnter = DateTime.Now;
            this.ServiceRate = settingObj.ServiceRate;
            this.StampPrice = settingObj.StampPrice;
            currentStay = new Admission(Session);
            journalEntry = new JournalEntry(Session);
            

        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if ((propertyName == nameof(totalC) || propertyName == nameof(medicationC) || propertyName == nameof(amountC)) && newValue != null)
            {
                
            }
        }


        public enum dischargeTypes { في_المستشفى , تحسن, وفاة, حسب_الطلب }

        dischargeTypes reasonForDischarge;

        public dischargeTypes ReasonForDischarge
        {
            get => reasonForDischarge;
            set => SetPropertyValue(nameof(ReasonForDischarge), ref reasonForDischarge, value);
        }

        public enum transferTypes { مريض_مستشفى, حالة_خاصة }

        transferTypes transferReason;

        public transferTypes TransferReason
        {
            get => transferReason;
            set => SetPropertyValue(nameof(TransferReason), ref transferReason, value);
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
            Session.Delete(this.Admissions);
            Session.Delete(this.PaymentsCollection);
            Session.Delete(this.PackageDetails);
            journalEntry.Post(true);
            this.journalEntry.Delete();
            this.patient.InStay = false;
            this.currentStay = null;
        }

        protected override void OnSaving()
        {
            journalEntry.type = this.GetType().ToString();
            journalEntry.objectKey = this.enterID.ToString();
            CalculateTotal();
            

            base.OnSaving();
            if(this.patient.InStay ==false && this.isDischarged == false)
            {
                this.patient.InStay = true;
            }
            //if(reasonForDischarge == dischargeTypes.وفاة && DeceasedPackageApplyed == false)
            //{
            //    StockProduct l = Session.FindObject<StockProduct>(CriteriaOperator.Parse("product.name='جوانتي, 2 رباط , لفت'"));
                
              
            //    StaySupplies deceassedService = new StaySupplies(Session);
            //    deceassedService.Stay = this.currentStay;
            //    deceassedService.supplyProduct = l;
            //    deceassedService.quantity = 1;
            //    //deceassedService.Save();

            //    StockProduct l2 = Session.FindObject<StockProduct>(CriteriaOperator.Parse("product.name='كيس بلاستك'"));


            //    StaySupplies deceassedService2 = new StaySupplies(Session);
            //    deceassedService2.Stay = this.currentStay;
            //    deceassedService2.supplyProduct = l2;
            //    deceassedService2.quantity = 1;
            //    //deceassedService2.Save();

            //    StockProduct l3 = Session.FindObject<StockProduct>(CriteriaOperator.Parse("product.name='ملاية'"));


            //    StaySupplies deceassedService3 = new StaySupplies(Session);
            //    deceassedService3.Stay = this.currentStay;
            //    deceassedService3.supplyProduct = l3;
            //    deceassedService3.quantity = 1;
            //    //deceassedService3.Save();


            //    DeceasedPackageApplyed = true;
            //}
            if (this.Session.IsNewObject(this))
            {
                currentStay.Status = this.Section;
                currentStay.Room = this.room;
                currentStay.bed = this.bed;
                currentStay.Patient = this.patient;
                currentStay.StayStart = DateTime.Now;
                currentStay.reception = this;
                
            }
            
            //if(!IsDeleted)
            //{
            //    if (journalEntry.JournalDetailsCollection.Count > 0)
            //    {
            //        journalEntry.Post(true);
            //    }

            //    journalEntry.DeleteDetails();
            //    SetJournal();
            //    journalEntry.Post(false);
            //}
            if(this.IsDiscounted == true)
            {
                this.IsDiscounted = false;
            }
            //this.patient.InStay = true;

        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            //CalculateTotal();
            //ICollection changedObjects = Session.GetObjectsToSave();
            //int count = changedObjects.Count;

            //foreach (Object i in changedObjects)
            //{
            //    Console.WriteLine(i.GetType());
            //    Console.WriteLine(i.ToString());
            //}

            //Session.DropChanges();
        }
        
        public void CalculateTotal()
        {
            
            decimal totalWithoutDiscount;
            decimal sumation;
            this.medication = Admissions.Sum(p => p.medicationSum);
            
            sumation = Admissions.Sum(p => p.stayTotalSum);
            
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
            if(this.totalC > this.PaymentsCollection.Sum(p => p.amount))
            {
                MessageBox.Show("الرجاء السداد اولا", "لم تسدد جميع المستحقات ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (reasonForDischarge == dischargeTypes.في_المستشفى)
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