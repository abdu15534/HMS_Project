using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp;
using System.Windows.Forms;
using DevExpress.Persistent.BaseImpl;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]

    public partial class SalaryDeductionDetails
    {
        public SalaryDeductionDetails(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); DeductionType = DeductionTypes.Absence;  date = DateTime.Now; } 


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

        DeductionTypes deductionType;
        public DeductionTypes DeductionType
        {
            get => deductionType;
            set => SetPropertyValue(nameof(DeductionType), ref deductionType, value);
        }

        public enum DeductionTypes { Absence , lateness  , FinancialAdvance , PunitiveSanctions , Others}

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(employee))
            {
                if (newValue == null) { payPerHour = 0; }
                else { payPerHour = employee.baseSalary / (employee.daysOfWork * employee.hoursOfDay); }

            }

            if (propertyName == nameof(payPerHour) || propertyName == nameof(deductionDays) || propertyName == nameof(deductionHours) || propertyName == nameof(deductionOthers))
            {
                if (employee != null)
                {
                    totalDeduction = deductionDays * employee.hoursOfDay * payPerHour + deductionHours * payPerHour + deductionOthers;
                }
                else
                {
                    totalDeduction = deductionOthers;
                }
            }

        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            this.SalaryDeduction.total -= this.totalDeduction;
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            /*            if (!IsDeleted && !IsLoading)
                        {
                            if (employee == null)
                            {
                                throw new ArgumentException("يجب اختيار موظف!", nameof(employee));
                            }

                            if (date == null)
                            {
                                throw new ArgumentException("يجب اختيار تاريخ!", nameof(date));
                            }


                            if (date.Month != SalaryDeduction.date.Month || date.Year != SalaryDeduction.date.Year)
                            {
                                throw new ArgumentException("يجب اختيار تاريخ في نفس مدي تاريخ القيد!", nameof(date));
                            }

                            totalDeduction = (deductionDays * employee.hoursOfDay + deductionHours) * payPerHour + deductionOthers;

                            if (totalDeduction == 0)
                            {
                                throw new ArgumentException("يجب اختيار قيمة خصم!", nameof(totalDeduction));
                            }
                            SalaryDeduction.totalFlag();
                        }*/

            if (!IsDeleted)
            {
                if (date.Month != SalaryDeduction.date.Month || date.Year != SalaryDeduction.date.Year)
                {
                    MessageBox.Show($"يجب اختيار تاريخ في نفس مدي تاريخ القيد! \n سيتم تغيره تلقائيا الي {new DateTime(SalaryDeduction.date.Year, SalaryDeduction.date.Month, 1).ToShortDateString()}");
                    date = new DateTime(SalaryDeduction.date.Year, SalaryDeduction.date.Month, 1);

                }
                totalDeduction = deductionDays * employee.hoursOfDay * payPerHour + deductionHours * payPerHour + deductionOthers;
                this.SalaryDeduction.totalFlag();
            }

        }

    }

}
