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
            newAdmission.transferDayCount = false;
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
                decimal regolAraddmission = curr.Admissions.Where(p => p.Status == Admission.statusType.normal).Sum(p => p.roomStaySum);
                decimal icuAddmission = curr.Admissions.Where(p => p.Status != Admission.statusType.normal).Sum(p => p.roomStaySum);
                decimal supervision = curr.Admissions.Sum(p => p.MedicalSupervisionSum);
                decimal midcalCare = curr.Admissions.Sum(p => p.medicalCareSum);
                decimal outSuperviosn = curr.Admissions.Sum(p => p.ConsolationSum);
                decimal companion = curr.Admissions.Sum(p => p.companionSum);
                decimal pharmacy = curr.Admissions.Sum(p => p.medicationSum);
                decimal supplies = curr.Admissions.Sum(p => p.suppliesSum);
                decimal tests = curr.Admissions.Sum(p => p.testsSum);
                decimal xrayes = curr.Admissions.Sum(p => p.xraysSum);
                decimal edoscopy = curr.Admissions.Sum(p => p.endscopesSum);
                //decimal bloodServies = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Blood).Sum(x => x.price);
                //decimal otherServices = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Other).Sum(x => x.price);
                decimal outMedication = curr.Admissions.Sum(p => p.OutMedcationSum);
                decimal paymentsTotal = curr.PaymentsCollection.Sum(p => p.amount);

                report.Parameters["norStay"].Value = regolAraddmission;
                report.Parameters["icuStay"].Value = icuAddmission;
                report.Parameters["supervsion"].Value = supervision;
                report.Parameters["roomCare"].Value = midcalCare;
                report.Parameters["outSuperviosn"].Value = outSuperviosn;
                report.Parameters["Companin"].Value = companion;
                report.Parameters["Pharmacy"].Value = pharmacy;
                report.Parameters["Supplis"].Value = supplies;
                report.Parameters["Tests"].Value = tests;
                report.Parameters["Xrayes"].Value = xrayes;
                report.Parameters["edos"].Value = edoscopy;
                //report.Parameters["blood"].Value = bloodServies;
                //report.Parameters["otherServies"].Value = otherServices;
                report.Parameters["OutMedication"].Value = outMedication;
                report.Parameters["paymentsTotal"].Value = paymentsTotal;

                report.Parameters["enterID"].Value = curr.enterID;
                report.Parameters["patientName"].Value = curr.patient.FullName;
                report.Parameters["enterDate"].Value = curr.dateEnter;
                report.Parameters["leaveDate"].Value = curr.dateLeave;
                report.Parameters["IsAccountStatement"].Value = false;
                if (!curr.isDischarged)
                    report.Parameters["leaveDate"].Value = "مازال في الاقامة";
                report.Parameters["totalStay"].Value = curr.total;
                report.Parameters["totalN2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.totalC), "جنيه", "قرش") + " فقط لاغير ";

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
                decimal regolAraddmission = curr.Admissions.Where(p => p.Status == Admission.statusType.normal).Sum(p => p.roomStaySum);
                decimal icuAddmission = curr.Admissions.Where(p => p.Status != Admission.statusType.normal).Sum(p => p.roomStaySum);
                decimal supervision = curr.Admissions.Sum(p => p.MedicalSupervisionSum);
                decimal midcalCare = curr.Admissions.Sum(p => p.medicalCareSum);
                decimal outSuperviosn = curr.Admissions.Sum(p => p.ConsolationSum);
                decimal companion = curr.Admissions.Sum(p => p.companionSum);
                decimal pharmacy = curr.Admissions.Sum(p => p.medicationSum);
                decimal supplies = curr.Admissions.Sum(p => p.suppliesSum);
                decimal tests = curr.Admissions.Sum(p => p.testsSum);
                decimal xrayes = curr.Admissions.Sum(p => p.xraysSum);
                decimal edoscopy = curr.Admissions.Sum(p => p.endscopesSum);
                //decimal bloodServies = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Blood).Sum(x => x.price);
                //decimal otherServices = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Other).Sum(x => x.price);
                decimal outMedication = curr.Admissions.Sum(p => p.OutMedcationSum);
                decimal paymentsTotal = curr.PaymentsCollection.Sum(p => p.amount);

                report.Parameters["norStay"].Value = regolAraddmission;
                report.Parameters["icuStay"].Value = icuAddmission;
                report.Parameters["supervsion"].Value = supervision;
                report.Parameters["roomCare"].Value = midcalCare;
                report.Parameters["outSuperviosn"].Value = outSuperviosn;
                report.Parameters["Companion"].Value = companion;
                report.Parameters["Pharmacy"].Value = pharmacy;
                report.Parameters["Supplies"].Value = supplies;
                report.Parameters["Tests"].Value = tests;
                report.Parameters["Xrayes"].Value = xrayes;
                report.Parameters["edos"].Value = edoscopy;
                //report.Parameters["blood"].Value = bloodServies;
                //report.Parameters["otherServies"].Value = otherServices;
                report.Parameters["OutMedication"].Value = outMedication;
                report.Parameters["paymentsTotal"].Value = paymentsTotal;

                report.Parameters["IsAccountstatement"].Value = false;

                report.Parameters["id"].Value = curr.enterID;
                report.Parameters["totalN2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.totalC), "جنيه", "قرش") + " فقط لاغير ";
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

        private void FintdPatient_Execute(object sender, ParametrizedActionExecuteEventArgs e)
        {
            
        }

        private void AccountStatement_Execute(object sender, SimpleActionExecuteEventArgs e)
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
                decimal regolAraddmission = curr.Admissions.Where(p => p.Status == Admission.statusType.normal).Sum(p => p.roomStaySum);
                decimal icuAddmission = curr.Admissions.Where(p => p.Status != Admission.statusType.normal).Sum(p => p.roomStaySum);
                decimal supervision = curr.Admissions.Sum(p => p.MedicalSupervisionSum);
                decimal midcalCare = curr.Admissions.Sum(p => p.medicalCareSum);
                decimal outSuperviosn = curr.Admissions.Sum(p => p.ConsolationSum);
                decimal companion = curr.Admissions.Sum(p => p.companionSum);
                decimal pharmacy = curr.Admissions.Sum(p => p.medicationSum);
                decimal supplies = curr.Admissions.Sum(p => p.suppliesSum);
                decimal tests = curr.Admissions.Sum(p => p.testsSum);
                decimal xrayes = curr.Admissions.Sum(p => p.xraysSum);
                decimal edoscopy = curr.Admissions.Sum(p => p.endscopesSum);
                //decimal bloodServies = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Blood).Sum(x => x.price);
                //decimal otherServices = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Other).Sum(x => x.price);
                decimal outMedication = curr.Admissions.Sum(p => p.OutMedcationSum);
                decimal paymentsTotal = curr.PaymentsCollection.Sum(p => p.amount);

                report.Parameters["norStay"].Value = regolAraddmission;
                report.Parameters["icuStay"].Value = icuAddmission;
                report.Parameters["supervsion"].Value = supervision;
                report.Parameters["roomCare"].Value = midcalCare;
                report.Parameters["outSuperviosn"].Value = outSuperviosn;
                report.Parameters["Companion"].Value = companion;
                report.Parameters["Pharmacy"].Value = pharmacy;
                report.Parameters["Supplies"].Value = supplies;
                report.Parameters["Tests"].Value = tests;
                report.Parameters["Xrayes"].Value = xrayes;
                report.Parameters["edos"].Value = edoscopy;
                //report.Parameters["blood"].Value = bloodServies;
                //report.Parameters["otherServies"].Value = otherServices;
                report.Parameters["OutMedication"].Value = outMedication;
                report.Parameters["paymentsTotal"].Value = paymentsTotal;

                report.Parameters["IsAccountstatement"].Value = true;

                report.Parameters["id"].Value = curr.enterID;
                report.Parameters["totalN2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.totalC), "جنيه", "قرش") + " فقط لاغير ";
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

        private void AccountStatement_Execute_1(object sender, SimpleActionExecuteEventArgs e)
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
                decimal regolAraddmission = curr.Admissions.Where(p => p.Status == Admission.statusType.normal).Sum(p => p.roomStaySum);
                decimal icuAddmission = curr.Admissions.Where(p => p.Status != Admission.statusType.normal).Sum(p => p.roomStaySum);
                decimal supervision = curr.Admissions.Sum(p => p.MedicalSupervisionSum);
                decimal midcalCare = curr.Admissions.Sum(p => p.medicalCareSum);
                decimal outSuperviosn = curr.Admissions.Sum(p => p.ConsolationSum);
                decimal companion = curr.Admissions.Sum(p => p.companionSum);
                decimal pharmacy = curr.Admissions.Sum(p => p.medicationSum);
                decimal supplies = curr.Admissions.Sum(p => p.suppliesSum);
                decimal tests = curr.Admissions.Sum(p => p.testsSum);
                decimal xrayes = curr.Admissions.Sum(p => p.xraysSum);
                decimal edoscopy = curr.Admissions.Sum(p => p.endscopesSum);
                //decimal bloodServies = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Blood).Sum(x => x.price);
                //decimal otherServices = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Other).Sum(x => x.price);
                decimal outMedication = curr.Admissions.Sum(p => p.OutMedcationSum);
                decimal paymentsTotal = curr.PaymentsCollection.Sum(p => p.amount);

                report.Parameters["norStay"].Value = regolAraddmission;
                report.Parameters["icuStay"].Value = icuAddmission;
                report.Parameters["supervsion"].Value = supervision;
                report.Parameters["roomCare"].Value = midcalCare;
                report.Parameters["outSuperviosn"].Value = outSuperviosn;
                report.Parameters["Companin"].Value = companion;
                report.Parameters["Pharmacy"].Value = pharmacy;
                report.Parameters["Supplis"].Value = supplies;
                report.Parameters["Tests"].Value = tests;
                report.Parameters["Xrayes"].Value = xrayes;
                report.Parameters["edos"].Value = edoscopy;
                //report.Parameters["blood"].Value = bloodServies;
                //report.Parameters["otherServies"].Value = otherServices;
                report.Parameters["OutMedication"].Value = outMedication;
                report.Parameters["paymentsTotal"].Value = paymentsTotal;

                report.Parameters["enterID"].Value = curr.enterID;
                report.Parameters["patientName"].Value = curr.patient.FullName;
                report.Parameters["enterDate"].Value = curr.dateEnter;
                report.Parameters["leaveDate"].Value = curr.dateLeave;
                report.Parameters["IsAccountStatement"].Value = true;
                if (!curr.isDischarged)
                    report.Parameters["leaveDate"].Value = "مازال في الاقامة";
                report.Parameters["totalStay"].Value = curr.total;
                report.Parameters["totalN2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.totalC), "جنيه", "قرش") + " فقط لاغير ";

                PermissionPolicyUser user;
                if (SecuritySystem.CurrentUser != null)
                {
                    user = ObjectSpace.GetObjectByKey<PermissionPolicyUser>(SecuritySystem.CurrentUserId);
                    report.Parameters["user"].Value = user.UserName;
                }
            }

            report.ShowPreviewDialog();
        }

        private void PatinetDayReport_Execute(object sender, ParametrizedActionExecuteEventArgs e)
        {
            reports.StayTotalsDay report = new reports.StayTotalsDay();
            var paramValue = e.ParameterCurrentValue;
            Console.WriteLine(paramValue);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            if (paramValue != null)
            {
                DateTime startDate = Convert.ToDateTime(paramValue);
                var curr = View.CurrentObject as ReceptionDesk;
                //decimal regolAraddmission = curr.Admissions.Where(p => p.Status == Admission.statusType.normal).Sum(p => p.roomStaySum);
                //decimal icuAddmission = curr.Admissions.Where(p => p.Status != Admission.statusType.normal).Sum(p => p.roomStaySum);
                //decimal supervision = curr.Admissions.Where(p=> p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.MedicalSupervisionSum);
                //decimal midcalCare = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.medicalCareSum);
                decimal outSuperviosn = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.ConsolationSum);
                decimal companion = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.companionSum);
                decimal pharmacy = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.medicationSum);
                decimal supplies = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.suppliesSum);
                decimal tests = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.testsSum);
                decimal xrayes = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.xraysSum);
                decimal edoscopy = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.endscopesSum);
                //decimal bloodServies = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Blood).Sum(x => x.price);
                //decimal otherServices = ObjectSpace.GetObjects<ServiceDetails>().Where(p => p.Stay != null && p.Stay.reception == curr && p.Service.ServiceType == Service.ServiceTypes.Other).Sum(x => x.price);
                decimal outMedication = curr.Admissions.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.OutMedcationSum);
                //decimal paymentsTotal = curr.PaymentsCollection.Where(p => p.date >= startDate && p.date < startDate.AddDays(1)).Sum(p => p.amount);

                //report.Parameters["norStay"].Value = regolAraddmission;
                //report.Parameters["icuStay"].Value = icuAddmission;
               // report.Parameters["supervsion"].Value = supervision;
                //report.Parameters["roomCare"].Value = midcalCare;
                report.Parameters["outSuperviosn"].Value = outSuperviosn;
                report.Parameters["Companion"].Value = companion;
                report.Parameters["Pharmacy"].Value = pharmacy;
                report.Parameters["Supplies"].Value = supplies;
                report.Parameters["Tests"].Value = tests;
                report.Parameters["Xrayes"].Value = xrayes;
                report.Parameters["edos"].Value = edoscopy;
                //report.Parameters["blood"].Value = bloodServies;
                //report.Parameters["otherServies"].Value = otherServices;
                report.Parameters["OutMedication"].Value = outMedication;
                //report.Parameters["paymentsTotal"].Value = paymentsTotal;
                report.Parameters["startDate"].Value = startDate;
                report.Parameters["endDate"].Value = startDate.AddDays(1);
                report.Parameters["IsAccountstatement"].Value = true;

                report.Parameters["id"].Value = curr.enterID;
                report.Parameters["totalN2C"].Value = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(curr.totalC), "جنيه", "قرش") + " فقط لاغير ";
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
                report.ShowPreviewDialog();

            } 
            
        }
    }
}
