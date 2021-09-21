
namespace HMS.Module.Win.Controllers
{
    partial class ClinincController
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
            this.PaymentRecipt = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.OutPatientLable = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.FindAppointment = new DevExpress.ExpressApp.Actions.ParametrizedAction(this.components);
            this.ClearTicket = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // PaymentRecipt
            // 
            this.PaymentRecipt.Caption = "Payment Recipt";
            this.PaymentRecipt.ConfirmationMessage = null;
            this.PaymentRecipt.Id = "PaymentRecipt";
            this.PaymentRecipt.ImageName = "BO_REPORT";
            this.PaymentRecipt.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Appointment);
            this.PaymentRecipt.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.PaymentRecipt.ToolTip = null;
            this.PaymentRecipt.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.PaymentRecipt.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PaymentRecipt_Execute);
            // 
            // OutPatientLable
            // 
            this.OutPatientLable.Caption = "ملصق المريض";
            this.OutPatientLable.ConfirmationMessage = null;
            this.OutPatientLable.Id = "OutPatientLable";
            this.OutPatientLable.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Appointment);
            this.OutPatientLable.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.OutPatientLable.ToolTip = null;
            this.OutPatientLable.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.OutPatientLable.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PatientLable_Execute);
            // 
            // FindAppointment
            // 
            this.FindAppointment.Caption = "بحث بالرقم الطبي";
            this.FindAppointment.ConfirmationMessage = null;
            this.FindAppointment.Id = "FindAppointment";
            this.FindAppointment.NullValuePrompt = null;
            this.FindAppointment.ShortCaption = null;
            this.FindAppointment.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Appointment);
            this.FindAppointment.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.FindAppointment.ToolTip = null;
            this.FindAppointment.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.FindAppointment.Execute += new DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventHandler(this.FindAppointment_Execute);
            // 
            // ClearTicket
            // 
            this.ClearTicket.Caption = "Clear Ticket";
            this.ClearTicket.ConfirmationMessage = null;
            this.ClearTicket.Id = "ClearTicket";
            this.ClearTicket.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Appointment);
            this.ClearTicket.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.ClearTicket.ToolTip = null;
            this.ClearTicket.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.ClearTicket.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ClearTicket_Execute);
            // 
            // ClinincController
            // 
            this.Actions.Add(this.PaymentRecipt);
            this.Actions.Add(this.OutPatientLable);
            this.Actions.Add(this.FindAppointment);
            this.Actions.Add(this.ClearTicket);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction PaymentRecipt;
        private DevExpress.ExpressApp.Actions.SimpleAction OutPatientLable;
        private DevExpress.ExpressApp.Actions.ParametrizedAction FindAppointment;
        private DevExpress.ExpressApp.Actions.SimpleAction ClearTicket;
    }
}
