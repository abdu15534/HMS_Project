using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XafDataModel.Module.BusinessObjects.test2;
using System.Linq;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ClinincController : ViewController
    {
        public ClinincController()
        {
            InitializeComponent();
            createXrayAppo.CustomizePopupWindowParams += createXrayAppo_CustomizePopupWindowParams;
            createTestAppo.CustomizePopupWindowParams += createTestAppo_CustomizePopupWindowParams;
            createEndoAppo.CustomizePopupWindowParams += createEndoAppo_CustomizePopupWindowParams;
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void PaymentRecipt_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ClinicCash report = new reports.ClinicCash();

            var curr = View.CurrentObject as Appointment;
            report.Parameters["parameter1"].Value = curr.id;
            report.Parameters["n2c"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.total), "جنيه", "قرش") + " فقط لاغير ";
            report.ShowPreviewDialog();
        }

        private void PatientLable_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.OutPatintLable report = new reports.OutPatintLable();

            var curr = View.CurrentObject as Appointment;
            if (curr.TicketNumber == 0)
            {
                //p.clinc == curr.clinc &&
                var latestApp = ObjectSpace.GetObjects<Appointment>().Where(p => p.clinc == curr.clinc && p.Doctor == curr.Doctor && p.StartOn.Date == DateTime.Now.Date).OrderByDescending(t => t.TicketNumber).ToList()[0];
                if (latestApp != null)
                {
                    if (latestApp.TicketNumber < 1)
                    {
                        curr.TicketNumber = 1;
                        ObjectSpace.CommitChanges();
                    }
                    else
                    {
                        curr.TicketNumber = latestApp.TicketNumber + 1;
                        ObjectSpace.CommitChanges();
                    }
                }
            }
            report.Parameters["oid"].Value = curr.Oid;
            report.ShowPreviewDialog();
        }

        private void FindAppointment_Execute(object sender, ParametrizedActionExecuteEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(((ListView)View).ObjectTypeInfo.Type);
            string paramValue = e.ParameterCurrentValue as string;
            try
            {
                var latestAppointment = objectSpace.GetObjects<Appointment>().Where(p => p.Patient.MedicalID == paramValue).OrderByDescending(t => t.StartOn).ToList()[0];

                if (latestAppointment != null)
                {
                    DetailView detailView = Application.CreateDetailView(objectSpace, latestAppointment);
                    detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
                    e.ShowViewParameters.CreatedView = detailView;
                }
            }
            catch
            {

            }
                //, CriteriaOperator.Parse("Patient.MedicalID = ?"), paramValue);
            Console.WriteLine("#####################################################################");
            //Console.WriteLine(date);
            //object obj = objectSpace.FindObject(((ListView)View).ObjectTypeInfo.Type,
              //  CriteriaOperator.Parse(string.Format("Contains([Patient.MedicalID], '{0}')"+" And SartOn = ?", paramValue, date)));
           
        }

        private void ClearTicket_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curr = View.CurrentObject as Appointment;
            curr.TicketNumber = 0;
            ObjectSpace.CommitChanges();
        }

        private void createXrayAppo_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

        }

        private void createXrayAppo_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var appo = View.CurrentObject as Appointment;
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Xrays));
            Xrays xray = objectSpace.CreateObject<Xrays>();
            xray.Patient = objectSpace.GetObjectByKey<Patient>(appo.Patient.ID);
            DetailView detailView = Application.CreateDetailView(objectSpace, xray);

            detailView.ViewEditMode = ViewEditMode.Edit;
            e.View = detailView;
        }

        private void createTestAppo_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

        }

        private void createTestAppo_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var appo = View.CurrentObject as Appointment;
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Test));
            Test test = objectSpace.CreateObject<Test>();
            test.Patient = objectSpace.GetObjectByKey<Patient>(appo.Patient.ID);
            DetailView detailView = Application.CreateDetailView(objectSpace, test);

            detailView.ViewEditMode = ViewEditMode.Edit;
            e.View = detailView;
        }

        private void createEndoAppo_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

        }

        private void createEndoAppo_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var appo = View.CurrentObject as Appointment;
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Endscope));
            Endscope endo = objectSpace.CreateObject<Endscope>();
            endo.Patient = objectSpace.GetObjectByKey<Patient>(appo.Patient.ID);
            DetailView detailView = Application.CreateDetailView(objectSpace, endo);

            detailView.ViewEditMode = ViewEditMode.Edit;
            e.View = detailView;
        }

        private void StatsReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ClinicStatsReport report = new reports.ClinicStatsReport();

            report.ShowPreviewDialog();
        }
    }
}