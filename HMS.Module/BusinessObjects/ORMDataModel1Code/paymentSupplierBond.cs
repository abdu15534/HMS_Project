using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class paymentBond
    {

        public paymentBond(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            date = DateTime.Now;
            journal = new JournalEntry(Session);
            journal.date = DateTime.Now;

            ffromAccount = Session.FindObject<Account>(new BinaryOperator("accountNumber", 104020001));
        }

        public enum BondTypes { receiptClient, paymentSupplier, receiptManagement, paymentManagement }


        protected override void OnSaving()
        {
            base.OnSaving();
            journal.type = this.GetType().ToString();
            journal.objectKey = this.id.ToString();

        }


        protected override void OnDeleting()
        {
            base.OnDeleting();
            if (post)
            {
                OrderConfirm(false);
            }
            this.journal.Delete();
        }


        public void OrderConfirm(bool add)
        {
            if (add)
            {
                journal.DeleteDetails();

                this.statement = $"سند صرف رقم: {this.id} من حساب السادة / {fromAccount.accountName} الي حساب {intoAccount.accountName}";

                var acc1 = new JournalDetails(Session);
                acc1.account = fromAccount;
                acc1.debit = amount;
                acc1.statement = this.statement;
                acc1.journal = this.journal;

                var acc2 = new JournalDetails(Session);
                acc2.account = intoAccount;
                acc2.credit = amount;
                acc2.statement = this.statement;
                acc2.journal = this.journal;

                journal.Post(false);
                post = true;
            }

            else
            {
                journal.Post(true);
                post = false;
            }

            journal.statement = this.statement;
        }
    }

}
