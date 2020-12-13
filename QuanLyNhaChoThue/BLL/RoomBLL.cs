using QuanLyNhaChoThue.DAL;
using QuanLyNhaChoThue.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyNhaChoThue.BLL
{
    class RoomBLL
    {
        Dal dal = new Dal();
        public bool Insert(RoomDTO roomDTO)
        {
            StringBuilder sql = new StringBuilder("insert into Room");
            sql.Append("(HouseId,RoomName,RoomMoney,ElectricMoney,");
            sql.Append("WaterMoney,NetworkMoney,OtherMoney,NetworkMoneyType,");
            sql.Append("WaterMoneyType,LastElectricNumber,LastWaterNumber,Member,");
            sql.Append("Description,Status) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)");
            return dal.ExecuteQuery(sql.ToString(), roomDTO.HouseId, roomDTO.RoomName,
                roomDTO.RoomMoney, roomDTO.ElectricMoney, roomDTO.WaterMoney,
                roomDTO.NetworkMoney, roomDTO.OtherMoney, roomDTO.NetworkMoneyType,
                roomDTO.WaterMoneyType, roomDTO.LastElectricNumber,
                roomDTO.LastWaterNumber, 0, roomDTO.Description, 0);
        }

        public bool Update(RoomDTO roomDTO)
        {
            StringBuilder sql = new StringBuilder("update Room set ");
            sql.Append(" RoomName = @0,RoomMoney = @1,ElectricMoney = @2, ");
            sql.Append("WaterMoney = @3,NetworkMoney = @4,OtherMoney = @5,NetworkMoneyType = @6,");
            sql.Append("WaterMoneyType = @7,LastElectricNumber = @8,LastWaterNumber = @9,");
            sql.Append("Description = @10 where Id = @11");
            return dal.ExecuteQuery(sql.ToString(),  roomDTO.RoomName,
                roomDTO.RoomMoney, roomDTO.ElectricMoney, roomDTO.WaterMoney,
                roomDTO.NetworkMoney, roomDTO.OtherMoney, roomDTO.NetworkMoneyType,
                roomDTO.WaterMoneyType, roomDTO.LastElectricNumber,
                roomDTO.LastWaterNumber, roomDTO.Description, roomDTO.Id);
        }
        private List<RoomDTO> ToList(DataTable dt)
        {
            
            var listRoom = new List<RoomDTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                var roomDTO = new RoomDTO();
                roomDTO.Id = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                roomDTO.HouseId = int.Parse(dt.Rows[i].ItemArray[1].ToString());
                roomDTO.RoomName = dt.Rows[i].ItemArray[2].ToString();
                roomDTO.RoomMoney = int.Parse(dt.Rows[i].ItemArray[3].ToString());
                roomDTO.ElectricMoney = int.Parse(dt.Rows[i].ItemArray[4].ToString());
                roomDTO.WaterMoney = int.Parse(dt.Rows[i].ItemArray[5].ToString());
                roomDTO.NetworkMoney = int.Parse(dt.Rows[i].ItemArray[6].ToString());
                roomDTO.OtherMoney = int.Parse(dt.Rows[i].ItemArray[7].ToString());
                roomDTO.NetworkMoneyType = dt.Rows[i].ItemArray[8].ToString();
                roomDTO.WaterMoneyType = dt.Rows[i].ItemArray[9].ToString();
                roomDTO.LastElectricNumber = int.Parse(dt.Rows[i].ItemArray[10].ToString());
                roomDTO.LastWaterNumber = int.Parse(dt.Rows[i].ItemArray[11].ToString());
                roomDTO.Member = int.Parse(dt.Rows[i].ItemArray[12].ToString());
                roomDTO.Description = dt.Rows[i].ItemArray[13].ToString();
                roomDTO.Status = bool.Parse(dt.Rows[i].ItemArray[14].ToString());
                listRoom.Add(roomDTO);
            }
            return listRoom;
        }



        public DataTable findByHouseId(int houseId)
        {
            string sql = "select * from Room where HouseId = "+houseId;
            return dal.Query(sql);
        }
        public RoomDTO findOne(int id)
        {
            string sql = "select * from Room where Id = "+id;
            DataTable dt = dal.Query(sql);
            var roomDTO = ToList(dt)[0];
            return roomDTO;
        }
    }
}
