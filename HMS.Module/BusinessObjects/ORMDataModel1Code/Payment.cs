using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using static XafDataModel.Module.BusinessObjects.test2.Spendings;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    [DefaultClassOptions]
    public partial class Payments
    {
        public Payments(Session session) : base(session) { }

        public override void AfterConstruction() 
        {
            base.AfterConstruction(); date = DateTime.Now;
            Safe safe = Session.FindObject<Safe>(new BinaryOperator("name", "Safe"));
            this.safe = safe;
            Transaction = TransactionCategories.payment;
        }


        public TransactionSecondCategories TransactionsSecond
        {
            get => transactionsSecond;
            set => SetPropertyValue(nameof(TransactionsSecond), ref transactionsSecond, value);
        }
        TransactionSecondCategories transactionsSecond;

        Person payer;

        public Person Payer
        {
            get => payer;
            set => SetPropertyValue(nameof(Payer), ref payer, value);
        }

        TransactionCategories transaction;

        public TransactionCategories Transaction
        {
            get => transaction;
            set => SetPropertyValue(nameof(Transaction), ref transaction, value);
        }

    }

}
