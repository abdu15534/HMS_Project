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
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PaymentReportController : ViewController
    {
        public PaymentReportController()
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

        private void PaymentInvoice_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.PaymentInvoice report = new reports.PaymentInvoice();

            var curr = View.CurrentObject as Payments;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Payments)View.CurrentObject).paymentID;

            report.ShowPreviewDialog();
        }

        private void FundInvoice_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.Sarf report = new reports.Sarf();

            var curr = View.CurrentObject as Payments;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Payments)View.CurrentObject).paymentID;

            report.ShowPreviewDialog();
        }

        private void PaymentCheck_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.Sarf report = new reports.Sarf();

            var curr = View.CurrentObject as Payer;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Payer)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void AccountsSheet_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.AccountsSheet report = new reports.AccountsSheet();

            var curr = View.CurrentObject as receiptClientBond;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((receiptClientBond)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void Accounts_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.Accounts report = new reports.Accounts();

            var curr = View.CurrentObject as receiptClientBond;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((receiptClientBond)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void ExpiredProducts_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ExpiredItems report = new reports.ExpiredItems();

            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void simpleAction1_Execute_1(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.Makhzan_Awel_Modda report = new reports.Makhzan_Awel_Modda();

            var curr = View.CurrentObject as PurchasingOrder;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((PurchasingOrder)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void simpleAction1_Execute_2(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.MeezanMoragaa report = new reports.MeezanMoragaa();

            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void PeriodBought_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.PeriodBought report = new reports.PeriodBought();

            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void PeriodSold_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.PeriodSold report = new reports.PeriodSold();

            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void PeriodExpenes_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.PeriodExpenses report = new reports.PeriodExpenses();

            var curr = View.CurrentObject as Spendings;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Spendings)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void PriceListRequest_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.PriceListRequest report = new reports.PriceListRequest();

            var curr = View.CurrentObject as PurchasingOrder;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((PurchasingOrder)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void DailyAccounts_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.DailyAccounts report = new reports.DailyAccounts();

            var curr = View.CurrentObject as Supplier;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Supplier)View.CurrentObject).nationalID;

            report.ShowPreviewDialog();
        }

        private void InventoryOperations_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.InventoryOperations report = new reports.InventoryOperations();

            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Inventory)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }
        private void SalariesReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.SalariesReport report = new reports.SalariesReport();

            var curr = View.CurrentObject as Inventory;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Spendings)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void DelayedPurchases2_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.DelayedPurchases2 report = new reports.DelayedPurchases2();

            var curr = View.CurrentObject as PurchasingOrder;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((PurchasingOrder)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void DelayedPurchases_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.DelayedPurchases report = new reports.DelayedPurchases();

            var curr = View.CurrentObject as Supplier;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Supplier)View.CurrentObject).nationalID;

            report.ShowPreviewDialog();
        }

        private void PaymentBond_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.PaymentVoucherReport report = new reports.PaymentVoucherReport();


            var curr = View.CurrentObject as receiptClientBond;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((receiptClientBond)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }
    }
}
