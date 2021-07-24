using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.Windows.Forms;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultProperty("date")]
    public partial class SalaryPayment
    {
        public SalaryPayment(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            paymentAccount = Session.FindObject<Account>(new BinaryOperator("accountNumber", 104020001));
            journalEntry = new JournalEntry(Session);
           // journalEntry.date = DateTime.Now;
        }

        protected override void OnSaving()
        {
            var payments = Session.Query<SalaryPayment>().Where(p => p.date.Year == this.date.Year && p.date.Month == this.date.Month).Where(p => p != this).ToList();

            if(payments.Count > 0)
            {
                throw new ArgumentException("هذا الشهر تم اضافته بالفعل!", nameof(date));
            }

            base.OnSaving();

            journalEntry.type = this.GetType().ToString();
            journalEntry.objectKey = this.id.ToString();
        
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            if (post)
            {
                SalaryPaymentPost(false);
            }
            this.journalEntry.Delete();
        }

        public void PrepareSalaries()
        {
            IList<Employee> employees;
            if (this.section == null)
            {
                employees = Session.Query<Employee>().ToList();
            }
            else
            {
                employees = Session.Query<Employee>().Where(p => p.section == this.section).ToList();
            }

            foreach (var item in employees)
            {
                SalaryPaymentDetails salary = new SalaryPaymentDetails(Session);
                salary.SalaryPayment = this;
                salary.employee = item;
                salary.baseSalary = item.baseSalary;
                salary.daysOfWork = item.daysOfWork;
                salary.hoursOfWork = item.hoursOfDay;
                salary.housing = item.housing;
                salary.incentive = item.incentive;
                salary.transportation = item.transportation;
                salary.socialInsurane = item.socialInsurane;
                salary.medicine = item.medicine;
                salary.others = item.others;
                salary.grossPay = item.baseSalary + item.incentive + item.housing + item.transportation + item.socialInsurane + item.medicine + item.others;

                salary.insuranceDeduction = item.insuranceDeduction;
                salary.otherDeductions = item.otherDeductions;

                decimal totalPenalties = Session.Query<SalaryDeductionDetails>().Where(p => p.employee == item && p.date.Year <= this.date.Year && p.date.Month <= this.date.Month && p.DeductionType != SalaryDeductionDetails.DeductionTypes.FinancialAdvance && p.SalaryDeduction.post == true).Sum(p => p.totalDeduction);
                decimal totalPaidPenalties = Session.Query<SalaryPaymentDetails>().Where(p => p.employee == item && p.SalaryPayment.date.Year <= this.date.Year && p.SalaryPayment.date.Month <= this.date.Month && p.SalaryPayment.post == true).Sum(p => p.totalPenalties);
                salary.totalPenalties = totalPenalties - totalPaidPenalties;

                decimal totalAdvances = Session.Query<SalaryDeductionDetails>().Where(p => p.employee == item && p.date.Year <= this.date.Year && p.date.Month <= this.date.Month && p.DeductionType == SalaryDeductionDetails.DeductionTypes.FinancialAdvance && p.SalaryDeduction.post == true).Sum(p => p.totalDeduction);
                decimal totalPaidAdvances= Session.Query<SalaryPaymentDetails>().Where(p => p.employee == item && p.SalaryPayment.date.Year <= this.date.Year && p.SalaryPayment.date.Month <= this.date.Month && p.SalaryPayment.post == true).Sum(p => p.totalAdvances );
                salary.totalAdvances= totalAdvances - totalPaidAdvances;

                decimal totalBonuses = Session.Query<BonusDetails>().Where(p => p.employee == item && p.date.Year <= this.date.Year && p.date.Month <= this.date.Month && p.SalaryDeduction.post == true).Sum(p => p.amount);
                decimal totalPaidBonuses = Session.Query<SalaryPaymentDetails>().Where(p => p.employee == item && p.SalaryPayment.date.Year <= this.date.Year && p.SalaryPayment.date.Month <= this.date.Month && p.SalaryPayment.post == true).Sum(p => p.totalBonuses);
                salary.totalBonuses = totalBonuses - totalPaidBonuses;

                salary.totalDeductions = item.insuranceDeduction + item.otherDeductions + salary.totalAdvances + salary.totalPenalties ;
                salary.netPay = salary.grossPay + salary.totalBonuses - salary.totalDeductions;

            }
        }

        public void SalaryPaymentPost(bool add)
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

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

        }

        public void SetJournalDetails()
        {
              
            if(section == null)
            {
                this.statement = $"كشف مرتبات شهر {date.Month} لعام {date.Year} قسم : الكل";
            }
            else
            {
                this.statement = $"كشف مرتبات شهر {date.Month} لعام {date.Year} قسم : {section.name}";
            }
           
            this.journalEntry.statement = this.statement;

            
            var accBaseSalary = new JournalDetails(Session);
            accBaseSalary.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 302010001));
            accBaseSalary.debit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.baseSalary);
            accBaseSalary.journal = this.journalEntry;

            if (section == null)
            {
                accBaseSalary.statement = $"قيمة مرتب اساسي شهر {date.Month} لعام {date.Year} قسم : الكل";
            }
            else
            {
                accBaseSalary.statement = $"كشف مرتب اساسي شهر {date.Month} لعام {date.Year} قسم : {section.name}";
            }

            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.housing) > 0)
            {
                var accHousing = new JournalDetails(Session);
                accHousing.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 302010003));
                accHousing.debit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.housing);
                accHousing.journal = this.journalEntry;

                if (section == null)
                {
                    accHousing.statement = $"قيمة بدل سكن شهر {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    accHousing.statement = $"قيمة بدل سكن شهر {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }

            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.incentive) > 0)
            {
                var accIncentive = new JournalDetails(Session);
                accIncentive.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 302010002));
                accIncentive.debit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.incentive);
                accIncentive.journal = this.journalEntry;

                if (section == null)
                {
                    accIncentive.statement = $"قيمة حوافز شهر {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    accIncentive.statement = $"كشف حوافز شهر {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }
            
            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.transportation) > 0)
            {
                var accTransportation = new JournalDetails(Session);
                accTransportation.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 302010004));
                accTransportation.debit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.transportation);
                accTransportation.journal = this.journalEntry;

                if (section == null)
                {
                    accTransportation.statement = $"قيمة بدل انتقال شهر {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    accTransportation.statement = $"قيمة بدل انتقال شهر {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }

            
            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.medicine) > 0)
            {
                var accMedicine = new JournalDetails(Session);
                accMedicine.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 302010005));
                accMedicine.debit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.medicine);
                accMedicine.journal = this.journalEntry;

                if (section == null)
                {
                    accMedicine.statement = $"قيمة بدل علاج شهر {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    accMedicine.statement = $"قيمة بدل علاج شهر {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }

            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.others) > 0)
            {
                var accOthers = new JournalDetails(Session);
                accOthers.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 302010006));
                accOthers.debit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.others);
                accOthers.journal = this.journalEntry;

                if (section == null)
                {
                    accOthers.statement = $"قيمة بدلات أخري شهر {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    accOthers.statement = $"قيمة بدلات أخري شهر {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }

            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.socialInsurane) > 0)
            {
                var acc2 = new JournalDetails(Session);
                acc2.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 302030001));
                acc2.debit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.socialInsurane);
                acc2.journal = this.journalEntry;

                if (section == null)
                {
                    acc2.statement = $"قيمة تأمينات شهر {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    acc2.statement = $"قيمة تأمينات شهر {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }
            
            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.insuranceDeduction) > 0)
            {
                var accInsuranceDeduction = new JournalDetails(Session);
                accInsuranceDeduction.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 207040005));
                accInsuranceDeduction.credit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.insuranceDeduction);
                accInsuranceDeduction.journal = this.journalEntry;

                if (section == null)
                {
                    accInsuranceDeduction.statement = $"محصل لمؤسسة التأمينات عن شهر {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    accInsuranceDeduction.statement = $"محصل لمؤسسة التأمينات عن شهر {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }
            

            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.totalPenalties) > 0)
            {
                var accPanalties = new JournalDetails(Session);
                accPanalties.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 103040002));
                accPanalties.credit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.totalPenalties);
                accPanalties.journal = this.journalEntry;

                if (section == null)
                {
                    accPanalties.statement = $"غياب و تسويات و خصومات شهر  {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    accPanalties.statement = $"غياب و تسويات و خصومات شهر  {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }

            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.totalAdvances) > 0)
            {
                var accPanalties = new JournalDetails(Session);
                accPanalties.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 103060002));
                accPanalties.credit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.totalAdvances);
                accPanalties.journal = this.journalEntry;

                if (section == null)
                {
                    accPanalties.statement = $"سلف شهر  {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    accPanalties.statement = $"سلف شهر  {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }

            if (this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.otherDeductions) > 0)
            {
                var acc2 = new JournalDetails(Session);
                acc2.account = Session.FindObject<Account>(new BinaryOperator("accountNumber", 403030005));
                acc2.credit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.otherDeductions);
                acc2.journal = this.journalEntry;

                if (section == null)
                {
                    acc2.statement = $"ايراد خصومات اخري عن شهر {date.Month} لعام {date.Year} قسم : الكل";
                }
                else
                {
                    acc2.statement = $"ايراد خصومات اخري عن شهر {date.Month} لعام {date.Year} قسم : {section.name}";
                }

            }

            //paymentAccount
            var accPaymentAccount = new JournalDetails(Session);
            accPaymentAccount.account = paymentAccount;
            accPaymentAccount.credit = this.SalaryDetailsCollection.Where(p => p.paySalary == true).Sum(p => p.netPay);
            accPaymentAccount.journal = this.journalEntry;

            if (section == null)
            {
                accPaymentAccount.statement = $"قيمة مرتب شهر {date.Month} لعام  {DateTime.Now} بتاريح {date.Year} قسم : الكل";
            }
            else
            {
                accPaymentAccount.statement = $"قيمة مرتب شهر {date.Month} لعام  {DateTime.Now} بتاريح {date.Year} قسم : {section.name}";
            }


        }
    }
}
