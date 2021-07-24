
namespace HMS.Module.Win.Controllers
{
    partial class CasherViewController
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
            this.TestPaid = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.TestCanclePayment = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.XrayPaid = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.XrayCanclePayment = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.EndscopePaid = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.EndscopeCanclePayment = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // TestPaid
            // 
            this.TestPaid.Caption = "Test Paid";
            this.TestPaid.ConfirmationMessage = null;
            this.TestPaid.Id = "TestPaid";
            this.TestPaid.ImageName = "Business_Cash";
            this.TestPaid.TargetObjectsCriteria = "Paid = false";
            this.TestPaid.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Test);
            this.TestPaid.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TestPaid.ToolTip = null;
            this.TestPaid.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.TestPaid.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Paid_Execute);
            // 
            // TestCanclePayment
            // 
            this.TestCanclePayment.Caption = "Test Cancle Pyment";
            this.TestCanclePayment.ConfirmationMessage = null;
            this.TestCanclePayment.Id = "TestCanclePyment";
            this.TestCanclePayment.ImageName = "TrackingChanges_Reject";
            this.TestCanclePayment.TargetObjectsCriteria = "Paid = true AND !Complete";
            this.TestCanclePayment.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Test);
            this.TestCanclePayment.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TestCanclePayment.ToolTip = null;
            this.TestCanclePayment.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.TestCanclePayment.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CanclePyment_Execute);
            // 
            // XrayPaid
            // 
            this.XrayPaid.Caption = "Xray Paid";
            this.XrayPaid.ConfirmationMessage = null;
            this.XrayPaid.Id = "XrayPaid";
            this.XrayPaid.ImageName = "Business_Cash";
            this.XrayPaid.TargetObjectsCriteria = "Paid = false";
            this.XrayPaid.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Xrays);
            this.XrayPaid.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.XrayPaid.ToolTip = null;
            this.XrayPaid.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.XrayPaid.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.XrayPaid_Execute);
            // 
            // XrayCanclePayment
            // 
            this.XrayCanclePayment.Caption = "Xray Cancle Payment";
            this.XrayCanclePayment.ConfirmationMessage = null;
            this.XrayCanclePayment.Id = "XrayCanclePayment";
            this.XrayCanclePayment.ImageName = "TrackingChanges_Reject";
            this.XrayCanclePayment.TargetObjectsCriteria = "Paid = true AND !Complete";
            this.XrayCanclePayment.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Xrays);
            this.XrayCanclePayment.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.XrayCanclePayment.ToolTip = null;
            this.XrayCanclePayment.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.XrayCanclePayment.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.XrayCanclePayment_Execute);
            // 
            // EndscopePaid
            // 
            this.EndscopePaid.Caption = "Endscope Paid";
            this.EndscopePaid.ConfirmationMessage = null;
            this.EndscopePaid.Id = "EndscopePaid";
            this.EndscopePaid.ImageName = "Business_Cash";
            this.EndscopePaid.TargetObjectsCriteria = "Paid = false";
            this.EndscopePaid.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Endscope);
            this.EndscopePaid.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.EndscopePaid.ToolTip = null;
            this.EndscopePaid.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.EndscopePaid.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.EndscopePaid_Execute);
            // 
            // EndscopeCanclePayment
            // 
            this.EndscopeCanclePayment.Caption = "Endscope Cancle Payment";
            this.EndscopeCanclePayment.ConfirmationMessage = null;
            this.EndscopeCanclePayment.Id = "EndscopeCanclePayment";
            this.EndscopeCanclePayment.ImageName = "TrackingChanges_Reject";
            this.EndscopeCanclePayment.TargetObjectsCriteria = "Paid = true AND !Complete";
            this.EndscopeCanclePayment.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Endscope);
            this.EndscopeCanclePayment.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.EndscopeCanclePayment.ToolTip = null;
            this.EndscopeCanclePayment.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.EndscopeCanclePayment.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.EndscopeCanclePayment_Execute);
            // 
            // CasherViewController
            // 
            this.Actions.Add(this.TestPaid);
            this.Actions.Add(this.TestCanclePayment);
            this.Actions.Add(this.XrayPaid);
            this.Actions.Add(this.XrayCanclePayment);
            this.Actions.Add(this.EndscopePaid);
            this.Actions.Add(this.EndscopeCanclePayment);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction TestPaid;
        private DevExpress.ExpressApp.Actions.SimpleAction TestCanclePayment;
        private DevExpress.ExpressApp.Actions.SimpleAction XrayPaid;
        private DevExpress.ExpressApp.Actions.SimpleAction XrayCanclePayment;
        private DevExpress.ExpressApp.Actions.SimpleAction EndscopePaid;
        private DevExpress.ExpressApp.Actions.SimpleAction EndscopeCanclePayment;
    }
}
