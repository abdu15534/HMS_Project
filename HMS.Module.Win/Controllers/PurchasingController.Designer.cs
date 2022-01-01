
namespace HMS.Module.Win.Controllers
{
    partial class PurchasingController
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
            this.Confirmed = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.UnConfirmed = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PurchasingOrder = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.OrderJournalReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.CancelPurchaseRequest = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.AcceptAllRequest = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.RequestReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.AcceptSomeOFTheRequest = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ZeroToAllItems = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // Confirmed
            // 
            this.Confirmed.Caption = "Order Confirmed";
            this.Confirmed.ConfirmationMessage = null;
            this.Confirmed.Id = "OrderConfirmed";
            this.Confirmed.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.Confirmed.TargetObjectsCriteria = "isConfirmed != true";
            this.Confirmed.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchasingOrder);
            this.Confirmed.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Confirmed.ToolTip = null;
            this.Confirmed.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.Confirmed.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Confirmed_Execute);
            // 
            // UnConfirmed
            // 
            this.UnConfirmed.Caption = "Order Un Confirmed";
            this.UnConfirmed.ConfirmationMessage = null;
            this.UnConfirmed.Id = "OrderUnConfirmed";
            this.UnConfirmed.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.UnConfirmed.TargetObjectsCriteria = "isConfirmed == true";
            this.UnConfirmed.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchasingOrder);
            this.UnConfirmed.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.UnConfirmed.ToolTip = null;
            this.UnConfirmed.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.UnConfirmed.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UnConfirmed_Execute);
            // 
            // PurchasingOrder
            // 
            this.PurchasingOrder.Caption = "Purchasing Order";
            this.PurchasingOrder.ConfirmationMessage = null;
            this.PurchasingOrder.Id = "PurchasingOrder";
            this.PurchasingOrder.ImageName = "BO_REPORT";
            this.PurchasingOrder.TargetObjectsCriteria = "isConfirmed == true";
            this.PurchasingOrder.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchasingOrder);
            this.PurchasingOrder.ToolTip = null;
            this.PurchasingOrder.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PurchasingOrder_Execute);
            // 
            // OrderJournalReport
            // 
            this.OrderJournalReport.Caption = "Order Journal Report";
            this.OrderJournalReport.ConfirmationMessage = null;
            this.OrderJournalReport.Id = "OrderJournalReport";
            this.OrderJournalReport.ImageName = "BO_REPORT";
            this.OrderJournalReport.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.OrderJournalReport.TargetObjectsCriteria = "isConfirmed == true";
            this.OrderJournalReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchasingOrder);
            this.OrderJournalReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.OrderJournalReport.ToolTip = null;
            this.OrderJournalReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.OrderJournalReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.OrderJournalReport_Execute_1);
            // 
            // CancelPurchaseRequest
            // 
            this.CancelPurchaseRequest.Caption = "الغاء طلب الشراء";
            this.CancelPurchaseRequest.ConfirmationMessage = null;
            this.CancelPurchaseRequest.Id = "CancelPurchaseRequest";
            this.CancelPurchaseRequest.TargetObjectsCriteria = "Approved == true";
            this.CancelPurchaseRequest.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchaseRequest);
            this.CancelPurchaseRequest.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.CancelPurchaseRequest.ToolTip = null;
            this.CancelPurchaseRequest.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.CancelPurchaseRequest.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CancelPurchaseRequest_Execute);
            // 
            // AcceptAllRequest
            // 
            this.AcceptAllRequest.Caption = "الموافقة على طلب الشراء كامل";
            this.AcceptAllRequest.ConfirmationMessage = null;
            this.AcceptAllRequest.Id = "AcceptAllRequest";
            this.AcceptAllRequest.TargetObjectsCriteria = "Approved != true";
            this.AcceptAllRequest.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchaseRequest);
            this.AcceptAllRequest.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.AcceptAllRequest.ToolTip = null;
            this.AcceptAllRequest.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.AcceptAllRequest.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.AcceptAllRequest_Execute);
            // 
            // RequestReport
            // 
            this.RequestReport.Caption = "Request Report";
            this.RequestReport.ConfirmationMessage = null;
            this.RequestReport.Id = "RequestReport";
            this.RequestReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchaseRequest);
            this.RequestReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.RequestReport.ToolTip = null;
            this.RequestReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.RequestReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.RequestReport_Execute);
            // 
            // AcceptSomeOFTheRequest
            // 
            this.AcceptSomeOFTheRequest.Caption = "الموافقة على بعض الاصناف";
            this.AcceptSomeOFTheRequest.ConfirmationMessage = null;
            this.AcceptSomeOFTheRequest.Id = "AcceptSomeOFTheRequest";
            this.AcceptSomeOFTheRequest.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchaseRequest);
            this.AcceptSomeOFTheRequest.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.AcceptSomeOFTheRequest.ToolTip = null;
            this.AcceptSomeOFTheRequest.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.AcceptSomeOFTheRequest.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.AcceptSomeOFTheRequest_Execute);
            // 
            // ZeroToAllItems
            // 
            this.ZeroToAllItems.Caption = "Zero To All Items";
            this.ZeroToAllItems.ConfirmationMessage = null;
            this.ZeroToAllItems.Id = "ZeroToAllItems";
            this.ZeroToAllItems.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Inventory);
            this.ZeroToAllItems.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ZeroToAllItems.ToolTip = null;
            this.ZeroToAllItems.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ZeroToAllItems.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ZeroToAllItems_Execute);
            // 
            // PurchasingController
            // 
            this.Actions.Add(this.Confirmed);
            this.Actions.Add(this.UnConfirmed);
            this.Actions.Add(this.PurchasingOrder);
            this.Actions.Add(this.OrderJournalReport);
            this.Actions.Add(this.CancelPurchaseRequest);
            this.Actions.Add(this.AcceptAllRequest);
            this.Actions.Add(this.RequestReport);
            this.Actions.Add(this.AcceptSomeOFTheRequest);
            this.Actions.Add(this.ZeroToAllItems);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction Confirmed;
        private DevExpress.ExpressApp.Actions.SimpleAction UnConfirmed;
        private DevExpress.ExpressApp.Actions.SimpleAction PurchasingOrder;
        private DevExpress.ExpressApp.Actions.SimpleAction OrderJournalReport;
        private DevExpress.ExpressApp.Actions.SimpleAction CancelPurchaseRequest;
        private DevExpress.ExpressApp.Actions.SimpleAction AcceptAllRequest;
        private DevExpress.ExpressApp.Actions.SimpleAction RequestReport;
        private DevExpress.ExpressApp.Actions.SimpleAction AcceptSomeOFTheRequest;
        private DevExpress.ExpressApp.Actions.SimpleAction ZeroToAllItems;
    }
}
