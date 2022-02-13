
namespace HMS.Module.Win.Controllers
{
    partial class Departments
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
            this.ICUPatentsDetails = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ICUtotals = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.InPatients = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.InPatientsTotal = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.DailyAccountReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ICUPatentsDetails
            // 
            this.ICUPatentsDetails.Caption = "ICUPatents Details";
            this.ICUPatentsDetails.ConfirmationMessage = null;
            this.ICUPatentsDetails.Id = "ICUPatentsDetails";
            this.ICUPatentsDetails.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.ICUPatentsDetails.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.ICUPatentsDetails.ToolTip = null;
            this.ICUPatentsDetails.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.ICUPatentsDetails.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ICUPatentsDetails_Execute);
            // 
            // ICUtotals
            // 
            this.ICUtotals.Caption = "ICUtotals";
            this.ICUtotals.ConfirmationMessage = null;
            this.ICUtotals.Id = "ICUtotals";
            this.ICUtotals.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.ICUtotals.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.ICUtotals.ToolTip = null;
            this.ICUtotals.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.ICUtotals.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ICUtotals_Execute);
            // 
            // InPatients
            // 
            this.InPatients.Caption = "InPatients";
            this.InPatients.ConfirmationMessage = null;
            this.InPatients.Id = "InPatients";
            this.InPatients.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.InPatients.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.InPatients.ToolTip = null;
            this.InPatients.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.InPatients.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.InPatients_Execute);
            // 
            // InPatientsTotal
            // 
            this.InPatientsTotal.Caption = "In Patients Total";
            this.InPatientsTotal.ConfirmationMessage = null;
            this.InPatientsTotal.Id = "InPatientsTotal";
            this.InPatientsTotal.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.InPatientsTotal.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.InPatientsTotal.ToolTip = null;
            this.InPatientsTotal.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.InPatientsTotal.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.InPatientsTotal_Execute);
            // 
            // DailyAccountReport
            // 
            this.DailyAccountReport.Caption = "تقرير الاقامات";
            this.DailyAccountReport.ConfirmationMessage = null;
            this.DailyAccountReport.Id = "DailyAccountReport";
            this.DailyAccountReport.ImageName = "BO_REPORT";
            this.DailyAccountReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.DailyAccountReport.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.DailyAccountReport.ToolTip = null;
            this.DailyAccountReport.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.DailyAccountReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.DailyAccountReport_Execute);
            // 
            // Departments
            // 
            this.Actions.Add(this.ICUPatentsDetails);
            this.Actions.Add(this.ICUtotals);
            this.Actions.Add(this.InPatients);
            this.Actions.Add(this.InPatientsTotal);
            this.Actions.Add(this.DailyAccountReport);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ICUPatentsDetails;
        private DevExpress.ExpressApp.Actions.SimpleAction ICUtotals;
        private DevExpress.ExpressApp.Actions.SimpleAction InPatients;
        private DevExpress.ExpressApp.Actions.SimpleAction InPatientsTotal;
        private DevExpress.ExpressApp.Actions.SimpleAction DailyAccountReport;
    }
}
