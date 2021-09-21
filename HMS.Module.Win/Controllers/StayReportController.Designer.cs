
namespace HMS.Module.Win.Controllers
{
    partial class StayReportController
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
            this.Checkout = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.UnCheckOutAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ApplyPackage = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.DiscardPackage = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // Checkout
            // 
            this.Checkout.Caption = "Checkout";
            this.Checkout.ConfirmationMessage = null;
            this.Checkout.Id = "CheckOutAction";
            this.Checkout.ImageName = "BO_UNKNOWN";
            this.Checkout.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.Checkout.TargetObjectsCriteria = "IsDischarged == false";
            this.Checkout.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Admission);
            this.Checkout.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Checkout.ToolTip = null;
            this.Checkout.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.Checkout.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Checkout_Execute);
            // 
            // UnCheckOutAction
            // 
            this.UnCheckOutAction.Caption = "الغاء الخروج";
            this.UnCheckOutAction.ConfirmationMessage = null;
            this.UnCheckOutAction.Id = "UnCheckOutAction";
            this.UnCheckOutAction.ImageName = "BO_UNKNOWN";
            this.UnCheckOutAction.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.UnCheckOutAction.TargetObjectsCriteria = "IsDischarged == true";
            this.UnCheckOutAction.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Admission);
            this.UnCheckOutAction.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.UnCheckOutAction.ToolTip = null;
            this.UnCheckOutAction.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.UnCheckOutAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UnCheckOutAction_Execute);
            // 
            // ApplyPackage
            // 
            this.ApplyPackage.Caption = "Apply Package";
            this.ApplyPackage.ConfirmationMessage = null;
            this.ApplyPackage.Id = "ApplyPackage";
            this.ApplyPackage.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PackageDetail);
            this.ApplyPackage.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ApplyPackage.ToolTip = null;
            this.ApplyPackage.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ApplyPackage.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ApplyPackage_Execute);
            // 
            // DiscardPackage
            // 
            this.DiscardPackage.Caption = "Discard Package";
            this.DiscardPackage.ConfirmationMessage = null;
            this.DiscardPackage.Id = "DiscardPackage";
            this.DiscardPackage.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PackageDetail);
            this.DiscardPackage.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.DiscardPackage.ToolTip = null;
            this.DiscardPackage.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.DiscardPackage.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.DiscardPackage_Execute);
            // 
            // StayReportController
            // 
            this.Actions.Add(this.Checkout);
            this.Actions.Add(this.UnCheckOutAction);
            this.Actions.Add(this.ApplyPackage);
            this.Actions.Add(this.DiscardPackage);

        }

        #endregion
        private DevExpress.ExpressApp.Actions.SimpleAction Checkout;
        private DevExpress.ExpressApp.Actions.SimpleAction UnCheckOutAction;
        private DevExpress.ExpressApp.Actions.SimpleAction ApplyPackage;
        private DevExpress.ExpressApp.Actions.SimpleAction DiscardPackage;
    }
}
