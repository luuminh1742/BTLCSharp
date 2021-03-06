﻿using System;

namespace QuanLyNhaChoThue.DTO
{
    class UserDTO
    {
        public int Id { get; set; }
        public string UserName {get;set;}
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Status { get; set; }
        public int RoomId { get; set; }
    }
}
