using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Employee
{
    public class EmployeeEditModel
    {
        public int Pk_id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public int Gender { get; set; }
        public int FK_ProvinceId { get; set; }
        public int FK_ComputerRoomId { get; set; }
        public int PhoneNumber { get; set; }
        public int Status { get; set; }
        public string EditBy { get; set; }
    }
}
