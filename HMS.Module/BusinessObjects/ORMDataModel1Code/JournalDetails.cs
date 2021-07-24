using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    public partial class JournalDetails
    {
        public JournalDetails(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}
