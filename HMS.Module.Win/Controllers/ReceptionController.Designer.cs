
namespace HMS.Module.Win.Controllers
{
    partial class ReceptionController
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
            this.CheckOutReception = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.UnCheckOutReception = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.DetailedReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.CurrentStay = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.Transfer = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.ReceptionJournalReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.TotalsReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.DiscoutAndService = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PatientLable = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.FindAddmition = new DevExpress.ExpressApp.Actions.ParametrizedAction(this.components);
            this.FintdPatient = new DevExpress.ExpressApp.Actions.ParametrizedAction(this.components);
            this.ToltalAccountStatement = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.AccountStatement = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // CheckOutReception
            // 
            this.CheckOutReception.Caption = "Check Out Reception";
            this.CheckOutReception.ConfirmationMessage = null;
            this.CheckOutReception.Id = "CheckOutReception";
            this.CheckOutReception.ImageName = "BO_UNKNOWN";
            this.CheckOutReception.TargetObjectsCriteria = "isDischarged != true";
            this.CheckOutReception.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.CheckOutReception.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.CheckOutReception.ToolTip = null;
            this.CheckOutReception.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.CheckOutReception.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.CheckOut_Execute);
            // 
            // UnCheckOutReception
            // 
            this.UnCheckOutReception.Caption = "Un Check Out Reception";
            this.UnCheckOutReception.ConfirmationMessage = null;
            this.UnCheckOutReception.Id = "UnCheckOutReception";
            this.UnCheckOutReception.ImageName = "BO_UNKNOWN";
            this.UnCheckOutReception.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.UnCheckOutReception.TargetObjectsCriteria = "isDischarged == true";
            this.UnCheckOutReception.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.UnCheckOutReception.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.UnCheckOutReception.ToolTip = null;
            this.UnCheckOutReception.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.UnCheckOutReception.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.UnCheckOutReception_Execute);
            // 
            // DetailedReport
            // 
            this.DetailedReport.Caption = "Detailed Report";
            this.DetailedReport.ConfirmationMessage = null;
            this.DetailedReport.Id = "DetailedReport";
            this.DetailedReport.ImageName = "BO_REPORT";
            this.DetailedReport.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.DetailedReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.DetailedReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.DetailedReport.ToolTip = null;
            this.DetailedReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.DetailedReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.DetailedReport_Execute);
            // 
            // CurrentStay
            // 
            this.CurrentStay.AcceptButtonCaption = null;
            this.CurrentStay.CancelButtonCaption = null;
            this.CurrentStay.Caption = "Current Stay";
            this.CurrentStay.ConfirmationMessage = null;
            this.CurrentStay.Id = "CurrentStay";
            this.CurrentStay.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.CurrentStay.TargetObjectsCriteria = "currentStay != null";
            this.CurrentStay.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.CurrentStay.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.CurrentStay.ToolTip = null;
            this.CurrentStay.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.CurrentStay.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.CurrentStay_Execute);
            // 
            // Transfer
            // 
            this.Transfer.AcceptButtonCaption = null;
            this.Transfer.CancelButtonCaption = null;
            this.Transfer.Caption = "Transfer";
            this.Transfer.ConfirmationMessage = null;
            this.Transfer.Id = "Transfer";
            this.Transfer.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.Transfer.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.Transfer.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Transfer.ToolTip = null;
            this.Transfer.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.Transfer.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.Transfer_Execute);
            // 
            // ReceptionJournalReport
            // 
            this.ReceptionJournalReport.Caption = "Reception Journal Report";
            this.ReceptionJournalReport.ConfirmationMessage = null;
            this.ReceptionJournalReport.Id = "ReceptionJournalReport";
            this.ReceptionJournalReport.ImageName = "BO_REPORT";
            this.ReceptionJournalReport.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.ReceptionJournalReport.TargetObjectsCriteria = "isDischarged == true";
            this.ReceptionJournalReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.ReceptionJournalReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ReceptionJournalReport.ToolTip = null;
            this.ReceptionJournalReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ReceptionJournalReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ReceptionJournalReport_Execute);
            // 
            // TotalsReport
            // 
            this.TotalsReport.Caption = "Totals Report";
            this.TotalsReport.ConfirmationMessage = null;
            this.TotalsReport.Id = "TotalsReport";
            this.TotalsReport.ImageName = "BO_REPORT";
            this.TotalsReport.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.TotalsReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TotalsReport.ToolTip = null;
            this.TotalsReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.TotalsReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.TotalsReport_Execute);
            // 
            // DiscoutAndService
            // 
            this.DiscoutAndService.Caption = "Discout And Service";
            this.DiscoutAndService.ConfirmationMessage = null;
            this.DiscoutAndService.Id = "DiscoutAndService";
            this.DiscoutAndService.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.DiscoutAndService.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.DiscoutAndService.ToolTip = null;
            this.DiscoutAndService.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.DiscoutAndService.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.DiscoutAndService_Execute);
            // 
            // PatientLable
            // 
            this.PatientLable.Caption = "ملصق المريض";
            this.PatientLable.ConfirmationMessage = null;
            this.PatientLable.Id = "PatientLable";
            this.PatientLable.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.PatientLable.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PatientLable.ToolTip = null;
            this.PatientLable.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.PatientLable.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PatientLable_Execute);
            // 
            // FindAddmition
            // 
            this.FindAddmition.Caption = "بحث بالرقم الطبي";
            this.FindAddmition.ConfirmationMessage = null;
            this.FindAddmition.Id = "FindAddmition";
            this.FindAddmition.NullValuePrompt = null;
            this.FindAddmition.ShortCaption = null;
            this.FindAddmition.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.FindAddmition.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.FindAddmition.ToolTip = null;
            this.FindAddmition.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.FindAddmition.Execute += new DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventHandler(this.FindAddmitionByMedicalID_Execute);
            // 
            // FintdPatient
            // 
            this.FintdPatient.Caption = "بحث بالرقم الطبي";
            this.FintdPatient.ConfirmationMessage = null;
            this.FintdPatient.Id = "FintdPatient";
            this.FintdPatient.NullValuePrompt = null;
            this.FintdPatient.ShortCaption = null;
            this.FintdPatient.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Patient);
            this.FintdPatient.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.FintdPatient.ToolTip = null;
            this.FintdPatient.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.FintdPatient.Execute += new DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventHandler(this.FintdPatient_Execute);
            // 
            // ToltalAccountStatement
            // 
            this.ToltalAccountStatement.Caption = "كشف حساب اجمالي";
            this.ToltalAccountStatement.ConfirmationMessage = null;
            this.ToltalAccountStatement.Id = "ToltalAccountStatement";
            this.ToltalAccountStatement.ImageName = "EmployeeTaskList";
            this.ToltalAccountStatement.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.ToltalAccountStatement.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ToltalAccountStatement.ToolTip = null;
            this.ToltalAccountStatement.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ToltalAccountStatement.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.AccountStatement_Execute);
            // 
            // AccountStatement
            // 
            this.AccountStatement.Caption = "كشف حساب تفصيلي";
            this.AccountStatement.ConfirmationMessage = null;
            this.AccountStatement.Id = "AccountStatement";
            this.AccountStatement.ImageName = "EmployeeTaskList";
            this.AccountStatement.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);
            this.AccountStatement.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.AccountStatement.ToolTip = null;
            this.AccountStatement.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.AccountStatement.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.AccountStatement_Execute_1);
            // 
            // ReceptionController
            // 
            this.Actions.Add(this.CheckOutReception);
            this.Actions.Add(this.UnCheckOutReception);
            this.Actions.Add(this.DetailedReport);
            this.Actions.Add(this.CurrentStay);
            this.Actions.Add(this.Transfer);
            this.Actions.Add(this.ReceptionJournalReport);
            this.Actions.Add(this.TotalsReport);
            this.Actions.Add(this.DiscoutAndService);
            this.Actions.Add(this.PatientLable);
            this.Actions.Add(this.FindAddmition);
            this.Actions.Add(this.FintdPatient);
            this.Actions.Add(this.ToltalAccountStatement);
            this.Actions.Add(this.AccountStatement);
            this.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.ReceptionDesk);

        }

        #endregion
        private DevExpress.ExpressApp.Actions.SimpleAction CheckOutReception;
        private DevExpress.ExpressApp.Actions.SimpleAction UnCheckOutReception;
        private DevExpress.ExpressApp.Actions.SimpleAction DetailedReport;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction CurrentStay;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction Transfer;
        private DevExpress.ExpressApp.Actions.SimpleAction ReceptionJournalReport;
        private DevExpress.ExpressApp.Actions.SimpleAction TotalsReport;
        private DevExpress.ExpressApp.Actions.SimpleAction DiscoutAndService;
        private DevExpress.ExpressApp.Actions.SimpleAction PatientLable;
        private DevExpress.ExpressApp.Actions.ParametrizedAction FindAddmition;
        private DevExpress.ExpressApp.Actions.ParametrizedAction FintdPatient;
        private DevExpress.ExpressApp.Actions.SimpleAction ToltalAccountStatement;
        private DevExpress.ExpressApp.Actions.SimpleAction AccountStatement;
    }
}
