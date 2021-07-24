using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class Spendings
    {
        public Spendings(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Safe safe = Session.FindObject<Safe>(new BinaryOperator("name", "Safe"));

            this.safe = safe;
            Transaction = TransactionCategories.spending;
        }




        TransactionCategories transaction;

        public TransactionCategories Transaction
        {
            get => transaction;
            set => SetPropertyValue(nameof(Transaction), ref transaction, value);
        }


        
        public TransactionSecondCategories TransactionsSecond
        {
            get => transactionsSecond;
            set => SetPropertyValue(nameof(TransactionsSecond), ref transactionsSecond, value);
        }
TransactionSecondCategories transactionsSecond;
        

        public enum TransactionCategories
        {
            none , payment , spending , stay , emergency , appointment
        }

        public enum TransactionSecondCategories
        {
           none , electric , salaries , clincPayments , waste
        }


        protected override void OnSaving()
        {
            base.OnSaving();
            if (category.name == "كهرباء")
                transactionsSecond = TransactionSecondCategories.electric;

            if (category.name == "مرتبات")
                transactionsSecond = TransactionSecondCategories.salaries;

            if (category.name == "مصاريف عيادات")
                transactionsSecond = TransactionSecondCategories.clincPayments;

            if (category.name == "هالك")
                transactionsSecond = TransactionSecondCategories.waste;

        }
    }

}
