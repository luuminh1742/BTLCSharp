using QuanLyNhaChoThue.DAL;
using QuanLyNhaChoThue.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyNhaChoThue.BLL
{
    class BillBLL
    {
        Dal dal = new Dal();
        RoomBLL roomBll = new RoomBLL();
        UserBLL userBll = new UserBLL();
        public bool Insert(BillDTO billDTO)
        {
            RoomDTO roomDTO = new RoomDTO();
            roomDTO = roomBll.findOne(billDTO.RoomId);
            billDTO.RoomMoney = roomDTO.RoomMoney;
            /*
                Theo đầu người
                Theo phòng
                Miễn phí
             */
            switch (roomDTO.NetworkMoneyType)
            {
                case "Theo đầu người":
                    billDTO.NetworkMoney = roomDTO.Member * roomDTO.NetworkMoney;
                    break;
                case "Theo phòng":
                    billDTO.NetworkMoney =  roomDTO.NetworkMoney;
                    break;
                case "Miễn phí":
                    billDTO.NetworkMoney = 0;
                    break;
                default:
                    billDTO.NetworkMoney = 0;
                    break;
            }
            /*
             Theo đầu người
            Theo phòng
            Theo số công tơ
            Miễn phí
             */
            billDTO.WaterNumber = billDTO.LastWaterNumber - roomDTO.LastWaterNumber;
            switch (roomDTO.WaterMoneyType)
            {
                case "Theo đầu người":
                    billDTO.WaterMoney = roomDTO.WaterMoney * roomDTO.Member;
                    break;
                case "Theo phòng":
                    billDTO.WaterMoney = roomDTO.WaterMoney;
                    break;
                case "Theo số công tơ":
                    if (billDTO.WaterNumber < 0)
                        return false;
                    else 
                        billDTO.WaterMoney = roomDTO.WaterMoney*billDTO.WaterNumber;
                    break;
                case "Miễn phí":
                    billDTO.WaterMoney = 0;
                    break;
            }
            billDTO.ElectricNumber = billDTO.LastElectricNumber - roomDTO.LastElectricNumber;
            if (billDTO.ElectricNumber < 0)
                return false;
            else
                billDTO.ElectricMoney = roomDTO.ElectricMoney * billDTO.ElectricNumber;
            billDTO.OtherMoney = roomDTO.OtherMoney;
            billDTO.Status = false;
            billDTO.TotalMoney = billDTO.RoomMoney + billDTO.ElectricMoney + billDTO.WaterMoney +
                billDTO.NetworkMoney + billDTO.OtherMoney;
            billDTO.CreatedDate = DateTime.Now;

            List<UserDTO> listUser = userBll.FindMemBer(billDTO.RoomId);

            StringBuilder memberName = new StringBuilder("");
            for (int i = 0; i < listUser.Count; i++)
            {
                memberName.Append(listUser[i].FullName);
                if (i != listUser.Count - 1)
                {
                    memberName.Append(", ");
                }
            }
            billDTO.MemberName = memberName.ToString();
            
            StringBuilder sql = new StringBuilder("insert into Bill ");
            sql.Append("(RoomId,MemberName,RoomMoney,ElectricMoney,");
            sql.Append("WaterMoney,NetworkMoney,OtherMoney,LastElectricNumber,");
            sql.Append("ElectricNumber,LastWaterNumber,WaterNumber,");
            sql.Append("TotalMoney,ModifiedBy,CreatedDate,Status) ");
            sql.Append(" values(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14)");

            return dal.ExecuteQuery(sql.ToString(),billDTO.RoomId,billDTO.MemberName,
                billDTO.RoomMoney,billDTO.ElectricMoney,billDTO.WaterMoney,
                billDTO.NetworkMoney,billDTO.OtherMoney,billDTO.LastElectricNumber,
                billDTO.ElectricNumber,billDTO.LastWaterNumber,billDTO.WaterNumber,
                billDTO.TotalMoney,"Lưu Bá Minh",billDTO.CreatedDate,0);
        }
    
        public DataTable FindByRoomId(int roomId)
        {
            string sql = "select * from Bill where RoomId = " + roomId;
            return dal.Query(sql);
        }

        public BillDTO FindById(int id)
        {
            string sql = "select * from Bill where Id = " + id;
            DataTable dt = dal.Query(sql);
            try
            {
                BillDTO dto = new BillDTO();
                dto.Id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                dto.RoomId = int.Parse(dt.Rows[0].ItemArray[1].ToString());
                dto.MemberName = dt.Rows[0].ItemArray[2].ToString();
                dto.RoomMoney = int.Parse(dt.Rows[0].ItemArray[3].ToString());
                dto.ElectricMoney = int.Parse(dt.Rows[0].ItemArray[4].ToString());
                dto.WaterMoney = int.Parse(dt.Rows[0].ItemArray[5].ToString());
                dto.NetworkMoney = int.Parse(dt.Rows[0].ItemArray[6].ToString());
                dto.OtherMoney = int.Parse(dt.Rows[0].ItemArray[7].ToString());
                dto.LastElectricNumber = int.Parse(dt.Rows[0].ItemArray[8].ToString());
                dto.ElectricNumber = int.Parse(dt.Rows[0].ItemArray[9].ToString());
                dto.LastWaterNumber = int.Parse(dt.Rows[0].ItemArray[10].ToString());
                dto.WaterNumber = int.Parse(dt.Rows[0].ItemArray[11].ToString());
                dto.TotalMoney = int.Parse(dt.Rows[0].ItemArray[12].ToString());
                dto.ModifiedBy = dt.Rows[0].ItemArray[13].ToString();
                dto.CreatedDate = DateTime.Parse(dt.Rows[0].ItemArray[14].ToString());
                //dto.ModifiedDate = DateTime.Parse(dt.Rows[0].ItemArray[15].ToString());
                dto.Status = bool.Parse(dt.Rows[0].ItemArray[16].ToString());

                return dto;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
        public bool UpdateStatus(int id)
        {
            string sql = "update Bill set ModifiedDate = @0, Status = @1 where Id = @2";
            return dal.ExecuteQuery(sql,DateTime.Now,1,id);
        }

        public List<ViewStatisticDTO> StatisticBill(string username)
        {
            string sql = "select * from View_Statistic where UserName = '"+username+ "' order by Date ,Status";
            List<ViewStatisticDTO> result = new List<ViewStatisticDTO>();
            DataTable dt = dal.Query(sql);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ViewStatisticDTO viewStatisticDTO = new ViewStatisticDTO();
                viewStatisticDTO.Status = bool.Parse(dt.Rows[i].ItemArray[1].ToString());
                viewStatisticDTO.Date = dt.Rows[i].ItemArray[2].ToString();
                viewStatisticDTO.Count = int.Parse(dt.Rows[i].ItemArray[3].ToString());
                result.Add(viewStatisticDTO);
            }
            return result;
        }

    }
}
