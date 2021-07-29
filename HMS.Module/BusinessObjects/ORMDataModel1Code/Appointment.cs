using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using static XafDataModel.Module.BusinessObjects.test2.Spendings;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class Appointment
    {
        public Appointment(Session session) : base(session) { }
        public override void AfterConstruction() 
        {
            base.AfterConstruction();
            this.AllDay = false;

        }

        

        protected override void OnSaving()
        {
            this.Subject = this.Patient.FullName;
            this.Location = this.Doctor.FullName + "  د/ " + (this.clinc.inCharge!= null ? this.clinc.inCharge.FullName : " ");
            base.OnSaving();
        }
    }

}
