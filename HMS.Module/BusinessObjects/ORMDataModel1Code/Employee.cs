using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    [DefaultProperty("FullName")]
    public partial class Employee
    {
        public Employee(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


        public IList<SalaryPaymentDetails> Salaries
        {
            get => Session.Query<SalaryPaymentDetails>().Where(p => p.employee == this && p.SalaryPayment.post == true).ToList();
        }

        decimal TotalAdvances;
        public decimal totalAdvances
        {
            get => Session.Query<SalaryDeductionDetails>().Where(p => p.employee == this && p.SalaryDeduction.post == true && p.DeductionType == SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction);
        }

        decimal totalPenalties;
        public decimal TotalPenalties
        {
            get => Session.Query<SalaryDeductionDetails>().Where(p => p.employee == this && p.SalaryDeduction.post == true && p.DeductionType != SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction);
        }

        decimal totalPenaltiesAndAdvancesPaid;

        public decimal TotalPenaltiesAndAdvancesPaid
        {
            get => Session.Query<SalaryPaymentDetails>().Where(p => p.employee == this && p.SalaryPayment.post == true).Sum(p => p.totalAdvances + p.totalPenalties);
        }
    }

    

}
