﻿
namespace HMS.Module.Win.Controllers
{
    partial class EmergencyViewController
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
            this.EmergencyInvoice = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.EmergencyPatients = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.EmergencyTotals = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.EmergencyDetailedReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // EmergencyInvoice
            // 
            this.EmergencyInvoice.Caption = "Emergency Invoice";
            this.EmergencyInvoice.Id = "EmergencyInvoice";
            this.EmergencyInvoice.ImageName = "BO_REPORT";
            this.EmergencyInvoice.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.EmergencyInvoice.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Emergency);
            this.EmergencyInvoice.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.EmergencyInvoice.ToolTip = null;
            this.EmergencyInvoice.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.EmergencyInvoice.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.EmergencyInvoice_Execute);
            // 
            // EmergencyPatients
            // 
            this.EmergencyPatients.Caption = "Emergency Patients";
            this.EmergencyPatients.ConfirmationMessage = null;
            this.EmergencyPatients.Id = "EmergencyPatients";
            this.EmergencyPatients.ImageName = "Tasklist";
            this.EmergencyPatients.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Emergency);
            this.EmergencyPatients.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.EmergencyPatients.ToolTip = null;
            this.EmergencyPatients.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.EmergencyPatients.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.EmergencyPatients_Execute);
            // 
            // EmergencyTotals
            // 
            this.EmergencyTotals.Caption = "Emergency Totals";
            this.EmergencyTotals.ConfirmationMessage = null;
            this.EmergencyTotals.Id = "EmergencyTotals";
            this.EmergencyTotals.ImageName = "";
            this.EmergencyTotals.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Emergency);
            this.EmergencyTotals.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.EmergencyTotals.ToolTip = null;
            this.EmergencyTotals.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.EmergencyTotals.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.EmergencyTotals_Execute);
            // 
            // EmergencyDetailedReport
            // 
            this.EmergencyDetailedReport.Caption = "الفاتورة التفصيلية";
            this.EmergencyDetailedReport.ConfirmationMessage = null;
            this.EmergencyDetailedReport.Id = "EmergencyDetailedReport";
            this.EmergencyDetailedReport.ImageName = "BO_REPORT";
            this.EmergencyDetailedReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Emergency);
            this.EmergencyDetailedReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.EmergencyDetailedReport.ToolTip = null;
            this.EmergencyDetailedReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.EmergencyDetailedReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.DetailedReport_Execute);
            // 
            // EmergencyViewController
            // 
            this.Actions.Add(this.EmergencyInvoice);
            this.Actions.Add(this.EmergencyPatients);
            this.Actions.Add(this.EmergencyTotals);
            this.Actions.Add(this.EmergencyDetailedReport);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction EmergencyInvoice;
        private DevExpress.ExpressApp.Actions.SimpleAction EmergencyPatients;
        private DevExpress.ExpressApp.Actions.SimpleAction EmergencyTotals;
        private DevExpress.ExpressApp.Actions.SimpleAction EmergencyDetailedReport;
    }
}
