using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static XafDataModel.Module.BusinessObjects.test2.Admission;
using static XafDataModel.Module.BusinessObjects.test2.Room;

namespace HMS.Module.InitialData
{
    class RoomData
    {
        public int number { get; set; }
        public decimal roomCost { get; set; }
        public decimal roomCare { get; set; }
        public decimal roomSupervision { get; set; }
        public bool isAvailable{ get; set; }
        public statusType status { get; set; }


        public List<RoomData> RoomInitialData()
        {
            List<RoomData> roomData = new List<RoomData>();

            roomData.Add(new RoomData() { number = 001, roomCost = 1500, roomCare = 1000, roomSupervision = 1000, isAvailable = true, status = statusType.ICU });
            roomData.Add(new RoomData() { number = 002, roomCost = 2000, roomCare = 2000, roomSupervision = 1000, isAvailable = true, status = statusType.covid });
            roomData.Add(new RoomData() { number = 101, roomCost = 750, roomCare = 500, roomSupervision = 480, isAvailable = true , status = statusType.normal });
            roomData.Add(new RoomData() { number = 102, roomCost = 750, roomCare = 500, roomSupervision = 480, isAvailable = true , status = statusType.normal });
            roomData.Add(new RoomData() { number = 103, roomCost = 750, roomCare = 500, roomSupervision = 480, isAvailable = true, status = statusType.normal });
            roomData.Add(new RoomData() { number = 104, roomCost = 750, roomCare = 500, roomSupervision = 480, isAvailable = true, status = statusType.normal });
            roomData.Add(new RoomData() { number = 105, roomCost = 750, roomCare = 500, roomSupervision = 480, isAvailable = true, status = statusType.normal });
            roomData.Add(new RoomData() { number = 106, roomCost = 750, roomCare = 500, roomSupervision = 480, isAvailable = true, status = statusType.normal });
            roomData.Add(new RoomData() { number = 112, roomCost = 850, roomCare = 450, roomSupervision = 500, isAvailable = true, status = statusType.normal });
            roomData.Add(new RoomData() { number = 113, roomCost = 850, roomCare = 450, roomSupervision = 500, isAvailable = true, status = statusType.normal });
            roomData.Add(new RoomData() { number = 114, roomCost = 850, roomCare = 600, roomSupervision = 650, isAvailable = true, status = statusType.normal });
            roomData.Add(new RoomData() { number = 115, roomCost = 850, roomCare = 600, roomSupervision = 650, isAvailable = true, status = statusType.normal });
            roomData.Add(new RoomData() { number = 116, roomCost = 850, roomCare = 600, roomSupervision = 650, isAvailable = true, status = statusType.normal });

            return roomData;
        }
    }
}
