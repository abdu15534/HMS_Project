using DevExpress.Xpo;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class Payer
    {
        public Payer(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
