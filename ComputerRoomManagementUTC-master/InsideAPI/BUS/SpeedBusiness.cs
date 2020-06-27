using Common.Common;
using Common.Entity.Models.Speed;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class SpeedBusiness
    {
        private SpeedDAL _speedDAL;
        public SpeedDAL SpeedDAL
        {
            get
            {
                _speedDAL = new SpeedDAL();
                return _speedDAL;
            }
        }
        public ReturnResult<Speed> GetAllSpeedSearched(BaseCondition<Speed> condition)
        {
            SpeedDAL speedDAL = new SpeedDAL();
            var result = speedDAL.GetAllSpeedSearched(condition);
            return result;
        }

        public ReturnResult<Speed> GetAll()
        {
            return SpeedDAL.GetAll();
        }

        public ReturnResult<Speed> AddSpeed(AddSpeedViewModel speed)
        {
            return SpeedDAL.Add(speed);
        }

        public ReturnResult<Speed> GetById(int Id)
        {
            return SpeedDAL.GetById(Id);
        }

        public ReturnResult<Speed> Delete(SpeedDeleteViewModel speed)
        {
            return SpeedDAL.Delete(speed);
        }

        public ReturnResult<Speed> Edit(SpeedEditViewModel speed)
        {
            return SpeedDAL.Edit(speed);
        }

        public ReturnResult<Speed> EditStatus(SpeedEditStatusViewModel speed)
        {
            return SpeedDAL.EditStatus(speed);
        }
    }
}

