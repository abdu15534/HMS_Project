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
    public partial class ReceptionController : ViewController
    {
        public ReceptionController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            CurrentStay.CustomizePopupWindowParams += showDetailViewAction_CustomizePopupWindowParams;
            Transfer.CustomizePopupWindowParams += createDetailViewAction_CustomizePopupWindowParams;

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

        void showDetailViewAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            //Show the admission which is not discharged
            var receptionDesk = View.CurrentObject as ReceptionDesk;
            foreach (var item in receptionDesk.Admissions)
            {
                if (!item.IsDischarged)
                {
                    IObjectSpace newObjectSpace = Application.CreateObjectSpace(typeof(Admission));
                    Object objectToShow = ObjectSpace.GetObjectByKey(typeof(Admission), item.admissionID);
                    if (objectToShow != null)
                    {
                        DetailView createdView = Application.CreateDetailView(newObjectSpace, objectToShow);
                        createdView.ViewEditMode = ViewEditMode.Edit;
                        e.View = createdView;
                    }
                }
            }
        }

        void createDetailViewAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var reception = View.CurrentObject as ReceptionDesk;
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Admission));
            Admission newAdmission = objectSpace.CreateObject<Admission>();
            newAdmission.reception = objectSpace.GetObjectByKey<ReceptionDesk>(reception.enterID);
            newAdmission.Patient = objectSpace.GetObjectByKey<Patient>(reception.patient.ID);
            newAdmission.transferFlag = true;
            newAdmission.transferDayCount = true;
            DetailView detailView = Application.CreateDetailView(objectSpace, newAdmission);
            
            detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
            e.View = detailView;
            
            
        }

        private void CheckOut_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var reception = View.CurrentObject as ReceptionDesk;
            reception.CheckOut();
            reception.patient.InStay = false;

        }

        private void CurrentStay_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

        }

        private void Transfer_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

        }

        private void UnCheckOutReception_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var reception = View.CurrentObject as ReceptionDesk;
            reception.isDischarged = false;
            reception.patient.InStay = true;
        }

        private void AdmissionReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.StayDetailReport report = new reports.StayDetailReport();

            var curr = View.CurrentObject as ReceptionDesk;
            if (curr == null)
            {
                var x = System.Convert.ToString(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["parameter1"].Value = x;
            }
            else
                report.Parameters["parameter1"].Value = ((ReceptionDesk)View.CurrentObject).enterID;

            report.ShowPreviewDialog();
        }

        private void DetailedReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.StayDetailReport report = new reports.StayDetailReport();

            var curr = View.CurrentObject as ReceptionDesk;

            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["enterID"].Value = x;
            }

            else
            {
                report.Parameters["enterID"].Value = curr.enterID;
                report.Parameters["patientName"].Value = curr.patient.FullName;
                report.Parameters["enterDate"].Value = curr.dateEnter;
                report.Parameters["leaveDate"].Value = curr.dateLeave;
                if (!curr.isDischarged)
                    report.Parameters["leaveDate"].Value = "مازال في الاقامة";
                report.Parameters["totalStay"].Value = curr.total;
                report.Parameters["totalN2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.total), "جنيه", "قرش") + " فقط لاغير ";

                PermissionPolicyUser user;
                if (SecuritySystem.CurrentUser != null)
                {
                    user = ObjectSpace.GetObjectByKey<PermissionPolicyUser>(SecuritySystem.CurrentUserId);
                    report.Parameters["user"].Value = user.UserName;
                }
            }

            report.ShowPreviewDialog();
        }

        private void ReceptionJournalReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.JournalEntryReport report = new reports.JournalEntryReport();

            var curr = View.CurrentObject as ReceptionDesk;

            PermissionPolicyUser user;
            if (SecuritySystem.CurrentUser != null)
            {
                user = ObjectSpace.GetObjectByKey<PermissionPolicyUser>(SecuritySystem.CurrentUserId);
                report.Parameters["user"].Value = user.UserName;
            }

            report.Parameters["parameter1"].Value =curr.journalEntry.ID;
            
            report.ShowPreviewDialog();
        }

        private void TotalsReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.StayTotals report = new reports.StayTotals();

            var curr = View.CurrentObject as ReceptionDesk;

            if (curr == null)
            {
                var x = System.Convert.ToInt32(((ObjectRecord)View.CurrentObject).ObjectKeyValue);
                report.Parameters["enterID"].Value = x;
            }

            else
            {
                report.Parameters["parameter1"].Value = curr.enterID;
                report.Parameters["totalN2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.total), "جنيه", "قرش") + " فقط لاغير ";
                //report.Parameters["patientName"].Value = curr.patient.FullName;
                //report.Parameters["enterDate"].Value = curr.dateEnter;
                //report.Parameters["leaveDate"].Value = curr.dateLeave;
                //if (!curr.isDischarged)
                //    report.Parameters["leaveDate"].Value = "مازال في الاقامة";
                //report.Parameters["totalStay"].Value = curr.total;
                //report.Parameters["totalN2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.total), "جنيه", "قرش") + " فقط لاغير ";

                //PermissionPolicyUser user;
                //if (SecuritySystem.CurrentUser != null)
                //{
                //    user = ObjectSpace.GetObjectByKey<PermissionPolicyUser>(SecuritySystem.CurrentUserId);
                //    report.Parameters["user"].Value = user.UserName;
                //}
            }

            report.ShowPreviewDialog();

        }

        

        private void DiscoutAndService_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var reception = View.CurrentObject as ReceptionDesk;
            reception.IsDiscounted = !reception.IsDiscounted;

        }

        private void PatientLable_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            reports.PatientLable report = new reports.PatientLable();

            var curr = View.CurrentObject as ReceptionDesk;
            report.Parameters["parameter1"].Value = curr.enterID;
            report.ShowPreviewDialog();
        }

        private void FindAddmitionByMedicalID_Execute(object sender, ParametrizedActionExecuteEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(((ListView)View).ObjectTypeInfo.Type);
            string paramValue = e.ParameterCurrentValue as string;
            object obj = objectSpace.FindObject(((ListView)View).ObjectTypeInfo.Type,
                CriteriaOperator.Parse(string.Format("Contains([patient.MedicalID], '{0}')", paramValue)));
            if (obj != null)
            {
                DetailView detailView = Application.CreateDetailView(objectSpace, obj);
                detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
                e.ShowViewParameters.CreatedView = detailView;
            }
        }
    }
}
