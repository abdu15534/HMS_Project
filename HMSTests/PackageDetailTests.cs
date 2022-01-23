using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using XafDataModel.Module.BusinessObjects.test2;
using static System.Net.Mime.MediaTypeNames;

namespace HMSTests
{

    [TestFixture]
    public class PackageDetailTests
    {
        IDataLayer dataLayer;
        UnitOfWork session;
        Patient patient;
        ReceptionDesk reception;
        Package testPackage;
        PackageDetail packageDetail;
        [OneTimeSetUp]
        public void OneTimeSetUp() { XpoDefault.Session = null; }
    
        [SetUp]
        public void SetUp()
        {
            dataLayer = new SimpleDataLayer(new InMemoryDataStore(AutoCreateOption.DatabaseAndSchema, false));
            session = new UnitOfWork(dataLayer);

            InPatientSettings settings = new InPatientSettings(session);
            settings.ServiceRate = 15;
            settings.StampPrice = 20;

            patient = new Patient(session);
            patient.FullName = "ahmed ali clay mahmoud";
            patient.DateOfBrith = DateTime.Now;
            patient.nationalID = "12345678912345";
            patient.PhoneNumber1 = "12345678912";
            patient.account.accountNumber = 100021;
            session.CommitChanges();

            reception = new ReceptionDesk(session);
            reception.patient = patient;
            reception.dateEnter = new DateTime(2022, 1, 18);
            Room room = new Room(session);
            room.number = 101;
            room.roomCost = 2000;
            room.supervisionCost = 1000;
            room.careCost = 2000;
            bed bed = new bed(session);
            bed.number = "1";
            bed.room = room;
            reception.room = room;
            reception.bed = bed;
            session.CommitChanges();
            reception.Admissions[0].StayStart = new DateTime(2022, 1, 18, 15, 10, 20);
            reception.CalculateTotal();
            reception.Admissions[0].DaysOfStay();
            reception.Admissions[0].CalculateRoomServices();

            testPackage = new Package(session) { Name = "Test Package", SuppliesLimit = 1000, Price = 10000 };

            List<Product> productList = new List<Product>
            {
                new Product(session) {id= 1, name = "سرنجة 1 سم (انسولين)", purchasingPrice = 5, sellingPrice = 7 },
                new Product(session) {id= 2, name = "سرنجة 3 سم", purchasingPrice = 5, sellingPrice = 5 },
                new Product(session) {id= 3, name = "سرنجة 5 سم", purchasingPrice = 5, sellingPrice = 5 },
                new Product(session) {id= 4, name = "سرنجة 10 سم", purchasingPrice = 5, sellingPrice = 10 },
                new Product(session) {id= 5, name = "سرنجة 50 سم ببوز (رايل)", purchasingPrice = 5, sellingPrice = 50 },
                new Product(session) {id= 6, name = "ماسك أكسجين كبار", purchasingPrice = 5, sellingPrice = 45 },
                new Product(session) {id= 7, name = "ماسك نيبولايزر كبار", purchasingPrice = 5, sellingPrice = 45 },
                new Product(session) {id= 8, name = "نيزل أكسجين كبار , نيزل كانيولا", purchasingPrice = 5, sellingPrice = 45 },
                new Product(session) {id= 9, name = "جوانتى معقم مقاسات", purchasingPrice = 5, sellingPrice = 30 },
                new Product(session) {id= 10, name = "جوانتى لاتكس", purchasingPrice = 5, sellingPrice = 450 },
                new Product(session) {id= 11, name = " قسطرة فولى 2 شعبة مقاسات", purchasingPrice = 5, sellingPrice = 50 },
                new Product(session) {id= 12, name = " قسطرة شفط نيلتون مقاسات", purchasingPrice = 5, sellingPrice = 20 },
                new Product(session) {id= 13, name = " كيس جمع بول كبار", purchasingPrice = 5, sellingPrice = 40 },
                new Product(session) {id= 14, name = " كيس جمع بول عادى 2 لتر", purchasingPrice = 5, sellingPrice = 40 },
                new Product(session) {id= 15, name = "كيس جمع بول أطفال", purchasingPrice = 5, sellingPrice = 40 },
                new Product(session) {id= 16, name = "ابرة كانيولا مقاسات مختلفة", purchasingPrice = 5, sellingPrice = 30 }, 
                new Product(session) {id= 17, name = "كانيولا مقاس 24 صفرا (أطفال", purchasingPrice = 5, sellingPrice = 30 }
            };

            var purchasingSettings = new SuppliesSettings(session)
            {
                FromNotTo4 = 3, From5To9 = 2, From10To90 = 1.5, From91To149 = 1.3, From150ToAll = 1.25
            };
            var inv = new Inventory(session) { Name = "stock", };
            session.CommitChanges();
            var order = new PurchasingOrder(session);

            foreach (var item in productList)
            {
                var orderDetail = new PurchasingOrderDetail(session) { product = item, price = item.purchasingPrice, puchasingOrder = order, quantity = 400};
            }
            session.CommitChanges();
            order.OrderConfirm(true);
            session.CommitChanges();
        }
        
        [Test]
        public void TestMethod1()
        {
            //Arange
            packageDetail = new PackageDetail(session);
            packageDetail.Package = testPackage;
            
            session.CommitChanges();

            var supply1 = new StaySupplies(session) { Stay = reception.currentStay, supplyProduct = session.Query<StockProduct>().Where(s => s.product.name == "سرنجة 1 سم (انسولين)").First(), quantity = 0};
            var supply2 = new StaySupplies(session) { Stay = reception.currentStay, supplyProduct = session.Query<StockProduct>().Where(s => s.product.name == "سرنجة 3 سم").First(), quantity = 0 };
            var supply3 = new StaySupplies(session) { Stay = reception.currentStay, supplyProduct = session.Query<StockProduct>().Where(s => s.product.name == "سرنجة 5 سم").First(), quantity = 0 };
            var supply4 = new StaySupplies(session) { Stay = reception.currentStay, supplyProduct = session.Query<StockProduct>().Where(s => s.product.name == "ماسك نيبولايزر كبار").First(), quantity = 0 };
            var supply5 = new StaySupplies(session) { Stay = reception.currentStay, supplyProduct = session.Query<StockProduct>().Where(s => s.product.name == "ابرة كانيولا مقاسات مختلفة").First(), quantity = 0 };
            session.CommitChanges();
            packageDetail.Applyed = true;
            packageDetail.ApplyAnyPackage();
            session.CommitTransaction();
            reception.CalculateTotal();
            reception.Admissions[0].DaysOfStay();
            Console.WriteLine(reception.Admissions[0].totalDays);
            Console.WriteLine(reception.amount);
            session.CommitChanges();
            Assert.IsTrue(packageDetail.Applyed == true);
        }
        
        [TearDown]
        public void TearDown()
        {
            session.Dispose();
            dataLayer.Dispose();
        }
    }
}
