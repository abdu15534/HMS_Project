
namespace HMS.Module.Win.Controllers
{
    partial class HRController
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
            this.VacationsReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.WarningsReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.SalariesReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.SalaryPayment = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PostSalaryPayment = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.UnPostSalaryPayment = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.SalaryPaymentJournal = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.SalaryPaymentReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.SalaryDeductionReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PostSalaryDeduction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.UnPostSalaryDeduction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.SalaryDeductionJournal = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // VacationsReport
            // 
            this.VacationsReport.Caption = "Vacations Report";
            this.VacationsReport.ConfirmationMessage = null;
            this.VacationsReport.Id = "VacationsReport";
            this.VacationsReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Employee);
            this.VacationsReport.ToolTip = null;
            this.VacationsReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.VacationsReport_Execute);
            // 
            // WarningsReport
            // 
            this.WarningsReport.Caption = "Warnings Report";
            this.WarningsReport.ConfirmationMessage = null;
            this.WarningsReport.Id = "WarningsReport";
            this.WarningsReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Employee);
            this.WarningsReport.ToolTip = null;
            this.WarningsReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.WarningsReport_Execute);
            // 
            // SalariesReport
            // 
            this.SalariesReport.Caption = "Salaries Report";
            this.SalariesReport.ConfirmationMessage = null;
            this.SalariesReport.Id = "SalariesReport";
            this.SalariesReport.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.SalariesReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Employee);
            this.SalariesReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.SalariesReport.ToolTip = null;
            this.SalariesReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.SalariesReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SalariesReport_Execute_1);
            // 
            // SalaryPayment
            // 
            this.SalaryPayment.Caption = "Salary Payment";
            this.SalaryPayment.ConfirmationMessage = null;
            this.SalaryPayment.Id = "SalaryPayment";
            this.SalaryPayment.ImageName = "Currency";
            this.SalaryPayment.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.SalaryPayment.TargetObjectsCriteria = "date != null ";
            this.SalaryPayment.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryPayment);
            this.SalaryPayment.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.SalaryPayment.ToolTip = null;
            this.SalaryPayment.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.SalaryPayment.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SalaryPayment_Execute);
            // 
            // PostSalaryPayment
            // 
            this.PostSalaryPayment.Caption = "Post Salary Payment";
            this.PostSalaryPayment.ConfirmationMessage = null;
            this.PostSalaryPayment.Id = "PostSalaryPayment";
            this.PostSalaryPayment.ImageName = "BO_UNKNOWN";
            this.PostSalaryPayment.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.PostSalaryPayment.TargetObjectsCriteria = "post == false ";
            this.PostSalaryPayment.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryPayment);
            this.PostSalaryPayment.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PostSalaryPayment.ToolTip = null;
            this.PostSalaryPayment.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.PostSalaryPayment.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PostSalaryPayment_Execute);
            // 
            // UnPostSalaryPayment
            // 
            this.UnPostSalaryPayment.Caption = "Un Post Salary Payment";
            this.UnPostSalaryPayment.ConfirmationMessage = null;
            this.UnPostSalaryPayment.Id = "UnPostSalaryPayment";
            this.UnPostSalaryPayment.ImageName = "BO_UNKNOWN";
            this.UnPostSalaryPayment.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.UnPostSalaryPayment.TargetObjectsCriteria = "post == true";
            this.UnPostSalaryPayment.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryPayment);
            this.UnPostSalaryPayment.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.UnPostSalaryPayment.ToolTip = null;
            this.UnPostSalaryPayment.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.UnPostSalaryPayment.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UnPostSalaryPayment_Execute);
            // 
            // SalaryPaymentJournal
            // 
            this.SalaryPaymentJournal.Caption = "Salary Payment Journal";
            this.SalaryPaymentJournal.ConfirmationMessage = null;
            this.SalaryPaymentJournal.Id = "SalaryPaymentJournal";
            this.SalaryPaymentJournal.ImageName = "BO_REPORT";
            this.SalaryPaymentJournal.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.SalaryPaymentJournal.TargetObjectsCriteria = "post == true";
            this.SalaryPaymentJournal.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryPayment);
            this.SalaryPaymentJournal.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.SalaryPaymentJournal.ToolTip = null;
            this.SalaryPaymentJournal.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.SalaryPaymentJournal.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SalaryPaymentJournal_Execute);
            // 
            // SalaryPaymentReport
            // 
            this.SalaryPaymentReport.Caption = "Salary Payment Report";
            this.SalaryPaymentReport.ConfirmationMessage = null;
            this.SalaryPaymentReport.Id = "SalaryPaymentReport";
            this.SalaryPaymentReport.ImageName = "BO_REPORT";
            this.SalaryPaymentReport.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.SalaryPaymentReport.TargetObjectsCriteria = "post == true";
            this.SalaryPaymentReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryPayment);
            this.SalaryPaymentReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.SalaryPaymentReport.ToolTip = null;
            this.SalaryPaymentReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.SalaryPaymentReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SalaryPaymentReport_Execute);
            // 
            // SalaryDeductionReport
            // 
            this.SalaryDeductionReport.Caption = "Salary Deduction Report";
            this.SalaryDeductionReport.ConfirmationMessage = null;
            this.SalaryDeductionReport.Id = "SalaryDeductionReport";
            this.SalaryDeductionReport.ImageName = "BO_REPORT";
            this.SalaryDeductionReport.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.SalaryDeductionReport.TargetObjectsCriteria = "post == true";
            this.SalaryDeductionReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryDeduction);
            this.SalaryDeductionReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.SalaryDeductionReport.ToolTip = null;
            this.SalaryDeductionReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.SalaryDeductionReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SalaryDeductionReport_Execute);
            // 
            // PostSalaryDeduction
            // 
            this.PostSalaryDeduction.Caption = "Post Salary Deduction";
            this.PostSalaryDeduction.ConfirmationMessage = null;
            this.PostSalaryDeduction.Id = "PostSalaryDeduction";
            this.PostSalaryDeduction.ImageName = "BO_UNKNOWN";
            this.PostSalaryDeduction.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.PostSalaryDeduction.TargetObjectsCriteria = "post == false ";
            this.PostSalaryDeduction.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryDeduction);
            this.PostSalaryDeduction.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PostSalaryDeduction.ToolTip = null;
            this.PostSalaryDeduction.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.PostSalaryDeduction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PostSalaryDeduction_Execute);
            // 
            // UnPostSalaryDeduction
            // 
            this.UnPostSalaryDeduction.Caption = "Un Post Salary Deduction";
            this.UnPostSalaryDeduction.ConfirmationMessage = null;
            this.UnPostSalaryDeduction.Id = "UnPostSalaryDeduction";
            this.UnPostSalaryDeduction.ImageName = "BO_UNKNOWN";
            this.UnPostSalaryDeduction.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.UnPostSalaryDeduction.TargetObjectsCriteria = "post == true";
            this.UnPostSalaryDeduction.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryDeduction);
            this.UnPostSalaryDeduction.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.UnPostSalaryDeduction.ToolTip = null;
            this.UnPostSalaryDeduction.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.UnPostSalaryDeduction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UnPostSalaryDeduction_Execute);
            // 
            // SalaryDeductionJournal
            // 
            this.SalaryDeductionJournal.Caption = "Salary Deduction Journal";
            this.SalaryDeductionJournal.ConfirmationMessage = null;
            this.SalaryDeductionJournal.Id = "SalaryDeductionJournal";
            this.SalaryDeductionJournal.ImageName = "BO_REPORT";
            this.SalaryDeductionJournal.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.SalaryDeductionJournal.TargetObjectsCriteria = "post == true";
            this.SalaryDeductionJournal.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.SalaryDeduction);
            this.SalaryDeductionJournal.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.SalaryDeductionJournal.ToolTip = null;
            this.SalaryDeductionJournal.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.SalaryDeductionJournal.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SalaryDeductionJournal_Execute);
            // 
            // HRController
            // 
            this.Actions.Add(this.VacationsReport);
            this.Actions.Add(this.WarningsReport);
            this.Actions.Add(this.SalariesReport);
            this.Actions.Add(this.SalaryPayment);
            this.Actions.Add(this.PostSalaryPayment);
            this.Actions.Add(this.UnPostSalaryPayment);
            this.Actions.Add(this.SalaryPaymentJournal);
            this.Actions.Add(this.SalaryPaymentReport);
            this.Actions.Add(this.SalaryDeductionReport);
            this.Actions.Add(this.PostSalaryDeduction);
            this.Actions.Add(this.UnPostSalaryDeduction);
            this.Actions.Add(this.SalaryDeductionJournal);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction VacationsReport;
        private DevExpress.ExpressApp.Actions.SimpleAction WarningsReport;
        private DevExpress.ExpressApp.Actions.SimpleAction SalariesReport;
        private DevExpress.ExpressApp.Actions.SimpleAction SalaryPayment;
        private DevExpress.ExpressApp.Actions.SimpleAction PostSalaryPayment;
        private DevExpress.ExpressApp.Actions.SimpleAction UnPostSalaryPayment;
        private DevExpress.ExpressApp.Actions.SimpleAction SalaryPaymentJournal;
        private DevExpress.ExpressApp.Actions.SimpleAction SalaryPaymentReport;
        private DevExpress.ExpressApp.Actions.SimpleAction SalaryDeductionReport;
        private DevExpress.ExpressApp.Actions.SimpleAction PostSalaryDeduction;
        private DevExpress.ExpressApp.Actions.SimpleAction UnPostSalaryDeduction;
        private DevExpress.ExpressApp.Actions.SimpleAction SalaryDeductionJournal;
    }
}
