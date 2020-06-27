using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Entity.Models.Employee
{
    public class AddEmployeeModel
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }
        public int Gender { get; set; }
        public int Status { get; set; }
        public int PhoneNumber { get; set; }
        public int FK_ComputerRoomId { get; set; }
        public string ComputerRoomName { get; set; }
        public int FK_ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string CreatedBy { get; set; }
    }
}
