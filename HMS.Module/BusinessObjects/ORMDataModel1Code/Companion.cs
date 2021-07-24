using DevExpress.ExpressApp;
using DevExpress.Xpo;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    public partial class Companion
    {
        public Companion(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

    }

}
