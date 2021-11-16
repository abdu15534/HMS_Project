using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class StockTransferController : ViewController
    {
        public StockTransferController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void ApproveTransferofAll_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            StockTransfer curr = e.CurrentObject as StockTransfer;
            foreach(TransferProduct obj in curr.TransferProducts)
            {
                if(obj.StockProduct.firstUnitQuantity > obj.RequstedCount)
                {
                    obj.Approved = true;
                    obj.TobeApproved = true;
                }
                else
                {
                    throw new ArgumentException("الكمية المتاحة اقل من الكمية المطلوبة!");
                }
            }
            List<TransferProduct> productList = ObjectSpace.GetObjects<TransferProduct>().Where(p => p.Approved == true && p.StockTransfer == curr ).ToList();
            foreach(TransferProduct tProduct in productList)
            {
                StockProduct sp = ObjectSpace.GetObjects<StockProduct>().Where(p => p.product == tProduct.StockProduct.product && p.Inventory == curr.ToWearhouse).FirstOrDefault();
                if( sp != null)
                {
                    StockProduct stockProduct = ObjectSpace.GetObjects<StockProduct>().Where(p => p.Inventory == curr.ToWearhouse && p.product == tProduct.StockProduct.product).ToList()[0];
                    stockProduct.firstUnitQuantity += tProduct.RequstedCount;
                    StockProduct fromStockProduct = curr.FromWarehouse.StockProducts.Where(p => p == tProduct.StockProduct && p.Inventory == curr.FromWarehouse).First();
                    fromStockProduct.firstUnitQuantity -= tProduct.RequstedCount;
                }
                else
                {
                    StockProduct stockProduct = ObjectSpace.CreateObject<StockProduct>();
                    stockProduct.Inventory = curr.ToWearhouse;
                    stockProduct.firstUnitQuantity = tProduct.RequstedCount;
                    stockProduct.product = tProduct.StockProduct.product;
                }
            }
            curr.Transferd = true;
            ObjectSpace.CommitChanges();
        }

        private void CancelRequest_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            StockTransfer curr = e.CurrentObject as StockTransfer;
            IEnumerable<TransferProduct> tProducts = curr.TransferProducts.Where(p => p.Approved == true && p.StockTransfer == curr);
            foreach (TransferProduct obj in tProducts)
            {
                
                StockProduct stockProduct = ObjectSpace.GetObjects<StockProduct>().Where(p => p.product == obj.StockProduct.product && p.Inventory == curr.ToWearhouse).ToList()[0];
                stockProduct.firstUnitQuantity -= obj.RequstedCount;
                obj.Approved = false;
                StockProduct fromStockProduct = curr.FromWarehouse.StockProducts.Where(p => p == obj.StockProduct && p.Inventory == curr.FromWarehouse).First();
                fromStockProduct.firstUnitQuantity += obj.RequstedCount;

            }
            curr.Transferd = false;
            ObjectSpace.CommitChanges();

        }

        private void ApproveTransferForSome_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            StockTransfer curr = e.CurrentObject as StockTransfer;
            IEnumerable<TransferProduct> productList = ObjectSpace.GetObjects<TransferProduct>().Where(p => p.TobeApproved == true  && p.StockTransfer == curr);
            foreach (TransferProduct tProduct in productList)
            {
                if (tProduct.StockProduct.firstUnitQuantity > tProduct.RequstedCount)
                {
                }
                else
                {
                    throw new ArgumentException("الكمية المتاحة اقل من الكمية المطلوبة!");
                }
            }
            foreach (TransferProduct tProduct in productList)
            {
                tProduct.Approved = true;
                StockProduct sp = ObjectSpace.GetObjects<StockProduct>().Where(p => p.product == tProduct.StockProduct.product && p.Inventory == curr.ToWearhouse).FirstOrDefault();
                if (sp != null)
                 {
                    StockProduct stockProduct = ObjectSpace.GetObjects<StockProduct>().Where(p => p.Inventory == curr.ToWearhouse && p.product == tProduct.StockProduct.product).ToList()[0];
                    stockProduct.firstUnitQuantity += tProduct.RequstedCount;
                    StockProduct fromStockProduct = curr.FromWarehouse.StockProducts.Where(p => p == tProduct.StockProduct && p.Inventory == curr.FromWarehouse).First();
                    fromStockProduct.firstUnitQuantity -= tProduct.RequstedCount;
                }
                else
                {
                    StockProduct stockProduct = ObjectSpace.CreateObject<StockProduct>();
                    stockProduct.Inventory = curr.ToWearhouse;
                    stockProduct.firstUnitQuantity = tProduct.RequstedCount;
                    stockProduct.product = tProduct.StockProduct.product;
                    StockProduct fromStockProduct = curr.FromWarehouse.StockProducts.Where(p => p.product == stockProduct.product && p.Inventory == curr.FromWarehouse).First();
                    fromStockProduct.firstUnitQuantity -= tProduct.RequstedCount;
                }
            }
            
            curr.Transferd = true;
            ObjectSpace.CommitChanges();
        }
    }
}
