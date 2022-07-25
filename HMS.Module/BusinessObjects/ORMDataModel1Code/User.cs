using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using XafDataModel.Module.BusinessObjects.test2;

namespace DevExpress.Persistent.BaseImpl.PermissionPolicy
{
    public class User : PermissionPolicyUser
    {
        public User(Session session)
        : base(session) { }


        Account faccount;
        public Account account
        {
            get { return faccount; }
            set { SetPropertyValue<Account>(nameof(account), ref faccount, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();


            this.account = new Account(Session);

            this.account.SubAccount = Session.FindObject<SubAccount>(new BinaryOperator("accountNumber", 10402));
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.Session.IsNewObject(this))
            {
                account.accountName = this.UserName;
            }
        }
    }
}
