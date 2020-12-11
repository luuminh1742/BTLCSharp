using QuanLyNhaChoThue.DAL;
using QuanLyNhaChoThue.DTO;

namespace QuanLyNhaChoThue.BLL
{
    class UserBLL
    {
        Dal dal = new Dal();
        public bool Login(UserDTO userDTO)
        {
            string sql = "select * from Users where UserName = '"+userDTO.UserName
                +"' and Password = '"+userDTO.Password+"'";
            return dal.Login(sql);
        }
    }
}
