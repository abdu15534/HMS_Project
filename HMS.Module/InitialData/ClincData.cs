using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Module.InitialData
{
    class ClincData
    {
        public int ID { get; set; }
        public string name { get; set; }


        public List<ClincData> ClinicInitialData()
        {
            List<ClincData> clincData = new List<ClincData>();

            clincData.Add(new ClincData() { ID = 2, name = "عيادة القلب" });
            clincData.Add(new ClincData() { ID = 3, name = "عيادة الجهاز الهضمى والمناظير" });
            clincData.Add(new ClincData() { ID = 4, name = "عيادة النساء والولادة" });
            clincData.Add(new ClincData() { ID = 5, name = "عيادة الصدر" });
            clincData.Add(new ClincData() { ID = 6, name = "عيادة الجلدية" });
            clincData.Add(new ClincData() { ID = 7, name = "عيادة المسالك البولية" });
            clincData.Add(new ClincData() { ID = 8, name = "عيادة الانف والأذن والسمعيات" });
            clincData.Add(new ClincData() { ID = 9, name = "عيادة المخ والأعصاب" });
            clincData.Add(new ClincData() { ID = 10, name = "عيادة الرمد" });
            clincData.Add(new ClincData() { ID = 11, name = "عيادة التخدير" });
            clincData.Add(new ClincData() { ID = 12, name = "عيادة الجراحة" });
            clincData.Add(new ClincData() { ID = 13, name = "عيادة العظام" });
            clincData.Add(new ClincData() { ID = 14, name = "عيادة العلاج الطبيعى" });
            clincData.Add(new ClincData() { ID = 15, name = "عيادة الأسنان" });

            return clincData;
        }
    }
}