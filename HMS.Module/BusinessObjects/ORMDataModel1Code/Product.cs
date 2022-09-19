using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
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

        //public IList<PurchasingOrder> Orders
        //{
        //    get => Session.Query<PurchasingOrder>().Where(p => p.PurchasingOrderDetails.Any(x => x.product == this)).ToList();
        //}

        public override void AfterConstruction() {
            base.AfterConstruction();

            unitAmount = 1;
            var unit = Session.FindObject<ProductUnit>(new BinaryOperator("unit", "وحدة"));
            this.purchasingUnit = unit;
            this.sellUnit = unit;
        }
        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.category != null)
            {
                if (this.Session.IsNewObject(this))
                {
                    if (this.id == 0)
                    {
                        if (this.category.name == "مستهلكات")
                        {
                            int lastservice = Session.Query<Product>().Where(o => this.category == o.category).Max(t => t.id);
                            this.id = lastservice + 1;
                        }
                        else
                        {
                            int lastservice = Session.Query<Product>().Where(o => this.category.name != "مستهلكات").Max(t => t.id);
                            this.id = lastservice + 1;
                        }
                    }

                    //object val = Convert.ChangeType(this.serviceType, this.serviceType.GetTypeCode());
                    //int Id = Convert.ToInt32(val);
                    //this.ID = ProccessServiceID(Id, lastservice);
                }
            }
            if (this.category != null)
            {
                if (this.category.name == "مستهلكات")
                {
                    //this.barCode = this.id.ToString();
                }
            }
        }
        protected override void OnDeleting()
        {

            base.OnDeleting();
            Session.Delete(this.PurchaseRequestDetails);
            Session.Delete(this.PurchasingOrderDetails);
            Session.Delete(this.StockProducts);
          
        }

    }

}
