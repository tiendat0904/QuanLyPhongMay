﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Monitor
{
    public class MonitorEditViewModel
    {
        public int Pk_id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string EditBy { get; set; }
    }
}
