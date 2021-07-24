using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Module.InitialData
{
    class DepartmentData
    {
        public int departmentID { get; set; }
        public String name { get; set; }

        public List<DepartmentData> DepartmentInitialData()
        {
            List<DepartmentData> roomData = new List<DepartmentData>();

            roomData.Add(new DepartmentData() { departmentID = 1, name = "اداريين", });
            roomData.Add(new DepartmentData() { departmentID = 2, name = "اطباء", });
            roomData.Add(new DepartmentData() { departmentID = 3, name = "تمريض", });
            roomData.Add(new DepartmentData() { departmentID = 4, name = "عمال", });


            return roomData;
        }
    }
}