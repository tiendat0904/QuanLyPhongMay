using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Computer
{
    public class Computer
    {
        public int PK_Id { get; set; }
        public string ComputerName { get; set; }
        public int ComputerId { get; set; }
        public string StorageDeviceName { get; set; }
        public int StorageDeviceId { get; set; }
        public string StorageCapacity { get; set; }
        public int StorageCapcityId { get; set; }
        public string CpuName { get; set; }
        public int CpuId { get; set; }
        public string RamName { get; set; }
        public int RamId { get; set; }
        public string MonitorSize { get; set; }
        public int MonitorSizeId { get; set; }
        public string MonitorName { get; set; }
        public int MonitorId { get; set; }
        public string MouseName { get; set; }
        public int MouseId { get; set; }
        public string KeyboardName { get; set; }
        public int KeyboarId { get; set; }
        public string OpticalDiscName { get; set; }
        public int OpticalDiscId { get; set; }
        public string Speed { get; set; }
        public int SpeedId { get; set; }
        public int Status { get; set; }
    }
}
