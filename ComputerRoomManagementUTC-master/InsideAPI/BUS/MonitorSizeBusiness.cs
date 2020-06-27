using Common.Common;
using Common.Entity.Models.MonitorSize;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class MonitorSizeBusiness
    {
        private MonitorSizeDAL _monitorSizeDAL;
        public MonitorSizeDAL MonitorSizeDAL
        {
            get
            {
                _monitorSizeDAL = new MonitorSizeDAL();
                return _monitorSizeDAL;
            }
        }
        public ReturnResult<MonitorSize> GetAllMonitorSizeSearched(BaseCondition<MonitorSize> condition)
        {
            MonitorSizeDAL monitorSizeDAL = new MonitorSizeDAL();
            var result = monitorSizeDAL.GetAllMonitorSizeSearched(condition);
            return result;
        }

        public ReturnResult<MonitorSize> GetAll()
        {
            return MonitorSizeDAL.GetAll();
        }

        public ReturnResult<MonitorSize> AddMonitorSize(AddMonitorSizeViewModel monitorSize)
        {
            return MonitorSizeDAL.Add(monitorSize);
        }

        public ReturnResult<MonitorSize> GetById(int Id)
        {
            return MonitorSizeDAL.GetById(Id);
        }

        public ReturnResult<MonitorSize> Delete(MonitorSizeDeleteViewModel monitorSize)
        {
            return MonitorSizeDAL.Delete(monitorSize);
        }

        public ReturnResult<MonitorSize> Edit(MonitorSizeEditViewModel monitorSize)
        {
            return MonitorSizeDAL.Edit(monitorSize);
        }

        public ReturnResult<MonitorSize> EditStatus(MonitorSizeEditStatusViewModel monitorSize)
        {
            return MonitorSizeDAL.EditStatus(monitorSize);
        }
    }
}

