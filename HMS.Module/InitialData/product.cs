using System.Collections.Generic;

namespace HMS.Module
{
    class product
    {
        public string Name { get; set; }
        public decimal purchasingPrice { get; set; }
        public decimal sellingPrice { get; set; }
        public string barCode { get; set; }
        public List<product> initialStockProductData()
        {
            List<product> productList = new List<product>();
            productList.Add(new product() { Name = "سرنجة 1 سم (انسولين)", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "سرنجة 3 سم", purchasingPrice = 5, sellingPrice = 5 });
            productList.Add(new product() { Name = "سرنجة 5 سم", purchasingPrice = 5, sellingPrice = 5 });
            productList.Add(new product() { Name = "سرنجة 10 سم", purchasingPrice = 5, sellingPrice = 10 });
            productList.Add(new product() { Name = "سرنجة 50 سم ببوز (رايل)", purchasingPrice = 5, sellingPrice = 50 });
            productList.Add(new product() { Name = "ماسك أكسجين كبار", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "ماسك نيبولايزر كبار", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "نيزل أكسجين كبار , نيزل كانيولا", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "جوانتى معقم مقاسات", purchasingPrice = 5, sellingPrice = 30 });
            productList.Add(new product() { Name = "جوانتى لاتكس", purchasingPrice = 5, sellingPrice = 450 });
            productList.Add(new product() { Name = " قسطرة فولى 2 شعبة مقاسات", purchasingPrice = 5, sellingPrice = 50 });
            productList.Add(new product() { Name = " قسطرة شفط نيلتون مقاسات", purchasingPrice = 5, sellingPrice = 20 });
            productList.Add(new product() { Name = " كيس جمع بول كبار", purchasingPrice = 5, sellingPrice = 40 });
            productList.Add(new product() { Name = " كيس جمع بول عادى 2 لتر", purchasingPrice = 5, sellingPrice = 40 });
            productList.Add(new product() { Name = "كيس جمع بول أطفال", purchasingPrice = 5, sellingPrice = 40 });
            productList.Add(new product() { Name = "ابرة كانيولا مقاسات مختلفة", purchasingPrice = 5, sellingPrice = 30 });
            productList.Add(new product() { Name = "كانيولا مقاس 24 صفرا (أطفال", purchasingPrice = 5, sellingPrice = 30 });
            productList.Add(new product() { Name = "مثبت كانيولا", purchasingPrice = 5, sellingPrice = 10 });
            productList.Add(new product() { Name = "بلاستر حرير 10 سم", purchasingPrice = 5, sellingPrice = 40 });
            productList.Add(new product() { Name = "خافض لسان خشب", purchasingPrice = 5, sellingPrice = 5 });
            productList.Add(new product() { Name = "مبولة رجالى", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "ثلاثية C.V.P قسطرة", purchasingPrice = 5, sellingPrice = 2000 });
            productList.Add(new product() { Name = "قسطرة ماهوكر ثنائية ", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "أنبوبة حنجرية", purchasingPrice = 5, sellingPrice = 50 });
            productList.Add(new product() { Name = "وصلة جهاز تنفس صناعى", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "(    )خيوط(   ) مقاس", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "شكاكة لتحليل السكر", purchasingPrice = 5, sellingPrice = 3 });
            productList.Add(new product() { Name = "شرايط سكر", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "الكترود رسم قلب", purchasingPrice = 5, sellingPrice = 20 });
            productList.Add(new product() { Name = "فلتر بكتيرى", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "مناديل", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "شراب طبى", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "وصلة وريدية", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "رباط شاش 10 سم", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "(       )رباط ضاغط مقاس", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "مريلة ماكنوش", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "دريسنج كبير 20*40", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "دريسنج وسط 10*20", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "سواب 5*5", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "سواب 10*10", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "سواب كحول", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "رباط ضاغط لاصق", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "شاش فازلين 10*10 سم", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "شاش فازلين 20*10 سم", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "(       )ستيرى باد مقاس", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "غطاء راس رجالى ورق", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "غطاء راس حريمى", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "جاون مريض", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "مفرش سرير", purchasingPrice = 5, sellingPrice = 10 });
            productList.Add(new product() { Name = "سالوسيت", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "ماسك طبيب ورق", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "بلاستر جروح , بانديدج", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "بلاستر قطع مدور", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "قطن طبى", purchasingPrice = 5, sellingPrice = 90 });
            productList.Add(new product() { Name = "جهاز وريد , جهاز نقل محاليل", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "جهاز نقل دم", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "غطاء راس حريمى", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "وصلة مضخة محاليل (سرنجة كهربائية)ة", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "رايل تيوب مقاسات", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "Tوصلة نيبيولايزر حرف", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "تى تيوب", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "ممر هوائى", purchasingPrice = 5, sellingPrice = 20 });
            productList.Add(new product() { Name = "بلاستر جراحى", purchasingPrice = 5, sellingPrice = 40 });
            productList.Add(new product() { Name = "قصرية", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "أنبوبة صدرية", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "شرايط تحليل السكر فى الدم", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "شرايط تحليل السكر فى البول", purchasingPrice = 5, sellingPrice = 15 });
            productList.Add(new product() { Name = "شرايط تحليل أسيتون فى البول", purchasingPrice = 5, sellingPrice = 15 });
            productList.Add(new product() { Name = "ركتل تيوب (أنبوبة شرجية)", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "حقنة شرجية", purchasingPrice = 5, sellingPrice = 85 });
            productList.Add(new product() { Name = "حفاضات كبار السن والبالغين", purchasingPrice = 5, sellingPrice = 15 });
            productList.Add(new product() { Name = "مفرش سرير مقاس 60*90", purchasingPrice = 5, sellingPrice = 15 });
            productList.Add(new product() { Name = "جاون طبيب معقم", purchasingPrice = 5, sellingPrice = 30 });
            productList.Add(new product() { Name = "جهاز وريد", purchasingPrice = 5, sellingPrice = 20 });
            productList.Add(new product() { Name = "دايل فلو", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "محبس ثلاثى", purchasingPrice = 5, sellingPrice = 30 });
            productList.Add(new product() { Name = "وصلة محاليل وريدية", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "كانيولا شريانية", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "أنبوبة رايل مقاسات", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "ترمومتر زئبقى", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "جل معقم K.Y أنبوبة", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "مشارط مقاسات", purchasingPrice = 5, sellingPrice = 15 });
            productList.Add(new product() { Name = "شكاكات", purchasingPrice = 5, sellingPrice = 3 });
            productList.Add(new product() { Name = "محلول رينجر 500 مللى", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "لاكيتات رينجر 500 مللى", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "منيتول 20% 500 مللى", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "بيتادين", purchasingPrice = 5, sellingPrice = 15 });
            productList.Add(new product() { Name = "كحول", purchasingPrice = 5, sellingPrice = 25 });
            productList.Add(new product() { Name = "محلول رينجر 500 مللى", purchasingPrice = 5, sellingPrice = 7 });
            productList.Add(new product() { Name = "محلول جلوكوز 10% 500 مللى", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "محلول جلوكوز 5% 500 مللى", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "محلول جلوكوز 25% 500 مللى", purchasingPrice = 5, sellingPrice = 60 });
            productList.Add(new product() { Name = "محلول ملح 9% 500 مللى", purchasingPrice = 5, sellingPrice = 45 });
            productList.Add(new product() { Name = "كانيولا مقاس 16", purchasingPrice = 5, sellingPrice = 30 });
            productList.Add(new product() { Name = "كانيولا مقاس 18", purchasingPrice = 5, sellingPrice = 30 });
            productList.Add(new product() { Name = "كانيولا مقاس 20", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "كانيولا مقاس 22", purchasingPrice = 5, sellingPrice = 35 });
            productList.Add(new product() { Name = "كانيولا مقاس 24", purchasingPrice = 5, sellingPrice = 30 });
            productList.Add(new product() { Name = "جوانتي, 2 رباط , لفت", purchasingPrice = 5, sellingPrice = 50 });
            productList.Add(new product() { Name = "كيس بلاستك", purchasingPrice = 5, sellingPrice = 250 });
            productList.Add(new product() { Name = "ملاية", purchasingPrice = 5, sellingPrice = 200 });
            
            return productList;
        }

