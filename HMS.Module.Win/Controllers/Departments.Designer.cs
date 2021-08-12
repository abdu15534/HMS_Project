
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
            // Departments
            // 
            this.Actions.Add(this.ICUPatentsDetails);
            this.Actions.Add(this.ICUtotals);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ICUPatentsDetails;
        private DevExpress.ExpressApp.Actions.SimpleAction ICUtotals;
    }
}
