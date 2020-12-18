using System;

namespace QuanLyNhaChoThue.DTO
{
    class BillDTO
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string MemberName { get; set; }
        public int RoomMoney { get; set; }
        public int ElectricMoney { get; set; }
        public int WaterMoney { get; set; }
        public int NetworkMoney { get; set; }
        public int OtherMoney { get; set; }
        public int LastElectricNumber { get; set; }
        public int ElectricNumber { get; set; }
        public int LastWaterNumber { get; set; }
        public int WaterNumber { get; set; }
        public int TotalMoney { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Member { get; set; }
        public bool Status { get; set; }

    }
}
