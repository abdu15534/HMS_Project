using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using static XafDataModel.Module.BusinessObjects.test2.Spendings;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class Emergency
    {
        public Emergency(Session session) : base(session) { }
        public override void AfterConstruction() 
        {
            base.AfterConstruction();
            transaction = TransactionCategories.emergency;
            date = DateTime.Now;
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
    }

}
