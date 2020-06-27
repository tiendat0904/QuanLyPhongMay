using Common.Common;
using Common.Entity.Models.Teacher;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class TeacherBusiness
    {
        private TeacherDAL _mouseDAL;
        public TeacherDAL TeacherDAL
        {
            get
            {
                _mouseDAL = new TeacherDAL();
                return _mouseDAL;
            }
        }
        public ReturnResult<Teacher> GetAllTeacherSearched(BaseCondition<Teacher> condition)
        {
            TeacherDAL mouseDAL = new TeacherDAL();
            var result = mouseDAL.GetAllTeacherSearched(condition);
            return result;
        }

        public ReturnResult<Teacher> GetAll()
        {
            return TeacherDAL.GetAll();
        }

        public ReturnResult<Teacher> AddTeacher(AddTeacherModel mouse)
        {
            return TeacherDAL.Add(mouse);
        }

        public ReturnResult<Teacher> GetById(int Id)
        {
            return TeacherDAL.GetById(Id);
        }

        public ReturnResult<Teacher> Delete(TeacherDeleteModel mouse)
        {
            return TeacherDAL.Delete(mouse);
        }

        public ReturnResult<Teacher> Edit(TeacherEditModel mouse)
        {
            return TeacherDAL.Edit(mouse);
        }

        public ReturnResult<Teacher> EditStatus(TeacherEditStatusModel mouse)
        {
            return TeacherDAL.EditStatus(mouse);
        }
    }
}
