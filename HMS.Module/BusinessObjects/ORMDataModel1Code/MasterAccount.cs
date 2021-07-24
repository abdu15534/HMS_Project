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
    [DefaultProperty("accountName")]
    public partial class MasterAccount
    {
        
        public MasterAccount(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); credit = 0; debit = 0; }

        AccountClassifications accountClassification;

        public AccountClassifications AccountClassification
        {
            get => accountClassification;
            set => SetPropertyValue(nameof(AccountClassification), ref accountClassification, value);
        }

       public enum AccountClassifications { Assets, Liabilities, Expenses, Revenues }

        public void GenerateAccountNubmer()
        {
            if(this.accountClassification == AccountClassifications.Assets)
            {
                int? num = Session.Query<MasterAccount>().Max(p => p.accountNumber);
                if (num == null)
                    this.accountNumber = 101;
                else
                    this.accountNumber = (int)num + 1;
            }
        }
    }

}
