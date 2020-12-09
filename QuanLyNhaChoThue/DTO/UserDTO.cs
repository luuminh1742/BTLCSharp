using System;

namespace QuanLyNhaChoThue.DTO
{
    class UserDTO :AbstractDTO
    {
        public string UserName {get;set;}
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Status { get; set; }

    }
}