        public List<product> initialPharmacyProductData()
        {
            List<product> productList = new List<product>();

            productList.Add(new product() { Name = "نويورك ٣٠٠ مجم ٢٠ قرص", purchasingPrice = 51, sellingPrice = 65, barCode="32" });
            productList.Add(new product() { Name = " نوفاكتام ٢٥٠ مجم", purchasingPrice = 34.25m, sellingPrice = 45 });
            productList.Add(new product() { Name = " بيفاتراسين ١٥٠ جم", purchasingPrice = 36, sellingPrice = 41 });
            productList.Add(new product() { Name = " هيرسوستوب 11.5٪ كريم موضعي 60 جم", purchasingPrice = 300, sellingPrice = 370 });
            productList.Add(new product() { Name = " هيستوتيك ١٦ مجم ٢٠ قرص", purchasingPrice = 19, sellingPrice = 25 });
            productList.Add(new product() { Name = "هيكساجبالين ١٥٠ مجم ٣٠ كبسولة", purchasingPrice = 120, sellingPrice = 140 });
            productList.Add(new product() { Name = " نيستاتين ٣٠ مل", purchasingPrice = 5.5m, sellingPrice = 7.5m });
            productList.Add(new product() { Name = " نيفيديبين 60 مجم SR جيلاتين صلب 10", purchasingPrice = 10, sellingPrice = 14 });
            productList.Add(new product() { Name = " نوفاكتام 375 مجم 12 قرص", purchasingPrice = 45, sellingPrice = 55 });
            productList.Add(new product() { Name = " نرفجاب ٧٥ مجم", purchasingPrice = 69, sellingPrice = 75 });

            return productList;
        }
    }


}
