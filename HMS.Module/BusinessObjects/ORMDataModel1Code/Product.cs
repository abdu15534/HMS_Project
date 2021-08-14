using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    [DefaultProperty("name")]
    public partial class Product
    {
        public Product(Session session) : base(session) 
        {

        }

        public IList<PurchasingOrder> Orders
        {
            get => Session.Query<PurchasingOrder>().Where(p => p.PurchasingOrderDetails.Any(x => x.product == this)).ToList();
        }

        public override void AfterConstruction() {
            base.AfterConstruction();

            unitAmount = 1;
            var unit = Session.FindObject<ProductUnit>(new BinaryOperator("unit", "قطعة"));
            this.purchasingUnit = unit;
            this.sellUnit = unit;
        }
        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.category != null)
            {
                if (this.category.name == "مستهلكات")
                {
                    this.barCode = this.id.ToString();
                }
            }
        }
    }

}
