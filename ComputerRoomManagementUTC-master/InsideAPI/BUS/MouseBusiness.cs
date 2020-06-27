using Common.Common;
using Common.Entity.Models.Mouse;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class MouseBusiness
    {
        private MouseDAL _mouseDAL;
        public MouseDAL MouseDAL
        {
            get
            {
                _mouseDAL = new MouseDAL();
                return _mouseDAL;
            }
        }
        public ReturnResult<Mouse> GetAllMouseSearched(BaseCondition<Mouse> condition)
        {
            MouseDAL mouseDAL = new MouseDAL();
            var result = mouseDAL.GetAllMouseSearched(condition);
            return result;
        }

        public ReturnResult<Mouse> GetAll()
        {
            return MouseDAL.GetAll();
        }

        public ReturnResult<Mouse> AddMouse(AddMouseViewModel mouse)
        {
            return MouseDAL.Add(mouse);
        }

        public ReturnResult<Mouse> GetById(int Id)
        {
            return MouseDAL.GetById(Id);
        }

        public ReturnResult<Mouse> Delete(MouseDeleteViewModel mouse)
        {
            return MouseDAL.Delete(mouse);
        }

        public ReturnResult<Mouse> Edit(MouseEditViewModel mouse)
        {
            return MouseDAL.Edit(mouse);
        }

        public ReturnResult<Mouse> EditStatus(MouseEditStatusViewModel mouse)
        {
            return MouseDAL.EditStatus(mouse);
        }
    }
}
