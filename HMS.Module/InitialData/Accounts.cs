using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static XafDataModel.Module.BusinessObjects.test2.MasterAccount;

namespace HMS.Module.InitialData
{
    public class MasterAccount
    {
        public int accountNumber { get; set; }
        public string accountName { get; set; }
        public AccountClassifications classification { get; set; }


        public List<MasterAccount> InitialData()
        {
            List<MasterAccount> list = new List<MasterAccount>();
            #region rest of accounts
            list.Add(new MasterAccount() { accountNumber = 101, accountName = "اصول ثابته", classification = AccountClassifications.Assets }); //example
            list.Add(new MasterAccount() { accountNumber = 102, accountName = "مخزون", classification = AccountClassifications.Assets }); //example
            list.Add(new MasterAccount() { accountNumber = 103, accountName = "عملاء و اوراق قبض و حسابات ", classification = AccountClassifications.Assets }); //example
            list.Add(new MasterAccount() { accountNumber = 104, accountName = "نقدية بالبنوك و الصندوق", classification = AccountClassifications.Assets }); //example
            list.Add(new MasterAccount() { accountNumber = 201, accountName = "راس مال مدفوع", classification = AccountClassifications.Liabilities }); //example
            list.Add(new MasterAccount() { accountNumber = 202, accountName = "احتياطيات", classification = AccountClassifications.Liabilities }); //example
            list.Add(new MasterAccount() { accountNumber = 203, accountName = "ارباح مرحلة خسائر", classification = AccountClassifications.Liabilities }); //example
            list.Add(new MasterAccount() { accountNumber = 204, accountName = "التزامات طويلة الاجل", classification = AccountClassifications.Liabilities }); //example
            list.Add(new MasterAccount() { accountNumber = 205, accountName = "مخصصات", classification = AccountClassifications.Liabilities }); //example
            list.Add(new MasterAccount() { accountNumber = 206, accountName = "دائنون متنوعون", classification = AccountClassifications.Liabilities }); //example
            list.Add(new MasterAccount() { accountNumber = 207, accountName = "موردون و اوراق دفع و حسابات", classification = AccountClassifications.Liabilities }); //example
            list.Add(new MasterAccount() { accountNumber = 301, accountName = "خدمات و وقود و قطع غيار", classification = AccountClassifications.Expenses }); //example
            list.Add(new MasterAccount() { accountNumber = 302, accountName = "اجور", classification = AccountClassifications.Expenses }); //example
            list.Add(new MasterAccount() { accountNumber = 303, accountName = "مصروفات", classification = AccountClassifications.Expenses }); //example
            list.Add(new MasterAccount() { accountNumber = 304, accountName = "مشتريات بضاعة بغرض البيع", classification = AccountClassifications.Expenses }); //example
            list.Add(new MasterAccount() { accountNumber = 305, accountName = "اعباء و خسائر", classification = AccountClassifications.Expenses }); //example
            list.Add(new MasterAccount() { accountNumber = 401, accountName = "ايرادات النشاط", classification = AccountClassifications.Revenues }); //example
            list.Add(new MasterAccount() { accountNumber = 402, accountName = "منح و اعانات", classification = AccountClassifications.Revenues }); //example
            list.Add(new MasterAccount() { accountNumber = 403, accountName = "ايرادات و ارباح اخري", classification = AccountClassifications.Revenues }); //example
            list.Add(new MasterAccount() { accountNumber = 404, accountName = "ارباح فروق عملة", classification = AccountClassifications.Revenues }); //example
            #endregion
            return list;
        }

        /*        public int GenerateAccountNumber(MasterAccount acc)
                {

                }*/
    }



    public class SubAccount
    {

        public int accountNumber { get; set; }
        public string accountName { get; set; }
        public int masterAccountID { get; set; }


