using Bogus;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Dashboards;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Xpo;
using HMS.Module.InitialData;
using HMS.Module.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using XafDataModel.Module.BusinessObjects.test2;
using static XafDataModel.Module.BusinessObjects.test2.Patient;
using Account = XafDataModel.Module.BusinessObjects.test2.Account;
using MasterAccount = XafDataModel.Module.BusinessObjects.test2.MasterAccount;

namespace HMS.Module.DatabaseUpdate
{


    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    public class Updater : ModuleUpdater
    {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion)
        {
        }
        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();
            //string name = "MyName";
            //DomainObject1 theObject = ObjectSpace.FindObject<DomainObject1>(CriteriaOperator.Parse("Name=?", name));
            //if(theObject == null) {
            //    theObject = ObjectSpace.CreateObject<DomainObject1>();
            //    theObject.Name = name;
            //}

            DashboardsModule.AddDashboardData<DashboardData>(
                 ObjectSpace, "Finance report", Resources.MainDashboard);

            DashboardsModule.AddDashboardData<DashboardData>(
              ObjectSpace, "Sections report", Resources.HospitalSections);


            DashboardsModule.AddDashboardData<DashboardData>(
              ObjectSpace, "Payments report", Resources.paymentDashboard);

            //DashboardsModule.AddDashboardData<DashboardData>(
            //  ObjectSpace, "Inventory report", Resources.);


