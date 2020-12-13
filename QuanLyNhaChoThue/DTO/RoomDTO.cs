using System;

namespace QuanLyNhaChoThue.DTO
{
    class RoomDTO:AbstractDTO
    {
        public int HouseId { get; set; }
        public string RoomName { get; set; }
        public int RoomMoney { get; set; }
        public int ElectricMoney { get; set; }
        public int WaterMoney { get; set; }
        public int NetworkMoney { get; set; }
        public int OtherMoney { get; set; }
        public string NetworkMoneyType { get; set; }
        public string WaterMoneyType { get; set; }
        public int LastElectricNumber { get; set; }
        public int LastWaterNumber { get; set; }
        public int Member{ get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
