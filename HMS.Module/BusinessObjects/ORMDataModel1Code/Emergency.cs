using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class Emergency
    {
        public Emergency(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            date = DateTime.Now;
            Department = Session.Query<Department>().Where(d => d.ID == 6).First();
        }

    }

}