            PermissionPolicyUser userAdmin = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Admin"));
            if (userAdmin == null)
            {
                userAdmin = ObjectSpace.CreateObject<PermissionPolicyUser>();
                userAdmin.UserName = "Admin";
                // Set a password if the standard authentication type is used
                userAdmin.SetPassword("98765");
            }
            PermissionPolicyUser Manager1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "M_Entisar"));
            if (Manager1 == null)
            {
                Manager1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Manager1.UserName = "M_Entisar";
                Manager1.SetPassword("941999");
            }

            PermissionPolicyUser Manager2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Dr_Haitham"));
            if (Manager2 == null)
            {
                Manager2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Manager2.UserName = "Dr_Haitham";
                Manager2.SetPassword("564738");
            }


            PermissionPolicyUser Cashier1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Cashier1"));
            if (Cashier1 == null)
            {
                Cashier1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Cashier1.UserName = "Cashier1";
                Cashier1.SetPassword("Cashier123");
            }

            PermissionPolicyUser Cashier2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Cashier2"));
            if (Cashier2 == null)
            {
                Cashier2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Cashier2.UserName = "Cashier2";
                Cashier2.SetPassword("Cashier567");
            }

            PermissionPolicyUser AdmissionDesk1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "AdmissionDesk1"));
            if (AdmissionDesk1 == null)
            {
                AdmissionDesk1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                AdmissionDesk1.UserName = "AdmissionDesk1";
                AdmissionDesk1.SetPassword("AdmissionDesk345");
            }

            PermissionPolicyUser AdmissionDesk2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "AdmissionDesk2"));
            if (AdmissionDesk2 == null)
            {
                AdmissionDesk2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                AdmissionDesk2.UserName = "AdmissionDesk2";
                AdmissionDesk2.SetPassword("AdmissionDesk678");
            }

            PermissionPolicyUser ReceptionDesk1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "ReceptionDesk1"));
            if (ReceptionDesk1 == null)
            {
                ReceptionDesk1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                ReceptionDesk1.UserName = "ReceptionDesk1";
                ReceptionDesk1.SetPassword("ReceptionDesk234");
            }

            PermissionPolicyUser ReceptionDesk2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "ReceptionDesk2"));
            if (ReceptionDesk2 == null)
            {
                ReceptionDesk2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                ReceptionDesk2.UserName = "ReceptionDesk2";
                ReceptionDesk2.SetPassword("ReceptionDesk789");
            }

            PermissionPolicyUser Pharmacy1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Pharmacy1"));
            if (Pharmacy1 == null)
            {
                Pharmacy1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Pharmacy1.UserName = "Pharmacy1";
                Pharmacy1.SetPassword("Pharmacy567");
            }

            PermissionPolicyUser Pharmacy2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Pharmacy2"));
            if (Pharmacy2 == null)
            {
                Pharmacy2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Pharmacy2.UserName = "Pharmacy2";
                Pharmacy2.SetPassword("Pharmacy678");
            }

            PermissionPolicyUser Inventory1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Inventory1"));
            if (Inventory1 == null)
            {
                Inventory1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Inventory1.UserName = "Inventory1";
                Inventory1.SetPassword("Inventory345");
            }

            PermissionPolicyUser Inventory2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Inventory2"));
            if (Inventory2 == null)
            {
                Inventory2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Inventory2.UserName = "Inventory2";
                Inventory2.SetPassword("Inventory789");
            }

            PermissionPolicyUser Lab1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Lab1"));
            if (Lab1 == null)
            {
                Lab1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Lab1.UserName = "Lab1";
                Lab1.SetPassword("Lab234");
            }
            PermissionPolicyUser Lab2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Lab2"));
            if (Lab2 == null)
            {
                Lab2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Lab2.UserName = "Lab2";
                Lab2.SetPassword("Lab456");
            }
            PermissionPolicyUser XRay1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "XRay1"));
            if (XRay1 == null)
            {
                XRay1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                XRay1.UserName = "Xray1";
                XRay1.SetPassword("xray678");
            }
            PermissionPolicyUser XRay2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "XRay2"));
            if (XRay2 == null)
            {
                XRay2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                XRay2.UserName = "Xray2";
                XRay2.SetPassword("XRay345");
            }
            PermissionPolicyUser Endoscopy1 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Endoscopy1"));
            if (Endoscopy1 == null)
            {
                Endoscopy1 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Endoscopy1.UserName = "Endoscopy1";
                Endoscopy1.SetPassword("Endoscopy678");
            }
            PermissionPolicyUser Endoscopy2 = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Endoscopy2"));
            if (Endoscopy2 == null)
            {
                Endoscopy2 = ObjectSpace.CreateObject<PermissionPolicyUser>();
                Endoscopy2.UserName = "Endoscopy2";
                Endoscopy2.SetPassword("Endoscopy789");
            }

            PermissionPolicyRole ManagerRole = CreateManagerRole();
            Manager1.Roles.Add(ManagerRole);
            Manager2.Roles.Add(ManagerRole);

            PermissionPolicyRole CashierRole = CreateCashierRole();
            Cashier1.Roles.Add(CashierRole);
            Cashier2.Roles.Add(CashierRole);

            PermissionPolicyRole AdmissionDeskRole = CreateAdmissionDeskRole();
            AdmissionDesk1.Roles.Add(AdmissionDeskRole);
            AdmissionDesk2.Roles.Add(AdmissionDeskRole);

            PermissionPolicyRole ReceptionDeskRole = CreateReceptionRole();
            ReceptionDesk1.Roles.Add(ReceptionDeskRole);
            ReceptionDesk2.Roles.Add(ReceptionDeskRole);

            PermissionPolicyRole PharmacyRole = CreatePharmacyRole();
            Pharmacy1.Roles.Add(PharmacyRole);
            Pharmacy2.Roles.Add(PharmacyRole);

            PermissionPolicyRole InventoryRole = CreateInventoryRole();
            Inventory1.Roles.Add(InventoryRole);
            Inventory2.Roles.Add(InventoryRole);

            PermissionPolicyRole LabRole = CreateLabRole();
            Lab1.Roles.Add(LabRole);
            Lab2.Roles.Add(LabRole);

            PermissionPolicyRole EndoscopyRole = CreateEndosocopyRole();
            Endoscopy1.Roles.Add(EndoscopyRole);
            Endoscopy2.Roles.Add(EndoscopyRole);

            PermissionPolicyRole XRayRole = CreateXRayRole();
            XRay1.Roles.Add(XRayRole);
            XRay2.Roles.Add(XRayRole);





            // If a role with the Administrators name doesn't exist in the database, create this role
            PermissionPolicyRole adminRole = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Administrators"));
            if (adminRole == null)
            {
                adminRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
                adminRole.Name = "Administrators";
            }
            adminRole.IsAdministrative = true;
            //// If a role with the Administrators name doesn't exist in the database, create this role
            //PermissionPolicyRole adminRole = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Administrators"));
            //if (adminRole == null)
            //{
            //    adminRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
            //    adminRole.Name = "Administrators";
            //}
            //adminRole.IsAdministrative = true;
            userAdmin.Roles.Add(adminRole);


            if (ObjectSpace.GetObjectsCount(typeof(SuppliesSettings), null) == 0)
            {
                var setting = ObjectSpace.CreateObject<SuppliesSettings>();
                setting.FromNotTo4 = 3;
                setting.From5To9 = 2;
                setting.From10To90 = 1.5;
                setting.From91To149 = 1.3;
                setting.From150ToAll = 1.25;

            }
            ObjectSpace.CommitChanges();

            if (ObjectSpace.GetObjectsCount(typeof(InPatientSettings), null) == 0)
            {
                var setting = ObjectSpace.CreateObject<InPatientSettings>();
                setting.ServiceRate = 15;
                setting.StampPrice = 20m;
                

            }
            ObjectSpace.CommitChanges();

            //Emploees Sections
            if (ObjectSpace.GetObjectsCount(typeof(Section), null) == 0)
            {
                var section1 = ObjectSpace.CreateObject<Section>();
                section1.name = "الادارة";

                var section2 = ObjectSpace.CreateObject<Section>();
                section2.name = "الحسابات";

                var section3 = ObjectSpace.CreateObject<Section>();
                section3.name = "المخازن";

                var section4 = ObjectSpace.CreateObject<Section>();
                section4.name = "الامن و الحراسة";

                var section5 = ObjectSpace.CreateObject<Section>();
                section5.name = "التمريض";

                var section6 = ObjectSpace.CreateObject<Section>();
                section6.name = "الاطباء";

                ObjectSpace.CommitChanges();
            }

            //Employees Professions
            if (ObjectSpace.GetObjectsCount(typeof(Job), null) == 0)
            {
                var Job1 = ObjectSpace.CreateObject<Job>();
                Job1.name = "مدير";

                var Job2 = ObjectSpace.CreateObject<Job>();
                Job2.name = "محاسب";

                var Job3 = ObjectSpace.CreateObject<Job>();
                Job3.name = "اداري";

                var Job4 = ObjectSpace.CreateObject<Job>();
                Job4.name = "عامل";

                var Job5 = ObjectSpace.CreateObject<Job>();
                Job5.name = "ممرض";

                var Job6 = ObjectSpace.CreateObject<Job>();
                Job6.name = "طبيب";

                var Job7 = ObjectSpace.CreateObject<Job>();
                Job7.name = "سائق";

                ObjectSpace.CommitChanges();
            }

            //if (ObjectSpace.GetObjectsCount(typeof(Employee), null) == 0)
            //{
            //    var employee1 = ObjectSpace.CreateObject<Employee>();
            //    employee1.FirstName = "احمد";
            //    employee1.LastName = "خالد";
            //    employee1.section = ObjectSpace.FindObject<Section>(new BinaryOperator("name", "الادارة"));
            //    employee1.job = ObjectSpace.FindObject<Job>(new BinaryOperator("name", "مدير"));
            //    employee1.NationalID = "26106162100875";
            //    employee1.daysOfWork = 30;
            //    employee1.hoursOfDay = 8;
            //    employee1.baseSalary = 6000;
            //    employee1.incentive = 250;
            //    employee1.housing = 600;
            //    employee1.transportation = 400;
            //    employee1.socialInsurane = 200;
            //    employee1.medicine = 250;
            //    employee1.others = 120;
            //    employee1.insuranceDeduction = 165;
            //    employee1.otherDeductions = 90;

            //    var employee2 = ObjectSpace.CreateObject<Employee>();
            //    employee2.FirstName = "مصطفي";
            //    employee2.LastName = "عبدالله";
            //    employee2.section = ObjectSpace.FindObject<Section>(new BinaryOperator("name", "الحسابات"));
            //    employee2.job = ObjectSpace.FindObject<Job>(new BinaryOperator("name", "محاسب"));
            //    employee2.NationalID = "25008183100925";
            //    employee2.daysOfWork = 30;
            //    employee2.hoursOfDay = 8;
            //    employee2.baseSalary = 4000;
            //    employee2.incentive = 300;
            //    employee2.housing = 300;
            //    employee2.transportation = 300;
            //    employee2.socialInsurane = 150;
            //    employee2.medicine = 200;
            //    employee2.others = 90;
            //    employee2.insuranceDeduction = 115;
            //    employee2.otherDeductions = 60;

            //    var employee3 = ObjectSpace.CreateObject<Employee>();
            //    employee3.FirstName = "محمد";
            //    employee3.LastName = "اسماعيل";
            //    employee3.section = ObjectSpace.FindObject<Section>(new BinaryOperator("name", "التمريض"));
            //    employee3.job = ObjectSpace.FindObject<Job>(new BinaryOperator("name", "ممرض"));
            //    employee3.NationalID = "28624186981145";
            //    employee3.daysOfWork = 30;
            //    employee3.hoursOfDay = 10;
            //    employee3.baseSalary = 2500;
            //    employee3.incentive = 220;
            //    employee3.housing = 350;
            //    employee3.transportation = 250;
            //    employee3.socialInsurane = 120;
            //    employee3.medicine = 180;
            //    employee3.others = 60;
            //    employee3.insuranceDeduction = 125;
            //    employee3.otherDeductions = 80;

            //    var employee4 = ObjectSpace.CreateObject<Employee>();
            //    employee4.FirstName = "ابراهيم";
            //    employee4.LastName = "محمود";
            //    employee4.section = ObjectSpace.FindObject<Section>(new BinaryOperator("name", "الاطباء"));
            //    employee4.job = ObjectSpace.FindObject<Job>(new BinaryOperator("name", "طبيب"));
            //    employee4.NationalID = "28624186981145";
            //    employee4.daysOfWork = 30;
            //    employee4.hoursOfDay = 8;
            //    employee4.baseSalary = 5000;
            //    employee4.incentive = 250;
            //    employee4.housing = 500;
            //    employee4.transportation = 300;
            //    employee4.socialInsurane = 145;
            //    employee4.medicine = 160;
            //    employee4.others = 80;
            //    employee4.insuranceDeduction = 150;
            //    employee4.otherDeductions = 70;

            //    var employee5 = ObjectSpace.CreateObject<Employee>();
            //    employee5.FirstName = "رضا";
            //    employee5.LastName = "ممدوح";
            //    employee5.section = ObjectSpace.FindObject<Section>(new BinaryOperator("name", "المخازن"));
            //    employee5.job = ObjectSpace.FindObject<Job>(new BinaryOperator("name", "عامل"));
            //    employee5.NationalID = "22135397982285";
            //    employee5.daysOfWork = 30;
            //    employee5.hoursOfDay = 12;
            //    employee5.baseSalary = 2500;
            //    employee5.incentive = 270;
            //    employee5.housing = 450;
            //    employee5.transportation = 200;
            //    employee5.socialInsurane = 145;
            //    employee5.medicine = 150;
            //    employee5.others = 65;
            //    employee5.insuranceDeduction = 120;
            //    employee5.otherDeductions = 55;

            //    ObjectSpace.CommitChanges();

            //}



            //ProductUnit
            if (ObjectSpace.GetObjectsCount(typeof(ProductUnit), null) == 0)
            {
                var unit1 = ObjectSpace.CreateObject<ProductUnit>();
                unit1.unit = "كرتونة";

                var unit2 = ObjectSpace.CreateObject<ProductUnit>();
                unit2.unit = "قطعة";

                var unit3 = ObjectSpace.CreateObject<ProductUnit>();
                unit3.unit = "علبة";

                var unit4 = ObjectSpace.CreateObject<ProductUnit>();
                unit4.unit = "عدد";

                var unit5 = ObjectSpace.CreateObject<ProductUnit>();
                unit5.unit = "دستة";

                var unit6 = ObjectSpace.CreateObject<ProductUnit>();
                unit6.unit = "زجاجة";

                var unit7 = ObjectSpace.CreateObject<ProductUnit>();
                unit7.unit = "انبوبة";

                var unit8 = ObjectSpace.CreateObject<ProductUnit>();
                unit8.unit = "حقنة";

                var unit9 = ObjectSpace.CreateObject<ProductUnit>();
                unit9.unit = "أمبول";

                var unit10 = ObjectSpace.CreateObject<ProductUnit>();
                unit10.unit = "وحدة";

            }

            //Accounts
            if (ObjectSpace.GetObjectsCount(typeof(MasterAccount), null) == 0)
            {
                List<InitialData.MasterAccount> masterAccounts = new InitialData.MasterAccount().InitialData();

                foreach (InitialData.MasterAccount item in masterAccounts)
                {
                    var acc = ObjectSpace.CreateObject<MasterAccount>();
                    acc.accountNumber = item.accountNumber;
                    acc.accountName = item.accountName;
                    acc.AccountClassification = item.classification;
                }
                ObjectSpace.CommitChanges();


                List<InitialData.SubAccount> subAccounts = new InitialData.SubAccount().InitialData();

                foreach (InitialData.SubAccount item in subAccounts)
                {
                    var acc = ObjectSpace.CreateObject<XafDataModel.Module.BusinessObjects.test2.SubAccount>();
                    acc.accountNumber = item.accountNumber;
                    acc.accountName = item.accountName;
                    acc.masterAccount = ObjectSpace.GetObjectByKey<MasterAccount>(item.masterAccountID);
                }
                ObjectSpace.CommitChanges();

                List<InitialData.Account> Accounts = new InitialData.Account().InitialData();

                foreach (InitialData.Account item in Accounts)
                {
                    var acc = ObjectSpace.CreateObject<XafDataModel.Module.BusinessObjects.test2.Account>();
                    acc.accountNumber = item.accountNumber;
                    acc.accountName = item.accountName;
                    acc.SubAccount = ObjectSpace.GetObjectByKey<XafDataModel.Module.BusinessObjects.test2.SubAccount>(item.subAccountID);
                }
                ObjectSpace.CommitChanges();

            }

            Safe safe = ObjectSpace.FindObject<Safe>(new BinaryOperator("name", "Safe"));
            if (safe == null)
            {
                safe = ObjectSpace.CreateObject<Safe>();
                safe.name = "Safe";
            }

            if (ObjectSpace.GetObjectsCount(typeof(Inventory), null) == 0)
            {
                var pharmacy = ObjectSpace.CreateObject<Inventory>();
                pharmacy.InventoryType = Inventory.InventoryTypes.Pharmacy;
                pharmacy.Name = "Pharmacy";

                var stock = ObjectSpace.CreateObject<Inventory>();
                stock.InventoryType = Inventory.InventoryTypes.Stock;
                stock.Name = "Stock";
            }

            ObjectSpace.CommitChanges();

            //if (ObjectSpace.GetObjectsCount(typeof(Product), null) == 0)
            //{
            //    List<product> supplies = new product().initialStockProductData();
            //    List<product> medications = new product().initialPharmacyProductData();

            //    foreach (var item in supplies)
            //    {
            //        var product1 = ObjectSpace.CreateObject<Product>();
            //        product1.name = item.Name;
            //        product1.purchasingPrice = item.purchasingPrice;
            //        product1.sellingPrice = item.sellingPrice;

            //        //Inventory stock = ObjectSpace.FindObject<Inventory>(new BinaryOperator("Name", "Stock"));

            //        //var stockProduct = ObjectSpace.CreateObject<StockProduct>();
            //        //stockProduct.product = product1;
            //        //stockProduct.Inventory = stock;
            //        //stockProduct.firstUnitQuantity = (Int32)new Random(Guid.NewGuid().GetHashCode()).Next(300, 500);
            //    }

            //    foreach (var item in medications)
            //    {
            //        var product1 = ObjectSpace.CreateObject<Product>();
            //        product1.name = item.Name;
            //        product1.purchasingPrice = item.purchasingPrice;
            //        product1.sellingPrice = item.sellingPrice;

            //        //Inventory pharmacy = ObjectSpace.FindObject<Inventory>(new BinaryOperator("Name", "Pharmacy"));

            //        //var stockProduct = ObjectSpace.CreateObject<StockProduct>();
            //        //stockProduct.product = product1;
            //        //stockProduct.Inventory = pharmacy;
            //        //stockProduct.firstUnitQuantity= (Int32)new Random().Next(300, 500);
            //    }
            //    ObjectSpace.CommitChanges();
            //}

            //Generate Spendings fakeData
            if (ObjectSpace.GetObjectsCount(typeof(SpendingsCategory), null) == 0)
            {
                var categories = new List<string> { "كهرباء", "مرتبات", "مصاريف عيادات", "هالك" };

                foreach (string item in categories)
                {
                    var cat = ObjectSpace.CreateObject<SpendingsCategory>();
                    cat.name = item;
                }

                ObjectSpace.CommitChanges();

                for (int i = 12; i > 0; i--)
                {
                    var electric = ObjectSpace.CreateObject<Spendings>();
                    electric.category = ObjectSpace.FindObject<SpendingsCategory>(new BinaryOperator("name", "كهرباء"));
                    electric.date = DateTime.Now.AddMonths(-i);
                    electric.amount = new Random(Guid.NewGuid().GetHashCode()).Next(7000, 9000);

                    var salaries = ObjectSpace.CreateObject<Spendings>();
                    salaries.category = ObjectSpace.FindObject<SpendingsCategory>(new BinaryOperator("name", "مرتبات"));
                    salaries.date = DateTime.Now.AddMonths(-i);
                    salaries.amount = new Random(Guid.NewGuid().GetHashCode()).Next(45000, 55000);


                    var clincs = ObjectSpace.CreateObject<Spendings>();
                    clincs.category = ObjectSpace.FindObject<SpendingsCategory>(new BinaryOperator("name", "مصاريف عيادات"));
                    clincs.date = DateTime.Now.AddMonths(-i);
                    clincs.amount = new Random(Guid.NewGuid().GetHashCode()).Next(6000, 8000);


                    var waste = ObjectSpace.CreateObject<Spendings>();
                    waste.category = ObjectSpace.FindObject<SpendingsCategory>(new BinaryOperator("name", "هالك"));
                    waste.date = DateTime.Now.AddMonths(-i);
                    waste.amount = new Random(Guid.NewGuid().GetHashCode()).Next(3000, 5000);

                }

            }

            if (ObjectSpace.GetObjectsCount(typeof(Category), null) == 0)
            {

                List<CatagoryInitialData> catagories = new CatagoryInitialData().CatagoryData();

                foreach (var item in catagories)
                {
                    var category = ObjectSpace.CreateObject<Category>();
                    category.name = item.name;

                }

                ObjectSpace.CommitChanges();
            }

            if (ObjectSpace.GetObjectsCount(typeof(Clinc), null) == 0)
            {

                List<ClincData> clincs = new ClincData().ClinicInitialData();

                foreach (var item in clincs)
                {
                    var clinic = ObjectSpace.CreateObject<Clinc>();
                    clinic.id = item.ID;
                    clinic.Name = item.name;
                }

                ObjectSpace.CommitChanges();
            }

            //    Clinc clinic1 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة القلب"));
            //    Clinc clinic2 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة النسا والتوليد"));
            //    Clinc clinic3 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة أمراض الذكورة"));
            //    Clinc clinic4 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة الأمراض الجلدية"));
            //    Clinc clinic5 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة المسالك البولية"));
            //    Clinc clinic6 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة الأنف والأذن"));
            //    Clinc clinic7 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة المخ والأعصاب"));
            //    Clinc clinic8 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "قسم التخدير"));
            //    Clinc clinic9 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة الأوعية الدموية"));
            //    Clinc clinic10 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة الرمد"));
            //    Clinc clinic11 = ObjectSpace.FindObject<Clinc>(CriteriaOperator.Parse("[Name] = ?", "عيادة الأسنان"));

            //if (ObjectSpace.GetObjectsCount(typeof(ClinicService), null) == 0)
            //{

            //    List<ClinicServiceInitialData> clincServices = new ClinicServiceInitialData().CardiacClinicServices();

            //    foreach (var item in clincServices)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic1;

            //    }

            //    List<ClinicServiceInitialData> clincServices2 = new ClinicServiceInitialData().OBGYNClinicServices();

            //    foreach (var item in clincServices2)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic2;

            //    }

            //    List<ClinicServiceInitialData> clincServices3 = new ClinicServiceInitialData().AndrologyClinicServices();

            //    foreach (var item in clincServices3)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic3;

            //    }

            //    List<ClinicServiceInitialData> clincServices4 = new ClinicServiceInitialData().DermatologyClinicServices();

            //    foreach (var item in clincServices4)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic4;

            //    }

            //    List<ClinicServiceInitialData> clincServices5 = new ClinicServiceInitialData().UrologyClinicServices();

            //    foreach (var item in clincServices5)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic5;

            //    }

            //    List<ClinicServiceInitialData> clincServices6 = new ClinicServiceInitialData().EarNoseAudiologyClinicServices();

            //    foreach (var item in clincServices6)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic6;

            //    }

            //    List<ClinicServiceInitialData> clincServices7 = new ClinicServiceInitialData().NeurologyClinicServices();

            //    foreach (var item in clincServices7)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic7;

            //    }

            //    List<ClinicServiceInitialData> clincServices8 = new ClinicServiceInitialData().AnesthesiologyClinicServices();

            //    foreach (var item in clincServices8)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic8;

            //    }

            //    List<ClinicServiceInitialData> clincServices9 = new ClinicServiceInitialData().VascularClinicServices();

            //    foreach (var item in clincServices9)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic9;

            //    }

            //    List<ClinicServiceInitialData> clincServices10 = new ClinicServiceInitialData().OphthalmicClinicServices();

            //    foreach (var item in clincServices10)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic10;

            //    }

            //    List<ClinicServiceInitialData> clincServices11 = new ClinicServiceInitialData().DentalClinicServices();

            //    foreach (var item in clincServices11)
            //    {
            //        var clinicservice = ObjectSpace.CreateObject<ClinicService>();
            //        clinicservice.ID = item.ClinicServicesID;
            //        clinicservice.Name = item.ClinicServicesName;
            //        clinicservice.Price = item.Price;
            //        clinicservice.Clinic = clinic11;

            //    }

            //    ObjectSpace.CommitChanges();
            //}

            if (ObjectSpace.GetObjectsCount(typeof(Room), null) == 0)
            {
                List<RoomData> Rooms = new RoomData().RoomInitialData();

                foreach (var item in Rooms)
                {
                    var room = ObjectSpace.CreateObject<Room>();
                    room.number = item.number;
                    room.roomCost = item.roomCost;
                    room.careCost = item.roomCare;
                    room.supervisionCost = item.roomSupervision;
                    room.Status = item.status;
                    if (room.Status == Admission.statusType.ICU)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            var bed = ObjectSpace.CreateObject<bed>();
                            bed.number = (i + 1).ToString();
                            bed.room = room;
                            bed.isAvailable = true;

                        }
                        ObjectSpace.CommitChanges();
                    }
                    if (room.Status == Admission.statusType.covid)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            var bed = ObjectSpace.CreateObject<bed>();
                            bed.number = (i + 1).ToString();
                            bed.room = room;
                            bed.isAvailable = true;

                        }
                        ObjectSpace.CommitChanges();
                    }
                    else if (room.Status == Admission.statusType.normal)
                    {
                        var bed = ObjectSpace.CreateObject<bed>();
                        bed.number = (1).ToString();
                        bed.room = room;
                        bed.isAvailable = true;
                        ObjectSpace.CommitChanges();
                    }
                }

                ObjectSpace.CommitChanges();
            }

            if (ObjectSpace.GetObjectsCount(typeof(Service), null) == 0)
            {
                List<ServicesInitialData> services = new ServicesInitialData().services();
                int bloodid = 19000;
                int otherid = 18000;
                foreach (ServicesInitialData item in services)
                {
                    var service = ObjectSpace.CreateObject<Service>();
                    if (item.serviceType == ServiceTypes.Other)
                    {
                        otherid += 1;
                        service.ID = otherid;
                    }
                    else
                    {
                        bloodid += 1;
                        service.ID = bloodid;
                    }
                    service.Name = item.name;
                    service.Price = item.price;
                    service.ServiceType = (Service.ServiceTypes)item.serviceType;

                }
                ObjectSpace.CommitChanges();
            }


            if (ObjectSpace.GetObjectsCount(typeof(PurchasingOrder), null) == 0 && ObjectSpace.GetObjectsCount(typeof(Product), null) != 0)
            {
                var supplier = ObjectSpace.FindObject<Account>(CriteriaOperator.Parse("[accountName] = ?", "مخزون بضاعة اول المدة"));

                //var fakeSuppliers = new Faker<Supplier>("ar")
                //   .CustomInstantiator(f => new Supplier(((XPObjectSpace)ObjectSpace).Session))
                //   .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                //   .RuleFor(o => o.LastName, f => f.Name.LastName())
                //   .RuleFor(o => o.Birthday, f => f.Date.Recent(350))
                //   .RuleFor(o => o.Email, f => f.Internet.Email());

                //var suppliers = fakeSuppliers.Generate(40);
                var Order = ObjectSpace.CreateObject<PurchasingOrder>();
                Order.supplierAccount = supplier;
                Order.inventory = ObjectSpace.FindObject<Inventory>(CriteriaOperator.Parse("[Name] = ?", "Pharmacy"));
                Order.paymentAccount = ObjectSpace.FindObject<Account>(CriteriaOperator.Parse("[accountName] = ?", "مخزون بضاعة اول المدة"));

                List<Product> supplies2 = ObjectSpace.GetObjects<Product>().Where(o => o.category.name == "مستهلكات").ToList();
                List<Product> medications2 = ObjectSpace.GetObjects<Product>().Where(o => o.category.name == "دواء" || o.category.name == "غير دواء").ToList();

                int i = 0;
                foreach (var item in medications2.ToList())
                {
                    PurchasingOrderDetail purchase = ObjectSpace.CreateObject<PurchasingOrderDetail>();
                    Product product = item;
                    //ObjectSpace.FindObject<Product>(CriteriaOperator.Parse("[name] = ? AND [sellingPrice] = ?", medications2[i].name.ToString(), medications2[i].sellingPrice.ToString()));
                    purchase.product = product;
                    purchase.quantity = (Int32)new Random().Next(300, 500);
                    purchase.price = product.sellingPrice;
                    purchase.Discount = (Int32)new Random().Next(5, 30);
                    Console.WriteLine(purchase.price.ToString() + " updater");
                    i++;
                    //purchasings.Add(purchase);
                    Order.PurchasingOrderDetails.Add(purchase);

                }
                //Order.OrderConfirm(true);

                var Order2 = ObjectSpace.CreateObject<PurchasingOrder>();
                Order2.supplierAccount = supplier;
                Order2.inventory = ObjectSpace.FindObject<Inventory>(CriteriaOperator.Parse("[Name] = ?", "Stock"));
                Order2.paymentAccount = ObjectSpace.FindObject<Account>(CriteriaOperator.Parse("[accountName] = ?", "مخزون بضاعة اول المدة"));

                int j = 0;
                foreach (var item in supplies2.ToList())
                {
                    PurchasingOrderDetail purchase = ObjectSpace.CreateObject<PurchasingOrderDetail>();
                    Product product = item;
                    //ObjectSpace.FindObject<Product>(CriteriaOperator.Parse("[name] = ? AND [sellingPrice] = ?", supplies2[j].name.ToString(), supplies2[j].purchasingPrice.ToString()));
                    purchase.product = product;
                    purchase.quantity = (Int32)new Random().Next(300, 500);
                    purchase.price = product.purchasingPrice;
                    j++;
                    Order2.PurchasingOrderDetails.Add(purchase);
                    Console.WriteLine(purchase.price.ToString() + " updater");
                }
                //Order2.OrderConfirm(true);


                //for (int z = 0; z < 90; z++)
                //{
                //    var OrderObj = ObjectSpace.CreateObject<PurchasingOrder>();
                //    OrderObj.supplierAccount = suppliers[new Random(Guid.NewGuid().GetHashCode()).Next(0, suppliers.Count)].account;
                //    OrderObj.date = RandomDay();
                //    OrderObj.OrderType = (PurchasingOrder.OrderTypes)new Random(Guid.NewGuid().GetHashCode()).Next(0, 9);

                //    //OrderObj.date = Faker<DateTime>().;
                //    if (new Random(Guid.NewGuid().GetHashCode()).NextDouble() > 0.7)
                //    {
                //        OrderObj.inventory = ObjectSpace.FindObject<Inventory>(CriteriaOperator.Parse("[Name] = ?", "Stock"));
                //        for (int u = 0; u < 6; u++)
                //        {
                //            int randomSubly = new Random(Guid.NewGuid().GetHashCode()).Next(0, supplies2.Count);
                //            PurchasingOrderDetail purchase = ObjectSpace.CreateObject<PurchasingOrderDetail>();
                //            Product product = ObjectSpace.FindObject<Product>(CriteriaOperator.Parse("[name] = ? AND [sellingPrice] = ?", supplies2[randomSubly].Name.ToString(), supplies2[randomSubly].sellingPrice.ToString()));
                //            purchase.product = product;
                //            purchase.quantity = (Int32)new Random().Next(10, 50);
                //            purchase.price = product.purchasingPrice;

                //            OrderObj.PurchasingOrderDetails.Add(purchase);
                //        }
                //    }
                //    else
                //    {

                //        for (int k = 0; k < 6; k++)
                //        {
                //            int randomMedication = new Random(Guid.NewGuid().GetHashCode()).Next(0, medications2.Count);
                //            PurchasingOrderDetail purchase = ObjectSpace.CreateObject<PurchasingOrderDetail>();
                //            Product product = ObjectSpace.FindObject<Product>(CriteriaOperator.Parse("[name] = ? AND [sellingPrice] = ?", medications2[randomMedication].Name.ToString(), medications2[randomMedication].sellingPrice.ToString()));
                //            purchase.product = product;
                //            purchase.quantity = (Int32)new Random().Next(40, 60);
                //            purchase.price = product.purchasingPrice;
                //            //purchasings.Add(purchase);
                //            OrderObj.PurchasingOrderDetails.Add(purchase);

                //        }
                //    }

                //}
                //}

                //if (ObjectSpace.GetObjectsCount(typeof(Supplier) , null) == 0)
                //    {

                //        var fakeSuppliers = new Faker<Supplier>("ar")
                //           .CustomInstantiator(f => new Supplier(((XPObjectSpace)ObjectSpace).Session))
                //           .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                //           .RuleFor(o => o.LastName, f => f.Name.LastName())
                //           .RuleFor(o => o.Birthday, f => f.Date.Recent(350))
                //           .RuleFor(o => o.Email, f => f.Internet.Email());


                //    /*
                //   #region fakeOrders
                //    var fakeOrders = new Faker<PurchasingOrder>("ar")
                //        .CustomInstantiator(f => new PurchasingOrder(((XPObjectSpace)ObjectSpace).Session))
                //        .RuleFor(o => o.supplier, suppliers[new Random(Guid.NewGuid().GetHashCode()).Next(0, suppliers.Count)])
                //        .RuleFor(o => o.date, f => f.Date.Recent(365));

                //    var orders = fakeOrders.Generate(20);
                //    foreach (PurchasingOrder order in orders)
                //    {
                //        for (int i = 0; i < new Random(Guid.NewGuid().GetHashCode()).Next(10, 20); i++)
                //        {

                //        }
                //    }
                //    #endregion
                //    */
            }

            ObjectSpace.CommitChanges();
            //if ((ObjectSpace.GetObjectsCount(typeof(ReceptionDesk), null) == 0) && ObjectSpace.GetObjectsCount(typeof(PurchasingOrder), null) != 0)
            //{

            //    IList<Room> rooms = ObjectSpace.GetObjects<Room>();

            //    var fakePatient = new Faker<Patient>("ar")
            //            .CustomInstantiator(f => new Patient(((XPObjectSpace)ObjectSpace).Session))
            //            .RuleFor(o => o.FirstName, f => f.Name.FirstName())
            //            .RuleFor(o => o.LastName, f => f.Name.LastName())
            //            .RuleFor(o => o.Birthday, f => f.Date.Recent(100))
            //            .RuleFor(o => o.BloodType, f => f.PickRandom<Blood>())
            //            .RuleFor(o => o.Email, f => f.Internet.Email());
            //    var entryIds = 0;
            //    var fakeEntries = new Faker<ReceptionDesk>("ar")
            //            .CustomInstantiator(f => new ReceptionDesk(((XPObjectSpace)ObjectSpace).Session))
            //            .RuleFor(o => o.patient, f => fakePatient.Generate())
            //            .RuleFor(o => o.enterID, f => entryIds++)
            //            .RuleFor(o => o.room, f => rooms[new Random(Guid.NewGuid().GetHashCode()).Next(0, rooms.Count)])
            //            .RuleFor(o => o.dateEnter, f => f.Date.Recent(365))
            //            .RuleFor(o => o.dateLeave, (f, usr) => usr.dateEnter.AddDays(f.Random.Int(2, 9)))
            //            .RuleFor(o => o.bed, (f, rec) => ObjectSpace.FindObject<bed>(CriteriaOperator.Parse("[room] = ? AND [isAvailable] = true", rec.room)))
            //            //.RuleFor(o => o.doctor, physicains[new Random(Guid.NewGuid().GetHashCode()).Next(0, physicains.Count)])
            //            .RuleFor(o => o.isDischarged, true);


            //    var entries = fakeEntries.Generate(100);
            //    //var patients = fakePatient.Generate(100);
            //    var medicCollection = ObjectSpace.GetObjects<StockProduct>().Where(p => p.Inventory.InventoryType == Inventory.InventoryTypes.Pharmacy).ToList();
            //    var supplyCollection = ObjectSpace.GetObjects<StockProduct>().Where(p => p.Inventory.InventoryType == Inventory.InventoryTypes.Stock).ToList();
            //    var xRaySevices = ObjectSpace.GetObjects<Service>().Where(p => p.ServiceType == ServiceTypes.Xrays).ToList();
            //    var endoscopySevices = ObjectSpace.GetObjects<Service>().Where(p => p.ServiceType == ServiceTypes.telescope).ToList();
            //    var testsSevices = ObjectSpace.GetObjects<Service>().Where(p => p.ServiceType == ServiceTypes.Tests).ToList();
            //    var genralSevices = ObjectSpace.GetObjects<Service>().Where(p => p.ServiceType == ServiceTypes.Other || p.ServiceType == ServiceTypes.Oxygen || p.ServiceType == ServiceTypes.advisory).ToList();
            //    var normalRooms = ObjectSpace.GetObjects<Room>().Where(p => p.Status == Admission.statusType.normal).ToList();
            //    var icuRooms = ObjectSpace.GetObjects<bed>().Where(p => p.room.Status == Admission.statusType.ICU).ToList();
            //    var covidRooms = ObjectSpace.GetObjects<bed>().Where(p => p.room.Status == Admission.statusType.covid).ToList();
            //    var doctors = ObjectSpace.GetObjects<Employee>().Where(p => p.job.name == "طبيب").ToList();

            //    foreach (ReceptionDesk item in entries)
            //    {

            //        var stayIds = 0;
            //        var firstAdmisssion = item.currentStay;
            //        firstAdmisssion.doctor = doctors[new Random(Guid.NewGuid().GetHashCode()).Next(0, doctors.Count)];

            //        if (new Random(Guid.NewGuid().GetHashCode()).NextDouble() > 0.7)
            //        {
            //            item.patient.Gender = Genders.female;
            //        }

            //        int numOfMedics1 = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);
            //        List<StockProduct> medicicationCollection1 = RandomProducts(medicCollection, numOfMedics1);

            //        for (int j = 0; j < numOfMedics1; j++)
            //        {
            //            int randomMedicQuantity = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);

            //            var medic = ObjectSpace.CreateObject<StayMedications>();
            //            medic.Medication = medicicationCollection1[j];
            //            medic.quantity = (int)randomMedicQuantity;
            //            medic.price = medicicationCollection1[j].product.sellingPrice;
            //            medic.Stay = firstAdmisssion;

            //            var medicine = ObjectSpace.GetObjectByKey<StockProduct>(medicicationCollection1[j].Oid);
            //            medicine.firstUnitQuantity -= (int)randomMedicQuantity;
            //        }

            //        int numOfSupplies1 = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);
            //        List<StockProduct> suppliesCollection1 = RandomProducts(supplyCollection, numOfSupplies1);

            //        for (int j = 0; j < numOfSupplies1; j++)
            //        {
            //            int randomSupplyQuantity = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);

            //            var supply = ObjectSpace.CreateObject<StaySupplies>();
            //            supply.supplyProduct = suppliesCollection1[j];
            //            supply.quantity = (int)randomSupplyQuantity;
            //            supply.price = suppliesCollection1[j].product.sellingPrice;
            //            supply.Stay = firstAdmisssion;

            //            var supply1 = ObjectSpace.GetObjectByKey<StockProduct>(suppliesCollection1[j].Oid);
            //            supply1.firstUnitQuantity -= (int)randomSupplyQuantity;
            //        }

            //        int numOfXrayServices1 = new Random(Guid.NewGuid().GetHashCode()).Next(2, xRaySevices.Count);
            //        List<Service> admissionXrays1 = RandomServices(xRaySevices, numOfXrayServices1);

            //        for (int j = 0; j < numOfXrayServices1; j++)
            //        {
            //            var services = ObjectSpace.GetObjects<Service>();

            //            var serviceCollection = ObjectSpace.CreateObject<XraysDetails>();
            //            serviceCollection.service = admissionXrays1[j];
            //            serviceCollection.price = admissionXrays1[j].Price;
            //            serviceCollection.admission = firstAdmisssion;
            //        }

            //        int numOfTestServices1 = new Random(Guid.NewGuid().GetHashCode()).Next(2, testsSevices.Count);
            //        List<Service> admissionTests1 = RandomServices(testsSevices, numOfTestServices1);

            //        for (int j = 0; j < numOfTestServices1; j++)
            //        {
            //            var services = ObjectSpace.GetObjects<Service>();

            //            var serviceCollection = ObjectSpace.CreateObject<TestDetails>();
            //            serviceCollection.service = admissionTests1[j];
            //            serviceCollection.price = admissionTests1[j].Price;
            //            serviceCollection.admission = firstAdmisssion;
            //        }

            //        //int numOfEndoscopyServices = new Random(Guid.NewGuid().GetHashCode()).Next(2, endoscopySevices.Count);
            //        //List<Service> admissionEndoscopies = RandomServices(endoscopySevices, numOfEndoscopyServices);

            //        //for (int j = 0; j < numOfEndoscopyServices; j++)
            //        //{
            //        //    var services = ObjectSpace.GetObjects<Service>();

            //        //    var serviceCollection = ObjectSpace.CreateObject<EndscopeDetails>();
            //        //    serviceCollection.service = admissionEndoscopies[j];
            //        //    serviceCollection.price = admissionEndoscopies[j].Price;
            //        //    serviceCollection.admission = admissionObject;
            //        //}

            //        int numOfGenralServices1 = new Random(Guid.NewGuid().GetHashCode()).Next(2, genralSevices.Count);
            //        List<Service> admissionGenralServices1 = RandomServices(genralSevices, numOfGenralServices1);

            //        for (int j = 0; j < numOfGenralServices1; j++)
            //        {
            //            var services = ObjectSpace.GetObjects<Service>();

            //            var serviceCollection = ObjectSpace.CreateObject<ServiceDetails>();
            //            serviceCollection.Service = admissionGenralServices1[j];
            //            serviceCollection.price = admissionGenralServices1[j].Price;
            //            serviceCollection.Stay = firstAdmisssion;
            //        }


            //        int transfreNumbers = new Random(Guid.NewGuid().GetHashCode()).Next(0, 4);
            //        bool isICU = true;
            //        for (int i = 0; i < transfreNumbers; i++)
            //        {
            //            Admission admissionObject = ObjectSpace.CreateObject<Admission>();
            //            admissionObject.Patient = item.patient;
            //            admissionObject.doctor = doctors[new Random(Guid.NewGuid().GetHashCode()).Next(0, doctors.Count)];
            //            admissionObject.admissionID = item.enterID + stayIds++;
            //            admissionObject.StayStart = item.dateEnter.AddDays(new Random(Guid.NewGuid().GetHashCode()).Next(0, 4));
            //            admissionObject.StayEnd = item.dateLeave.AddDays(new Random(Guid.NewGuid().GetHashCode()).Next(-2, 0));
            //            if (!isICU)
            //            //new Random(Guid.NewGuid().GetHashCode()).NextDouble() > 0.7 &&
            //            {
            //                admissionObject.Status = Admission.statusType.ICU;
            //                admissionObject.bed = icuRooms[new Random(Guid.NewGuid().GetHashCode()).Next(0, icuRooms.Count)];
            //                admissionObject.Room = admissionObject.bed.room;
            //                isICU = true;
            //            }
            //            else
            //            {
            //                admissionObject.Status = Admission.statusType.normal;
            //                admissionObject.Room = normalRooms[new Random(Guid.NewGuid().GetHashCode()).Next(0, normalRooms.Count)];
            //                admissionObject.bed = admissionObject.Room.beds.First();
            //                isICU = false;
            //            }
            //            admissionObject.reception = item;

            //            admissionObject.IsDischarged = true;


            //            int numOfMedics = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);
            //            List<StockProduct> medicicationCollection = RandomProducts(medicCollection, numOfMedics);

            //            for (int j = 0; j < numOfMedics; j++)
            //            {
            //                int randomMedicQuantity = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);

            //                var medic = ObjectSpace.CreateObject<StayMedications>();
            //                medic.Medication = medicicationCollection[j];
            //                medic.quantity = randomMedicQuantity;
            //                medic.price = medicicationCollection[j].product.sellingPrice;
            //                medic.Stay = admissionObject;

            //                var medicine = ObjectSpace.GetObjectByKey<StockProduct>(medicicationCollection[j].Oid);
            //                medicine.firstUnitQuantity -= randomMedicQuantity;
            //            }

            //            int numOfSupplies = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);
            //            List<StockProduct> suppliesCollection = RandomProducts(supplyCollection, numOfSupplies);

            //            for (int j = 0; j < numOfSupplies; j++)
            //            {
            //                int randomSupplyQuantity = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);

            //                var supply = ObjectSpace.CreateObject<StaySupplies>();
            //                supply.supplyProduct = suppliesCollection[j];
            //                supply.quantity = randomSupplyQuantity;
            //                supply.price = suppliesCollection[j].product.sellingPrice;
            //                supply.Stay = admissionObject;

            //                var supply1 = ObjectSpace.GetObjectByKey<StockProduct>(suppliesCollection[j].Oid);
            //                supply1.firstUnitQuantity -= randomSupplyQuantity;
            //            }

            //            int numOfXrayServices = new Random(Guid.NewGuid().GetHashCode()).Next(2, xRaySevices.Count);
            //            List<Service> admissionXrays = RandomServices(xRaySevices, numOfXrayServices);

            //            for (int j = 0; j < numOfXrayServices; j++)
            //            {
            //                var services = ObjectSpace.GetObjects<Service>();

            //                var serviceCollection = ObjectSpace.CreateObject<XraysDetails>();
            //                serviceCollection.service = admissionXrays[j];
            //                serviceCollection.price = admissionXrays[j].Price;
            //                serviceCollection.admission = admissionObject;
            //            }

            //            int numOfTestServices = new Random(Guid.NewGuid().GetHashCode()).Next(2, testsSevices.Count);
            //            List<Service> admissionTests = RandomServices(testsSevices, numOfTestServices);

            //            for (int j = 0; j < numOfTestServices; j++)
            //            {
            //                var services = ObjectSpace.GetObjects<Service>();

            //                var serviceCollection = ObjectSpace.CreateObject<TestDetails>();
            //                serviceCollection.service = admissionTests[j];
            //                serviceCollection.price = admissionTests[j].Price;
            //                serviceCollection.admission = admissionObject;
            //            }

            //            //int numOfEndoscopyServices = new Random(Guid.NewGuid().GetHashCode()).Next(2, endoscopySevices.Count);
            //            //List<Service> admissionEndoscopies = RandomServices(endoscopySevices, numOfEndoscopyServices);

            //            //for (int j = 0; j < numOfEndoscopyServices; j++)
            //            //{
            //            //    var services = ObjectSpace.GetObjects<Service>();

            //            //    var serviceCollection = ObjectSpace.CreateObject<EndscopeDetails>();
            //            //    serviceCollection.service = admissionEndoscopies[j];
            //            //    serviceCollection.price = admissionEndoscopies[j].Price;
            //            //    serviceCollection.admission = admissionObject;
            //            //}

            //            int numOfGenralServices = new Random(Guid.NewGuid().GetHashCode()).Next(2, genralSevices.Count);
            //            List<Service> admissionGenralServices = RandomServices(genralSevices, numOfGenralServices);

            //            for (int j = 0; j < numOfGenralServices; j++)
            //            {
            //                var services = ObjectSpace.GetObjects<Service>();

            //                var serviceCollection = ObjectSpace.CreateObject<ServiceDetails>();
            //                serviceCollection.Service = admissionGenralServices[j];
            //                serviceCollection.price = admissionGenralServices[j].Price;
            //                serviceCollection.Stay = admissionObject;
            //            }

            //        }


            //        //        #region Companion

            //        //        if (item.Room.Status == Room.statusType.normal)
            //        //        {
            //        //            var companoin1 = ObjectSpace.CreateObject<CompanionDetails>();
            //        //            companoin1.Stay = item;
            //        //            companoin1.price = 450;
            //        //            companoin1.date = item.StayStart.Date;

            //        //            var companoin2 = ObjectSpace.CreateObject<CompanionDetails>();
            //        //            companoin2.Stay = item;
            //        //            companoin2.price = 450;
            //        //            companoin2.date = item.StayEnd.Date;
            //        //        }
            //        //        #endregion

            //        //        #region services



            //        //        #endregion

            //        //        #region payments
            //        //        var payment1 = ObjectSpace.CreateObject<Payments>();
            //        //        payment1.amount = (item.stayTotalSum * 0.2m) - ((item.stayTotalSum * 0.2m) % 1000);
            //        //        payment1.date = item.StayStart;
            //        //        payment1.Patient = item.Patient;

            //        //        var payment2 = ObjectSpace.CreateObject<Payments>();
            //        //        payment2.amount = item.stayTotalSum - payment1.amount;
            //        //        payment2.date = item.StayEnd;
            //        //        payment2.Patient = item.Patient;

            //        //        #endregion
            //        ObjectSpace.CommitChanges();
            //        var payerAccount = ObjectSpace.GetObjects<Account>().Where(p => p == item.patient.account).Single();
            //        var recivingAccount = ObjectSpace.GetObjects<Account>().Where(p => p.accountName == "صندوق رئيسي").Single();
            //        var payment = ObjectSpace.CreateObject<receiptClientBond>();
            //        payment.fromAccount = payerAccount;
            //        payment.amount = item.total;
            //        payment.date = RandomDay();
            //        payment.intoAccount = recivingAccount;

            //        payment.OrderConfirm(true);


            //    }


            //    ObjectSpace.CommitChanges();

            //    var patients = ObjectSpace.GetObjects<Patient>();
            //    var fakeEmergency = new Faker<Emergency>("ar")
            //        .CustomInstantiator(f => new Emergency(((XPObjectSpace)ObjectSpace).Session))
            //        .RuleFor(o => o.supervision, 200)
            //        .RuleFor(o => o.date, f => f.Date.Recent(365));

            //    var emergencies = fakeEmergency.Generate(100);


            //    foreach (Emergency emItem in emergencies)
            //    {

            //        #region Overal
            //        emItem.Patient = patients[new Random(Guid.NewGuid().GetHashCode()).Next(0, patients.Count)];
            //        emItem.doctor = doctors[new Random(Guid.NewGuid().GetHashCode()).Next(0, doctors.Count)];
            //        #endregion

            //        #region Medic
            //        int numOfMedics = new Random(Guid.NewGuid().GetHashCode()).Next(1, 2);
            //        List<StockProduct> medicicationCollection = RandomProducts(medicCollection, numOfMedics);



            //        for (int i = 0; i < numOfMedics; i++)
            //        {
            //            int randomMedicQuantity = 1;

            //            var medic = ObjectSpace.CreateObject<StayMedications>();
            //            medic.Medication = medicicationCollection[i];
            //            medic.quantity = (int)randomMedicQuantity;
            //            medic.price = medicicationCollection[i].product.sellingPrice;
            //            medic.emergency = emItem;
            //            medic.date = emItem.date;

            //            var medicine = ObjectSpace.GetObjectByKey<StockProduct>(medicicationCollection[i].Oid);
            //            medicine.firstUnitQuantity -= (int)randomMedicQuantity;
            //        }

            //        #endregion

            //        #region supplyProduct

            //        int numOfSupplies = new Random(Guid.NewGuid().GetHashCode()).Next(1, 2);
            //        List<StockProduct> suppliesCollection = RandomProducts(supplyCollection, numOfSupplies);

            //        for (int i = 0; i < numOfSupplies; i++)
            //        {
            //            int randomSupplyQuantity = 1;

            //            var supply = ObjectSpace.CreateObject<StaySupplies>();
            //            supply.supplyProduct = suppliesCollection[i];
            //            supply.quantity = (int)randomSupplyQuantity;
            //            supply.price = suppliesCollection[i].product.sellingPrice;
            //            supply.emergency = emItem;
            //            supply.date = emItem.date;

            //            var supply1 = ObjectSpace.GetObjectByKey<StockProduct>(suppliesCollection[i].Oid);
            //            supply1.firstUnitQuantity -= (int)randomSupplyQuantity;
            //        }
            //        #endregion

            //        var services = ObjectSpace.GetObjects<Service>();

            //        int randomService = new Random(Guid.NewGuid().GetHashCode()).Next(0, services.Count);
            //        var serviceCollection = ObjectSpace.CreateObject<ServiceDetails>();
            //        serviceCollection.Service = services[randomService];
            //        serviceCollection.price = services[randomService].Price;
            //        serviceCollection.emergency = emItem;

            //        //        #region services

            //        //        #endregion

            //        //        #region payments
            //        //        var payment1 = ObjectSpace.CreateObject<Payments>();
            //        //        payment1.amount = (item.TotalSum * 0.2m) - ((item.TotalSum * 0.2m) % 1000);
            //        //        payment1.date = item.date;
            //        //        payment1.Patient = item.Patient;

            //        //        var payment2 = ObjectSpace.CreateObject<Payments>();
            //        //        payment2.amount = item.TotalSum - payment1.amount;
            //        //        payment2.date = item.date;
            //        //        payment2.Patient = item.Patient;

            //        //        #endregion
            //        //    }
            //    }
            //}
            //}
            //ObjectSpace.GetObjectsCount(typeof(Appointment), null) == 0 && ObjectSpace.GetObjectsCount(typeof(PurchasingOrder), null) != 0
            if (ObjectSpace.GetObjectsCount(typeof(Appointment), null) == 0 && ObjectSpace.GetObjectsCount(typeof(PurchasingOrder), null) != 0)
            {
                var patients = ObjectSpace.GetObjects<Patient>();
                var doctors = ObjectSpace.GetObjects<Employee>().Where(o => o.section.id == 6 && o.Clinic != null).ToList();
                var clincs = new List<Clinc>();
                foreach (var i in doctors)
                {
                    clincs.Add(i.Clinic);
                }
                //var clincs = ObjectSpace.GetObjects<Clinc>();
                var fakeAppointments = new Faker<Appointment>("ar")
                    .CustomInstantiator(f => new Appointment(((XPObjectSpace)ObjectSpace).Session))
                    .RuleFor(o => o.ExaminationPrice, 100)
                    .RuleFor(o => o.clinc, f => clincs[new Random(Guid.NewGuid().GetHashCode()).Next(0, clincs.Count)])
                    .RuleFor(o => o.Patient, f => patients[new Random(Guid.NewGuid().GetHashCode()).Next(0, patients.Count)])
                    .RuleFor(o => o.Doctor, (f,p) => doctors.Where(o => o.Clinic == p.clinc).ToList()[0])
                    .RuleFor(o => o.StartOn, f => f.Date.Between(DateTime.Today,DateTime.Today.AddHours(23)))
                    .RuleFor(o => o.EndOn, (f, p) => p.StartOn.AddMinutes(30.0));

                var Appointments = fakeAppointments.Generate(30);

            }

                //        //foreach (Appointment item in Appointments)
                //        //{

                //        //    var clinicService = ObjectSpace.CreateObject<ClinicService>();
                //        //    List<ClinicService> currentClinincServices = item.clinc.ClinicServices.ToList();
                //        //    var numberOfServices = new Random(Guid.NewGuid().GetHashCode()).Next(0, 4);
                //        //    clinicService.Appointment = item;
                //        //    clinicService = currentClinincServices[new Random(Guid.NewGuid().GetHashCode()).Next(0, currentClinincServices.Count)];

                //        //    //var payment = ObjectSpace.CreateObject<Payments>();
                //        //    //payment.Patient = item.Patient;
                //        //    //payment.amount = item.amount;
                //        //    //payment.date = item.StartOn;
                //        //}

                //    }

                ObjectSpace.CommitChanges();

            //*** The following code generate stay fake data ***
            /*
            if ((ObjectSpace.GetObjectsCount(typeof(Admission), null) == 0))
            {
                IList<Product> products = ObjectSpace.GetObjects<Product>();
                IList<Room> rooms = ObjectSpace.GetObjects<Room>();
                var physicains = ObjectSpace.GetObjects<Physician>();

                var fakePatient = new Faker<Patient>("ar")
                    .CustomInstantiator(f => new Patient(((XPObjectSpace)ObjectSpace).Session))
                    .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                    .RuleFor(o => o.LastName, f => f.Name.LastName())
                    .RuleFor(o => o.Birthday, f => f.Date.Recent(100))
                    .RuleFor(o => o.BloodType, f => f.PickRandom<Blood>())
                    .RuleFor(o => o.Email, f => f.Internet.Email());

                var stayIds = 0;
                var fakeAdmissions = new Faker<Admission>("ar")
                    .CustomInstantiator(f => new Admission(((XPObjectSpace)ObjectSpace).Session))
                    .RuleFor(o => o.Patient, f => fakePatient.Generate())
                    .RuleFor(o => o.admissionID, f => stayIds++)
                    .RuleFor(o => o.Room, f => rooms[new Random(Guid.NewGuid().GetHashCode()).Next(0, rooms.Count)])
                    .RuleFor(o => o.StayStart, f => f.Date.Recent(365))
                    .RuleFor(o => o.StayEnd, (f, usr) => usr.StayStart.AddDays(f.Random.Int(2, 9)))
                    .RuleFor(o => o.doctor, physicains[new Random(Guid.NewGuid().GetHashCode()).Next(0, physicains.Count)])
                    .RuleFor(o => o.IsDischarged, true);


                var admissions = fakeAdmissions.Generate(100);

                var medicCollection = ObjectSpace.GetObjects<StockProduct>().Where(p => p.Inventory.InventoryType == Inventory.InventoryTypes.Pharmacy).ToList();
                var supplyCollection = ObjectSpace.GetObjects<StockProduct>().Where(p => p.Inventory.InventoryType == Inventory.InventoryTypes.Stock).ToList();

                foreach (Admission item in admissions)
                {
                    if (new Random(Guid.NewGuid().GetHashCode()).NextDouble() > 0.7)
                        item.Patient.Gender = Genders.female;

                    #region Overal
                    if (item.Room.Status == Room.statusType.ICU)
                        item.Status = Admission.InPatientSections.ICU;

                    #endregion

                    #region Medic
                    int numOfMedics = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);
                    List<StockProduct> medicicationCollection = RandomProducts(medicCollection, numOfMedics);

                    for (int i = 0; i < numOfMedics; i++)
                    {
                        int randomMedicQuantity = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);

                        var medic = ObjectSpace.CreateObject<StayMedications>();
                        medic.Medication = medicicationCollection[i];
                        medic.quantity = (int)randomMedicQuantity;
                        medic.price = medicicationCollection[i].product.sellingPrice;
                        medic.Stay = item;

                        var medicine = ObjectSpace.GetObjectByKey<StockProduct>(medicicationCollection[i].Oid);
                        medicine.firstUnitQuantity -= (int)randomMedicQuantity;
                    }

                    #endregion

                    #region supplyProduct

                    int numOfSupplies = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);
                    List<StockProduct> suppliesCollection = RandomProducts(supplyCollection, numOfSupplies);

                    for (int i = 0; i < numOfSupplies; i++)
                    {
                        int randomSupplyQuantity = new Random(Guid.NewGuid().GetHashCode()).Next(2, 6);

                        var supply = ObjectSpace.CreateObject<StaySupplies>();
                        supply.supplyProduct = suppliesCollection[i];
                        supply.quantity = (int)randomSupplyQuantity;
                        supply.price = suppliesCollection[i].product.sellingPrice;
                        supply.Stay = item;

                        var supply1 = ObjectSpace.GetObjectByKey<StockProduct>(suppliesCollection[i].Oid);
                        supply1.firstUnitQuantity -= (int)randomSupplyQuantity;
                    }
                    #endregion

                    var services = ObjectSpace.GetObjects<Service>();

                    int randomService = new Random(Guid.NewGuid().GetHashCode()).Next(0, services.Count);
                    var serviceCollection = ObjectSpace.CreateObject<ServiceDetails>();
                    serviceCollection.Service = services[randomService];
                    serviceCollection.price = services[randomService].Price;
                    serviceCollection.Stay = item;

                    #region Companion

                    if (item.Room.Status == Room.statusType.normal)
                    {
                        var companoin1 = ObjectSpace.CreateObject<CompanionDetails>();
                        companoin1.Stay = item;
                        companoin1.price = 450;
                        companoin1.date = item.StayStart.Date;

                        var companoin2 = ObjectSpace.CreateObject<CompanionDetails>();
                        companoin2.Stay = item;
                        companoin2.price = 450;
                        companoin2.date = item.StayEnd.Date;
                    }
                    #endregion

                    #region services



                    #endregion

                    #region payments
                    var payment1 = ObjectSpace.CreateObject<Payments>();
                    payment1.amount = (item.stayTotalSum * 0.2m) - ((item.stayTotalSum * 0.2m) % 1000);
                    payment1.date = item.StayStart;
                    payment1.Patient = item.Patient;

                    var payment2 = ObjectSpace.CreateObject<Payments>();
                    payment2.amount = item.stayTotalSum - payment1.amount;
                    payment2.date = item.StayEnd;
                    payment2.Patient = item.Patient;

                    #endregion

                }

                ObjectSpace.CommitChanges();

                var patients = ObjectSpace.GetObjects<Patient>();
                var fakeEmergency = new Faker<Emergency>("ar")
                    .CustomInstantiator(f => new Emergency(((XPObjectSpace)ObjectSpace).Session))
                    .RuleFor(o => o.supervision, 200)
                    .RuleFor(o => o.date, f => f.Date.Recent(365));

                var emergencies = fakeEmergency.Generate(100);


                foreach (Emergency item in emergencies)
                {

                    #region Overal
                    item.Patient = patients[new Random(Guid.NewGuid().GetHashCode()).Next(0, patients.Count)];
                    item.doctor = physicains[new Random(Guid.NewGuid().GetHashCode()).Next(0, physicains.Count)];
                    #endregion

                    #region Medic
                    int numOfMedics = new Random(Guid.NewGuid().GetHashCode()).Next(1, 2);
                    List<StockProduct> medicicationCollection = RandomProducts(medicCollection, numOfMedics);

                    for (int i = 0; i < numOfMedics; i++)
                    {
                        int randomMedicQuantity = 1;

                        var medic = ObjectSpace.CreateObject<StayMedic>();
                        medic.Medication = medicicationCollection[i];
                        medic.quantity = (int)randomMedicQuantity;
                        medic.price = medicicationCollection[i].product.sellingPrice;
                        medic.emergency = item;
                        medic.date = item.date;

                        var medicine = ObjectSpace.GetObjectByKey<StockProduct>(medicicationCollection[i].Oid);
                        medicine.firstUnitQuantity -= (int)randomMedicQuantity;
                    }

                    #endregion

                    #region supplyProduct

                    int numOfSupplies = new Random(Guid.NewGuid().GetHashCode()).Next(1, 2);
                    List<StockProduct> suppliesCollection = RandomProducts(supplyCollection, numOfSupplies);

                    for (int i = 0; i < numOfSupplies; i++)
                    {
                        int randomSupplyQuantity = 1;

                        var supply = ObjectSpace.CreateObject<StaySupplies>();
                        supply.supplyProduct = suppliesCollection[i];
                        supply.quantity = (int)randomSupplyQuantity;
                        supply.price = suppliesCollection[i].product.sellingPrice;
                        supply.emergency = item;
                        supply.date = item.date;

                        var supply1 = ObjectSpace.GetObjectByKey<StockProduct>(suppliesCollection[i].Oid);
                        supply1.firstUnitQuantity-= (int)randomSupplyQuantity;
                    }
                    #endregion

                    var services = ObjectSpace.GetObjects<Service>();

                    int randomService = new Random(Guid.NewGuid().GetHashCode()).Next(0, services.Count);
                    var serviceCollection = ObjectSpace.CreateObject<ServiceDetails>();
                    serviceCollection.Service = services[randomService];
                    serviceCollection.price = services[randomService].Price;
                    serviceCollection.emergency = item;

                    #region services

                    #endregion

                    #region payments
                    var payment1 = ObjectSpace.CreateObject<Payments>();
                    payment1.amount = (item.TotalSum * 0.2m) - ((item.TotalSum * 0.2m) % 1000);
                    payment1.date = item.date;
                    payment1.Patient = item.Patient;

                    var payment2 = ObjectSpace.CreateObject<Payments>();
                    payment2.amount = item.TotalSum - payment1.amount;
                    payment2.date = item.date;
                    payment2.Patient = item.Patient;

                    #endregion
                }
            }


            if (ObjectSpace.GetObjectsCount(typeof(Appointment), null) == 0)
            {
                var patients = ObjectSpace.GetObjects<Patient>();
                var doctors = ObjectSpace.GetObjects<Physician>();
                var clincs = ObjectSpace.GetObjects<Clinc>();
                var fakeAppointments = new Faker<Appointment>("ar")
                    .CustomInstantiator(f => new Appointment(((XPObjectSpace)ObjectSpace).Session))
                    .RuleFor(o => o.amount, 100)
                    .RuleFor(o => o.Patient, f => patients[new Random(Guid.NewGuid().GetHashCode()).Next(0, patients.Count)])
                    .RuleFor(o => o.Physician, f => doctors[new Random(Guid.NewGuid().GetHashCode()).Next(0, doctors.Count)])
                    .RuleFor(o => o.StartOn, f => f.Date.Recent(365))
                    .RuleFor(o => o.dateStart, (f, p) => p.StartOn)
                    .RuleFor(o => o.clinc, f => clincs[new Random(Guid.NewGuid().GetHashCode()).Next(0, clincs.Count)])
                    .RuleFor(o => o.EndOn, (f, p) => p.StartOn.AddMinutes(30.0));

                var Appointments = fakeAppointments.Generate(100);

                foreach (Appointment item in Appointments)
                {
                    var payment = ObjectSpace.CreateObject<Payments>();
                    payment.Patient = item.Patient;
                    payment.amount = item.amount;
                    payment.date = item.StartOn;
                }

            }
            */
            ObjectSpace.CommitChanges(); //This line persists created object(s).
        }
        public override void UpdateDatabaseBeforeUpdateSchema()
        {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(2020, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        private PermissionPolicyRole CreateDefaultRole()
        {
            PermissionPolicyRole defaultRole = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Default"));
            if (defaultRole == null)
            {
                defaultRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
                defaultRole.Name = "Default";

                defaultRole.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.Read, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                defaultRole.AddNavigationPermission(@"Application/NavigationItems/Items/Default/Items/MyDetails", SecurityPermissionState.Allow);
                defaultRole.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                defaultRole.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                defaultRole.AddTypePermissionsRecursively<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Deny);
                defaultRole.AddTypePermissionsRecursively<ModelDifference>(SecurityOperations.ReadWriteAccess, SecurityPermissionState.Allow);
                defaultRole.AddTypePermissionsRecursively<ModelDifferenceAspect>(SecurityOperations.ReadWriteAccess, SecurityPermissionState.Allow);
                defaultRole.AddTypePermissionsRecursively<ModelDifference>(SecurityOperations.Create, SecurityPermissionState.Allow);
                defaultRole.AddTypePermissionsRecursively<ModelDifferenceAspect>(SecurityOperations.Create, SecurityPermissionState.Allow);
            }
            return defaultRole;
        }
        private PermissionPolicyRole CreateManagerRole()
        {
            PermissionPolicyRole Manager = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Manager"));
            if (Manager == null)
            {
                Manager = ObjectSpace.CreateObject<PermissionPolicyRole>();
                Manager.Name = "Manager";
                Manager.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                Manager.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                Manager.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                Manager.AddNavigationPermission(@"Application/NavigationItems/Items/Default", SecurityPermissionState.Deny);
                Manager.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                Manager.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                Manager.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                Manager.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                Manager.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Manager.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Manager.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                Manager.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                Manager.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                Manager.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                Manager.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                Manager.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Manager.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);

            }
            return Manager;

        }


        private PermissionPolicyRole CreateCashierRole()
        {
            PermissionPolicyRole Cashier = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Cashier"));
            if (Cashier == null)
            {
                Cashier = ObjectSpace.CreateObject<PermissionPolicyRole>();
                Cashier.Name = "Cashier";
                Cashier.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Patient_ListView", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Room_ListView", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/Pharmacy", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/Inventory & products", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Clinc_ListView", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Appointments", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Section_ListView", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Job_ListView", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Employee_ListView", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/إحصائيات", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/DashboardItem", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/Default", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                Cashier.AddNavigationPermission(@"Application/NavigationItems/Items/Services", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Cashier.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Cashier.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                Cashier.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                Cashier.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                Cashier.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                Cashier.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<StayMedications>("Write;Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<StaySupplies>("Write;Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<ServiceDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<XraysDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<TestDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<SupervisionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<EndscopeDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Cashier.AddTypePermission<CompanionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);

            }
            return Cashier;

        }
        private PermissionPolicyRole CreateReceptionRole()
        {
            PermissionPolicyRole Reception = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Reception"));
            if (Reception == null)
            {
                Reception = ObjectSpace.CreateObject<PermissionPolicyRole>();
                Reception.Name = "Reception";
                Reception.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Patient_ListView", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/Pharmacy", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/Inventory & products", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Section_ListView", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Job_ListView", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Employee_ListView", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/إحصائيات", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/DashboardItem", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/Services", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/ReceptionDesk_ListView", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/Purchasing Department", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/الحسابات", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment", SecurityPermissionState.Deny);
                Reception.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                Reception.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Reception.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Reception.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                Reception.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                Reception.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                Reception.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                Reception.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                Reception.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Reception.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);

            }
            return Reception;

        }
        private PermissionPolicyRole CreateAdmissionDeskRole()
        {
            PermissionPolicyRole AdmissionDesk = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "AdmissionDesk"));
            if (AdmissionDesk == null)
            {
                AdmissionDesk = ObjectSpace.CreateObject<PermissionPolicyRole>();
                AdmissionDesk.Name = "AdmissionDesk";
                AdmissionDesk.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Clinc_ListView", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Appointments", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Section_ListView", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Job_ListView", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment/Items/Employee_ListView", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/إحصائيات", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/DashboardItem", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/Default", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/Services", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/الحسابات", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/Purchasing Department", SecurityPermissionState.Deny);
                AdmissionDesk.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                AdmissionDesk.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                AdmissionDesk.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                AdmissionDesk.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                AdmissionDesk.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                AdmissionDesk.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                AdmissionDesk.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                AdmissionDesk.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                AdmissionDesk.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                AdmissionDesk.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
            }
            return AdmissionDesk;

        }

        private PermissionPolicyRole CreatePharmacyRole()
        {
            PermissionPolicyRole Pharmacy = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Pharmacy"));
            if (Pharmacy == null)
            {
                Pharmacy = ObjectSpace.CreateObject<PermissionPolicyRole>();
                Pharmacy.Name = "Pharmacy";
                Pharmacy.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Room_ListView", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/Inventory & products", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/إحصائيات", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/DashboardItem", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/Default", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/Services", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/الحسابات", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/ReceptionDesk_ListView", SecurityPermissionState.Deny);
                Pharmacy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Pharmacy.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                Pharmacy.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                Pharmacy.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                Pharmacy.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                Pharmacy.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<StaySupplies>("Write;Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<ServiceDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<XraysDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<TestDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<SupervisionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<EndscopeDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddTypePermission<CompanionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Pharmacy.AddObjectPermission<Inventory>(SecurityOperations.Read, "[Name] = 'Stock'", SecurityPermissionState.Deny);
                Pharmacy.AddObjectPermission<Product>(SecurityOperations.Read, "[category.name] = 'مستهلكات'", SecurityPermissionState.Deny);
                Pharmacy.AddObjectPermission<PurchasingOrder>(SecurityOperations.Read, "[inventory.Name] = 'Stock'", SecurityPermissionState.Deny);

            }
            return Pharmacy;

        }


        private PermissionPolicyRole CreateLabRole()
        {
            PermissionPolicyRole Lab = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Lab"));
            if (Lab == null)
            {
                Lab = ObjectSpace.CreateObject<PermissionPolicyRole>();
                Lab.Name = "Lab";
                Lab.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Room_ListView", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/Inventory & products", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/إحصائيات", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/DashboardItem", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/Default", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/Services", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/الحسابات", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Xrays_ListView", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Clinc_ListView", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Endscope_ListView", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Appointments", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/ReceptionDesk_ListView", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/Pharmacy", SecurityPermissionState.Deny);
                Lab.AddNavigationPermission(@"Application/NavigationItems/Items/Purchasing Department", SecurityPermissionState.Deny);
                Lab.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Lab.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Lab.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                Lab.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                Lab.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                Lab.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                Lab.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<StayMedications>("Write;Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<StaySupplies>("Write;Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<ServiceDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<XraysDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<SupervisionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<EndscopeDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Lab.AddTypePermission<CompanionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Lab.AddObjectPermission<Service>(SecurityOperations.Read, "[ServiceType] <> 17", SecurityPermissionState.Deny);
            }
            return Lab;

        }
        private PermissionPolicyRole CreateXRayRole()
        {
            PermissionPolicyRole XRay = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "XRay"));
            if (XRay == null)
            {
                XRay = ObjectSpace.CreateObject<PermissionPolicyRole>();
                XRay.Name = "XRay";
                XRay.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Room_ListView", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/Inventory & products", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/إحصائيات", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/DashboardItem", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/Default", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/Services", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/الحسابات", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Test_ListView", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Clinc_ListView", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Endscope_ListView", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Appointments", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/ReceptionDesk_ListView", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/Pharmacy", SecurityPermissionState.Deny);
                XRay.AddNavigationPermission(@"Application/NavigationItems/Items/Purchasing Department", SecurityPermissionState.Deny);
                XRay.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                XRay.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                XRay.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                XRay.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                XRay.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                XRay.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                XRay.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<StayMedications>("Write;Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<StaySupplies>("Write;Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<ServiceDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<TestDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<SupervisionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<EndscopeDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                XRay.AddTypePermission<CompanionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                XRay.AddObjectPermission<Service>(SecurityOperations.Read, "[ServiceType] <> 16", SecurityPermissionState.Deny);
            }
            return XRay;

        }
        private PermissionPolicyRole CreateEndosocopyRole()
        {
            PermissionPolicyRole Endoscopy = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Endoscopy"));
            if (Endoscopy == null)
            {
                Endoscopy = ObjectSpace.CreateObject<PermissionPolicyRole>();
                Endoscopy.Name = "Endoscopy";
                Endoscopy.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Room_ListView", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/Inventory & products", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/إحصائيات", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/DashboardItem", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/Default", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/Services", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/الحسابات", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Xrays_ListView", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Clinc_ListView", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Test_ListView", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي/Items/Appointments", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/ReceptionDesk_ListView", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/Pharmacy", SecurityPermissionState.Deny);
                Endoscopy.AddNavigationPermission(@"Application/NavigationItems/Items/Purchasing Department", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Endoscopy.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                Endoscopy.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                Endoscopy.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                Endoscopy.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                Endoscopy.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<StayMedications>("Write;Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<StaySupplies>("Write;Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<ServiceDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<XraysDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<TestDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<SupervisionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddTypePermission<CompanionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Endoscopy.AddObjectPermission<Service>(SecurityOperations.Read, "[ServiceType] <> 3", SecurityPermissionState.Deny);
            }
            return Endoscopy;

        }


        private PermissionPolicyRole CreateInventoryRole()
        {
            PermissionPolicyRole Inventory = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Inventory"));
            if (Inventory == null)
            {
                Inventory = ObjectSpace.CreateObject<PermissionPolicyRole>();
                Inventory.Name = "Inventory";
                Inventory.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/StandardFormWithCustomUserControl", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Room_ListView", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/Pharmacy", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/إحصائيات", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/DashboardItem", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/KPI", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/Default", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/Task", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/State Machine", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/Reports", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/Services", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/HRDepartment", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/الحسابات", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/القسم الخارجي", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/@304c1aff-0fec-4dfe-8164-bcb288938137", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/ReceptionDesk_ListView", SecurityPermissionState.Deny);
                Inventory.AddNavigationPermission(@"Application/NavigationItems/Items/In-Patient/Items/Emergency_ListView", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<PermissionPolicyRole>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Inventory.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
                Inventory.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                Inventory.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
                Inventory.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
                Inventory.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
                Inventory.AddTypePermission<PermissionPolicyTypePermissionObject>("Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<PermissionPolicyMemberPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<PermissionPolicyObjectPermissionsObject>("Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<StayMedications>("Write;Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<ServiceDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<XraysDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<TestDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<SupervisionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<EndscopeDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddTypePermission<CompanionDetails>("Write;Delete;Create", SecurityPermissionState.Deny);
                Inventory.AddObjectPermission<Inventory>(SecurityOperations.Read, "[Name] = 'Pharmacy'", SecurityPermissionState.Deny);
                Inventory.AddObjectPermission<Product>(SecurityOperations.Read, "[category.name] <> 'مستهلكات'", SecurityPermissionState.Deny);
                Inventory.AddObjectPermission<PurchasingOrder>(SecurityOperations.Read, "[inventory.Name] = 'Pharmacy'", SecurityPermissionState.Deny);
            }
            return Inventory;

        }

        //Select distinct elemets from List
        public List<StockProduct> RandomProducts(List<StockProduct> collection, int number)
        {
            List<StockProduct> products = new List<StockProduct>();

            while (products.Count < number)
            {
                int randomIndex = new Random(Guid.NewGuid().GetHashCode()).Next(0, collection.Count);
                if (!products.Contains(collection[randomIndex]))
                {
                    products.Add(collection[randomIndex]);
                }
            }

            return products;
        }
        public List<Service> RandomServices(List<Service> collection, int number)
        {
            List<Service> services = new List<Service>();

            while (services.Count < number)
            {
                int randomIndex = new Random(Guid.NewGuid().GetHashCode()).Next(0, collection.Count);
                if (!services.Contains(collection[randomIndex]))
                {
                    services.Add(collection[randomIndex]);
                }
            }

            return services;
        }
    }
}
