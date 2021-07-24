using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class Kitchen
    {
        public Kitchen(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        Person inCharge;

        public Person InCharge
        {
            get
            {

                return inCharge;
            }
            set => SetPropertyValue(nameof(InCharge), ref inCharge, value);
        }
    }
}
