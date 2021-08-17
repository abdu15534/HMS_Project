using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using NPOI.SS.Formula.Functions;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static XafDataModel.Module.BusinessObjects.test2.Spendings;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions, DefaultProperty("admissionID")]
    // [RuleCriteria("", DefaultContexts.Save, "ClientAddress.House != 0",
    //"House should not be 0", SkipNullOrEmptyValues = false)]

    public partial class Admission
    {
        public Admission(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction(); StayStart = DateTime.Now;
            Status = statusType.normal;
        }

        statusType status;

        public statusType Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }

        public enum statusType { normal = 0, ICU = 1, covid = 2 }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            // CalculateRoomServices();
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (propertyName == nameof(Status))
            {
                Room = null;
                bed = null;
            }

            if (propertyName == nameof(Room))
            {
                if (Room != null)
                {
                    roomStayCost = Room.roomCost;
                    roomCareCost = Room.careCost;
                    roomSupervisionCost = Room.supervisionCost;
                }
            }

            if ((propertyName == nameof(StayStart) || propertyName == nameof(StayEnd)) && newValue != null)
            {
                CalculateRoomServices();
            }
        }
        protected override void OnSaving()
        {
            if (Room == null || bed == null)
                throw new ArgumentException("يجب اختيار الغرفة و السرير!", nameof(Room));

            /*            if (Room == null)
                        {
                            MessageBox.Show("Enter a room, please", "Room Empty!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Delete();
                            return;
                        }
                        if (bed == null)
                        {
                            MessageBox.Show("Enter a bed, please", "bed Empty!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Delete();
                            return;
                        }*/

            base.OnSaving();

            if (this.Session.IsNewObject(this))
            {
                if (reception.currentStay != this)
                {
                    /*                    if(this.reception.currentStay.totalDays != this.reception.currentStay.SupervisionDetailsCollection.Count)
                                        {
                                            throw new ArgumentException($"هناك ايام في الاقامة رقم {reception.currentStay.admissionID} لم يضف اليها اشراف!", nameof(Room));
                                        }*/

                    reception.currentStay.bed.isAvailable = true;
                    reception.currentStay.StayEnd = DateTime.Now;
                    //TimeSpan control = TimeSpan.Parse("12:00:00");
                    if (transferDayCount)
                    {
                        reception.currentStay.StayEnd = DateTime.Now.Date.AddHours(11).AddMinutes(59);
                    }

                    reception.currentStay.IsDischarged = true;
                    reception.currentStay = this;
                }
                bed.isAvailable = false;
                //Patient.InStay = true;
            }
            CalculateRoomServices();
            transferFlag = false;
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            if (!transferFlag)
            {
                Patient.InStay = false;
                bed.isAvailable = true;
                var supervisions = Session.Query<SupervisionDetails>().Where(p => p.admission == this);
                foreach (var item in supervisions)
                {
                    item.Delete();
                }
            }
        }

        public void CheckOut()
        {
            bed.isAvailable = true;
            this.IsDischarged = true;
            //Patient.InStay = false;
            IsDischarged = true;
            if (StayEnd == DateTime.MinValue)
                StayEnd = DateTime.Now;
            CalculateRoomServices();
        }

        public void CalculateRoomServices()
        {
            DaysOfStay();
            if (this.Patient != null)
            {
                if (this.Patient.Nationality != Patient.Nationalitys.مصر)
                {
                    roomStaySum = this.roomStayCost * totalDays;
                    medicalCareSum = this.roomCareCost * totalDays;
                    MedicalSupervisionSum = this.roomSupervisionCost * totalDays;
                    roomStaySum = roomStaySum * Convert.ToDecimal(1.5);
                    medicalCareSum = medicalCareSum * Convert.ToDecimal(1.5);
                    MedicalSupervisionSum = MedicalSupervisionSum * Convert.ToDecimal(1.5);
                }
                else
                {
                    roomStaySum = this.roomStayCost * totalDays;
                    medicalCareSum = this.roomCareCost * totalDays;
                    MedicalSupervisionSum = this.roomSupervisionCost * totalDays;
                }
            }
            
                //this.SupervisionDetailsCollection.Sum(p => p.price);
        }

        public void DaysOfStay()
        {
            int _totalDays = 0;
            if (StayStart.TimeOfDay < new TimeSpan(14, 0, 0))
            {
                _totalDays = Convert.ToInt32(Math.Ceiling(((IsDischarged ? StayEnd : DateTime.Now) - StayStart.Date.AddHours(12)).TotalDays)) + 1;
            }

            if (StayStart.TimeOfDay >= new TimeSpan(14, 0, 0))
            {
                _totalDays = Convert.ToInt32(Math.Ceiling(((IsDischarged ? StayEnd : DateTime.Now) - StayStart.Date.AddHours(12)).TotalDays));
            }


            if (ignoreFirstDay)
            {
                totalDays = (_totalDays - 1);
            }

            else
            {
                totalDays = _totalDays;
            }
        }


        public bool validCompanionDate(DateTime d)
        {
            if (CompanionDetailsCollection.Count > 0)
            {
                foreach (CompanionDetails comp in CompanionDetailsCollection)
                {
                    if (comp.Stay == this && comp.date == d) return false;
                }
                return true;
            }
            return true;
        }
    }
}