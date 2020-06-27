using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Computer
{
    public class ComputerExportModel
    {
        public int PK_Id { get; set; }
        public string ComputerName { get; set; }
        
        public string StorageDeviceName { get; set; }
    
        public string StorageCapacity { get; set; }
        
        public string CpuName { get; set; }
        
        public string RamName { get; set; }
        
        public string MonitorSize { get; set; }
        
        public string MonitorName { get; set; }
        
        public string MouseName { get; set; }
        
        public string KeyboardName { get; set; }
        
        public string OpticalDiscName { get; set; }
        
        public string Speed { get; set; }
        
        public int Status { get; set; }

    }
}
