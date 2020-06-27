using Common.Common;
using Common.Entity.Models.OpticalDisc;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class OpticalDiscBusiness
    {
        private OpticalDiscDAL _opticalDiscDAL;
        public OpticalDiscDAL OpticalDiscDAL
        {
            get
            {
                _opticalDiscDAL = new OpticalDiscDAL();
                return _opticalDiscDAL;
            }
        }
        public ReturnResult<OpticalDisc> GetAllOpticalDiscSearched(BaseCondition<OpticalDisc> condition)
        {
            OpticalDiscDAL opticalDiscDAL = new OpticalDiscDAL();
            var result = opticalDiscDAL.GetAllOpticalDiscSearched(condition);
            return result;
        }

        public ReturnResult<OpticalDisc> GetAll()
        {
            return OpticalDiscDAL.GetAll();
        }

        public ReturnResult<OpticalDisc> AddOpticalDisc(AddOpticalDiscViewModel opticalDisc)
        {
            return OpticalDiscDAL.Add(opticalDisc);
        }

        public ReturnResult<OpticalDisc> GetById(int Id)
        {
            return OpticalDiscDAL.GetById(Id);
        }

        public ReturnResult<OpticalDisc> Delete(OpticalDiscDeleteViewModel opticalDisc)
        {
            return OpticalDiscDAL.Delete(opticalDisc);
        }

        public ReturnResult<OpticalDisc> Edit(OpticalDiscEditViewModel opticalDisc)
        {
            return OpticalDiscDAL.Edit(opticalDisc);
        }

        public ReturnResult<OpticalDisc> EditStatus(OpticalDiscEditStatusViewModel opticalDisc)
        {
            return OpticalDiscDAL.EditStatus(opticalDisc);
        }
    }
}
