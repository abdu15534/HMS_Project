
namespace HMS.Module.Win.Controllers
{
    partial class ClinincController
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
            this.PaymentRecipt = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // PaymentRecipt
            // 
            this.PaymentRecipt.Caption = "Payment Recipt";
            this.PaymentRecipt.ConfirmationMessage = null;
            this.PaymentRecipt.Id = "PaymentRecipt";
            this.PaymentRecipt.ImageName = "BO_REPORT";
            this.PaymentRecipt.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Appointment);
            this.PaymentRecipt.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PaymentRecipt.ToolTip = null;
            this.PaymentRecipt.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.PaymentRecipt.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PaymentRecipt_Execute);
            // 
            // ClinincController
            // 
            this.Actions.Add(this.PaymentRecipt);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction PaymentRecipt;
    }
}
