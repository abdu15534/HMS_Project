
namespace HMS.Module.Win.Controllers
{
    partial class PatientPaymentReportController
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
            this.PaymentReceipt = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.RefundReceipt = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // PaymentReceipt
            // 
            this.PaymentReceipt.Caption = "Payment Receipt";
            this.PaymentReceipt.ConfirmationMessage = null;
            this.PaymentReceipt.Id = "PaymentReceipt";
            this.PaymentReceipt.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Patient);
            this.PaymentReceipt.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PaymentReceipt.ToolTip = null;
            this.PaymentReceipt.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.PaymentReceipt.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PaymentReceipt_Execute);
            // 
            // RefundReceipt
            // 
            this.RefundReceipt.Caption = "Refund Receipt";
            this.RefundReceipt.ConfirmationMessage = null;
            this.RefundReceipt.Id = "RefundReceipt";
            this.RefundReceipt.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Patient);
            this.RefundReceipt.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.RefundReceipt.ToolTip = null;
            this.RefundReceipt.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.RefundReceipt.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.RefundReceipt_Execute);
            // 
            // PatientPaymentReportController
            // 
            this.Actions.Add(this.PaymentReceipt);
            this.Actions.Add(this.RefundReceipt);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction PaymentReceipt;
        private DevExpress.ExpressApp.Actions.SimpleAction RefundReceipt;
    }
}
