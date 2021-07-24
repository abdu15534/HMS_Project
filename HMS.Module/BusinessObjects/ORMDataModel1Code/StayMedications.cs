using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Bottom)]
    [DefaultClassOptions]
    //[RuleCriteria("'@This.quantity' < Medication.quantity AND '@This.quantity' >= 1")]
    public partial class StayMedications
    {
        public StayMedications(Session session) : base(session) { }

        public StayMedications()
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            quantity = 0;
            date = DateTime.Now;
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            if (propertyName == nameof(quantity) && Medication != null)
            {
                Int32 newVal = Convert.ToInt32(newValue);
                Int32 oldVal = Convert.ToInt32(oldValue);

                if (newVal > oldVal)
                {
                    Int32 totalVal = newVal - oldVal;
                    if ((Medication.firstUnitQuantity)*Medication.product.unitAmount + Medication.secondUnitQuantity >= totalVal)
                        Medication.secondUnitQuantity -= newVal - oldVal;
                    else
                    {
                        fquantity = (Medication.firstUnitQuantity) * Medication.product.unitAmount + Medication.secondUnitQuantity;
                        Medication.firstUnitQuantity = 0;
                        Medication.secondUnitQuantity= 0;
                    }
                }
                else
                {
                    Medication.secondUnitQuantity += oldVal - newVal;
                }
            }

            if (propertyName == nameof(Medication))
            {
                if (oldValue != null)
                {
                    var med = oldValue as StockProduct;
                    med.secondUnitQuantity += quantity;
                    fquantity = 0;
                }

                else fquantity = 0;

                var medic = newValue as StockProduct;
                if (medic != null)
                    price = medic.product.sellingPrice/medic.product.unitAmount;
            }

            if (Medication != null && Medication.product != null && Medication.product.purchasingPrice != 0)
            {
                profit = Convert.ToDecimal((double)((price - (Medication.product.purchasingPrice / Medication.product.unitAmount))) * quantity);
            }
        }

        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsDeleted)
                if (this.Medication == null || quantity == 0)
                    this.Delete();
        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
            if (Medication != null && !IsLoading)
                this.Medication.secondUnitQuantity += quantity;
        }
    }
}
