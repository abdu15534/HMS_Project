using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Module.InitialData
{
    class ClinicServiceInitialData
    {
        public int ClinicServicesID { get; set; }
        public string ClinicServicesName { get; set; }
        public decimal Price { get; set; }

        public List<ClinicServiceInitialData> CardiacClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 0 , ClinicServicesName = "رسم قلب عادى EKG -NORMAL", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 1 , ClinicServicesName = "رسم قلب طويل EKG -Strip", Price = 225 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 2 , ClinicServicesName = "رسم قلب بالمجهود  STRESS TEST TREDMILL", Price = 900 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 3 , ClinicServicesName = "هولتر للقلب (رسم قلب 24 ساعة HOLTER MONITOR  - 24 HOURS", Price = 850 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 4 , ClinicServicesName = "تسجيل ضغط الدم 24 ساعة", Price = 850 });

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> LiverClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 5, ClinicServicesName = "منظار على المعدة والاثنى عشر", Price = 2100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 6, ClinicServicesName = "منظار قصير للقولون", Price = 1700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 7, ClinicServicesName = "منظار طويل  للقولون", Price = 3000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 8, ClinicServicesName = "حقن قرحة نازفة", Price = 3000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 9, ClinicServicesName = "استخراج جسم غريب", Price = 3000 });

            return ClinicServiceCollection;
        }

        
        public List<ClinicServiceInitialData> OBGYNClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 10, ClinicServicesName = "موجات صوتيه عن طريق المهبل STANDARD ULTRASOUND:TRANSVAGINAL", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 11, ClinicServicesName = "موجات صوتيه للحمل STANDARD ULTRASOUND:OBSTETRICS", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 12, ClinicServicesName = "تركيب لولب نحاسى او عادى I.U.D. INSERTION COPPER OR SILVER", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 13, ClinicServicesName = "خلع لولب I.U.D. REMOVAL", Price = 350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 14, ClinicServicesName = "عينة من عنق الرحم بدون اتعاب المعملPAP SMEAR - WITHOUT LAB. FEES  ", Price = 250 });

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> AndrologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 15, ClinicServicesName = "الفحص بالموجات فوق الصوتية(الدوبلر الملون) على الخصيتين DUPPLER  TESTIS", Price = 450 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 16, ClinicServicesName = "جهاز قياس قوة الانتصاب  RIGISCAN  ", Price = 450 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 17, ClinicServicesName = "حقن موضعى بالجسم الكهفى للقضيب بدواء البروستين او الكوادمكس  INTRACAVERNOSAL INJECTION TESTL", Price = 450 });
            

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> DermatologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 18, ClinicServicesName = "كى سنطة /عين سمكة , الاولى  ELCTRO CAUTERY – FIRST ONE", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 19, ClinicServicesName = "كى كل سنطة /عين سمكة , بعد الاولى  ELCTRO CAUTERY – AFTER FIRST ONE", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 20, ClinicServicesName = "ازالة سنطة او عين سمكة  SKIN TAG EXCISION", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 21, ClinicServicesName = "ازالة الرؤوس البيضاء WHITE COMEDO EXTRACTION", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 22, ClinicServicesName = "ازالة الرؤوس السوداء BLACK COMEDO EXTRACTION", Price = 250 });

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> UrologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 23, ClinicServicesName = "قياس تدفق البول   GU: FLOWMETRY", Price = 350 });
            

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> EarNoseAudiologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 24, ClinicServicesName = "قياس السمع     PURE TONE AUDIOMETERY-  PTA", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 25, ClinicServicesName = "قياس ضغط الأذن   TYMPANOMETRY", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 26, ClinicServicesName = "قياس السمع وضغط الأذن AUDIOMETERY+TYMPANOMETERY", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 27, ClinicServicesName = "حشو الأنف أو كي بالأنف أو غسيل الأذن  NASAL CAUTERY BY SILVER NITRATE OR EAR WASH", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 28, ClinicServicesName = "رد مغلق لكسر الأنف CLOSED REDUCTION OF NASAL FRACTURE", Price = 350 });

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> NeurologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 29, ClinicServicesName = "الرسم الكهربائي للعضلات  ROUTINE EMG", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 30, ClinicServicesName = "جهاز الجهد المثار- اعتيادي  ROUTINE EVOKED POTENTIALS ", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 31, ClinicServicesName = "فحص اختناق العصب الأوسط عند الرسغ  CARPAL TUNNEL SUNDROME", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 32, ClinicServicesName = "رسم عضلات وتوصيل عصب لطرف علوي واحد أو احد الأعصاب الدماغية  EMG&NCV OF ONE UPPER LIMB;CRANIAL NERVE EXAM", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 33, ClinicServicesName = "رسم عضلات وتوصيل عصب لطرفين علويين EMG&NCV OF TWO UPPER LIMBS", Price = 1100 });

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> AnesthesiologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 34, ClinicServicesName = "تركيب قسطرة وريد مركزى INSERTION OF A CENTRAL VENOUS CATHETER", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 35, ClinicServicesName = "حقن/سحب من سائل النخاع الشوكى  INTRATHECAL INJECTION OR ASPIRATION", Price = 1350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 36, ClinicServicesName = "تركيب ماهوكر INSERTION OF MAHOOKER", Price = 1350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 37, ClinicServicesName = "موجات صوتية للقلب عن طريق المرئ اثناء الجراحة   INTRAOPERATIVE TEE BY ANESTHIA DOCTOR", Price = 1800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 38, ClinicServicesName = "تركيب قسطرة خارج الام الجافية  INSERTION OF EPIDURAL CATHETER", Price = 1500 });

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> VascularClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 39, ClinicServicesName = "حقن الدوالى الساق السطحية بالعيادات او الطوارئ  SPIDER VEINS INJECTION", Price = 4000 });
            

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> OphthalmicClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 40, ClinicServicesName = "كشف نظارة – لا يخضع لخصم التعاقد EYE GLASSES TEST – NOT DISCOUNTABLE", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 41, ClinicServicesName = "ازالة كيس دهنى بعيادة الرمد عين واحدة – ويضاف اتعاب تخدير فى الاطفال لاستخدام العمليات CHASLAZION REMOVAL ONE EYE – ADD ANESTHESIA FEES FOR PEDIATRIC IF NEEDED", Price = 1500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 42, ClinicServicesName = "ازالة حبوب بعيادة الرمد عين واحدة MULTIPLE PTD’S REMOVAL FOR ONE EYE", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 43, ClinicServicesName = "ازالة شعرة او جسم غريب بعيادة الرمد عين واحدة REMOVAL OF EYELASHE OR FOREIGN BODY FOR ONE EYE", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 44, ClinicServicesName = "حقن تحت الملتحمة بعيادة الرمد عين واحدة    SUBCONJUNCTIVA INJECTION FOR ONE EYE", Price = 700 });

            return ClinicServiceCollection;
        }
    }
}
