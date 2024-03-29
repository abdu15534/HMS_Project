﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafDataModel.Module.BusinessObjects.test2
{
    public static class ConnectionHelper
    {
        static Type[] persistentTypes = new Type[] {
            typeof(Appointment),
            typeof(Patient),
            typeof(Admission),
            typeof(Product),
            typeof(Category),
            typeof(Inventory),
            typeof(Employee),
            typeof(Room),
            typeof(Service),
            typeof(ServiceDetails),
            typeof(Payments),
            typeof(StayMedications),
            typeof(StaySupplies),
            typeof(Companion),
            typeof(CompanionDetails),
            typeof(StockProduct),
            typeof(FinancialExchange),
            typeof(AbsenceDetails),
            typeof(VacationDetails),
            typeof(BonusDetails),
            typeof(DeductionDetails),
            typeof(CompensationDetails),
            typeof(Warning),
            typeof(SalaryAdvance),
            typeof(Supplier),
            typeof(PurchasingOrder),
            typeof(PurchasingOrderDetail),
            typeof(SpendingsCategory),
            typeof(Spendings),
            typeof(OrderExchange),
            typeof(Emergency),
            typeof(Clinc),
            typeof(Safe),
            typeof(MasterAccount),
            typeof(SubAccount),
            typeof(Account),
            typeof(JournalEntry),
            typeof(StartAccounts),
            typeof(StartAccountsDetails),
            typeof(JournalDetails),
            typeof(receiptClientBond),
            typeof(Bank),
            typeof(ProductUnit),
            typeof(ReceptionDesk),
            typeof(bed),
            typeof(Pharmacy),
            typeof(EndscopeDetails),
            typeof(Test),
            typeof(Endscope),
            typeof(Xrays),
            typeof(XraysDetails),
            typeof(TestDetails),
            typeof(Section),
            typeof(Job),
            typeof(SalaryPayment),
            typeof(SalaryPaymentDetails),
            typeof(ServiceFirstCategory),
            typeof(ServiceSecondCategory),
            typeof(SalaryDeduction),
            typeof(SalaryDeductionDetails),
            typeof(SupervisionDetails),
            typeof(paymentSupplierBond),
            typeof(ClinicServiceDetail),
            typeof(EmergencyServiceDetails),
            typeof(Consultant),
            typeof(ConsultantDetails),
            typeof(Package),
            typeof(PackageDetail),
            typeof(SuppliesSettings),
            typeof(StockTransfer),
            typeof(TransferProduct),
            typeof(Department),
            typeof(WearhouseType),
            typeof(ProductRefund),
            typeof(PurchaseRequest),
            typeof(PurchaseRequestDetail),
            typeof(InPatientSettings),
            typeof(SurgicalCategory),
            typeof(surgeryRoom),
            typeof(PreSchdual),
            typeof(Surgery),
            typeof(SurgerySchedule),
            typeof(SurgeryPackage),
            typeof(ReceiptItem),
            typeof(OutMedication)
        };
        public static Type[] GetPersistentTypes()
        {
            Type[] copy = new Type[persistentTypes.Length];
            Array.Copy(persistentTypes, copy, persistentTypes.Length);
            return copy;
        }
        public static string ConnectionString { get { return System.Configuration.ConfigurationManager.ConnectionStrings["DESKTOP-TCE86V6HMS"].ConnectionString; } }
        public static void Connect(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, bool threadSafe = false)
        {
            if (threadSafe)
            {
                var provider = XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
                var dictionary = new DevExpress.Xpo.Metadata.ReflectionDictionary();
                dictionary.GetDataStoreSchema(persistentTypes);
                XpoDefault.DataLayer = new ThreadSafeDataLayer(dictionary, provider);
            }
            else
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
            }
            XpoDefault.Session = null;
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption, out objectsToDisposeOnDisconnect);
        }
        public static IDataLayer GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
        }
    }

}
