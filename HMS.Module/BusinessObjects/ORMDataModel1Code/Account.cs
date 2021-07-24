using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using System.Linq;


namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    [DefaultProperty("accountName")]
    public partial class Account
    {
        public Account(Session session) : base(session) { }
        public override void AfterConstruction() 
        {
            base.AfterConstruction(); 
            credit = 0; 
            debit = 0;
        }

        public IList<JournalEntry> Journals
        {
            get => Session.Query<JournalEntry>().Where(p => p.JournalDetailsCollection.Any(x => x.account == this)).ToList();
        }
        

        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.Session.IsNewObject(this))
            {
                if (this.accountNumber == 0)
                {
                    SetAccountNumber();
                }
            }
        }

        public void SetAccountNumber()
        {
            int? maxNumber = Session.Query<Account>().Where(p => p.SubAccount.accountNumber == this.SubAccount.accountNumber).Max(p => p.accountNumber);
            if(!maxNumber.HasValue || maxNumber == 0)
            {
                //this.accountNumber = Convert.ToInt32($"{this.SubAccount.accountNumber}+{0001}");
                SetPropertyValue<int>(nameof(accountNumber), ref faccountNumber,
                                this.accountNumber = Convert.ToInt32($"{this.SubAccount.accountNumber}+{0001}"));

            }
            else
            {
                int count = 1;
                while(this.accountNumber == 0)
                {
                    Account sampleAccount = Session.FindObject<Account>(new BinaryOperator("accountNumber", maxNumber + count));

                    if (sampleAccount == null)
                    {
                        //this.accountNumber = Convert.ToInt32(maxNumber + count);
                        SetPropertyValue<int>(nameof(accountNumber), ref faccountNumber, 
                        this.accountNumber = Convert.ToInt32(maxNumber + count));
                        return;
                    }
                    count++;
                }
                    
            }
        }
    }

}
