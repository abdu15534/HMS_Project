
namespace HMS.Module.Win.Controllers
{
    partial class OrderPaymentReportController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CachReceipts = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PaymentVoucher = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // CachReceipts
            // 
            this.CachReceipts.Caption = "Cach Receipts";
            this.CachReceipts.ConfirmationMessage = null;
            this.CachReceipts.Id = "CachReceipts";
            this.CachReceipts.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Supplier);
            this.CachReceipts.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.CachReceipts.ToolTip = null;
            this.CachReceipts.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            // 
            // PaymentVoucher
            // 
            this.PaymentVoucher.Caption = "Payment Voucher";
            this.PaymentVoucher.ConfirmationMessage = null;
            this.PaymentVoucher.Id = "PaymentVoucher";
            this.PaymentVoucher.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.OrderExchange);
            this.PaymentVoucher.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PaymentVoucher.ToolTip = null;
            this.PaymentVoucher.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            // 
            // OrderPaymentReportController
            // 
            this.Actions.Add(this.CachReceipts);
            this.Actions.Add(this.PaymentVoucher);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction CachReceipts;
        private DevExpress.ExpressApp.Actions.SimpleAction PaymentVoucher;
    }
}
