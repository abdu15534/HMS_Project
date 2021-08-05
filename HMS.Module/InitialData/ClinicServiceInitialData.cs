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
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 0, ClinicServicesName = "موجات صوتية قلب اطفال ECHO", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 1, ClinicServicesName = "رسم قلب عادى EKG -NORMAL", Price = 80 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 2, ClinicServicesName = "رسم قلب بالمجهود  STRESS TEST TREDMILL", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 3, ClinicServicesName = "موجات صوتية للقلب  ECHO", Price = 220 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 4, ClinicServicesName = "قياس ضغط 24 ساعة", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 5, ClinicServicesName = "موجات صوتية على القلب بالمنظار", Price = 350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 6, ClinicServicesName = "رسم قلب ديناميكي (هولترمونيتور) 24 ساعة", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 7, ClinicServicesName = "رسم قلب ديناميكي (هولترمونيتور) 48 ساعة", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 8, ClinicServicesName = "فحص القلب بالموجات الصوتيه بالمجهود الذاتى", Price = 400 });

            return ClinicServiceCollection;
        }



        public List<ClinicServiceInitialData> OBGYNClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 9, ClinicServicesName = "موجات صوتيه عن طريق المهبل STANDARD ULTRASOUND:TRANSVAGINAL", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 10, ClinicServicesName = "موجات صوتيه للحمل STANDARD ULTRASOUND:OBSTETRICS", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 11, ClinicServicesName = "تركيب لولب نحاسى او عادى I.U.D. INSERTION COPPER OR SILVER", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 12, ClinicServicesName = "خلع لولب I.U.D. REMOVAL", Price = 350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 13, ClinicServicesName = "عينة من عنق الرحم بدون اتعاب المعملPAP SMEAR - WITHOUT LAB. FEES  ", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 14, ClinicServicesName = "موجات صوتيه مهبلية بالعيادة VAGINAL U/S IN OB.GYN.CLINIC", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 15, ClinicServicesName = "اخذ عينة من الرحم بدون اتعاب المعمل ENDOMETRIAL BIOPSY - WITHOUT LAB. FEES", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 16, ClinicServicesName = "منظار رحمى واخذ عينة بدون اتعاب المعمل HYSTROSCOPY& BIOPSY WITHOUT LAB  FEES ", Price = 1700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 17, ClinicServicesName = "سحب عينة من سائل الرحم بعيادة النساءAMNIOCENTESIS", Price = 1100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 18, ClinicServicesName = "سحب عينة من المشيمة بعيادة النساءVILLOUS SAMPLING CHRONIC", Price = 1100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 19, ClinicServicesName = "تركيب لولب هرمونى I.U.D. INSERTION  - HORMONIC", Price = 1100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 20, ClinicServicesName = "متابعة حمل 10 زيارات+ 10 سونار حمل PREGNENCY FOLLOW UP(10 VISITS+10 U/S) OBSTETRICS ABDOMINAL", Price = 2200 });

            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> AndrologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 21, ClinicServicesName = "الفحص بالموجات فوق الصوتية(الدوبلر الملون) على الخصيتين DUPPLER  TESTIS", Price = 450 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 22, ClinicServicesName = "جهاز قياس قوة الانتصاب  RIGISCAN  ", Price = 450 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 23, ClinicServicesName = "حقن موضعى بالجسم الكهفى للقضيب بدواء البروستين او الكوادمكس  INTRACAVERNOSAL INJECTION TESTL", Price = 450 });


            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> DermatologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 24, ClinicServicesName = "كى سنطة /عين سمكة , الاولى  ELCTRO CAUTERY – FIRST ONE", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 25, ClinicServicesName = "كى كل سنطة /عين سمكة , بعد الاولى  ELCTRO CAUTERY – AFTER FIRST ONE", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 26, ClinicServicesName = "ازالة سنطة او عين سمكة  SKIN TAG EXCISION", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 27, ClinicServicesName = "ازالة الرؤوس البيضاء WHITE COMEDO EXTRACTION", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 28, ClinicServicesName = "ازالة الرؤوس السوداء BLACK COMEDO EXTRACTION", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 29, ClinicServicesName = "عينة من الجلد SKIN BIOPSY", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 30, ClinicServicesName = "حقن موضعى  MESOTHERAPY", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 31, ClinicServicesName = "تقشير كيماوى CHEMICAL PEELING", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 32, ClinicServicesName = "ازالة التكيسات الخلوية بالوجه  EXCISION OF SEBACEOUS CYST", Price = 250 });


            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> UrologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 33, ClinicServicesName = "قياس تدفق البول   GU: FLOWMETRY", Price = 350 });


            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> EarNoseAudiologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 34, ClinicServicesName = "قياس السمع     PURE TONE AUDIOMETERY-  PTA", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 35, ClinicServicesName = "قياس ضغط الأذن   TYMPANOMETRY", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 36, ClinicServicesName = "قياس السمع وضغط الأذن AUDIOMETERY+TYMPANOMETERY", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 37, ClinicServicesName = "حشو الأنف أو كي بالأنف أو غسيل الأذن  NASAL CAUTERY BY SILVER NITRATE OR EAR WASH", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 38, ClinicServicesName = "رد مغلق لكسر الأنف CLOSED REDUCTION OF NASAL FRACTURE", Price = 350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 39, ClinicServicesName = "كشف بالميكروسكوب + شفط إفرازات الأذن MICROSCOPIC EXAM. + EAR SUCTION", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 40, ClinicServicesName = "منظار ألياف ضوئية للبلعوم الأنفي والحنجرة LARYNGOSCOPY", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 41, ClinicServicesName = "منظار ألياف ضوئية للأنف والبلعوم الأنفي NASO+PHARYNGOSCOPY", Price = 550 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 42, ClinicServicesName = "منظار ألياف ضوئية للبلعوم الأنفي والحنجرة LARYNGOSCOPY", Price = 550 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 43, ClinicServicesName = "ازالة جسم غريب بعيادة الانف والاذن والحنجرة- ولا تخضع لخصم التعاقدREMOVE FOREIGN BODY   IN E.N.T CLINIC – NOT DISCOUNTABLE", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 44, ClinicServicesName = "جلسة تمرينات دوار حركى(apley) ولا تخضع لخصم التعاقد APLEY – NOT DISCOUNTABLE", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 45, ClinicServicesName = "شفط افرازات الاذن   EAR SUCTION ", Price = 200 });
            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> NeurologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 46, ClinicServicesName = "الرسم الكهربائي للعضلات  ROUTINE EMG", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 47, ClinicServicesName = "جهاز الجهد المثار- اعتيادي  ROUTINE EVOKED POTENTIALS ", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 48, ClinicServicesName = "فحص اختناق العصب الأوسط عند الرسغ  CARPAL TUNNEL SUNDROME", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 49, ClinicServicesName = "رسم عضلات وتوصيل عصب لطرف علوي واحد أو احد الأعصاب الدماغية  EMG&NCV OF ONE UPPER LIMB;CRANIAL NERVE EXAM", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 50, ClinicServicesName = "رسم عضلات وتوصيل عصب لطرفين علويين EMG&NCV OF TWO UPPER LIMBS", Price = 1100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 51, ClinicServicesName = "رسم عضلات وتوصيل عصب لطرف سفلى واحد أو احد عضلات الشرج EMG&NCV OF ONE LOWER LIMB-;SACRAL FUNCTION", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 52, ClinicServicesName = "رسم عضلات وتوصيل عصب لطرفين سفليين EMG&NCV OF TWO LOWER LIMBS", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 53, ClinicServicesName = "رسم عضلات وتوصيل أعصاب شامل SYSTEMIC DISORDER", Price = 1400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 54, ClinicServicesName = "رسم المخ من نصف ساعة حتى ساعة  ELECTROENCEPHALOGRAPH UP TO ONE HOUR", Price = 1100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 55, ClinicServicesName = "رسم المخ حتى ساعتين ELECTROENCEPHALOGRAPH UP TO TWO HOURS", Price = 1500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 56, ClinicServicesName = "رسم المخ حتى اربع ساعات ELECTROENCEPHALOGRAPH UP TO FOUR HOURS", Price = 2750 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 57, ClinicServicesName = "رسم مخ مطول حتى ست ساعات ELECTROENCEPHALOGRAPH STRIP UP TO SIX HOURS", Price = 4000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 58, ClinicServicesName = "رسم مخ مطول حتى 12 ساعة  ELECTROENCEPHALOGRAPH UP TO 12 HOURS", Price = 5500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 59, ClinicServicesName = "رسم مخ مستمر لمدة يوم ELECTROENCEPHALOGRAPH CONTINUES-  FOR ONE DAY", Price = 10000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 60, ClinicServicesName = "جهد مثار حسى SSEP", Price = 1400 });
            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> AnesthesiologyClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 61, ClinicServicesName = "تركيب قسطرة وريد مركزى INSERTION OF A CENTRAL VENOUS CATHETER", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 62, ClinicServicesName = "حقن/سحب من سائل النخاع الشوكى  INTRATHECAL INJECTION OR ASPIRATION", Price = 1350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 63, ClinicServicesName = "تركيب ماهوكر INSERTION OF MAHOOKER", Price = 1350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 64, ClinicServicesName = "موجات صوتية للقلب عن طريق المرئ اثناء الجراحة   INTRAOPERATIVE TEE BY ANESTHIA DOCTOR", Price = 1800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 65, ClinicServicesName = "تركيب قسطرة خارج الام الجافية  INSERTION OF EPIDURAL CATHETER", Price = 1500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 66, ClinicServicesName = "	أتعاب تركيب بورتا كاث او بيرميكاث/  قسطرة ذيل الخنزير او هيكمان Dr. fees for Insertion of portcath or permicath or pigtail or heckman", Price = 3500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 67, ClinicServicesName = "	أتعاب رفع او تسليك بورتا كاث اوبيرميكاث او هيكمان Dr. fees for removal or repair obstruction of  portcath or permicath or heckman", Price = 1500 });
            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> VascularClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 68, ClinicServicesName = "حقن الدوالى الساق السطحية بالعيادات او الطوارئ  SPIDER VEINS INJECTION", Price = 4000 });


            return ClinicServiceCollection;
        }

        public List<ClinicServiceInitialData> OphthalmicClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 69, ClinicServicesName = "كشف نظارة – لا يخضع لخصم التعاقد EYE GLASSES TEST – NOT DISCOUNTABLE", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 70, ClinicServicesName = "ازالة كيس دهنى بعيادة الرمد عين واحدة – ويضاف اتعاب تخدير فى الاطفال لاستخدام العمليات CHASLAZION REMOVAL ONE EYE – ADD ANESTHESIA FEES FOR PEDIATRIC IF NEEDED", Price = 1500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 71, ClinicServicesName = "ازالة حبوب بعيادة الرمد عين واحدة MULTIPLE PTD’S REMOVAL FOR ONE EYE", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 72, ClinicServicesName = "ازالة شعرة او جسم غريب بعيادة الرمد عين واحدة REMOVAL OF EYELASHE OR FOREIGN BODY FOR ONE EYE", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 73, ClinicServicesName = "حقن تحت الملتحمة بعيادة الرمد عين واحدة    SUBCONJUNCTIVA INJECTION FOR ONE EYE", Price = 700 });

            return ClinicServiceCollection;
        }


        public List<ClinicServiceInitialData> DentalClinicServices()
        {
            List<ClinicServiceInitialData> ClinicServiceCollection = new List<ClinicServiceInitialData>();

            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 74, ClinicServicesName = "عملية ازالة بقايا الجذور جراحيا", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 75, ClinicServicesName = "حشو معملى كمبوزيت", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 76, ClinicServicesName = "خلع درس العقل عادى", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 77, ClinicServicesName = "طقم كامل اكريلك علوى +سفلى", Price = 1200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 78, ClinicServicesName = "طقم علوى او سفلى", Price = 750 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 79, ClinicServicesName = "عملية ضرس عقل مدفون راسى", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 80, ClinicServicesName = "تضييق او تبطين طقم او تغيير قاعدة", Price = 350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 81, ClinicServicesName = "عملية ضرس عقل مدفون مائل", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 82, ClinicServicesName = "طقم اكريلك جزئى سوفت اكربلك للسن الواحد", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 83, ClinicServicesName = "عملية ضرس عقل مدفون مستعرض", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 84, ClinicServicesName = "نصف فيتالوم علوى او سفلى", Price = 750 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 85, ClinicServicesName = "عملية ضرس عقل مدفون ثابت جارد", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 86, ClinicServicesName = "ربع فيتالوم علوى او سفلى بدون اسنان", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 87, ClinicServicesName = "عملية ازالة الناب المدفون او الضاحك مدفون", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 88, ClinicServicesName = "طقم هارد اكريلك للسن الواحد", Price = 125 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 89, ClinicServicesName = "عملية ازالة سن زائد مدفون بالفك", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 90, ClinicServicesName = "اضافة اى سنة حتى 4 اسنان للواحدة", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 91, ClinicServicesName = "عملية اغلاق ناصور حيب انفى او فمى", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 92, ClinicServicesName = "اكثر من 6 اسنان سوفت اكريلك", Price = 1500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 93, ClinicServicesName = "عملية ازالة وكحت ناصور مزمن", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 94, ClinicServicesName = "الفك الواحد باستخدام الاسلاك الثابتة", Price = 4000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 95, ClinicServicesName = "زراعة اسنان بدون بورسلين", Price = 4000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 96, ClinicServicesName = "اعادة اللصق", Price = 50 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 97, ClinicServicesName = "كشف ناب مدفون جراحيا", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 98, ClinicServicesName = "سنة امامية غير شامل الحشو النهائى", Price = 350 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 99, ClinicServicesName = "ازالة الرواسب الجيرية وكحت جيوب لثوية للجلسة", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 100, ClinicServicesName = "الضاحك غير شامل الحشو النهائى", Price = 400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 101, ClinicServicesName = "ازالة زوائد لثوية لكل جزء من 4 اجزاء", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 102, ClinicServicesName = "الضرس غير شامل الحشو النهائى", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 103, ClinicServicesName = "جراحة لثوية لكل جزء من 4 اجزاء", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 104, ClinicServicesName = "علاج جذور اطفال", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 105, ClinicServicesName = "تلميع", Price = 100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 106, ClinicServicesName = "حافظ مسافة", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 107, ClinicServicesName = "تبيض اسنان", Price = 1200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 108, ClinicServicesName = "زراعة اسنان (بدون بورسلين) دفعة اولى", Price = 2000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 109, ClinicServicesName = "حشو ابيض زجاجى", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 110, ClinicServicesName = "زراعة اسنان (بدون بورسلين ) دفعة ثانية", Price = 2000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 111, ClinicServicesName = "حشو معملى بورسلين او زركنيوم", Price = 900 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 112, ClinicServicesName = "حشو معملى بورسلين او زركانيوم دفعة اولى", Price = 450 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 113, ClinicServicesName = "حشو معملى بورسلين او زركانيوم دفعة تانية", Price = 100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 114, ClinicServicesName = "طقم كامل اكريلك علوى +سفلى دفعة اولى", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 115, ClinicServicesName = "ثابت جارد دفعة اولى", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 116, ClinicServicesName = "طقم كامل اكريلك علوى +سفلى دفعة ثانية", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 117, ClinicServicesName = "ثابت جارد دفعة ثانية", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 118, ClinicServicesName = "طقم علوى او سفلى دفعة اولى", Price = 375 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 119, ClinicServicesName = "علاج جذور سنة امامية غير شامل الحشو النهائى دفغة ثانية", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 120, ClinicServicesName = "تاج زيركونيوم", Price = 1800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 121, ClinicServicesName = "نصف فيتالوم علوى او سفلى دفعة اولى", Price = 375 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 122, ClinicServicesName = "دعامة صب", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 123, ClinicServicesName = "نصف فيتالوم علوى او سفلى دفعة ثانية", Price = 375 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 124, ClinicServicesName = "دعامات جاهزة +بناء السن", Price = 700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 125, ClinicServicesName = "ربع طقم فيناليوم علوى وسفلى دفعة اولى", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 126, ClinicServicesName = "خلع طربوش ثابت", Price = 100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 127, ClinicServicesName = "ربع طقم فيناليوم علوى وسفلى دفعة ثانية", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 128, ClinicServicesName = "خلع تركيبة ثابتة لعدد 3 وحدات", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 129, ClinicServicesName = "تقويم الفك الواحد باستخدام اسلاك ثابتة دفعة اولى", Price = 2000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 130, ClinicServicesName = "خلع تركيبة ثابتة لاكثر من 3 وحدات", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 131, ClinicServicesName = "تقويم الفك الواحد باستخدام اسلاك ثابتة دفعة ثانية", Price = 2000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 132, ClinicServicesName = "تاج معدن فقط", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 133, ClinicServicesName = "لامنيت (قشرة بورسلين) دفعة اولى", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 134, ClinicServicesName = "تاج بورسلين", Price = 500  });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 135, ClinicServicesName = "لامنيت (قشرة بورسلين) دفعة ثانية", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 136, ClinicServicesName = "تقويم اسنان فك واحد بسلك ثابت", Price = 4000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 137, ClinicServicesName = "علاج جذور سنة امامية غير شامل الحشو النهائى دفعة اولى", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 138, ClinicServicesName = "تقويم اسنان فك واحد بجهاز شفاف", Price = 4000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 139, ClinicServicesName = "علاج جذور سنة امامية غير شامل الحشو النهائى دفعة ثانية", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 140, ClinicServicesName = "تقويم اسنان فك واحد بجهاز متحرك", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 141, ClinicServicesName = "علاج جذور الضاحك غير شامل الحشو النهائى دفعة اولى", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 142, ClinicServicesName = "جهاز تعديل وظيفى للفك الواحد", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 143, ClinicServicesName = "علاج جذور الضاحك غير شامل الحشو النهائى دفعة ثانية", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 144, ClinicServicesName = "خلع درس عادى", Price = 75 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 145, ClinicServicesName = "بقايا جذور", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 146, ClinicServicesName = "ازالة كيس دموى", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 147, ClinicServicesName = "علاج جذور اطفال دفعة اولى", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 148, ClinicServicesName = "كشف اسنان تحضيرى ايطالى", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 149, ClinicServicesName = "حشو معملى بورسلين او زركانيوم دفعة تانية", Price = 450 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 150, ClinicServicesName = "علاج جذور اطفال دفعة ثانية", Price = 100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 151, ClinicServicesName = "علاج جذور اسنان امامية ايطالى", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 152, ClinicServicesName = "تبيض الاسنان تلميع ايطالى", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 153, ClinicServicesName = "علاج جذور اسنان امامية cyst or abcess ايطالى", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 154, ClinicServicesName = "ازالة التصبغات اللثوية (فك علوى او سفلى)", Price = 1500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 155, ClinicServicesName = "علاج جذور اسنان امامية apciectomy ايطاالى", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 156, ClinicServicesName = "تعقيم الجيوب اللثوية للسن الواحدة", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 157, ClinicServicesName = "علاج جذور اسنان خلفية للقناة الواحدة ايطالى", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 158, ClinicServicesName = "علاج حساسية اسنان سن واحدة", Price = 850 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 159, ClinicServicesName = "ازالة اغشية مخاطية ايطالي labial", Price = 1200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 160, ClinicServicesName = "Composite class/ italy", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 161, ClinicServicesName = "ازالة اغشية مخاطية ايطالى lingual", Price = 2400 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 162, ClinicServicesName = "ازالة اغشية مخاطية ايطالي labial", Price = 1200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 163, ClinicServicesName = "ازالة اغشية مخاطية ايطالى allgaw", Price = 4000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 164, ClinicServicesName = "ازالة اورام حميدة ايطالى", Price = 3000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 165, ClinicServicesName = "ازالة انسجة فوق ضرس العقل ايطالى", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 166, ClinicServicesName = "علاج قرح الفم ايطالى", Price = 750 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 167, ClinicServicesName = "علاج تقيح الفم الفيروسى ايطالى", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 168, ClinicServicesName = "علاج الم مفصل الفك ايطالى", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 169, ClinicServicesName = "علاج التقيح بعد الخلع ايطالى", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 170, ClinicServicesName = "تطويل اللثوى لتاج السن لك سنة ايطالى", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 171, ClinicServicesName = "ازالة زوائد لثوية للسنة الواحدة ايطالى", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 172, ClinicServicesName = "ازالة زوائد لثوية لربع الفك ايطالى", Price = 2000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 173, ClinicServicesName = "ازالة زوائد لثوية للفك الواحد ايطالىايطالى", Price = 1500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 174, ClinicServicesName = "تبيض الاسنان زووم ايطالى)", Price = 3500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 175, ClinicServicesName = "تبيض الاسنان بالليزر ايطالىايطاالى", Price = 5000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 176, ClinicServicesName = "Composite class 1 italy", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 177, ClinicServicesName = "Composite class 2 italy", Price = 650 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 178, ClinicServicesName = "Composite class iv italy", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 179, ClinicServicesName = "Composite class v italy", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 180, ClinicServicesName = "Composite class 3 italy", Price = 650 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 181, ClinicServicesName = "Diastema ciosure italy", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 182, ClinicServicesName = "Post and core composite", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 183, ClinicServicesName = "Inaly and only zirconium", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 184, ClinicServicesName = "Only italy", Price = 1200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 185, ClinicServicesName = "Endo crown italy", Price = 1700 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 186, ClinicServicesName = "Single root italy", Price = 750 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 187, ClinicServicesName = "Double root italy", Price = 1500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 188, ClinicServicesName = "Fiber post + composit core italy", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 189, ClinicServicesName = "Molar italy", Price = 1800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 190, ClinicServicesName = "حشو معملى بورسلين او زركانيوم دفعة تانية", Price = 450 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 191, ClinicServicesName = "علاج جذور اطفال دفعة ثانية", Price = 100 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 192, ClinicServicesName = "Full porcelain (jacket Italy)", Price = 1800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 193, ClinicServicesName = "حشو ضوئى بسيط", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 194, ClinicServicesName = "e- max italy", Price = 3000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 195, ClinicServicesName = "حشو ضوئى مملغم", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 196, ClinicServicesName = "Zirconimum italy", Price = 2500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 197, ClinicServicesName = "Temporary italy", Price = 800 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 198, ClinicServicesName = "علاج شقوق fissure sealant", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 199, ClinicServicesName = "حشو ضوئى بناء ضرس", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 200, ClinicServicesName = "تطبيق فلوريدا", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 201, ClinicServicesName = "حقن (prp)", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 202, ClinicServicesName = "تاج استانلسيل", Price = 200 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 203, ClinicServicesName = "الفك الواحد باستخدام الاجهزة القابلة للازالة", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 204, ClinicServicesName = "الفك الواحد باستخدام الاجهزة القابلة للازالة  دفعة ثانية", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 205, ClinicServicesName = "الفك الواحد باستخدام الاجهزة القابلة للازالة  دفعة اولى", Price = 250 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 206, ClinicServicesName = "Veneers porcelain max italy", Price = 3000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 207, ClinicServicesName = "Laminate italy", Price = 2500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 208, ClinicServicesName = "Botox vial italy", Price = 4000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 209, ClinicServicesName = "Derma fillers italy", Price = 5000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 210, ClinicServicesName = "دعامة أسنان", Price = 150 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 211, ClinicServicesName = "تاج بورسلين دفعة اولى", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 212, ClinicServicesName = "تاج بورسلين دفعة ثانية", Price = 300 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 213, ClinicServicesName = "تاج زركونيوم دفعة اولى", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 214, ClinicServicesName = "تاج زركونيوم دفعة ثانية", Price = 600 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 215, ClinicServicesName = "دفعة اولى emax تاج ال", Price = 750 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 216, ClinicServicesName = "دفعة ثانية emax تاج ال", Price = 750 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 217, ClinicServicesName = "اضافة جبيرة فك ارشبار", Price = 1000 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 218, ClinicServicesName = "اضافة فتح خراج", Price = 500 });
            ClinicServiceCollection.Add(new ClinicServiceInitialData() { ClinicServicesID = 219, ClinicServicesName = "حشو مملغم", Price = 150 });

            return ClinicServiceCollection;
        }











    }
}
