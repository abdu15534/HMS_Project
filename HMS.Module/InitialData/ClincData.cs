using System.Collections.Generic;

namespace HMS.Module.InitialData
{
    class ClincData
    {
        public int ID { get; set; }
        public string name { get; set; }


        public List<ClincData> ClinicInitialData()
        {
            List<ClincData> clincData = new List<ClincData>();

            clincData.Add(new ClincData() { ID = 2, name = "القلب" });
            clincData.Add(new ClincData() { ID = 3, name = "الجهاز الهضمى والمناظير" });
            clincData.Add(new ClincData() { ID = 4, name = "النساء والولادة" });
            clincData.Add(new ClincData() { ID = 5, name = "الصدر" });
            clincData.Add(new ClincData() { ID = 6, name = "الجلدية" });
            clincData.Add(new ClincData() { ID = 7, name = "المسالك البولية" });
            clincData.Add(new ClincData() { ID = 8, name = "الانف والأذن والسمعيات" });
            clincData.Add(new ClincData() { ID = 9, name = "المخ والأعصاب" });
            clincData.Add(new ClincData() { ID = 10, name = "الرمد" });
            clincData.Add(new ClincData() { ID = 11, name = "التخدير" });
            clincData.Add(new ClincData() { ID = 12, name = "الجراحة" });
            clincData.Add(new ClincData() { ID = 13, name = "العظام" });
            clincData.Add(new ClincData() { ID = 14, name = "العلاج الطبيعى" });
            clincData.Add(new ClincData() { ID = 15, name = "الأسنان" });

            return clincData;
        }
    }
}