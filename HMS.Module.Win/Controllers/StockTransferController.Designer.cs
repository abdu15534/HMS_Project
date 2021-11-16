
namespace HMS.Module.Win.Controllers
{
    partial class StockTransferController
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
            this.ApproveTransferofAll = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ApproveTransferForSome = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.CancelRequest = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.TransferReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ApproveTransferofAll
            // 
            this.ApproveTransferofAll.Caption = "موافقة على طلب الصرف كاملا و الترحيل";
            this.ApproveTransferofAll.ConfirmationMessage = null;
            this.ApproveTransferofAll.Id = "ApproveTransferofAll";
            this.ApproveTransferofAll.TargetObjectsCriteria = "Transferd != true && ReportScan != null";
            this.ApproveTransferofAll.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.StockTransfer);
            this.ApproveTransferofAll.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ApproveTransferofAll.ToolTip = null;
            this.ApproveTransferofAll.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ApproveTransferofAll.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ApproveTransferofAll_Execute);
            // 
            // ApproveTransferForSome
            // 
            this.ApproveTransferForSome.Caption = "الموافقة على بعض المنتجات في طلب الصرف و الترحيل";
            this.ApproveTransferForSome.ConfirmationMessage = null;
            this.ApproveTransferForSome.Id = "ApproveTransferForSome";
            this.ApproveTransferForSome.TargetObjectsCriteria = "Transferd != true && ReportScan != null";
            this.ApproveTransferForSome.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.StockTransfer);
            this.ApproveTransferForSome.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ApproveTransferForSome.ToolTip = null;
            this.ApproveTransferForSome.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ApproveTransferForSome.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ApproveTransferForSome_Execute);
            // 
            // CancelRequest
            // 
            this.CancelRequest.Caption = "إلغاء الموافقة على طلب الصرف ";
            this.CancelRequest.ConfirmationMessage = null;
            this.CancelRequest.Id = "CancelRequest";
            this.CancelRequest.TargetObjectsCriteria = "Transferd == true";
            this.CancelRequest.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.StockTransfer);
            this.CancelRequest.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.CancelRequest.ToolTip = null;
            this.CancelRequest.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.CancelRequest.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CancelRequest_Execute);
            // 
            // TransferReport
            // 
            this.TransferReport.Caption = "Transfer Report";
            this.TransferReport.ConfirmationMessage = null;
            this.TransferReport.Id = "TransferReport";
            this.TransferReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.StockTransfer);
            this.TransferReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TransferReport.ToolTip = null;
            this.TransferReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.TransferReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.TransferReport_Execute);
            // 
            // StockTransferController
            // 
            this.Actions.Add(this.ApproveTransferofAll);
            this.Actions.Add(this.ApproveTransferForSome);
            this.Actions.Add(this.CancelRequest);
            this.Actions.Add(this.TransferReport);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ApproveTransferofAll;
        private DevExpress.ExpressApp.Actions.SimpleAction ApproveTransferForSome;
        private DevExpress.ExpressApp.Actions.SimpleAction CancelRequest;
        private DevExpress.ExpressApp.Actions.SimpleAction TransferReport;
    }
}
