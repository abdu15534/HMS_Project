using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class SalaryDeduction
    {
        public SalaryDeduction(Session session) : base(session) { }
        public override void AfterConstruction() 
        {
            base.AfterConstruction();
            paymentAccount = Session.FindObject<Account>(new BinaryOperator("accountNumber", 104020001));
            journalEntry = new JournalEntry(Session);
        }


        private XPCollection<AuditDataItemPersistent> auditTrail;
        [CollectionOperationSet(AllowAdd = false, AllowRemove = false)]
        public XPCollection<AuditDataItemPersistent> AuditTrail
        {
            get
            {
                if (auditTrail == null)
                {
                    auditTrail = AuditedObjectWeakReference.GetAuditTrail(Session, this);
                }
                return auditTrail;
            }
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

        }

        protected override void OnSaving()
        {

            var deductions = Session.Query<SalaryDeduction>().Where(p => p.date.Year == this.date.Year && p.date.Month == this.date.Month).Where(p => p.id != this.id).ToList();

            if (deductions.Count > 0)
            {
                throw new ArgumentException("هذا الشهر تم اضافته بالفعل!", nameof(date));
            }

            base.OnSaving();

            journalEntry.type = this.GetType().ToString();
            journalEntry.objectKey = this.id.ToString();

        }
        public void totalFlag()
        {
            total = SalaryDeductionDetailsCollection.Sum(p => p.totalDeduction);
        }

        public void SalaryDeductionPost(bool add)
        {
            if (add)
            {
                journalEntry.DeleteDetails();
                SetJournalDetails();
                journalEntry.Post(false);
                post = true;
            }

            else
            {
                journalEntry.Post(true);
                post = false;
            }
        }

        public void SetJournalDetails()
        {

            this.statement = $"غياب و تسويات و خصومات شهر {this.date.ToShortDateString()}";

            this.journalEntry.statement = this.statement;

            if (SalaryDeductionDetailsCollection.Where(p => p.DeductionType != SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction) > 0)
            {
                var accPanalties = new JournalDetails(Session);
                accPanalties.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 103040002));
                accPanalties.debit = SalaryDeductionDetailsCollection.Where(p => p.DeductionType != SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction);
                accPanalties.journal = this.journalEntry;
                accPanalties.statement = this.statement = $"غياب و تسويات و خصومات شهر {this.date.ToShortDateString()}";

                var accPanaltiesRevenue = new JournalDetails(Session);
                accPanaltiesRevenue.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 403030005));
                accPanaltiesRevenue.credit = SalaryDeductionDetailsCollection.Where(p => p.DeductionType != SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction);
                accPanaltiesRevenue.journal = this.journalEntry;
                accPanaltiesRevenue.statement = this.statement = $"غياب و تسويات و خصومات شهر {this.date.ToShortDateString()}";
            }


            if (SalaryDeductionDetailsCollection.Where(p => p.DeductionType == SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction) > 0)
            {
                var addAdvances = new JournalDetails(Session);
                addAdvances.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 103060002));
                addAdvances.debit = SalaryDeductionDetailsCollection.Where(p => p.DeductionType == SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction);
                addAdvances.journal = this.journalEntry;
                addAdvances.statement = this.statement = $"سلف شهر {this.date.ToShortDateString()}";

                var accPanaltiesRevenue = new JournalDetails(Session);
                accPanaltiesRevenue.account = paymentAccount;
                accPanaltiesRevenue.credit = SalaryDeductionDetailsCollection.Where(p => p.DeductionType == SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction);
                accPanaltiesRevenue.journal = this.journalEntry;
                accPanaltiesRevenue.statement = this.statement = $"سلف شهر  {this.date.ToShortDateString()}";

            }

        }

    }
}
