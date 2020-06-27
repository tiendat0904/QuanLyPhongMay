using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Teacher
{
    public class Teacher
    {
        public int PK_Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int Status { get; set; }
    }
}
