using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Employee
{
    public class EmployeeDeleteModel
    {
        public int Id { get; set; }
        public string DeletedBy { get; set; }
    }
}
