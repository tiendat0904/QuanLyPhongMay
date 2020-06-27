using Common.Common;
using Common.Entity.Models.Province;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class ProvinceBusiness
    {
        private ProvinceDAL _provinceDAL;
        public ProvinceDAL ProvinceDAL
        {
            get
            {
                _provinceDAL = new ProvinceDAL();
                return _provinceDAL;
            }
        }
        public ReturnResult<Province> GetAllProvinceSearched(BaseCondition<Province> condition)
        {
            ProvinceDAL provinceDAL = new ProvinceDAL();
            var result = provinceDAL.GetAllProvinceSearched(condition);
            return result;
        }

        public ReturnResult<Province> GetAll()
        {
            return ProvinceDAL.GetAll();
        }

        public ReturnResult<Province> AddProvince(AddProvinceViewModel province)
        {
            return ProvinceDAL.Add(province);
        }

        public ReturnResult<Province> GetById(int Id)
        {
            return ProvinceDAL.GetById(Id);
        }

        public ReturnResult<Province> Delete(ProvinceDeleteViewModel province)
        {
            return ProvinceDAL.Delete(province);
        }

        public ReturnResult<Province> Edit(ProvinceEditViewModel province)
        {
            return ProvinceDAL.Edit(province);
        }

        public ReturnResult<Province> EditStatus(ProvinceEditStatusViewModel province)
        {
            return ProvinceDAL.EditStatus(province);
        }
    }
}
