using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class SurgerySchedule
    {
        public SurgerySchedule(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnSaving()
        {
            base.OnSaving();
            CheckforBookingConflict();
            if (CheckforBookingConflict() != null)
            {
                throw new ArgumentException("يوجد حجز في نفس التوقيت",nameof(StartDay));
            }
        }

        private SurgerySchedule CheckforBookingConflict()
        {
            SurgerySchedule conflict = Session.Query<SurgerySchedule>().Where(c => c.StartDay.Date == StartDay.Date && c.Room == Room && ((c.Start >= Start && c.Start < End) || (c.End >= Start && c.End <= End))).First();
            return conflict;
        }
    }

}
