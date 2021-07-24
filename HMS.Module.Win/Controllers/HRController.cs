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
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
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
    public partial class HRController : ViewController
    {
        public HRController()
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

        private void VacationsReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var report = new reports.VacationsReport();
            var curr = View.CurrentObject as Employee;

            if (curr == null)
                report.Parameters["parameter1"].Value = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
            else
                report.Parameters["parameter1"].Value = ((Employee)View.CurrentObject).Oid;

            report.ShowPreviewDialog();
        }

        private void WarningsReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var report = new reports.WarningsReport();
            var curr = View.CurrentObject as Employee;

            if (curr == null)
                report.Parameters["parameter1"].Value = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
            else
                report.Parameters["parameter1"].Value = ((Employee)View.CurrentObject).Oid;

            report.ShowPreviewDialog();
        }



        private void SalariesReport_Execute_1(object sender, SimpleActionExecuteEventArgs e)
        {
            var report = new reports.SalariesReport();
            var curr = View.CurrentObject as Employee;

            if (curr == null)
                report.Parameters["parameter1"].Value = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
            else
                report.Parameters["parameter1"].Value = ((Employee)View.CurrentObject).Oid;

            report.ShowPreviewDialog();
        }


        private void PostSalaryPayment_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var order = View.CurrentObject as SalaryPayment;
            order.SalaryPaymentPost(true);
        }

        private void UnPostSalaryPayment_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var order = View.CurrentObject as SalaryPayment;
            order.SalaryPaymentPost(false);
        }

        private void SalaryPaymentJournal_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.JournalEntryReport report = new reports.JournalEntryReport();

            var curr = View.CurrentObject as SalaryPayment;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
            {
                PermissionPolicyUser user;
                if (SecuritySystem.CurrentUser != null)
                {
                    user = ObjectSpace.GetObjectByKey<PermissionPolicyUser>(SecuritySystem.CurrentUserId);
                    report.Parameters["user"].Value = user.UserName;
                }

                report.Parameters["parameter1"].Value = ((SalaryPayment)View.CurrentObject).journalEntry.ID;
            }

            report.ShowPreviewDialog();
        }

        private void SalaryPayment_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curr = View.CurrentObject as SalaryPayment;
            curr.PrepareSalaries();

        }

        private void SalaryDeductionReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

        }

        private void SalaryPaymentReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.SalariesReport report = new reports.SalariesReport();

            var curr = View.CurrentObject as SalaryPayment;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
            {
                report.Parameters["parameter1"].Value = ((SalaryPayment)View.CurrentObject).id;
            }

            report.ShowPreviewDialog();
        }

        private void PostSalaryDeduction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var SalaryDeduction = View.CurrentObject as SalaryDeduction;
            SalaryDeduction.SalaryDeductionPost(true);
        }

        private void UnPostSalaryDeduction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var SalaryDeduction = View.CurrentObject as SalaryDeduction;
            SalaryDeduction.SalaryDeductionPost(false);
        }

        private void SalaryDeductionJournal_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.JournalEntryReport report = new reports.JournalEntryReport();

            var curr = View.CurrentObject as SalaryDeduction;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
            {
                PermissionPolicyUser user;
                if (SecuritySystem.CurrentUser != null)
                {
                    user = ObjectSpace.GetObjectByKey<PermissionPolicyUser>(SecuritySystem.CurrentUserId);
                    report.Parameters["user"].Value = user.UserName;
                }

                report.Parameters["parameter1"].Value = ((SalaryDeduction)View.CurrentObject).journalEntry.ID;
            }

            report.ShowPreviewDialog();

        }
    }
}
