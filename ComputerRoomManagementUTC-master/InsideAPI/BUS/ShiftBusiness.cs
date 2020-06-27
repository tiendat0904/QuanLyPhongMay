using Common.Common;
using Common.Entity.Models.Shift;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class ShiftBusiness
    {
        private ShiftDAL _mouseDAL;
        public ShiftDAL ShiftDAL
        {
            get
            {
                _mouseDAL = new ShiftDAL();
                return _mouseDAL;
            }
        }
        public ReturnResult<Shift> GetAllShiftSearched(BaseCondition<Shift> condition)
        {
            ShiftDAL mouseDAL = new ShiftDAL();
            var result = mouseDAL.GetAllShiftSearched(condition);
            return result;
        }

        public ReturnResult<Shift> GetAll()
        {
            return ShiftDAL.GetAll();
        }

        public ReturnResult<Shift> AddShift(AddShiftModel mouse)
        {
            return ShiftDAL.Add(mouse);
        }

        public ReturnResult<Shift> GetById(int Id)
        {
            return ShiftDAL.GetById(Id);
        }

        public ReturnResult<Shift> Delete(ShiftDeleteModel mouse)
        {
            return ShiftDAL.Delete(mouse);
        }

        public ReturnResult<Shift> Edit(ShiftEditModel mouse)
        {
            return ShiftDAL.Edit(mouse);
        }

        public ReturnResult<Shift> EditStatus(ShiftEditStatusModel mouse)
        {
            return ShiftDAL.EditStatus(mouse);
        }
    }
}
