using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Module.InitialData
{
    class CatagoryInitialData
    {
        public string name { get; set; }


        public List<CatagoryInitialData> CatagoryData()
        {
            List<CatagoryInitialData> catagoryData = new List<CatagoryInitialData>();

            catagoryData.Add(new CatagoryInitialData() {  name = "دواء" });
            catagoryData.Add(new CatagoryInitialData() {  name = "غير دواء" });
            catagoryData.Add(new CatagoryInitialData() {  name = "مستهلكات" });
            

            return catagoryData;
        }
    }
}