        public List<SubAccount> InitialData()
        {
            List<SubAccount> list = new List<SubAccount>();
            list.Add(new SubAccount() { accountNumber = 10101, accountName = "مباني و انشاءات و مرافق و طرق ", masterAccountID = 101 }); //example
            list.Add(new SubAccount() { accountNumber = 10102, accountName = "الات و معدات", masterAccountID = 101 }); //example
            list.Add(new SubAccount() { accountNumber = 10103, accountName = "وسائل نقل و انتقال", masterAccountID = 101 }); //example
            list.Add(new SubAccount() { accountNumber = 10104, accountName = "اثاث و تجهيزات مكتبية", masterAccountID = 101 }); //example
            list.Add(new SubAccount() { accountNumber = 10201, accountName = "مخزون بضاعة مشتراه بعضر البيع", masterAccountID = 102 }); //example
            list.Add(new SubAccount() { accountNumber = 10301, accountName = "عملاء", masterAccountID = 103 }); //example
            list.Add(new SubAccount() { accountNumber = 10302, accountName = "ورق قبض", masterAccountID = 103 }); //example
            list.Add(new SubAccount() { accountNumber = 10303, accountName = "حسابات مدينة لدي المصالح و الهيئات", masterAccountID = 103 }); //example
            list.Add(new SubAccount() { accountNumber = 10304, accountName = "ايرادات مستحقة التحصيل", masterAccountID = 103 }); //example
            list.Add(new SubAccount() { accountNumber = 10305, accountName = "مصروفات مدفوعة مقدما", masterAccountID = 103 }); //example
            list.Add(new SubAccount() { accountNumber = 10306, accountName = "حسابات مدينة اخري", masterAccountID = 103 }); //example
            list.Add(new SubAccount() { accountNumber = 10307, accountName = "شيكات تحت التحصيل", masterAccountID = 103 }); //example
            list.Add(new SubAccount() { accountNumber = 10401, accountName = "حسابات جارية بالبنوك", masterAccountID = 104 }); //example
            list.Add(new SubAccount() { accountNumber = 10402, accountName = "نقدية بالصندوق", masterAccountID = 104 }); //example
            list.Add(new SubAccount() { accountNumber = 20101, accountName = "راس مال المصدر", masterAccountID = 201 }); //example
            list.Add(new SubAccount() { accountNumber = 20102, accountName = "اقساط لم يطلب سدادها", masterAccountID = 201 }); //example
            list.Add(new SubAccount() { accountNumber = 20103, accountName = "اقساط متأخر سدادها", masterAccountID = 201 }); //example
            list.Add(new SubAccount() { accountNumber = 20104, accountName = "راس مال ارصدة بداية المدة", masterAccountID = 201 }); //example
            list.Add(new SubAccount() { accountNumber = 20201, accountName = "احتياطي قانوني", masterAccountID = 202 }); //example
            list.Add(new SubAccount() { accountNumber = 20202, accountName = "اختياطيات اخري", masterAccountID = 202 }); //example
            list.Add(new SubAccount() { accountNumber = 20301, accountName = "ارباح مرحلة خسائر", masterAccountID = 203 }); //example
            list.Add(new SubAccount() { accountNumber = 20401, accountName = "قروض طويلة الاجل من البنوك", masterAccountID = 204 }); //example
            list.Add(new SubAccount() { accountNumber = 20501, accountName = "مخصص اهلاك اصول ثابتة", masterAccountID = 205 }); //example
            list.Add(new SubAccount() { accountNumber = 20502, accountName = "مخصص هبوط اسعار مخزون البضائع", masterAccountID = 205 }); //example
            list.Add(new SubAccount() { accountNumber = 20503, accountName = "مخصص هبوط اسعار اوراق مالية", masterAccountID = 205 }); //example
            list.Add(new SubAccount() { accountNumber = 20504, accountName = "مخصص ديون مشكوك في تحصيلها ", masterAccountID = 205 }); //example
            list.Add(new SubAccount() { accountNumber = 20505, accountName = "مخصص ضرائب متنازع عليها ", masterAccountID = 205 }); //example
            list.Add(new SubAccount() { accountNumber = 20506, accountName = "مخصص لمطالبات و المنازعات ", masterAccountID = 205 }); //example
            list.Add(new SubAccount() { accountNumber = 20507, accountName = "مخصصات اخري ", masterAccountID = 205 }); //example
            list.Add(new SubAccount() { accountNumber = 20601, accountName = "سحب علي المكشوف", masterAccountID = 206 }); //example
            list.Add(new SubAccount() { accountNumber = 20602, accountName = "تمويل اعتمادات مستندية ", masterAccountID = 206 }); //example
            list.Add(new SubAccount() { accountNumber = 20603, accountName = "قروض قصيرة الاجل ", masterAccountID = 206 }); //example
            list.Add(new SubAccount() { accountNumber = 20604, accountName = "جاري الشركاء ", masterAccountID = 206 }); //example
            list.Add(new SubAccount() { accountNumber = 20701, accountName = "موردون", masterAccountID = 207 }); //example
            list.Add(new SubAccount() { accountNumber = 20702, accountName = "اوراق دفع ", masterAccountID = 207 }); //example
            list.Add(new SubAccount() { accountNumber = 20703, accountName = "حسابات دائنة للشركات ", masterAccountID = 207 }); //example
            list.Add(new SubAccount() { accountNumber = 20704, accountName = "حسابات دائنة للمصالح و الهيئات ", masterAccountID = 207 }); //example
            list.Add(new SubAccount() { accountNumber = 20705, accountName = "دائنين توزيعات ", masterAccountID = 207 }); //example
            list.Add(new SubAccount() { accountNumber = 20706, accountName = "شيكات موجلة الدفع ", masterAccountID = 207 }); //example
            list.Add(new SubAccount() { accountNumber = 20707, accountName = "حسابات دائنة اخري ", masterAccountID = 207 }); //example
            list.Add(new SubAccount() { accountNumber = 30101, accountName = "وقود و زيوت", masterAccountID = 301 }); //example
            list.Add(new SubAccount() { accountNumber = 30102, accountName = "قطع غيار و مهمات", masterAccountID = 301 }); //example
            list.Add(new SubAccount() { accountNumber = 30103, accountName = "مواد تعبئة و تغليف", masterAccountID = 301 }); //example
            list.Add(new SubAccount() { accountNumber = 30104, accountName = "كهرباء و مياه ", masterAccountID = 301 }); //example
            list.Add(new SubAccount() { accountNumber = 30105, accountName = "ادوات مكتبية ", masterAccountID = 301 }); //example
            list.Add(new SubAccount() { accountNumber = 30201, accountName = "اجور نقدية ", masterAccountID = 302 }); //example
            list.Add(new SubAccount() { accountNumber = 30202, accountName = "مزايا عينية ", masterAccountID = 302 }); //example
            list.Add(new SubAccount() { accountNumber = 30203, accountName = "تأمينات اجتماعية", masterAccountID = 302 }); //example
            list.Add(new SubAccount() { accountNumber = 30204, accountName = "مكافأت تشجيعية", masterAccountID = 302 }); //example
            list.Add(new SubAccount() { accountNumber = 30301, accountName = "خدمات مشتراه", masterAccountID = 303 }); //example
            list.Add(new SubAccount() { accountNumber = 30302, accountName = "اهلاك و استهلاك ", masterAccountID = 303 }); //example
            list.Add(new SubAccount() { accountNumber = 30303, accountName = "فوائد", masterAccountID = 303 }); //example
            list.Add(new SubAccount() { accountNumber = 30304, accountName = "ايجارات عقارية ", masterAccountID = 303 }); //example
            list.Add(new SubAccount() { accountNumber = 30305, accountName = "ضرائب عقارية", masterAccountID = 303 }); //example
            list.Add(new SubAccount() { accountNumber = 30306, accountName = "ضرائب غير مباشرة ", masterAccountID = 303 }); //example
            list.Add(new SubAccount() { accountNumber = 30401, accountName = "مشتريات بضاعة بغرض البيع", masterAccountID = 304 }); //example
            list.Add(new SubAccount() { accountNumber = 30501, accountName = "مخصصات بخلاف الاهلاك", masterAccountID = 305 }); //example
            list.Add(new SubAccount() { accountNumber = 30502, accountName = "ديون معدومة", masterAccountID = 305 }); //example
            list.Add(new SubAccount() { accountNumber = 30503, accountName = "اعباء و خسائر متنوعة", masterAccountID = 305 }); //example
            list.Add(new SubAccount() { accountNumber = 30504, accountName = "خسائر فروق العملة", masterAccountID = 305 }); //example
            list.Add(new SubAccount() { accountNumber = 30505, accountName = "مصروفات سنوات سابقة", masterAccountID = 305 }); //example
            list.Add(new SubAccount() { accountNumber = 30506, accountName = "توزيعات متنوعة", masterAccountID = 305 }); //example
            list.Add(new SubAccount() { accountNumber = 30507, accountName = "ضرائب الدخل", masterAccountID = 305 }); //example
            list.Add(new SubAccount() { accountNumber = 40101, accountName = "مبيعات بضاعة مشتراه", masterAccountID = 401 }); //example   
            list.Add(new SubAccount() { accountNumber = 40102, accountName = "خدمات مباعة", masterAccountID = 401 }); //example   
            list.Add(new SubAccount() { accountNumber = 40103, accountName = "ايرادات تشغيل للغير", masterAccountID = 401 }); //example   
            list.Add(new SubAccount() { accountNumber = 40104, accountName = "ايرادات تشغيل اخري", masterAccountID = 401 }); //example   
            list.Add(new SubAccount() { accountNumber = 40105, accountName = "ايرادات العيادات", masterAccountID = 401 }); //example   
            list.Add(new SubAccount() { accountNumber = 40106, accountName = "ايرادات القسم الداخلي", masterAccountID = 401 }); //example   
            list.Add(new SubAccount() { accountNumber = 40107, accountName = "ايرادات الطوارئ ", masterAccountID = 401 }); //example   
            list.Add(new SubAccount() { accountNumber = 40201, accountName = "منح و اعانات", masterAccountID = 402 }); //example   
            list.Add(new SubAccount() { accountNumber = 40301, accountName = "ديون سبق اعدامها", masterAccountID = 403 }); //example   
            list.Add(new SubAccount() { accountNumber = 40302, accountName = "ارباح بيع و اوراق مالية", masterAccountID = 403 }); //example   
            list.Add(new SubAccount() { accountNumber = 40303, accountName = "ايردات و ارباح متنوعة", masterAccountID = 403 }); //example   
            list.Add(new SubAccount() { accountNumber = 40401, accountName = "ايراد ارباح فروق عملة", masterAccountID = 404 }); //example    

            #region rest of accounts

            #endregion
            return list;
        }
    }

