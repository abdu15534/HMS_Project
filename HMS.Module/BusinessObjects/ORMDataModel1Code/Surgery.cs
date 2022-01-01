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
        public override void AfterConstruction() { base.AfterConstruction(); }
        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (propertyName == nameof(SurgeryPackage) && newValue != null)
            {
                if (this.SurgeryPackage.SurgeonsFees != null)
                {
                    this.SurgeonsFees = this.SurgeryPackage.SurgeonsFees;
                    if (this.SurgeryPackage.AssistantFeeRate != null)
                    {
                        this.AssistantFees = this.SurgeryPackage.SurgeonsFees * Convert.ToDecimal(this.SurgeryPackage.AssistantFeeRate);
                    }
                    if (this.SurgeryPackage.AnesthesiaFeeRate != null)
                    {
                        this.AnesthesiaFees = this.SurgeryPackage.SurgeonsFees * Convert.ToDecimal(this.SurgeryPackage.AnesthesiaFeeRate);
                    }
                    if (SurgeryPackage.openingFee != null)
                    {
                        this.RoomOpeningFee = this.SurgeryPackage.openingFee;
                    }
                }
            }
        }
    }

}
