using System;
using Common.Common;
using Common.Entity.Models.Monitor;
using InsideAPI.DAL;

namespace InsideAPI.BUS
{
    public class MonitorBusiness
    {
        private MonitorDAL _monitorDAL;
        public MonitorDAL MonitorDAL
        {
            get
            {
                _monitorDAL = new MonitorDAL();
                return _monitorDAL;
            }
        }
        public ReturnResult<Monitor> GetAllMonitorSearched(BaseCondition<Monitor> condition)
        {
            MonitorDAL monitorDAL = new MonitorDAL();
            var result = monitorDAL.GetAllMonitorSearched(condition);
            return result;
        }

        public ReturnResult<Monitor> GetAll()
        {
            return MonitorDAL.GetAll();
        }

        public ReturnResult<Monitor> AddMonitor(AddMonitorViewModel monitor)
        {
            return MonitorDAL.Add(monitor);
        }

        public ReturnResult<Monitor> GetById(int Id)
        {
            return MonitorDAL.GetById(Id);
        }

        public ReturnResult<Monitor> Delete(MonitorDeleteViewModel monitor)
        {
            return MonitorDAL.Delete(monitor);
        }

        public ReturnResult<Monitor> Edit(MonitorEditViewModel monitor)
        {
            return MonitorDAL.Edit(monitor);
        }

        public ReturnResult<Monitor> EditStatus(MonitorEditStatusViewModel monitor)
        {
            return MonitorDAL.EditStatus(monitor);
        }
    }
}
