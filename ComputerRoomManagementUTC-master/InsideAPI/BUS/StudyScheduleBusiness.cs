using Common.Common;
using Common.Entity.Models.StudySchedule;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class StudyScheduleBusiness
    {
        private StudyScheduleDAL _mouseDAL;
        public StudyScheduleDAL StudyScheduleDAL
        {
            get
            {
                _mouseDAL = new StudyScheduleDAL();
                return _mouseDAL;
            }
        }
        public ReturnResult<StudySchedule> GetAllStudyScheduleSearched(BaseCondition<StudySchedule> condition)
        {
            StudyScheduleDAL mouseDAL = new StudyScheduleDAL();
            var result = mouseDAL.GetAllStudyScheduleSearched(condition);
            return result;
        }

        public ReturnResult<StudySchedule> GetAll()
        {
            return StudyScheduleDAL.GetAll();
        }

        public ReturnResult<StudySchedule> AddStudySchedule(AddStudyScheduleModel mouse)
        {
            return StudyScheduleDAL.Add(mouse);
        }

        public ReturnResult<StudySchedule> GetById(int Id)
        {
            return StudyScheduleDAL.GetById(Id);
        }

        public ReturnResult<StudySchedule> Delete(StudyScheduleDeleteModel mouse)
        {
            return StudyScheduleDAL.Delete(mouse);
        }

        public ReturnResult<StudySchedule> Edit(StudyScheduleEditModel mouse)
        {
            return StudyScheduleDAL.Edit(mouse);
        }

        public ReturnResult<StudySchedule> EditStatus(StudyScheduleEditStatusModel mouse)
        {
            return StudyScheduleDAL.EditStatus(mouse);
        }
    }
}
