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
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Persistent.Validation;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class AccountingController : ViewController
    {
        public AccountingController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            showDocument.CustomizePopupWindowParams += showDetailViewAction_CustomizePopupWindowParams;
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

        private void Confirm_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var JournalEntry = View.CurrentObject as JournalEntry;
            JournalEntry.Post(false);
        }

        private void UnConfirm_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var JournalEntry = View.CurrentObject as JournalEntry;
            JournalEntry.Post(true);
        }
        void showDetailViewAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var JournalEntry = View.CurrentObject as JournalEntry;

            Type type = XafTypesInfo.Instance.FindTypeInfo(JournalEntry.type).Type;
            IObjectSpace newObjectSpace = Application.CreateObjectSpace(type);
            Object objectToShow = ObjectSpace.GetObjectByKey(type, Convert.ToInt32(JournalEntry.objectKey));
            if (objectToShow != null)
            {
                DetailView createdView = Application.CreateDetailView(newObjectSpace, objectToShow);
                createdView.ViewEditMode = ViewEditMode.Edit;                
                e.View = createdView;
            }
        }

        private void showDocument_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

        }

        private void BondUnConfirm_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var order = View.CurrentObject as receiptClientBond;
            order.OrderConfirm(false);
        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var order = View.CurrentObject as receiptClientBond;
            order.OrderConfirm(true);
        }

        private void ReceiptVoucher_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ReceiptVoucherReport report = new reports.ReceiptVoucherReport();

            var curr = View.CurrentObject as receiptClientBond;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((receiptClientBond)View.CurrentObject).id;

            report.Parameters["BondType"].Value = "سند قبض";
            report.Parameters["N2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.amount), "جنيه", "قرش") + " فقط لاغير ";
            report.ShowPreviewDialog();
        }

        private void PaymentVoucher_Execute(object sender, SimpleActionExecuteEventArgs e)
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

        private void DailyAccounts_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.DailyAccounts report = new reports.DailyAccounts();

            var curr = View.CurrentObject as JournalEntry;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((JournalEntry)View.CurrentObject).ID;

            report.ShowPreviewDialog();
        }

        private void BondReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.JournalEntryReport report = new reports.JournalEntryReport();

            var curr = View.CurrentObject as JournalEntry;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
            {
                PermissionPolicyUser user;
                if (SecuritySystem.CurrentUser != null)
                {
                    user = ObjectSpace.GetObjectByKey<PermissionPolicyUser>(SecuritySystem.CurrentUserId);
                    report.Parameters["user"].Value = user.UserName;
                }
                
                report.Parameters["parameter1"].Value = ((JournalEntry)View.CurrentObject).ID;
            }

            report.ShowPreviewDialog();
        }

        private void PaymentBondConfirm_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var payment = View.CurrentObject as paymentSupplierBond;
            payment.OrderConfirm(true);
        }

        private void PaymentBondUnConfirm_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var order = View.CurrentObject as receiptClientBond;
            order.OrderConfirm(false);
        }

        private void PaymentBondReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ReceiptVoucherReport report = new reports.ReceiptVoucherReport();

            var curr = View.CurrentObject as paymentSupplierBond;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((paymentSupplierBond)View.CurrentObject).id;

            report.Parameters["BondType"].Value = "سند صرف";
            report.Parameters["N2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.amount), "جنيه", "قرش") + " فقط لاغير ";
            report.ShowPreviewDialog();
        }
    }
}
