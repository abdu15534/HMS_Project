using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]

    public partial class ICU
    {
        public ICU(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
