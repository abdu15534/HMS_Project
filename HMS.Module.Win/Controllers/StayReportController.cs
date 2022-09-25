using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.XtraReports.UI;
using System;
using System.Linq;
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
            //popupWindowShowAction1.CustomizePopupWindowParams += popupWindowShowAction1_CustomizePopupWindowParams;
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

        private void ApplyPackage_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curr = e.CurrentObject as PackageDetail;
            curr.ApplyAnyPackage();
            

            curr.Applyed = true;
            ObjectSpace.CommitChanges();
            //ReceptionDesk receptionDesk = ObjectSpace.GetObjects<ReceptionDesk>().Where(o => o == curr.Reciption).First();

            //var medications = ObjectSpace.GetObjects<StayMedications>().Where(o => o.Stay != null && o.Stay.reception == receptionDesk);
            //var supplies = ObjectSpace.GetObjects<StaySupplies>().Where(o => o.Stay != null && o.Stay.reception == receptionDesk);
            //var tests = ObjectSpace.GetObjects<TestDetails>().Where(o => o.admission != null && o.admission.reception == receptionDesk);
            //var xrays = ObjectSpace.GetObjects<XraysDetails>().Where(o => o.admission != null && o.admission.reception == receptionDesk);
            //var endoscpy = ObjectSpace.GetObjects<EndscopeDetails>().Where(o => o.admission != null && o.admission.reception == receptionDesk);
            //var servies = ObjectSpace.GetObjects<ServiceDetails>().Where(o => o.Stay != null && o.Stay.reception == receptionDesk);
            //var consultations = ObjectSpace.GetObjects<ConsultantDetails>().Where(o => o.Admission != null && o.Admission.reception == receptionDesk);
            //var companion = ObjectSpace.GetObjects<CompanionDetails>().Where(o => o.Stay != null && o.Stay.reception == receptionDesk);

            //decimal totalmedication = 0;
            //int normalNumDays = 0;
            //decimal normalCost = 0.0m;
            //int icuNumDays = 0;
            //decimal icuCost = 0.0m;
            //foreach (var i in curr.Reciption.Admissions)
            //{
            //    if(i.Status == Admission.statusType.normal)
            //    {
            //        normalNumDays += i.totalDays;
            //        normalCost = i.roomStayCost;
            //    }
            //    else
            //    {
            //        icuNumDays += i.totalDays;
            //        icuCost = i.roomStayCost;
            //    }

            //}
            //curr.ICuRoomTotal = Convert.ToDecimal(curr.Package.NumDaysICU) * icuCost;
            //curr.NormalRoomTotal = Convert.ToDecimal(curr.Package.NumDaysnorm) * normalCost;

            //foreach (StayMedications item in medications)
            //{
            //    Console.WriteLine(item.Medication.product.name);
            //    if (receptionDesk.medication > totalmedication)
            //    {
            //        totalmedication += item.total;
            //        if(totalmedication > curr.Package.medicineLimit)
            //        {
            //            var defrance = totalmedication - curr.Package.medicineLimit;
            //            var newquantity = defrance / item.price;
            //            totalmedication -= defrance;
            //            var newmedcation = ObjectSpace.CreateObject<StayMedications>();
            //            newmedcation.Medication = item.Medication;
            //            newmedcation.Stay = item.Stay;
            //            newmedcation.quantity = Convert.ToDouble(newquantity);
            //            //ObjectSpace.CommitChanges();
            //            //item.price -= defrance;
            //            if(item.quantity > 1)
            //            {
            //                item.quantity = item.quantity - Convert.ToDouble(newquantity);
            //            }
            //        }
            //        item.Package = curr.Package;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


            //decimal totalSupplies = 0;
            //foreach (StaySupplies item in supplies)
            //{
            //    Console.WriteLine(item.supplyProduct.product.name);
            //    if (curr.Package.SuppliesLimit >= totalSupplies)
            //    {
            //        totalSupplies += item.total;
            //        if (totalSupplies > curr.Package.SuppliesLimit)
            //        {
            //            var defrance = totalSupplies - curr.Package.SuppliesLimit;
            //            var newquantity = defrance / item.price;
            //            totalSupplies -= defrance;
            //            var newsupplie = ObjectSpace.CreateObject<StaySupplies>();
            //            newsupplie.supplyProduct = item.supplyProduct;
            //            newsupplie.Stay = item.Stay;
            //            newsupplie.quantity = Convert.ToDouble(newquantity);
            //            //ObjectSpace.CommitChanges();
            //            //item.price -= defrance;
            //            item.quantity = item.quantity - Convert.ToDouble(newquantity);
            //        }
            //        item.Package = curr.Package;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //decimal totaltests = 0;
            //foreach (TestDetails item in tests)
            //{
            //    Console.WriteLine(item.service.Name);
            //    if (curr.Package.TestsLimit > totaltests)
            //    {
            //        totaltests += item.price;
            //        if (totaltests > curr.Package.TestsLimit)
            //        {
            //            var defrance = totaltests - curr.Package.EndoscopyLimit;
            //            //var newquantity = defrance / item.price;
            //            //totaltests -= defrance;
            //            var newTest = ObjectSpace.CreateObject<TestDetails>();
            //            newTest.service = item.service;
            //            newTest.admission = item.admission;
            //            newTest.price = defrance;
            //            //ObjectSpace.CommitChanges();
            //            item.price -= defrance;
            //        }
            //        item.Package = curr.Package;
            //    }
            //}

            //decimal totalXrays = 0;
            //foreach (XraysDetails item in xrays)
            //{
            //    Console.WriteLine(item.service.Name);
            //    if (curr.Package.XrayLimit > totalXrays)
            //    {
            //        totalXrays += item.price;
            //        if (totalXrays > curr.Package.XrayLimit)
            //        {
            //            var defrance = totalXrays - curr.Package.EndoscopyLimit;
            //            //var newquantity = defrance / item.price;
            //            //totalXrays -= defrance;
            //            var newXray = ObjectSpace.CreateObject<XraysDetails>();
            //            newXray.service = item.service;
            //            newXray.admission = item.admission;
            //            newXray.price = defrance;
            //            //ObjectSpace.CommitChanges();
            //            item.price -= defrance;
            //        }
            //        item.Package = curr.Package;
            //    }
            //}

            //decimal totalEndoscpies = 0;
            //foreach (EndscopeDetails item in endoscpy)
            //{
            //    Console.WriteLine(item.service.Name);
            //    if (curr.Package.EndoscopyLimit > totalEndoscpies)
            //    {
            //        totalEndoscpies += item.price;
            //        if (totalEndoscpies > curr.Package.EndoscopyLimit)
            //        {
            //            var defrance = totalEndoscpies - curr.Package.EndoscopyLimit;
            //            //var newquantity = defrance / item.price;
            //            //totalEndoscpies -= defrance;
            //            var newEndo = ObjectSpace.CreateObject<EndscopeDetails>();
            //            newEndo.service = item.service;
            //            newEndo.admission = item.admission;
            //            newEndo.price = defrance;
            //            //ObjectSpace.CommitChanges();
            //            item.price -= defrance;
            //        }
            //        item.Package = curr.Package;
            //    }
            //}

            //decimal totalServies = 0;
            //foreach (ServiceDetails item in servies)
            //{
            //    Console.WriteLine(item.Service.Name);
            //    if (curr.Package.ServicesLimit > totalServies)
            //    {
            //        totalServies += item.price;
            //        if (totalServies > curr.Package.ServicesLimit)
            //        {
            //            var defrance = totalServies - curr.Package.EndoscopyLimit;
            //            //var newquantity = defrance / item.price;
            //            //totalServies -= defrance;
            //            var newService = ObjectSpace.CreateObject<ServiceDetails>();
            //            newService.Service = item.Service;
            //            newService.Stay = item.Stay;
            //            newService.price = defrance;
            //            //ObjectSpace.CommitChanges();
            //            item.price -= defrance;
            //        }
            //        item.Package = curr.Package;
            //    }
            //}
            //decimal totalConsul = 0;
            //foreach (ConsultantDetails item in consultations)
            //{
            //    Console.WriteLine(item.Consultant.Name);
            //    if (curr.Package.ConsolationLimit > totalConsul)
            //    {
            //        totalConsul += item.Price;
            //        if (totalConsul > curr.Package.ConsolationLimit)
            //        {
            //            var defrance = totalConsul - curr.Package.ConsolationLimit;
            //            //var newquantity = defrance / item.price;
            //            //totalServies -= defrance;
            //            var newConsul = ObjectSpace.CreateObject<ConsultantDetails>();
            //            newConsul.Consultant = item.Consultant;
            //            newConsul.Admission = item.Admission;
            //            newConsul.Price = defrance;
            //            newConsul.Date = item.Date;
            //            //ObjectSpace.CommitChanges();
            //            item.Price -= defrance;
            //        }
            //        item.Package = curr.Package;
            //    }
            //}
            //decimal totalCompanion = 0;
            //foreach (CompanionDetails item in companion)
            //{
            //    Console.WriteLine(item.Companion.FirstName);
            //    if (curr.Package.ServicesLimit > totalCompanion)
            //    {
            //        totalCompanion += item.price;
            //        if (totalCompanion > curr.Package.ServicesLimit)
            //        {
            //            var defrance = totalCompanion - curr.Package.ServicesLimit;
            //            //var newquantity = defrance / item.price;
            //            //totalServies -= defrance;
            //            var newCompanion = ObjectSpace.CreateObject<CompanionDetails>();
            //            newCompanion.Companion = item.Companion;
            //            newCompanion.Stay = item.Stay;
            //            newCompanion.price = defrance;
            //            newCompanion.date = item.date;
            //            //ObjectSpace.CommitChanges();
            //            item.price -= defrance;
            //        }
            //        item.Package = curr.Package;
            //    }
            //}
            //curr.Applyed = true;
            //ObjectSpace.CommitChanges();
        }

        private void DiscardPackage_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curr = e.CurrentObject as PackageDetail;

            curr.DiscardPackage();

            //ReceptionDesk receptionDesk = ObjectSpace.GetObjects<ReceptionDesk>().Where(o => o == curr.Reciption).First();
            //var medications = ObjectSpace.GetObjects<StayMedications>().Where(o => o.Stay != null && o.Stay.reception == receptionDesk && o.Package == curr.Package);
            //var supplies = ObjectSpace.GetObjects<StaySupplies>().Where(o => o.Stay != null && o.Stay.reception == receptionDesk && o.Package == curr.Package);
            //var tests = ObjectSpace.GetObjects<TestDetails>().Where(o => o.admission != null && o.admission.reception == receptionDesk && o.Package == curr.Package);
            //var xrays = ObjectSpace.GetObjects<XraysDetails>().Where(o => o.admission != null && o.admission.reception == receptionDesk && o.Package == curr.Package);
            //var endoscpy = ObjectSpace.GetObjects<EndscopeDetails>().Where(o => o.admission != null && o.admission.reception == receptionDesk && o.Package == curr.Package);
            //var servies = ObjectSpace.GetObjects<ServiceDetails>().Where(o => o.Stay != null && o.Stay.reception == receptionDesk && o.Package == curr.Package);
            //var consultations = ObjectSpace.GetObjects<ConsultantDetails>().Where(o => o.Admission != null && o.Admission.reception == receptionDesk && o.Package == curr.Package);
            //var companion = ObjectSpace.GetObjects<CompanionDetails>().Where(o => o.Stay != null && o.Stay.reception == receptionDesk && o.Package == curr.Package);
            //foreach (StayMedications item in medications)
            //{
            //    Console.WriteLine(item.Medication.product.name);
            //    item.Package = null;
            //}
            //foreach (StaySupplies item in supplies)
            //{
            //    Console.WriteLine(item.supplyProduct.product.name);
            //    item.Package = null;
            //}
            //foreach (TestDetails item in tests)
            //{
            //    Console.WriteLine(item.service.Name);
            //    item.Package = null;
            //}
            //foreach (XraysDetails item in xrays)
            //{
            //    Console.WriteLine(item.service.Name);
            //    item.Package = null;
            //}
            //foreach (EndscopeDetails item in endoscpy)
            //{
            //    Console.WriteLine(item.service.Name);
            //    item.Package = null;
            //}
            //foreach (ServiceDetails item in servies)
            //{
            //    Console.WriteLine(item.Service.Name);
            //    item.Package = null;
            //}

            //foreach (ConsultantDetails item in consultations)
            //{
            //    Console.WriteLine(item.Consultant.Name);
            //    item.Package = null;
            //}

            ////foreach (CompanionDetails item in companion)
            ////{
            ////    Console.WriteLine(item.Companion.FullName);
            ////    item.Package = null;
            ////}
            //ObjectSpace.CommitChanges();
            //curr.Applyed = false;
        }

        private void popupWindowShowAction1_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            
        }

        private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {



            var curr = View.CurrentObject as PackageDetail;
            IObjectSpace newObjectSpace = Application.CreateObjectSpace(typeof(PreSchdual));
            PreSchdual preS = newObjectSpace.CreateObject<PreSchdual>();
            preS.Patient = newObjectSpace.GetObjectByKey<Patient>(curr.Reciption.patient.ID);
            preS.PackageDetails = newObjectSpace.GetObjectByKey<PackageDetail>(curr.ID);
            preS.Status = "Test 123";
            //CollectionSourceBase collectionSource = Application.CreateDetailView(newObjectSpace, typeof(PreSchdual));
            var detailView = Application.CreateDetailView(newObjectSpace, preS);
            detailView.ViewEditMode = ViewEditMode.Edit;
            
            
            e.View = detailView;




            //var curr = View.CurrentObject as PackageDetail;
            //IObjectSpace newObjectSpace = Application.CreateObjectSpace(typeof(PreSchdual));

            //PreSchdual preS = ObjectSpace.CreateObject<PreSchdual>();
            //preS.Patient = curr.Reciption.patient;
            //preS.PackageDetails = curr;
            //preS.Status = "Test 123";
            //if (preS != null)
            //{
            //    DetailView createdView = Application.CreateDetailView(newObjectSpace, preS);
            //    createdView.ViewEditMode = ViewEditMode.Edit;
            //    e.View = createdView;
            //}
        }
    }
}
