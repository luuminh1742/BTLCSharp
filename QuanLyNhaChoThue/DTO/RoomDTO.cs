namespace QuanLyNhaChoThue.DTO
{
    class RoomDTO:AbstractDTO
    {
        public string RoomName { get; set; }
        public int RoomMoney { get; set; }
        public int ElectricMoney { get; set; }
        public int WaterMoney { get; set; }
        public int NetworkMoney { get; set; }
        public int OtherMoney { get; set; }
        public int NetworkMoneyType { get; set; }
        public int WaterMoneyType { get; set; }
        public int LastElectricNumber { get; set; }
        public int LastWaterNumber { get; set; }
        public int Member{ get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
