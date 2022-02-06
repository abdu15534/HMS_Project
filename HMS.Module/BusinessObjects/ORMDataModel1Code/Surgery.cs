using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class Surgery
    {
        public Surgery(Session session) : base(session) { }
        public override void AfterConstruction() 
        { 
            base.AfterConstruction();
            Date = DateTime.Now;
        }
        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (propertyName == nameof(SurgeryPackage) && newValue != null)
            {
                ApplySurgeryCatagory();
            }
        }

        private void ApplySurgeryCatagory()
        {
            if (SurgeryPackage.SurgeonsFees != null)
            {
                SurgeonsFees = SurgeryPackage.SurgeonsFees;
                price = SurgeryPackage.Price;
                if (SurgeryPackage.AssistantFeeRate != null)
                {
                    AssistantFees = SurgeryPackage.SurgeonsFees * Convert.ToDecimal(SurgeryPackage.AssistantFeeRate);
                }
                if (SurgeryPackage.AnesthesiaFeeRate != null)
                {
                    this.AnesthesiaFees = this.SurgeryPackage.SurgeonsFees * Convert.ToDecimal(SurgeryPackage.AnesthesiaFeeRate);
                }
                if (SurgeryPackage.openingFee != null)
                {
                    RoomOpeningFee = SurgeryPackage.openingFee;
                }
            }
        }
    }

}
