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

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class EmergencyViewController : ViewController
    {
        public EmergencyViewController()
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

        private void EmergencyInvoice_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.EmergencyInvoice report = new reports.EmergencyInvoice();
            var curr = View.CurrentObject as Emergency;
            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Emergency)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }

        private void OUTPatients_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var report = new reports.OutPatients();
            var objs = View.ObjectSpace.GetObjects<Appointment>();
            var curr = View.CurrentObject as Appointment;

            if (curr == null)
                report.Parameters["parameter1"].Value = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
            else
                //report.Parameters["parameter1"].Value = objs.Aggregate<Appointment>;

            report.ShowPreviewDialog();
        }

        private void EmergencyPatients_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.EmergencyPatients report = new reports.EmergencyPatients();
            var curr = View.CurrentObject as Emergency;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((Emergency)View.CurrentObject).id;

            report.ShowPreviewDialog();
        }
    }
}
