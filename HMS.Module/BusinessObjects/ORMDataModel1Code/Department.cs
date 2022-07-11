using DevExpress.Xpo;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class Department
    {

        public Department(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

    }

}
