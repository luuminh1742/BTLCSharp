using QuanLyNhaChoThue.DAL;
using QuanLyNhaChoThue.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhaChoThue.BLL
{
    class HouseBLL
    {
        Dal dal = new Dal();

        public List<HouseDTO> findAll()
        {
            string sql = "select * from House where UserId = 1";
            DataTable dt = dal.Query(sql);
            var houseList = new List<HouseDTO>();
            for(int i = 0; i < dt.Rows.Count ;i++)
            {
                var houseDTO = new HouseDTO();
                houseDTO.Id = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                houseDTO.Name = dt.Rows[i].ItemArray[1].ToString();
                houseDTO.Address = dt.Rows[i].ItemArray[2].ToString();
                houseDTO.Description = dt.Rows[i].ItemArray[3].ToString();
                houseDTO.UserId = int.Parse(dt.Rows[i].ItemArray[4].ToString());
                houseList.Add(houseDTO);
            }
            return houseList;
        }

        public DataTable findById(int id)
        {
            string sql = "select * from House where Id = "+id;
            return dal.Query(sql);
        }

        public bool Insert(HouseDTO houseDTO)
        {
            string sql = "insert into House(Name,Address,Description,UserId) values (@0,@1,@2,1)";
            return dal.ExecuteQuery(sql, houseDTO.Name, houseDTO.Address, houseDTO.Description);
        }
        public bool Update(HouseDTO houseDTO)
        {
            string sql = "update House set Name = @0,Address = @1,Description = @2 where Id = @3";
            return dal.ExecuteQuery(sql, houseDTO.Name, houseDTO.Address, houseDTO.Description,houseDTO.Id);
        }

    }
}
