using Common.Common;
using Common.Entity.Models.Class;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class ClassBusiness
    {
        private ClassDAL _mouseDAL;
        public ClassDAL ClassDAL
        {
            get
            {
                _mouseDAL = new ClassDAL();
                return _mouseDAL;
            }
        }
        public ReturnResult<Class> GetAllClassSearched(BaseCondition<Class> condition)
        {
            ClassDAL mouseDAL = new ClassDAL();
            var result = mouseDAL.GetPaging(condition);
            return result;
        }

        public ReturnResult<Class> GetAll()
        {
            return ClassDAL.GetAll();
        }

        public ReturnResult<Class> AddClass(AddClassViewModel mouse)
        {
            return ClassDAL.Add(mouse);
        }

        public ReturnResult<Class> GetById(int Id)
        {
            return ClassDAL.GetById(Id);
        }

        public ReturnResult<Class> Delete(ClassDeleteViewModel mouse)
        {
            return ClassDAL.Delete(mouse);
        }

        public ReturnResult<Class> Edit(ClassEditViewModel mouse)
        {
            return ClassDAL.Edit(mouse);
        }

        public ReturnResult<Class> EditStatus(ClassEditStatusViewModel mouse)
        {
            return ClassDAL.EditStatus(mouse);
        }
    }
}
