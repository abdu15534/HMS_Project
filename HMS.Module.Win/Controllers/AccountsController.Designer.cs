
namespace HMS.Module.Win.Controllers
{
    partial class AccountsController
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
            this.Transfer = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.CancelTransfer = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // Transfer
            // 
            this.Transfer.Caption = "تحويل";
            this.Transfer.ConfirmationMessage = null;
            this.Transfer.Id = "50743a38-ce49-4307-82d7-c76720cae336";
            this.Transfer.TargetObjectsCriteria = "Transferd == false";
            this.Transfer.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.AccountTransfers);
            this.Transfer.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Transfer.ToolTip = null;
            this.Transfer.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.Transfer.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Transfer_Execute);
            // 
            // CancelTransfer
            // 
            this.CancelTransfer.Caption = "الغاء التحويل";
            this.CancelTransfer.ConfirmationMessage = null;
            this.CancelTransfer.Id = "24c49753-0c12-4dad-935f-074d38e0159b";
            this.CancelTransfer.TargetObjectsCriteria = "Transferd != false";
            this.CancelTransfer.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.AccountTransfers);
            this.CancelTransfer.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.CancelTransfer.ToolTip = null;
            this.CancelTransfer.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.CancelTransfer.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CancelTransfer_Execute);
            // 
            // AccountsController
            // 
            this.Actions.Add(this.Transfer);
            this.Actions.Add(this.CancelTransfer);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction Transfer;
        private DevExpress.ExpressApp.Actions.SimpleAction CancelTransfer;
    }
}
