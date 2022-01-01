using System;
using DevExpress.Xpo;
using System.Linq;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{

    public partial class PackageDetail
    {
        public PackageDetail(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == nameof(Package) && newValue != null)
            {
                this.price = ((Package)newValue).Price;
            }
        }
        

            public void ApplySurgeryPackage()
        {
            IQueryable<StayMedications> FirstMedications = Session.Query<StayMedications>().Where(p => p.Stay.reception != null && p.Stay.reception == Reciption && p.Medication.Inventory.Department.ID == 7 && p.Package == null);
            IQueryable<StaySupplies> FirstSupplies = Session.Query<StaySupplies>().Where(p => p.Stay.reception != null && p.Stay.reception == Reciption && p.supplyProduct.Inventory.Department.ID == 7 && p.Package == null);
            IQueryable<TestDetails> Firsttests = Session.Query<TestDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.service.ServiceType == Service.ServiceTypes.Surgeries && o.Package == null);
            IQueryable<XraysDetails> Firstxrays = Session.Query<XraysDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.service.ServiceType == Service.ServiceTypes.Surgeries && o.Package == null);
            IQueryable<EndscopeDetails> Firstendoscpy = Session.Query<EndscopeDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.service.ServiceType == Service.ServiceTypes.Surgeries && o.Package == null);
            IQueryable<ServiceDetails> Firstservies = Session.Query<ServiceDetails>().Where(o => o.Stay != null && o.Stay.reception == Reciption && o.Service.ServiceType == Service.ServiceTypes.Surgeries && o.Package == null);

            ApplyPackageToMedecations();
            ApplyPackageToMedicalSupplies();
            ApplyPackageToTests();
            ApplyPackageToXrays();
            ApplyPackageToEndos();
            ApplyPackageToServics();
            ApplyAnyPackage();
        }

        public void ApplyAnyPackage()
        {
            //IQueryable<StayMedications> Medications = Session.Query<StayMedications>().Where(p => p.Stay.reception != null && p.Stay.reception == Reciption && p.Package == null);
            //IQueryable<StaySupplies> Supplies = Session.Query<StaySupplies>().Where(p => p.Stay.reception != null && p.Stay.reception == Reciption && p.Package == null);
            //IQueryable<TestDetails> tests = Session.Query<TestDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == null);
            //IQueryable<XraysDetails> xrays = Session.Query<XraysDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == null);
            //IQueryable<EndscopeDetails> endoscpy = Session.Query<EndscopeDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == null);
            //IQueryable<ServiceDetails> servies = Session.Query<ServiceDetails>().Where(o => o.Stay != null && o.Stay.reception == Reciption && o.Package == null);

            ApplyPackageToMedecations();
            ApplyPackageToMedicalSupplies();
            ApplyPackageToTests();
            ApplyPackageToXrays();
            ApplyPackageToEndos();
            ApplyPackageToServics();
        }

        public void UpdateInfo()
        {
            
                //ApplySurgeryPackage();
            
          
                ApplyAnyPackage();
            
            
        }

        public void ApplyPackageToMedicalSupplies()
        {
            decimal applyedSupplies = Session.Query<StaySupplies>().Where(p => p.Stay.reception != null && p.Stay.reception == Reciption && p.Package == this.Package).Sum(p => p.total);
            IQueryable<StaySupplies> supplies = Session.Query<StaySupplies>().Where(p => p.Stay.reception != null && p.Stay.reception == Reciption && p.Package == null);
            decimal totalAmount = applyedSupplies;
            foreach (StaySupplies item in supplies)
            {
                if (this.Package.SuppliesLimit > totalAmount)
                {
                    totalAmount += item.total;
                    if (totalAmount > this.Package.SuppliesLimit)
                    {
                        var defrance = totalAmount - this.Package.SuppliesLimit;
                        defrance = Math.Abs(defrance);
                        var newquantity = defrance / item.price;
                        totalAmount -= defrance;
                        var newsupplie = new StaySupplies(Session);
                        newsupplie.supplyProduct = item.supplyProduct;
                        newsupplie.Stay = item.Stay;
                        newsupplie.quantity = Convert.ToDouble(newquantity);
                        //ObjectSpace.CommitChanges();
                        item.price = item.price;
                        item.quantity = item.quantity - Convert.ToDouble(newquantity);
                    }
                    item.Package = this.Package;
                }
                else
                {
                    break;
                }
            }
        }

        public void ApplyPackageToMedecations()
        {
            decimal applyedMedications = Session.Query<StayMedications>().Where(p => p.Stay.reception != null && p.Stay.reception == Reciption && p.Package == this.Package).Sum(p => p.total);
            IQueryable<StayMedications> medications = Session.Query<StayMedications>().Where(p => p.Stay.reception != null && p.Stay.reception == Reciption && p.Package == null);
            decimal totalmedication = applyedMedications;
            foreach (StayMedications item in medications)
            {
                if (this.Reciption.medication > totalmedication)
                {
                    totalmedication += item.total;
                    if (totalmedication > this.Package.medicineLimit)
                    {
                        var defrance = totalmedication - this.Package.medicineLimit;
                        defrance = Math.Abs(defrance);
                        var newquantity = defrance / item.price;
                        totalmedication -= defrance;
                        var newmedcation = new StayMedications(Session);
                        newmedcation.Medication = item.Medication;
                        newmedcation.Stay = item.Stay;
                        newmedcation.quantity = Convert.ToDouble(newquantity);
                        //ObjectSpace.CommitChanges();
                        item.price = item.price;
                        item.quantity = item.quantity - Convert.ToDouble(newquantity);
                        if (item.quantity > 1)
                        {
                        }
                    }
                    item.Package = this.Package;
                }
                else
                {
                    break;
                }
            }
        }

        public void ApplyPackageToTests()
        {
            IQueryable<TestDetails> testDetails = Session.Query<TestDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == null);
            decimal applyedTestDetails = Session.Query<TestDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == this.Package).Sum(p => p.price);
            decimal totaltests = applyedTestDetails;
            foreach (TestDetails item in testDetails)
            {
                if (this.Package.TestsLimit > totaltests)
                {
                    totaltests += item.price;
                    if (totaltests > this.Package.TestsLimit)
                    {
                        var defrance = totaltests - this.Package.EndoscopyLimit;
                        defrance = Math.Abs(defrance);
                        //var newquantity = defrance / item.price;
                        //totaltests -= defrance;
                        var newTest = new TestDetails(Session);
                        newTest.service = item.service;
                        newTest.admission = item.admission;
                        decimal oldPrice = Convert.ToDecimal(Math.Abs(item.price - defrance));
                        newTest.price = item.price - oldPrice;
                        //ObjectSpace.CommitChanges();
                        item.price = oldPrice;
                    }
                    item.Package = this.Package;
                }
            }
        }

        public void ApplyPackageToXrays()
        {
            IQueryable<XraysDetails> xrays = Session.Query<XraysDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == null);
            decimal applyedXrays = Session.Query<XraysDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == this.Package).Sum(p => p.price);

            decimal totalXrays = applyedXrays;
            foreach (XraysDetails item in xrays)
            {
                if (this.Package.XrayLimit > totalXrays)
                {
                    totalXrays += item.price;
                    if (totalXrays > this.Package.XrayLimit)
                    {
                        var defrance = totalXrays - this.Package.EndoscopyLimit;
                        defrance = Math.Abs(defrance);
                        //var newquantity = defrance / item.price;
                        //totalXrays -= defrance;
                        var newXray = new XraysDetails(Session);
                        newXray.service = item.service;
                        newXray.admission = item.admission;
                        decimal oldPrice = Convert.ToDecimal(Math.Abs(item.price - defrance));
                        newXray.price = item.price - oldPrice;
                        //ObjectSpace.CommitChanges();
                        item.price = oldPrice;
                    }
                    item.Package = this.Package;
                }
            }
        }
        public void ApplyPackageToEndos()
        {
            IQueryable<EndscopeDetails> endscopes = Session.Query<EndscopeDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == null);
            decimal applyedEndscopes = Session.Query<EndscopeDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == this.Package).Sum(p => p.price);
            decimal totalEndoscpies = applyedEndscopes;
            foreach (EndscopeDetails item in endscopes)
            {
                if (this.Package.EndoscopyLimit > totalEndoscpies)
                {
                    totalEndoscpies += item.price;
                    if (totalEndoscpies > this.Package.EndoscopyLimit)
                    {
                        var defrance = totalEndoscpies - this.Package.EndoscopyLimit;
                        defrance = Math.Abs(defrance);
                        //var newquantity = defrance / item.price;
                        //totalEndoscpies -= defrance;
                        var newEndo = new EndscopeDetails(Session);
                        newEndo.service = item.service;
                        newEndo.admission = item.admission;
                        decimal oldPrice = Convert.ToDecimal(Math.Abs(item.price - defrance));
                        newEndo.price = item.price - oldPrice;
                        //ObjectSpace.CommitChanges();
                        item.price = oldPrice;
                    }
                    item.Package = this.Package;
                }
            }
        }

        public void ApplyPackageToServics()
        {
            IQueryable<ServiceDetails> services = Session.Query<ServiceDetails>().Where(o => o.Stay != null && o.Stay.reception == Reciption && o.Package == null);
            decimal applyedServices = Session.Query<ServiceDetails>().Where(o => o.Stay != null && o.Stay.reception == Reciption && o.Package == this.Package).Sum(p => p.price);
            decimal totalServies = applyedServices;
            foreach (ServiceDetails item in services)
            {
                if (this.Package.ServicesLimit > totalServies)
                {
                    totalServies += item.price;
                    if (totalServies > this.Package.ServicesLimit)
                    {
                        var defrance = totalServies - this.Package.EndoscopyLimit;
                        defrance = Math.Abs(defrance);
                        //var newquantity = defrance / item.price;
                        //totalServies -= defrance;
                        var newService = new ServiceDetails(Session);
                        newService.Service = item.Service;
                        newService.Stay = item.Stay;
                        decimal oldPrice = Convert.ToDecimal(Math.Abs(item.price - defrance));
                        newService.price = item.price - oldPrice;
                        //ObjectSpace.CommitChanges();
                        item.price = oldPrice;
                    }
                    item.Package = this.Package;
                }
            }
        }

        public void DiscardPackage()
        {
            IQueryable<StayMedications> medications = Session.Query<StayMedications>().Where(o => o.Stay != null && o.Stay.reception == Reciption && o.Package == this.Package);
            IQueryable<StaySupplies> supplies = Session.Query<StaySupplies>().Where(o => o.Stay != null && o.Stay.reception == Reciption && o.Package == Package);
            IQueryable<TestDetails> tests = Session.Query<TestDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == Package);
            IQueryable<XraysDetails> xrays = Session.Query<XraysDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == this.Package);
            IQueryable<EndscopeDetails> endoscpy = Session.Query<EndscopeDetails>().Where(o => o.admission != null && o.admission.reception == Reciption && o.Package == this.Package);
            IQueryable<ServiceDetails> servies = Session.Query<ServiceDetails>().Where(o => o.Stay != null && o.Stay.reception == Reciption && o.Package == this.Package);

            foreach (StayMedications item in medications)
            {
                item.Package = null;
            }
            foreach (StaySupplies item in supplies)
            {
                item.Package = null;
            }
            foreach (TestDetails item in tests)
            {
                item.Package = null;
            }
            foreach (XraysDetails item in xrays)
            {
                item.Package = null;
            }
            foreach (EndscopeDetails item in endoscpy)
            {
                item.Package = null;
            }
            foreach (ServiceDetails item in servies)
            {
                item.Package = null;
            }

            this.Applyed = false;
            Session.CommitTransaction();
            

        }
    }
}
