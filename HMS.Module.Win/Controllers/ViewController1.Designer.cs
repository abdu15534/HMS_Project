
namespace HMS.Module.Win.Controllers
{
    partial class ViewController1
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
            this.StockReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // StockReport
            // 
            this.StockReport.Caption = "Stock Report";
            this.StockReport.ConfirmationMessage = null;
            this.StockReport.Id = "Stock Report ";
            this.StockReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Inventory);
            this.StockReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.StockReport.ToolTip = null;
            this.StockReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.StockReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
            // 
            // ViewController1
            // 
            this.Actions.Add(this.StockReport);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction StockReport;
    }
}
