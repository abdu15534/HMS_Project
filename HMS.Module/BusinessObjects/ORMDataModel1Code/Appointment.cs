using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using static XafDataModel.Module.BusinessObjects.test2.Spendings;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class Appointment
    {
        public Appointment(Session session) : base(session) { }
        public override void AfterConstruction() 
        {
            base.AfterConstruction();
            transaction = TransactionCategories.appointment;
        }

        public TransactionSecondCategories TransactionsSecond
        {
            get => transactionsSecond;
            set => SetPropertyValue(nameof(TransactionsSecond), ref transactionsSecond, value);
        }
        TransactionSecondCategories transactionsSecond;

        TransactionCategories transaction;

        public TransactionCategories Transaction
        {
            get => transaction;
            set => SetPropertyValue(nameof(Transaction), ref transaction, value);
        }

        protected override void OnSaving()
        {
            this.Subject = this.Patient.FullName;
            this.Location = this.clinc.Name + "  د/ " + (this.clinc.inCharge!= null ? this.clinc.inCharge.FullName : " ");
            base.OnSaving();
        }
    }

}
