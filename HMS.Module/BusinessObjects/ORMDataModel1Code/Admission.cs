using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
 
namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions, DefaultProperty("admissionID")]
    // [RuleCriteria("", DefaultContexts.Save, "ClientAddress.House != 0",
    //"House should not be 0", SkipNullOrEmptyValues = false)]

    public partial class Admission
    {
        public Admission(Session session) : base(session)
        {


        }
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
            DaysOfStay();
            
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(Status))
            {
                Room = null;
                bed = null;
            }
            if (propertyName == nameof(suppliesSum))
            {
                PackageDetail pdetail = reception.PackageDetails.FirstOrDefault(o => o.Applyed);
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
            if ((propertyName == nameof(StayMedicications) || propertyName == nameof(medicationSum)) && newValue != null)
            {

            }
            if (propertyName == nameof(StayStart) && newValue != null)
            {
                if (this.reception != null)
                {
                    var erlestDate = this.reception.Admissions.Min(p => p.StayStart);
                    if (erlestDate != this.reception.dateEnter)
                    {
                        this.reception.dateEnter = erlestDate;
                    }
                }
            }
           
        }
        protected override void OnSaving()
        {
            CalculateRoomServices();
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
                switch (status)
                {
                    case statusType.normal:
                        this.Department = Session.GetObjectByKey<Department>(3);
                        return;
                    case statusType.ICU:
                        this.Department = Session.GetObjectByKey<Department>(4);
                        return;
                    case statusType.covid:
                        this.Department = Session.GetObjectByKey<Department>(5);
                        return;
                }
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

            if (!IsDeleted)
            {
                if (this.reception.PackageDetails != null)
                {
                    IEnumerable<PackageDetail> packages = this.reception.PackageDetails.Where(o => o.Applyed == true);
                    foreach (PackageDetail item in packages)
                    {
                        item.UpdateInfo();
                    }
                }
            }
            transferFlag = false;
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            Session.Delete(this.StayMedicications);
            Session.Delete(this.StockDetailsCollection);
            Session.Delete(this.ServiceDetailsCollection);
            Session.Delete(this.CompanionDetailsCollection);
            Session.Delete(this.TestDetailsCollection);
            Session.Delete(this.XraysDetailsCollection);
            Session.Delete(this.EndscopeDetailsCollection);
            Session.Delete(this.SupervisionDetailsCollection);
            Session.Delete(this.ConsultantDetailsCollection);
            //Session.Delete(this.OutMedications);
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
                    roomStaySum = this.roomStayCost * Convert.ToDecimal(totalDays-dayOffset);
                    medicalCareSum = this.roomCareCost * Convert.ToDecimal(totalDays-dayOffset);
                    MedicalSupervisionSum = this.roomSupervisionCost * Convert.ToDecimal(totalDays-dayOffset);
                    roomStaySum = roomStaySum * Convert.ToDecimal(1.5);
                    medicalCareSum = medicalCareSum * Convert.ToDecimal(1.5);
                    MedicalSupervisionSum = MedicalSupervisionSum * Convert.ToDecimal(1.5);
                    
                }
                else
                {
                    roomStaySum = this.roomStayCost * Convert.ToDecimal(totalDays-dayOffset);
                    medicalCareSum = this.roomCareCost * Convert.ToDecimal(totalDays-dayOffset);
                    MedicalSupervisionSum = this.roomSupervisionCost * Convert.ToDecimal(totalDays-dayOffset);
                }
                
            }

            //this.SupervisionDetailsCollection.Sum(p => p.price);
        }

        //protected override void On()
        //{
        //    //base.();
        //    DaysOfStay();
        //}

        private double DeductHalfDays(double totalDays)
        {
            if (halfDayAtStart)
            {
                totalDays = totalDays - 0.5;
            }
            if (HalfDayAtEnd)
            {
                totalDays = totalDays - 0.5;
            }
            return totalDays;
        }

        public void DaysOfStay()
        {
            double _totalDays = 0;
            if (StayStart.TimeOfDay < new TimeSpan(14, 0, 0))
            {
                DateTime ttime = DateTime.Now;
                if (IsDischarged)
                {
                    ttime = this.StayEnd;
                }
                _totalDays = (ttime - this.StayStart.Date.AddHours(14)).TotalDays + 1;
                _totalDays = Math.Ceiling(_totalDays);
                _totalDays = Convert.ToInt32(_totalDays);
                _totalDays = DeductHalfDays(_totalDays);
                if (ignoreFirstDay)
                {
                    totalDays = _totalDays - 1;
                }

                else
                {
                    totalDays = _totalDays;
                }
            }

            if (StayStart.TimeOfDay >= new TimeSpan(14, 0, 0))
            {
                DateTime ttime = DateTime.Now;
                if (IsDischarged)
                {
                    ttime = this.StayEnd;
                }
                _totalDays = (ttime - this.StayStart.Date.AddHours(14)).TotalDays;
                _totalDays = Math.Ceiling(_totalDays);
                _totalDays = Convert.ToInt32(_totalDays);
                _totalDays = DeductHalfDays(_totalDays);
                if (ignoreFirstDay)
                {
                    totalDays = _totalDays - 1;
                }

                else
                {
                    totalDays = _totalDays;
                }
            }


            if (ignoreFirstDay)
            {
                totalDays = _totalDays - 1;
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