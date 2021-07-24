using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.Collections.Generic;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class Supplier
    {
        public Supplier(Session session) : base(session) { }
        public override void AfterConstruction() 
        {
            base.AfterConstruction();
            account = new Account(Session);
            account.accountName = FullName;
            account.SubAccount = Session.FindObject<SubAccount>(new BinaryOperator("accountNumber", 20701));
        }


        IList<PurchasingOrder> orders;

        public IList<PurchasingOrder> Orders
        {
            get => Session.Query<PurchasingOrder>().Where(p => p.supplierAccount == this.account).ToList();
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.Session.IsNewObject(this))
                account.accountName = FullName;

        }



    }
}