    public class Account
    {
        public int accountNumber { get; set; }
        public string accountName { get; set; }
        public int subAccountID { get; set; }


        public List<Account> InitialData()
        {
            List<Account> list = new List<Account>();
            list.Add(new Account() { accountNumber = 101010001, accountName = "مبني الادارة و المصنع", subAccountID = 10101 }); //example
            list.Add(new Account() { accountNumber = 101020001, accountName = "الات و معدات المصنع", subAccountID = 10102 }); //example
            list.Add(new Account() { accountNumber = 101030001, accountName = "سيارات", subAccountID = 10103 }); //example
            list.Add(new Account() { accountNumber = 101040001, accountName = "اثاث الادارة و المصنع", subAccountID = 10104 }); //example
            list.Add(new Account() { accountNumber = 102010001, accountName = "مخزون بضاعة اول المدة", subAccountID = 10201 }); //example
            list.Add(new Account() { accountNumber = 103010001, accountName = "عميل نقدي", subAccountID = 10301 }); //example
            list.Add(new Account() { accountNumber = 103020001, accountName = "اوراق قبض", subAccountID = 10302 }); //example
            list.Add(new Account() { accountNumber = 103020002, accountName = "اوراق قبض مرحلة من سنوات سابقة", subAccountID = 10302 }); //example
            list.Add(new Account() { accountNumber = 103030001, accountName = "تأمين مشروع", subAccountID = 10303 }); //example
            list.Add(new Account() { accountNumber = 103040001, accountName = "يرادات مستحقة التحصيل", subAccountID = 10304 }); //example
            list.Add(new Account() { accountNumber = 103040002, accountName = "جزاءات و غياب و تسويات مستحقة", subAccountID = 10304 }); //example
            list.Add(new Account() { accountNumber = 103050001, accountName = "مصروفات مدفوعة مقدما", subAccountID = 10305 }); //example
            list.Add(new Account() { accountNumber = 103060001, accountName = "حسابات مدينة اخري", subAccountID = 10306 }); //example
            list.Add(new Account() { accountNumber = 103060002, accountName = "سلف و حسميات موظفين", subAccountID = 10306 }); //example
            list.Add(new Account() { accountNumber = 103070001, accountName = "شيكات تحت التحصيل ", subAccountID = 10307 }); //example
            list.Add(new Account() { accountNumber = 103070002, accountName = "شيكات تحت التحصيل مرحلة من سنوات سابقة ", subAccountID = 10307 }); //example
            list.Add(new Account() { accountNumber = 104010001, accountName = "بنك الاهلي التجاري", subAccountID = 10401 }); //example
            list.Add(new Account() { accountNumber = 104010002, accountName = "فيزا كارت", subAccountID = 10401 }); //example
            list.Add(new Account() { accountNumber = 104020001, accountName = "صندوق رئيسي", subAccountID = 10402 }); //example
            list.Add(new Account() { accountNumber = 104020002, accountName = "خزينة فرعية", subAccountID = 10402 }); //example
            list.Add(new Account() { accountNumber = 201010001, accountName = "راس مال الشريك الاول", subAccountID = 20101 }); //example
            list.Add(new Account() { accountNumber = 201010002, accountName = "راس مال الشريك الثاني", subAccountID = 20101 }); //example
            list.Add(new Account() { accountNumber = 201010003, accountName = "راس مال الشريك الثالث", subAccountID = 20101 }); //example
            list.Add(new Account() { accountNumber = 201020001, accountName = "اقساط لم يطلب سدادها", subAccountID = 20102 }); //example
            list.Add(new Account() { accountNumber = 201030001, accountName = "اقساط متأخر سدادها", subAccountID = 20103 }); //example
            list.Add(new Account() { accountNumber = 201040001, accountName = "راس مال ارصدة بداية المدة", subAccountID = 20104 }); //example
            list.Add(new Account() { accountNumber = 202010001, accountName = "احتياطي قانوني", subAccountID = 20201 }); //example
            list.Add(new Account() { accountNumber = 202020001, accountName = "احتياطيات اخري", subAccountID = 20202 }); //example
            list.Add(new Account() { accountNumber = 203010001, accountName = "ارباح مرحلة خسائر", subAccountID = 20301 }); //example
            list.Add(new Account() { accountNumber = 204010001, accountName = "قروض بنك مصر", subAccountID = 20401 }); //example
            list.Add(new Account() { accountNumber = 205010001, accountName = "مخصص اهلاك مباني", subAccountID = 20501 }); //example
            list.Add(new Account() { accountNumber = 205010002, accountName = "مخصص اهلاك الات", subAccountID = 20501 }); //example
            list.Add(new Account() { accountNumber = 205010003, accountName = "مخصص اهلاك وسائل نقل", subAccountID = 20501 }); //example
            list.Add(new Account() { accountNumber = 205010004, accountName = "مخصص اهلاك عدد و ادوات", subAccountID = 20501 }); //example
            list.Add(new Account() { accountNumber = 205010005, accountName = "مخصص اهلاك اثاث و تجهيزات مكتبية", subAccountID = 20501 }); //example
            list.Add(new Account() { accountNumber = 205020001, accountName = "مخصص هبوط اسعار مخزون البضائع المشتراه", subAccountID = 20502 }); //example
            list.Add(new Account() { accountNumber = 205030001, accountName = "مخصص هبوط اسعار اوراق مالية ", subAccountID = 20503 }); //example
            list.Add(new Account() { accountNumber = 205040001, accountName = "مخصص ديون مشكوك في تحصيلها", subAccountID = 20504 }); //example
            list.Add(new Account() { accountNumber = 205050001, accountName = "مخصص ضرائب متنازع عليها", subAccountID = 20505 }); //example
            list.Add(new Account() { accountNumber = 205060001, accountName = "مخصص لمطالبات و المنازعات ", subAccountID = 20506 }); //example
            list.Add(new Account() { accountNumber = 205070001, accountName = "مخصصات اخري ", subAccountID = 20507 }); //example
            list.Add(new Account() { accountNumber = 206010001, accountName = "سحب علي المكشوف", subAccountID = 20601 }); //example
            list.Add(new Account() { accountNumber = 206020001, accountName = "تمويل اعتمادات مستندية ", subAccountID = 20602 }); //example
            list.Add(new Account() { accountNumber = 206030001, accountName = "قروض قصيرة الاجل ", subAccountID = 20603 }); //example
            list.Add(new Account() { accountNumber = 206040001, accountName = "جاري الشريك الاول", subAccountID = 20604 }); //example
            list.Add(new Account() { accountNumber = 206040002, accountName = "جاري الشريك الثاني", subAccountID = 20604 }); //example
            list.Add(new Account() { accountNumber = 206040003, accountName = "جاري الشريك الثالث", subAccountID = 20604 }); //example
            list.Add(new Account() { accountNumber = 207010001, accountName = "مورد نقدي", subAccountID = 20701 }); //example
            list.Add(new Account() { accountNumber = 207020001, accountName = "اوراق دفع", subAccountID = 20702 }); //example
            list.Add(new Account() { accountNumber = 207020002, accountName = "اوراق دفع مرحلة من سنوات سابقة", subAccountID = 20702 }); //example
            list.Add(new Account() { accountNumber = 207030001, accountName = "حسابات دائنة للشركات", subAccountID = 20703 }); //example
            list.Add(new Account() { accountNumber = 207040001, accountName = "حسابات دائنة للمصالح و الهيئات", subAccountID = 20704 }); //example
            list.Add(new Account() { accountNumber = 207040002, accountName = "مصلحة الجمارك قيمة مضافة ", subAccountID = 20704 }); //example
            list.Add(new Account() { accountNumber = 207040003, accountName = "مصلحة ضرائب عامة مستقطة من الغير", subAccountID = 20704 }); //example
            list.Add(new Account() { accountNumber = 207040004, accountName = "مصلحة ضرائب عامة مستقطة لدي الغير", subAccountID = 20704 }); //example
            list.Add(new Account() { accountNumber = 207040005, accountName = "الهيئة القومية للتامين الاجتماعي", subAccountID = 20704 }); //example
            list.Add(new Account() { accountNumber = 207040006, accountName = "هيئات تأمينية اخري", subAccountID = 20704 }); //example
            list.Add(new Account() { accountNumber = 207050001, accountName = "مصروفات توزيع مستحقة", subAccountID = 20705 }); //example
            list.Add(new Account() { accountNumber = 207050002, accountName = "ايرادات توزيع محصلة مقدما", subAccountID = 20705 }); //example
            list.Add(new Account() { accountNumber = 207060001, accountName = "شيكات موجلة الدفع", subAccountID = 20706 }); //example
            list.Add(new Account() { accountNumber = 207060002, accountName = "شيكات موجلة الدفع مرحلة من سنوات سابقة", subAccountID = 20706 }); //example
            list.Add(new Account() { accountNumber = 207070001, accountName = "جمعية التجار المتعاونين ", subAccountID = 20707 }); //example
            list.Add(new Account() { accountNumber = 301010001, accountName = "وقود و زيوت", subAccountID = 30101 }); //example
            list.Add(new Account() { accountNumber = 301020001, accountName = " قطع غيار و مهمات", subAccountID = 30102 }); //example
            list.Add(new Account() { accountNumber = 301030001, accountName = "مواد تعبئة و تغليف ", subAccountID = 30103 }); //example
            list.Add(new Account() { accountNumber = 301040001, accountName = "كهرباء و مياه ", subAccountID = 30104 }); //example
            list.Add(new Account() { accountNumber = 301050001, accountName = "ادوات مكتبية ", subAccountID = 30105 }); //example
            list.Add(new Account() { accountNumber = 302010001, accountName = "مرتب", subAccountID = 30201 }); //example
            list.Add(new Account() { accountNumber = 302010002, accountName = "حوافز", subAccountID = 30201 }); //example
            list.Add(new Account() { accountNumber = 302010003, accountName = "سكن", subAccountID = 30201 }); //example
            list.Add(new Account() { accountNumber = 302010004, accountName = "انتقال", subAccountID = 30201 }); //example
            list.Add(new Account() { accountNumber = 302010005, accountName = "علاج", subAccountID = 30201 }); //example
            list.Add(new Account() { accountNumber = 302010006, accountName = "اخري", subAccountID = 30201 }); //example
            list.Add(new Account() { accountNumber = 302020001, accountName = "مزايا عينية", subAccountID = 30202 }); //example
            list.Add(new Account() { accountNumber = 302030001, accountName = "تأمينات اجتماعية", subAccountID = 30203 }); //example
            list.Add(new Account() { accountNumber = 302040001, accountName = "مكافأة توزيع ", subAccountID = 30204 }); //example
            list.Add(new Account() { accountNumber = 302040002, accountName = "مكافأة تميز ", subAccountID = 30204 }); //example
            list.Add(new Account() { accountNumber = 303010001, accountName = "مصروفات صيانة", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303010002, accountName = "مشتريات خدمات ", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303010003, accountName = "مصروفات ابحاث و تجارب ", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303010004, accountName = "مصروفات دعاية و اعلان و استقبال ", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303010005, accountName = "كهرباء", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303010006, accountName = "مياه", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303010007, accountName = "تليفون", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303010008, accountName = "رحلات داخلية ", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303010009, accountName = "شحن بضائع ", subAccountID = 30301 }); //example
            list.Add(new Account() { accountNumber = 303020001, accountName = "مصروفات اهلاك مباني ", subAccountID = 30302 }); //example
            list.Add(new Account() { accountNumber = 303020002, accountName = "مصروفات اهلاك الات ", subAccountID = 30302 }); //example
            list.Add(new Account() { accountNumber = 303020003, accountName = "مصروفات اهلاك وسائل نقل ", subAccountID = 30302 }); //example
            list.Add(new Account() { accountNumber = 303020004, accountName = "مصروفات اهلاك عدد و الات ", subAccountID = 30302 }); //example
            list.Add(new Account() { accountNumber = 303030001, accountName = "فوائد", subAccountID = 30303 }); //example
            list.Add(new Account() { accountNumber = 303040001, accountName = "ايجارات عقارية", subAccountID = 30304 }); //example
            list.Add(new Account() { accountNumber = 303050001, accountName = "ضرائب عقارية", subAccountID = 30305 }); //example
            list.Add(new Account() { accountNumber = 303060001, accountName = "ضرائب غير مباشرة", subAccountID = 30306 }); //example
            list.Add(new Account() { accountNumber = 303060002, accountName = "دمغات", subAccountID = 30306 }); //example
            list.Add(new Account() { accountNumber = 304010001, accountName = "مشتريات بضاعة بغرض البيع", subAccountID = 30401 }); //example
            list.Add(new Account() { accountNumber = 304010002, accountName = "مردودات مشتريات بغرض البيع ", subAccountID = 30401 }); //example
            list.Add(new Account() { accountNumber = 304010003, accountName = "خصم مكتسب ", subAccountID = 30401 }); //example
            list.Add(new Account() { accountNumber = 304010004, accountName = "مسموحات مشتريات ", subAccountID = 30401 }); //example
            list.Add(new Account() { accountNumber = 305010001, accountName = "مخصصات بخلاف الاهلاك", subAccountID = 30501 }); //example
            list.Add(new Account() { accountNumber = 305020001, accountName = "ديون معدومة ", subAccountID = 30502 }); //example
            list.Add(new Account() { accountNumber = 305030001, accountName = "تعويضات و غرامات ", subAccountID = 30503 }); //example
            list.Add(new Account() { accountNumber = 305030002, accountName = "تبرعات و اعانات ", subAccountID = 30503 }); //example
            list.Add(new Account() { accountNumber = 305030003, accountName = "عجز جرد مخازن ", subAccountID = 30503 }); //example
            list.Add(new Account() { accountNumber = 305040001, accountName = "خسائر فروق العملة ", subAccountID = 30504 }); //example
            list.Add(new Account() { accountNumber = 305050001, accountName = "مصروفات سنوات سابقة ", subAccountID = 30505 }); //example
            list.Add(new Account() { accountNumber = 305060001, accountName = "توزيع ارباح ", subAccountID = 30506 }); //example
            list.Add(new Account() { accountNumber = 305070001, accountName = "ضرائب الدخل ", subAccountID = 30507 }); //example
            list.Add(new Account() { accountNumber = 401010001, accountName = "مبيعات بضاعة مشتراه", subAccountID = 40101 }); //example
            list.Add(new Account() { accountNumber = 401010002, accountName = "مردودات مبيعات سنوات سابقة ", subAccountID = 40101 }); //example
            list.Add(new Account() { accountNumber = 401010003, accountName = "مردودات مبيعات ", subAccountID = 40101 }); //example
            list.Add(new Account() { accountNumber = 401010004, accountName = "خصم مسموح به", subAccountID = 40101 }); //example
            list.Add(new Account() { accountNumber = 401020001, accountName = "مبيعات خدامات ", subAccountID = 40102 }); //example
            list.Add(new Account() { accountNumber = 401030001, accountName = "ايردات تشعيل سيارة ", subAccountID = 40103 }); //example
            list.Add(new Account() { accountNumber = 401040001, accountName = "ايرادات تشغيل اخري ", subAccountID = 40104 }); //example
            list.Add(new Account() { accountNumber = 401050001, accountName = "ايرادات العيادة الخارجية", subAccountID = 40105 }); //example

            list.Add(new Account() { accountNumber = 401060001, accountName = "ايراد اقامة غرف", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060002, accountName = "اشراف و فحص طبي ", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060003, accountName = "عمليات جراحية ", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060004, accountName = "غرفة عمليات ", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060005, accountName = "عناية مركزة ", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060006, accountName = "ايراد رعاية", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060007, accountName = "ادوية", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060008, accountName = "مستلزمات طبية ", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060009, accountName = "تحاليل", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060010, accountName = "اجراءات اكلينيكية ", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060011, accountName = "غسيل الكلى", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060012, accountName = "اشعة", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060013, accountName = "علاج طبيعى", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060014, accountName = "مناظير", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060015, accountName = "خدمات قسم داخلي", subAccountID = 40106 }); 
            list.Add(new Account() { accountNumber = 401060016, accountName = "مرافق", subAccountID = 40106 }); 

            list.Add(new Account() { accountNumber = 402010001, accountName = "منح و اعانات", subAccountID = 40201 }); //example
            list.Add(new Account() { accountNumber = 403010001, accountName = "ديون سبق اعدامها", subAccountID = 40301 }); //example
            list.Add(new Account() { accountNumber = 403020001, accountName = "ايرادات ارباح بيع و اوراق مالية", subAccountID = 40302 }); //example
            list.Add(new Account() { accountNumber = 403030001, accountName = "ايراد ارباح بيع مخلفات", subAccountID = 40303 }); //example
            list.Add(new Account() { accountNumber = 403030002, accountName = "ايراد تعويضات و غرامات ", subAccountID = 40303 }); //example
            list.Add(new Account() { accountNumber = 403030003, accountName = "ايراد عمولات ", subAccountID = 40303 }); //example
            list.Add(new Account() { accountNumber = 403030004, accountName = "ايراد ايجارات ", subAccountID = 40303 }); //example
            list.Add(new Account() { accountNumber = 403030005, accountName = "ايراد جزاءات و غياب تسويات ", subAccountID = 40303 }); //example
            list.Add(new Account() { accountNumber = 403030006, accountName = "ايراد اشتراكات ", subAccountID = 40303 }); //example
            list.Add(new Account() { accountNumber = 403030007, accountName = "ايراد خدمات متنوعة للعاملين ", subAccountID = 40303 }); //example
            list.Add(new Account() { accountNumber = 403030008, accountName = "زيادة جرد مخازن ", subAccountID = 40303 }); //example
            list.Add(new Account() { accountNumber = 404010001, accountName = "ايراد ارباح فروق عملة", subAccountID = 40401 }); //example

            #region rest of accounts

            #endregion
            return list;
        }


    }
}
