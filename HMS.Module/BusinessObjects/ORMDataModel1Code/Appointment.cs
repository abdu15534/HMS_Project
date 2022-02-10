using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class Appointment
    {
        public Appointment(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            this.StartOn = DateTime.Now;
            this.EndOn = DateTime.Now.AddHours(2);
            base.AfterConstruction();
            Appointment result = Session.Query<Appointment>().OrderByDescending(t => t.id).FirstOrDefault();
            if (result == null)
            {
                int idNum = 1;
                this.id = idNum;

            }
            else
            {
                int newID = result.id + 1;
                this.id = newID;

            }
            this.AllDay = false;
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(clinc) && newValue != null)
            {
                if (Apttype == AppointmentType.كشف)
                {
                    if (clinc.ExaminationPrice != null)
                    {
                        ExaminationPrice = clinc.ExaminationPrice;
                    }
                }
                else if (Apttype == AppointmentType.استشارة)
                {
                    if (clinc.ConsultationPrice != null)
                    {
                        ExaminationPrice = clinc.ConsultationPrice;
                    }
                }
                else if (Apttype == AppointmentType.NotSet)
                {
                    ExaminationPrice = 0;
                }
            }
            if (propertyName == nameof(Apttype) && newValue != null)
            {
                if (Apttype == AppointmentType.كشف)
                {
                    if (clinc.ExaminationPrice != null)
                    {
                        ExaminationPrice = clinc.ExaminationPrice;
                    }
                }
                else
                {
                    if (clinc.ConsultationPrice != null)
                    {
                        ExaminationPrice = clinc.ConsultationPrice;
                    }
                }
            }
        }



        AppointmentStatus status;

        public AppointmentStatus AptStatus
        {
            get => status;
            set => SetPropertyValue(nameof(AptStatus), ref status, value);
        }

        public enum AppointmentStatus
        {
            NotSet, Paid, InProgress, NoShow, Canceled, completed,
        }

        AppointmentType ftype;

        public AppointmentType Apttype
        {
            get => ftype;
            set => SetPropertyValue(nameof(Apttype), ref ftype, value);
        }

        public enum AppointmentType
        {
            NotSet, كشف, استشارة
        }

        protected override void OnSaving()
        {
            if (this.Patient != null)
            {
                this.Subject = this.Patient.FullName;
            }
            if (this.Doctor != null && this.clinc != null)
            {
                this.Location = this.Doctor.FullName + "  د/ ";
                //+ (this.clinc.inCharge != null ? this.clinc.inCharge.FullName : " ");
            }
            switch (AptStatus)
            {
                case AppointmentStatus.Canceled:
                    this.Label = 1;
                    break;
                case AppointmentStatus.completed:
                    this.Label = 3;
                    break;
                case AppointmentStatus.NoShow:
                    this.Label = 5;
                    break;
                default:
                    break;
            }
            this.AllDay = false;
            base.OnSaving();
        }
    }

}
