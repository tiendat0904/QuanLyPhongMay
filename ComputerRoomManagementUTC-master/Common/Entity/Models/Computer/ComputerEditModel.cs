using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.Computer {
    public class ComputerEditModel
    {
        public string Name { get; set; }
        public int ComputerRoomId { get; set; }
        public int StorageDeviceId { get; set; }
        public int StorageCapacityId { get; set; }
        public int CpuId { get; set; }
        public int RamId { get; set; }
        public int SpeedId { get; set; }
        public int MonitorId { get; set; }
        public int MonitorSizeId { get; set; }
        public int MouseId { get; set; }
        public int KeyboardId { get; set; }
        public int OpticalDiscId { get; set; }
        public int Status { get; set; }
        public string EditBy { get; set; }
    }
}
