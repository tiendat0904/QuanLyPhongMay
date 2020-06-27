using Common.Common;
using Common.Entity.Models.CPU;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class CPUBusiness
    {
        private CpuDAL _cpuDAL;
        public CpuDAL CpuDAL
        {
            get
            {
                _cpuDAL = new CpuDAL();
                return _cpuDAL;
            }
        }
        public ReturnResult<CPU> GetAllCpuSearched(BaseCondition<CPU> condition)
        {
            CpuDAL cpuDAL = new CpuDAL();
            var result = cpuDAL.GetAllCpuSearched(condition);
            return result;
        }

        public ReturnResult<CPU> GetAll()
        {
            return CpuDAL.GetAll();
        }

        public ReturnResult<CPU> AddCpu(AddCpuViewModel cpu)
        {
            return CpuDAL.Add(cpu);
        }

        public ReturnResult<CPU> GetById(int Id)
        {
            return CpuDAL.GetById(Id);
        }

        public ReturnResult<CPU> Delete(CpuDeleteViewModel cpu)
        {
            return CpuDAL.Delete(cpu);
        }

        public ReturnResult<CPU> Edit(CpuEditViewModel cpu)
        {
            return CpuDAL.Edit(cpu);
        }

        public ReturnResult<CPU> EditStatus(CpuEditStatusViewModel cpu)
        {
            return CpuDAL.EditStatus(cpu);
        }
    }
}
