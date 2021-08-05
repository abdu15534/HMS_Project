
namespace HMS.Module.Win.Controllers
{
    partial class LabsViewController
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
            this.TestComplete = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.TestBacktrack = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.XrayComplete = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.XrayBacktrack = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.EndscopeComplete = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.EndscopeBacktrack = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.Recipt = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ReciptXray = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ReciptEndoscpy = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // TestComplete
            // 
            this.TestComplete.Caption = "Test Complete";
            this.TestComplete.ConfirmationMessage = null;
            this.TestComplete.Id = "TestComplete";
            this.TestComplete.ImageName = "TrackingChanges_Accept_32x32";
            this.TestComplete.TargetObjectsCriteria = "!Complete AND Paid";
            this.TestComplete.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Test);
            this.TestComplete.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TestComplete.ToolTip = null;
            this.TestComplete.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.TestComplete.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.TestComplete_Execute);
            // 
            // TestBacktrack
            // 
            this.TestBacktrack.Caption = "Test Backtrack";
            this.TestBacktrack.ConfirmationMessage = null;
            this.TestBacktrack.Id = "TestBacktrack";
            this.TestBacktrack.ImageName = "TrackingChanges_Reject_32x32";
            this.TestBacktrack.TargetObjectsCriteria = "Complete";
            this.TestBacktrack.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Test);
            this.TestBacktrack.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TestBacktrack.ToolTip = null;
            this.TestBacktrack.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.TestBacktrack.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.TestBacktrack_Execute);
            // 
            // XrayComplete
            // 
            this.XrayComplete.Caption = "Xray Complete";
            this.XrayComplete.ConfirmationMessage = null;
            this.XrayComplete.Id = "XrayComplete";
            this.XrayComplete.ImageName = "TrackingChanges_Accept_32x32";
            this.XrayComplete.TargetObjectsCriteria = "!Complete AND Paid";
            this.XrayComplete.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Xrays);
            this.XrayComplete.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.XrayComplete.ToolTip = null;
            this.XrayComplete.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.XrayComplete.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.XrayComplete_Execute);
            // 
            // XrayBacktrack
            // 
            this.XrayBacktrack.Caption = "Xray Backtrack";
            this.XrayBacktrack.ConfirmationMessage = null;
            this.XrayBacktrack.Id = "XrayBacktrack";
            this.XrayBacktrack.ImageName = "TrackingChanges_Reject_32x32";
            this.XrayBacktrack.TargetObjectsCriteria = "Complete";
            this.XrayBacktrack.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Xrays);
            this.XrayBacktrack.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.XrayBacktrack.ToolTip = null;
            this.XrayBacktrack.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.XrayBacktrack.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.XrayBacktrack_Execute);
            // 
            // EndscopeComplete
            // 
            this.EndscopeComplete.Caption = "Endscope Complete";
            this.EndscopeComplete.ConfirmationMessage = null;
            this.EndscopeComplete.Id = "EndscopeComplete";
            this.EndscopeComplete.ImageName = "TrackingChanges_Accept_32x32";
            this.EndscopeComplete.TargetObjectsCriteria = "!Complete AND Paid";
            this.EndscopeComplete.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Endscope);
            this.EndscopeComplete.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.EndscopeComplete.ToolTip = null;
            this.EndscopeComplete.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.EndscopeComplete.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.EndscopeComplete_Execute);
            // 
            // EndscopeBacktrack
            // 
            this.EndscopeBacktrack.Caption = "Endscope Backtrack";
            this.EndscopeBacktrack.ConfirmationMessage = null;
            this.EndscopeBacktrack.Id = "EndscopeBacktrack";
            this.EndscopeBacktrack.ImageName = "TrackingChanges_Reject_32x32";
            this.EndscopeBacktrack.TargetObjectsCriteria = "Complete";
            this.EndscopeBacktrack.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Endscope);
            this.EndscopeBacktrack.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.EndscopeBacktrack.ToolTip = null;
            this.EndscopeBacktrack.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.EndscopeBacktrack.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.EndscopeBacktrack_Execute);
            // 
            // Recipt
            // 
            this.Recipt.Caption = "فاتورة دفع تحاليل";
            this.Recipt.ConfirmationMessage = null;
            this.Recipt.Id = "Recipt";
            this.Recipt.ImageName = "BO_REPORT";
            this.Recipt.TargetObjectsCriteria = "Paid = true";
            this.Recipt.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Test);
            this.Recipt.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Recipt.ToolTip = null;
            this.Recipt.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.Recipt.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Recipt_Execute);
            // 
            // ReciptXray
            // 
            this.ReciptXray.Caption = "فاتورة دفع اشعة";
            this.ReciptXray.ConfirmationMessage = null;
            this.ReciptXray.Id = "ReciptXray";
            this.ReciptXray.ImageName = "BO_REPORT";
            this.ReciptXray.TargetObjectsCriteria = "Paid = true";
            this.ReciptXray.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Xrays);
            this.ReciptXray.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ReciptXray.ToolTip = null;
            this.ReciptXray.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ReciptXray.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ReciptXray_Execute);
            // 
            // ReciptEndoscpy
            // 
            this.ReciptEndoscpy.Caption = "فاتورة دفع مناظير";
            this.ReciptEndoscpy.ConfirmationMessage = null;
            this.ReciptEndoscpy.Id = "ReciptEndoscpy";
            this.ReciptEndoscpy.ImageName = "BO_REPORT";
            this.ReciptEndoscpy.TargetObjectsCriteria = "Paid = true";
            this.ReciptEndoscpy.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Endscope);
            this.ReciptEndoscpy.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ReciptEndoscpy.ToolTip = null;
            this.ReciptEndoscpy.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ReciptEndoscpy.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ReciptEndoscpy_Execute);
            // 
            // LabsViewController
            // 
            this.Actions.Add(this.TestComplete);
            this.Actions.Add(this.TestBacktrack);
            this.Actions.Add(this.XrayComplete);
            this.Actions.Add(this.XrayBacktrack);
            this.Actions.Add(this.EndscopeComplete);
            this.Actions.Add(this.EndscopeBacktrack);
            this.Actions.Add(this.Recipt);
            this.Actions.Add(this.ReciptXray);
            this.Actions.Add(this.ReciptEndoscpy);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction TestComplete;
        private DevExpress.ExpressApp.Actions.SimpleAction TestBacktrack;
        private DevExpress.ExpressApp.Actions.SimpleAction XrayComplete;
        private DevExpress.ExpressApp.Actions.SimpleAction XrayBacktrack;
        private DevExpress.ExpressApp.Actions.SimpleAction EndscopeComplete;
        private DevExpress.ExpressApp.Actions.SimpleAction EndscopeBacktrack;
        private DevExpress.ExpressApp.Actions.SimpleAction Recipt;
        private DevExpress.ExpressApp.Actions.SimpleAction ReciptXray;
        private DevExpress.ExpressApp.Actions.SimpleAction ReciptEndoscpy;
    }
}
