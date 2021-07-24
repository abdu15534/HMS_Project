using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.Collections.Generic;

namespace XafDataModel.Module.BusinessObjects.test2
{
    [DefaultClassOptions]
    public partial class Inventory
    {
        public Inventory(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            

        }
        
        InventoryTypes inventoryType;              

        public InventoryTypes InventoryType
        {
            get => inventoryType;
            set => SetPropertyValue(nameof(InventoryType), ref inventoryType, value);
        }

        public enum InventoryTypes
        {
            Pharmacy, Stock , Other
        }
    }

}
