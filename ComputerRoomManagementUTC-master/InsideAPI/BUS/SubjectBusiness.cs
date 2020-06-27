using Common.Common;
using Common.Entity.Models.Subject;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class SubjectBusiness
    {
        private SubjectDAL _mouseDAL;
        public SubjectDAL SubjectDAL
        {
            get
            {
                _mouseDAL = new SubjectDAL();
                return _mouseDAL;
            }
        }
        public ReturnResult<Subject> GetAllSubjectSearched(BaseCondition<Subject> condition)
        {
            SubjectDAL mouseDAL = new SubjectDAL();
            var result = mouseDAL.GetAllSubjectSearched(condition);
            return result;
        }

        public ReturnResult<Subject> GetAll()
        {
            return SubjectDAL.GetAll();
        }

        public ReturnResult<Subject> AddSubject(AddSubjectModel mouse)
        {
            return SubjectDAL.Add(mouse);
        }

        public ReturnResult<Subject> GetById(int Id)
        {
            return SubjectDAL.GetById(Id);
        }

        public ReturnResult<Subject> Delete(SubjectDeleteModel mouse)
        {
            return SubjectDAL.Delete(mouse);
        }

        public ReturnResult<Subject> Edit(SubjectEditModel mouse)
        {
            return SubjectDAL.Edit(mouse);
        }

        public ReturnResult<Subject> EditStatus(SubjectEditStatusModel mouse)
        {
            return SubjectDAL.EditStatus(mouse);
        }
    }
}
