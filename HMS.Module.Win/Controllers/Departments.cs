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

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class Departments : ViewController
    {
        public Departments()
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

        private void ICUPatentsDetails_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ICUpatients report = new reports.ICUpatients();

            report.ShowPreviewDialog();
        }

        private void ICUtotals_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.ICUtotals report = new reports.ICUtotals();

            report.ShowPreviewDialog();
        }

        private void InPatients_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.InPatients report = new reports.InPatients();

            report.ShowPreviewDialog();
        }

        private void InPatientsTotal_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.InPatientsTotal report = new reports.InPatientsTotal();

            report.ShowPreviewDialog();
        }
    }
}
