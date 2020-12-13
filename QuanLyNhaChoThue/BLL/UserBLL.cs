using QuanLyNhaChoThue.DAL;
using QuanLyNhaChoThue.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhaChoThue.BLL
{
    class UserBLL
    {
        Dal dal = new Dal();
        /*public bool Login(UserDTO userDTO)
        {
            string sql = "select * from Users where UserName = '"+userDTO.UserName
                +"' and Password = '"+userDTO.Password+"'";
            return dal.Login(sql);
        }*/
        private List<UserDTO> ToList(DataTable dt)
        {
            List<UserDTO> results = new List<UserDTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                UserDTO user = new UserDTO();
                user.UserName = "";
                user.Password = "";
                user.FullName = "";
                user.Gender = "";
                user.Address = "";
                user.Phone = "";
                user.Id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                user.UserName = dt.Rows[0].ItemArray[1].ToString();
                user.Password = dt.Rows[0].ItemArray[2].ToString();
                user.FullName = dt.Rows[0].ItemArray[3].ToString();
                user.Gender = dt.Rows[0].ItemArray[4].ToString();
                user.Address = dt.Rows[0].ItemArray[5].ToString();
                user.Phone = dt.Rows[0].ItemArray[6].ToString();
                results.Add(user);
            }
            return results;
        }
        public UserDTO FindOne(string username)
        {
            string sql = "select * from Users where UserName = '" + username+"'";
            DataTable dt = dal.Query(sql);
            return ToList(dt).Count != 0 ? ToList(dt)[0]:null;
        }
        public UserDTO FindOne(string username,string password)
        {
            string sql = "select * from Users where UserName = '" + username 
                + "' and Password = '"+password+"'";
            DataTable dt = dal.Query(sql);
            
            return ToList(dt).Count != 0 ? ToList(dt)[0] : null;
        }
        public List<UserDTO> FindMemBer(int roomId)
        {
            string sql = "select * from Users where RoomId = " + roomId;
            DataTable dt = dal.Query(sql);
            return ToList(dt).Count != 0 ? ToList(dt) : null; 
        }
        public DataTable FindMemBerByRoomId(int roomId)
        {
            string sql = "select * from Users where RoomId = " + roomId;
            return dal.Query(sql);
        }

        public bool Insert(UserDTO userDTO)
        {
            userDTO.CreatedDate = DateTime.Now;
            string sql = "insert into Users(FullName,Gender,Address,Phone,CreatedDate,RoomId) values(@0,@1,@2,@3,@4,@5)";
            return dal.ExecuteQuery(sql, userDTO.FullName, userDTO.Gender,
                userDTO.Address, userDTO.Phone, userDTO.CreatedDate, userDTO.RoomId);
        }
        public bool Update(UserDTO userDTO)
        {
            userDTO.ModifiedDate = DateTime.Now;
            string sql = "update Users set FullName = @0,Gender = @1,Address = @2,Phone = @3,ModifiedDate = @4 where Id = @5";
            return dal.ExecuteQuery(sql, userDTO.FullName, userDTO.Gender,
                userDTO.Address, userDTO.Phone, userDTO.ModifiedDate, userDTO.Id);
        }
        public bool Delete(int id)
        {
            string sql = "delete from Users where Id = @0";
            return dal.ExecuteQuery(sql,id);
        }

        public bool UpdateAdmin(UserDTO userDTO)
        {
            userDTO.ModifiedDate = DateTime.Now;
            string sql = "update Users set UserName = @0,FullName = @1,Gender = @2,Address = @3,Phone = @4,ModifiedDate = @5 where Id = @6";
            return dal.ExecuteQuery(sql, userDTO.UserName, userDTO.FullName, userDTO.Gender,
                userDTO.Address, userDTO.Phone, userDTO.ModifiedDate, userDTO.Id);
        }
        public bool UpdatePassword(int id,string password)
        {
            string sql = "update Users set Password = @0 where Id = @1";
            return dal.ExecuteQuery(sql, password, id);
        }


    }
}
