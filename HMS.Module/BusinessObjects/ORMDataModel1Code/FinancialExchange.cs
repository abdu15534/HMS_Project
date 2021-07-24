using DevExpress.Xpo;
using System;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class FinancialExchange
    {
        public FinancialExchange(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); date = DateTime.Now; }
    }

}
