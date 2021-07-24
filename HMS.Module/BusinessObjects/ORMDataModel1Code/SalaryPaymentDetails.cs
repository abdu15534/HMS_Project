using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class SalaryPaymentDetails
    {
        public SalaryPaymentDetails(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            paySalary = true;
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if((propertyName == nameof(totalAdvances) || propertyName == nameof(totalPenalties)) && oldValue != newValue)
            {
                totalDeductions = insuranceDeduction + otherDeductions + totalAdvances + totalPenalties;
            }
            if (propertyName == nameof(totalDeductions) && oldValue != newValue)
            {
                netPay = grossPay - totalDeductions;
            }

            if (propertyName == nameof(totalPenalties))
            {
                decimal totalPenalties = Session.Query<SalaryDeductionDetails>().Where(p => p.employee == this.employee && p.SalaryDeduction.date <= this.SalaryPayment.date && p.DeductionType != SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction);
                decimal totalPaidPenalties = Session.Query<SalaryPaymentDetails>().Where(p => p.employee == this.employee && p.SalaryPayment.date <= this.SalaryPayment.date && p.SalaryPayment.post == true).Sum(p => p.totalPenalties);

                if (this.totalPenalties < 0 )
                {
                    this.totalPenalties = 0;
                }

                if (this.totalPenalties > (totalPenalties - totalPaidPenalties))
                {
                    this.totalPenalties = totalPenalties - totalPaidPenalties;
                }
            }

            if (propertyName == nameof(totalAdvances))
            {
                decimal totalAdvances = Session.Query<SalaryDeductionDetails>().Where(p => p.employee == this.employee && p.SalaryDeduction.date <= this.SalaryPayment.date && p.DeductionType == SalaryDeductionDetails.DeductionTypes.FinancialAdvance).Sum(p => p.totalDeduction);
                decimal totalPaidAdvances = Session.Query<SalaryPaymentDetails>().Where(p => p.employee == this.employee && p.SalaryPayment.date <= this.SalaryPayment.date && p.SalaryPayment.post == true).Sum(p => p.totalAdvances);


                if (this.totalAdvances < 0 )
                {
                    this.totalAdvances = 0;
                }

                if (this.totalAdvances > (totalAdvances - totalPaidAdvances))
                {
                    this.totalAdvances = totalAdvances - totalPaidAdvances;
                }
            }

        }
    }

}
