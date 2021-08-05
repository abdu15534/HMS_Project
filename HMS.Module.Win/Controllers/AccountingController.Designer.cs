
namespace HMS.Module.Win.Controllers
{
    partial class AccountingController
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
            this.JournalReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.Post = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.UnPost = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.showDocument = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.ReceiptBondUnConfirm = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ReceiptBondConfirm = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ReceiptBondReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PaymentBondConfirm = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PaymentBondUnConfirm = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.Receipt = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // JournalReport
            // 
            this.JournalReport.Caption = "Journal Report";
            this.JournalReport.ConfirmationMessage = null;
            this.JournalReport.Id = "JournalReport";
            this.JournalReport.ImageName = "BO_REPORT";
            this.JournalReport.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.JournalReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.JournalEntry);
            this.JournalReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.JournalReport.ToolTip = null;
            this.JournalReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.JournalReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.BondReport_Execute);
            // 
            // Post
            // 
            this.Post.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.Post.Caption = "Post";
            this.Post.ConfirmationMessage = null;
            this.Post.Id = "Post";
            this.Post.ImageName = "BO_UNKNOWN";
            this.Post.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.Post.TargetObjectsCriteria = "post != true";
            this.Post.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.JournalEntry);
            this.Post.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Post.ToolTip = null;
            this.Post.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.Post.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Confirm_Execute);
            // 
            // UnPost
            // 
            this.UnPost.Caption = "UnPost";
            this.UnPost.ConfirmationMessage = null;
            this.UnPost.Id = "UnPost";
            this.UnPost.ImageName = "BO_UNKNOWN";
            this.UnPost.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.UnPost.TargetObjectsCriteria = "post == true";
            this.UnPost.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.JournalEntry);
            this.UnPost.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.UnPost.ToolTip = null;
            this.UnPost.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.UnPost.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UnConfirm_Execute);
            // 
            // showDocument
            // 
            this.showDocument.AcceptButtonCaption = null;
            this.showDocument.CancelButtonCaption = null;
            this.showDocument.Caption = "Show Document";
            this.showDocument.ConfirmationMessage = null;
            this.showDocument.Id = "518bc82a-7f89-4bab-b766-1d8bd0cbcc3c";
            this.showDocument.ImageName = "Detailed";
            this.showDocument.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.showDocument.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.JournalEntry);
            this.showDocument.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.showDocument.ToolTip = null;
            this.showDocument.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.showDocument.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.showDocument_Execute);
            // 
            // ReceiptBondUnConfirm
            // 
            this.ReceiptBondUnConfirm.Caption = "Receipt Bond Un Confirm";
            this.ReceiptBondUnConfirm.ConfirmationMessage = null;
            this.ReceiptBondUnConfirm.Id = "ReceiptBondUnConfirm";
            this.ReceiptBondUnConfirm.ImageName = "BO_UNKNOWN";
            this.ReceiptBondUnConfirm.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.ReceiptBondUnConfirm.TargetObjectsCriteria = "post  == true";
            this.ReceiptBondUnConfirm.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.receiptClientBond);
            this.ReceiptBondUnConfirm.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ReceiptBondUnConfirm.ToolTip = null;
            this.ReceiptBondUnConfirm.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ReceiptBondUnConfirm.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.BondUnConfirm_Execute);
            // 
            // ReceiptBondConfirm
            // 
            this.ReceiptBondConfirm.Caption = "Receipt Bond Confirm";
            this.ReceiptBondConfirm.ConfirmationMessage = null;
            this.ReceiptBondConfirm.Id = "ReceiptBondConfirm";
            this.ReceiptBondConfirm.ImageName = "BO_UNKNOWN";
            this.ReceiptBondConfirm.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.ReceiptBondConfirm.TargetObjectsCriteria = "post  != true && amount > 0";
            this.ReceiptBondConfirm.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.receiptClientBond);
            this.ReceiptBondConfirm.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ReceiptBondConfirm.ToolTip = null;
            this.ReceiptBondConfirm.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ReceiptBondConfirm.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
            // 
            // ReceiptBondReport
            // 
            this.ReceiptBondReport.Caption = "Receipt Bond Report";
            this.ReceiptBondReport.ConfirmationMessage = null;
            this.ReceiptBondReport.Id = "ReceiptBondReport";
            this.ReceiptBondReport.ImageName = "BO_UNKNOWN";
            this.ReceiptBondReport.TargetObjectsCriteria = "post == true";
            this.ReceiptBondReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.receiptClientBond);
            this.ReceiptBondReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ReceiptBondReport.ToolTip = null;
            this.ReceiptBondReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ReceiptBondReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ReceiptVoucher_Execute);
            // 
            // PaymentBondConfirm
            // 
            this.PaymentBondConfirm.Caption = "Payment Bond Confirm";
            this.PaymentBondConfirm.ConfirmationMessage = null;
            this.PaymentBondConfirm.Id = "PaymentBondConfirm";
            this.PaymentBondConfirm.ImageName = "BO_UNKNOWN";
            this.PaymentBondConfirm.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.PaymentBondConfirm.TargetObjectsCriteria = "post  != true && amount > 0";
            this.PaymentBondConfirm.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.paymentSupplierBond);
            this.PaymentBondConfirm.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PaymentBondConfirm.ToolTip = null;
            this.PaymentBondConfirm.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.PaymentBondConfirm.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PaymentBondConfirm_Execute);
            // 
            // PaymentBondUnConfirm
            // 
            this.PaymentBondUnConfirm.Caption = "Payment Bond Un Confirm";
            this.PaymentBondUnConfirm.ConfirmationMessage = null;
            this.PaymentBondUnConfirm.Id = "PaymentBondUnConfirm";
            this.PaymentBondUnConfirm.ImageName = "BO_UNKNOWN";
            this.PaymentBondUnConfirm.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.PaymentBondUnConfirm.TargetObjectsCriteria = "post  == true";
            this.PaymentBondUnConfirm.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.paymentSupplierBond);
            this.PaymentBondUnConfirm.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PaymentBondUnConfirm.ToolTip = null;
            this.PaymentBondUnConfirm.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.PaymentBondUnConfirm.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PaymentBondUnConfirm_Execute);
            // 
            // Receipt
            // 
            this.Receipt.Caption = "الفاتورة";
            this.Receipt.ConfirmationMessage = null;
            this.Receipt.Id = "Receipt";
            this.Receipt.ImageName = "BO_REPORT";
            this.Receipt.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.receiptClientBond);
            this.Receipt.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Receipt.ToolTip = null;
            this.Receipt.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.Receipt.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Receipt_Execute);
            // 
            // AccountingController
            // 
            this.Actions.Add(this.JournalReport);
            this.Actions.Add(this.Post);
            this.Actions.Add(this.UnPost);
            this.Actions.Add(this.showDocument);
            this.Actions.Add(this.ReceiptBondUnConfirm);
            this.Actions.Add(this.ReceiptBondConfirm);
            this.Actions.Add(this.ReceiptBondReport);
            this.Actions.Add(this.PaymentBondConfirm);
            this.Actions.Add(this.PaymentBondUnConfirm);
            this.Actions.Add(this.Receipt);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction Post;
        private DevExpress.ExpressApp.Actions.SimpleAction UnPost;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction showDocument;
        private DevExpress.ExpressApp.Actions.SimpleAction ReceiptBondUnConfirm;
        private DevExpress.ExpressApp.Actions.SimpleAction ReceiptBondConfirm;
        private DevExpress.ExpressApp.Actions.SimpleAction ReceiptBondReport;
        private DevExpress.ExpressApp.Actions.SimpleAction JournalReport;
        private DevExpress.ExpressApp.Actions.SimpleAction PaymentBondConfirm;
        private DevExpress.ExpressApp.Actions.SimpleAction PaymentBondUnConfirm;
        private DevExpress.ExpressApp.Actions.SimpleAction Receipt;
    }
}
