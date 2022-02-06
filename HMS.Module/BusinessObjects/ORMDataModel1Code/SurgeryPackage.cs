using DevExpress.Xpo;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class SurgeryPackage
    {
        public SurgeryPackage(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (propertyName == nameof(SurgeryCategory) && newValue != null)
            {
                if (SurgeryCategory.SurgeonsFees != null)
                {
                    SurgeonsFees = SurgeryCategory.SurgeonsFees;
                    if (SurgeryCategory.AssistantFeeRate != null)
                    {
                        AnesthesiaFeeRate = SurgeryCategory.AnesthesiaFeeRate;
                    }
                    if (SurgeryCategory.AnesthesiaFeeRate != null)
                    {
                        AssistantFeeRate = SurgeryCategory.AssistantFeeRate;
                    }
                    if (openingFee != null)
                    {
                        openingFee = SurgeryCategory.openingFee;
                    }
                }
            }
        }
    }
}
