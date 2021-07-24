using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.ComponentModel;
using static XafDataModel.Module.BusinessObjects.test2.Admission;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    [DefaultProperty("number")]
    public partial class Room
    {
        public Room(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction();}


        statusType status;

        public statusType Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }


    }
}
