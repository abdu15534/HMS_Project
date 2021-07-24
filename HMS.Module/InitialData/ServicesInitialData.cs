using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.InitialData
{
    class ServicesInitialData
    {
        public decimal price { get; set; }
        public string name { get; set; }
        public ServiceTypes serviceType { get; set; }

        public List<ServicesInitialData> services()
        {
            List<ServicesInitialData> serviceCollection = new List<ServicesInitialData>();

            serviceCollection.Add(new ServicesInitialData() { name = "Chest-X RAY", price = 600, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "CT-CHEST", price = 1500, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "CT-BRAIN", price = 1500, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "ECHO", price = 1200, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "COLORE Dopler", price = 1000, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "ULTRA SOUND", price = 800, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "MONITOR", price = 200, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "رسم قلب", price = 300, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "Chest-X RAY", price = 600, serviceType = ServiceTypes.Xrays });
            serviceCollection.Add(new ServicesInitialData() { name = "Chest-X RAY", price = 600, serviceType = ServiceTypes.Xrays });


            serviceCollection.Add(new ServicesInitialData() { name = "نقل دم", price = 1200, serviceType = ServiceTypes.Other });
            serviceCollection.Add(new ServicesInitialData() { name = "نقل دم مفلتر", price = 2400, serviceType = ServiceTypes.Other });
            serviceCollection.Add(new ServicesInitialData() { name = "نقل بلازما", price = 250, serviceType = ServiceTypes.Other });
            serviceCollection.Add(new ServicesInitialData() { name = "صفائح 6 وحدات", price = 1800, serviceType = ServiceTypes.Other });
            serviceCollection.Add(new ServicesInitialData() { name = "صفائح 12 وحدات", price = 3600, serviceType = ServiceTypes.Other });
            serviceCollection.Add(new ServicesInitialData() { name = "علاج طبيعي ", price = 400, serviceType = ServiceTypes.Other });
            serviceCollection.Add(new ServicesInitialData() { name = "بذل بطن", price = 1200, serviceType = ServiceTypes.Other });
            

            serviceCollection.Add(new ServicesInitialData() { name = "اكسجين", price = 800, serviceType = ServiceTypes.Oxygen });
            serviceCollection.Add(new ServicesInitialData() { name = "اكسجين CPAP", price = 1000, serviceType = ServiceTypes.Oxygen });
            serviceCollection.Add(new ServicesInitialData() { name = "اكسجين VENT", price = 1800, serviceType = ServiceTypes.Oxygen });
            

            serviceCollection.Add(new ServicesInitialData() { name = "ماسحه covid- 19", price = 2000, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "CBC", price = 150, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "VBG", price = 400, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "ABG", price = 400, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "NA", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "K", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "CA Total", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "CA lonised", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Mg", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Phosphours", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "GPT (ALT)", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "GOT (AST)", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "GGT", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Bilirubin (Toal)", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Bilirubin (Direct)", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Albumin", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Total protin", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "HCV Ab", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "HBs Ag", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "HIV 1 and 2", price = 150, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "HAV LgG LgM", price = 150, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Creatinine", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Urea", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Uric Acid", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Procalcitonin", price = 1000, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Ferritin", price = 500, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "D-dimer", price = 500, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "TSH", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "T3", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "T4", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Urine Analysis", price = 40, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "URINE C/S", price = 360, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "BLOOD C/S", price = 450, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "SPUTUM C/S", price = 300, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "WOUND SWAB", price = 315, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Stool Analysis", price = 40, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Pus C/S", price = 300, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Ammonia level", price = 500, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "HABIC", price = 200, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "lipid Profeil", price = 220, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "ABO +RH", price = 65, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "Troponin", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "CK", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "CK Mb", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "ESR", price = 100, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "ALP", price = 75, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "VIT-D", price = 400, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "PT (INR)", price = 110, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "PTT", price = 110, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "IL6", price = 800, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "PSA  T&F", price = 450, serviceType = ServiceTypes.Tests });
            serviceCollection.Add(new ServicesInitialData() { name = "AFP", price = 150, serviceType = ServiceTypes.Tests });

            return serviceCollection;
        }
    }
}
