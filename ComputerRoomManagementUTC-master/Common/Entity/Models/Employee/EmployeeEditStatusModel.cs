using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Employee
{
    public class EmployeeEditStatusModel
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string EditBy { get; set; }
    }
}
