using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class StayReportController : ViewController
    {
        public StayReportController()
        {
            InitializeComponent();
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

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.StayTotals report = new reports.StayTotals();
            var curr = View.CurrentObject as Admission;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Admission)View.CurrentObject).admissionID;

            report.ShowPreviewDialog();
        }

        private void Checkout_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var stay = View.CurrentObject as Admission;
            stay.CheckOut();
        }

        private void StayDetialInvoice_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

        }

        private void testAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
                      
        }

        private void ICUpatients_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ICUpatients report = new reports.ICUpatients();

            var curr = View.CurrentObject as Admission;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Admission)View.CurrentObject).admissionID;

            report.ShowPreviewDialog();
        }

        private void simpleAction1_Execute_1(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.AdmittedPatients report = new reports.AdmittedPatients();

            var curr = View.CurrentObject as Admission;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Admission)View.CurrentObject).admissionID;

            report.ShowPreviewDialog();
        }

        private void ConsultationRequest_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.Consultation report = new reports.Consultation();

            var curr = View.CurrentObject as Admission;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Admission)View.CurrentObject).admissionID;

            report.ShowPreviewDialog();
        }

        private void DischargeDetails_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.DischargeDetails report = new reports.DischargeDetails();

            var curr = View.CurrentObject as Admission;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Admission)View.CurrentObject).admissionID;

            report.ShowPreviewDialog();
        }

        private void UnCheckOutAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var stay = View.CurrentObject as Admission;
            stay.IsDischarged = false;
        }
    }
}
