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

            clincData.Add(new ClincData() { ID = 1, name = "عيادة القلب" });
            clincData.Add(new ClincData() { ID = 2, name = "عيادة النسا والتوليد" });
            clincData.Add(new ClincData() { ID = 3, name = "عيادة أمراض الذكورة" });
            clincData.Add(new ClincData() { ID = 4, name = "عيادة الأمراض الجلدية" });
            clincData.Add(new ClincData() { ID = 5, name = "عيادة المسالك البولية" });
            clincData.Add(new ClincData() { ID = 6, name = "عيادة الأنف والأذن" });
            clincData.Add(new ClincData() { ID = 7, name = "عيادة المخ والأعصاب" });
            clincData.Add(new ClincData() { ID = 8, name = "قسم التخدير" });
            clincData.Add(new ClincData() { ID = 9, name = "عيادة الأوعية الدموية" });
            clincData.Add(new ClincData() { ID = 10, name = "عيادة الرمد" });
            clincData.Add(new ClincData() { ID = 11, name = "عيادة الأسنان" });

            return clincData;
        }
    }
}