using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.CPU
{
    public class CpuEditStatusViewModel
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string EditBy { get; set; }
    }
}
