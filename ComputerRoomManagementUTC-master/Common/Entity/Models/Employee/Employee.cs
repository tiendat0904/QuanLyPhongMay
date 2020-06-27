using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Entity.Models.Employee
{
    public class Employee
    {
        public int PK_Id { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Dob { get; set; }
        public int Gender { get; set; }
        public int FK_ComputerRoomId { get; set; }
        public string ComputerRoomName { get; set; }
        public int FK_ProvinceId{get;set;}
        public string ProvinceName { get; set; }
        public int PhoneNumber { get; set; }
        public int Status { get; set; }
    }
}
