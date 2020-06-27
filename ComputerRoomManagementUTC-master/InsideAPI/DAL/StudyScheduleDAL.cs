using Common.Common;
using Common.Entity.Models.StudySchedule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.DAL
{
    public class StudyScheduleDAL
    {
        public ReturnResult<StudySchedule> GetAllStudyScheduleSearched(BaseCondition<StudySchedule> condition)
        {
            List<StudySchedule> studyScheduleList = new List<StudySchedule>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<StudySchedule> storedProcedureConfigs = new StoredProcedureConfigs<StudySchedule>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_PAGING_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("FROM_RECORD", SqlDbType.Int, condition.FROM_RECORD, ParameterDirection.Input)
                .SetParameter("PAGE_SIZE", SqlDbType.Int, condition.PAGE_SIZE, ParameterDirection.Input)
                .SetParameter("IN_WHERE", SqlDbType.NVarChar, condition.IN_WHERE, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .SetParameter("OUT_TOTAL_ROWS", SqlDbType.Int, DBNull.Value, ParameterDirection.Output)
                .GetList<StudySchedule>(out studyScheduleList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage)
                       .GetOutValue("OUT_TOTAL_ROWS", out totalRows);
            return new ReturnResult<StudySchedule>()
            {
                ItemList = studyScheduleList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<StudySchedule> Edit(StudyScheduleEditModel studySchedule)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<StudySchedule> storedProcedureConfigs = new StoredProcedureConfigs<StudySchedule>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, studySchedule.PK_Id, ParameterDirection.Input)
                .SetParameter("StartDate", SqlDbType.DateTime, studySchedule.StartDate, ParameterDirection.Input)
                .SetParameter("EndDate", SqlDbType.DateTime, studySchedule.EndDate, ParameterDirection.Input)
                .SetParameter("ClassId", SqlDbType.Int, studySchedule.ClassId, ParameterDirection.Input)
                .SetParameter("ComputerRoomId", SqlDbType.Int, studySchedule.ComputerRoomId, ParameterDirection.Input)
                .SetParameter("ShiftId", SqlDbType.Int, studySchedule.ShiftId, ParameterDirection.Input)
                .SetParameter("SubjectId", SqlDbType.Int, studySchedule.SubjectId, ParameterDirection.Input)
                .SetParameter("TeacherId", SqlDbType.Int, studySchedule.TeacherId, ParameterDirection.Input)
                .SetParameter("DayOfWeek", SqlDbType.Int, studySchedule.DayOfWeek, ParameterDirection.Input)
                .SetParameter("EmployeeId", SqlDbType.Int, studySchedule.EmployeeId, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, studySchedule.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, studySchedule.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StudySchedule>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<StudySchedule> Delete(StudyScheduleDeleteModel studySchedule)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<StudySchedule> storedProcedureConfigs = new StoredProcedureConfigs<StudySchedule>();
            dbProvider.SetQuery(storedProcedureConfigs._DELETE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, studySchedule.Id, ParameterDirection.Input)
                .SetParameter("UserName", SqlDbType.NVarChar, studySchedule.DeletedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StudySchedule>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<StudySchedule> GetById(int id)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StudySchedule studySchedule = null;
            StoredProcedureConfigs<StudySchedule> storedProcedureConfigs = new StoredProcedureConfigs<StudySchedule>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, id, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<StudySchedule>(out studySchedule)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StudySchedule>()
            {
                Item = studySchedule,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<StudySchedule> Add(AddStudyScheduleModel studySchedule)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<StudySchedule> storedProcedureConfigs = new StoredProcedureConfigs<StudySchedule>();
            dbProvider.SetQuery(storedProcedureConfigs._INSERT_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("StartDate", SqlDbType.DateTime, studySchedule.StartDate, ParameterDirection.Input)
                .SetParameter("EndDate", SqlDbType.DateTime, studySchedule.EndDate, ParameterDirection.Input)
                .SetParameter("ClassId", SqlDbType.Int, studySchedule.ClassId, ParameterDirection.Input)
                .SetParameter("ComputerRoomId", SqlDbType.Int, studySchedule.ComputerRoomId, ParameterDirection.Input)
                .SetParameter("ShiftId", SqlDbType.Int, studySchedule.ShiftId, ParameterDirection.Input)
                .SetParameter("SubjectId", SqlDbType.Int, studySchedule.SubjectId, ParameterDirection.Input)
                .SetParameter("TeacherId", SqlDbType.Int, studySchedule.TeacherId, ParameterDirection.Input)
                .SetParameter("DayOfWeek", SqlDbType.Int, studySchedule.DayOfWeek, ParameterDirection.Input)
                .SetParameter("EmployeeId", SqlDbType.Int, studySchedule.EmployeeId, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, studySchedule.Status, ParameterDirection.Input)
                .SetParameter("CreatedBy", SqlDbType.NVarChar, studySchedule.CreatedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StudySchedule>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<StudySchedule> GetAll()
        {
            List<StudySchedule> studyScheduleList = new List<StudySchedule>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<StudySchedule> storedProcedureConfigs = new StoredProcedureConfigs<StudySchedule>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_ALL_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("ERROR_CODE", System.Data.SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", System.Data.SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetList<StudySchedule>(out studyScheduleList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StudySchedule>()
            {
                ItemList = studyScheduleList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<StudySchedule> EditStatus(StudyScheduleEditStatusModel studySchedule)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<StudySchedule> storedProcedureConfigs = new StoredProcedureConfigs<StudySchedule>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_STATUS_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Status", SqlDbType.Int, studySchedule.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, studySchedule.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StudySchedule>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }
    }
}
