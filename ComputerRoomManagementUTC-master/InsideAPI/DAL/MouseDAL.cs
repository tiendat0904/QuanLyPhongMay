using Common.Common;
using Common.Entity.Models.Mouse;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.DAL
{
    public class MouseDAL
    {
        public ReturnResult<Mouse> GetAllMouseSearched(BaseCondition<Mouse> condition)
        {
            List<Mouse> mouseList = new List<Mouse>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<Mouse> storedProcedureConfigs = new StoredProcedureConfigs<Mouse>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_PAGING_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("FROM_RECORD", SqlDbType.Int, condition.FROM_RECORD, ParameterDirection.Input)
                .SetParameter("PAGE_SIZE", SqlDbType.Int, condition.PAGE_SIZE, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .SetParameter("OUT_TOTAL_ROWS", SqlDbType.Int, DBNull.Value, ParameterDirection.Output)
                .GetList<Mouse>(out mouseList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage)
                       .GetOutValue("OUT_TOTAL_ROWS", out totalRows);
            return new ReturnResult<Mouse>()
            {
                ItemList = mouseList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Mouse> Edit(MouseEditViewModel mouse)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Mouse> storedProcedureConfigs = new StoredProcedureConfigs<Mouse>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, mouse.Pk_id, 100, ParameterDirection.Input)
                .SetParameter("Name", SqlDbType.NVarChar, mouse.Name, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, mouse.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, mouse.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Mouse>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Mouse> Delete(MouseDeleteViewModel mouse)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Mouse> storedProcedureConfigs = new StoredProcedureConfigs<Mouse>();
            dbProvider.SetQuery(storedProcedureConfigs._DELETE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, mouse.Id, ParameterDirection.Input)
                .SetParameter("UserName", SqlDbType.NVarChar, mouse.DeletedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Mouse>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Mouse> GetById(int id)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            Mouse mouse = null;
            StoredProcedureConfigs<Mouse> storedProcedureConfigs = new StoredProcedureConfigs<Mouse>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, id, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<Mouse>(out mouse)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Mouse>()
            {
                Item = mouse,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Mouse> Add(AddMouseViewModel mouse)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Mouse> storedProcedureConfigs = new StoredProcedureConfigs<Mouse>();
            dbProvider.SetQuery("MOUSE_INSERT", CommandType.StoredProcedure)
                .SetParameter("Name", SqlDbType.NVarChar, mouse.Name, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, mouse.Status, ParameterDirection.Input)
                .SetParameter("CreatedBy", SqlDbType.NVarChar, mouse.CreatedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Mouse>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Mouse> GetAll()
        {
            List<Mouse> mouseList = new List<Mouse>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            
            dbProvider.SetQuery("MOUSE_GET_ALL", CommandType.StoredProcedure)
                .SetParameter("ERROR_CODE", System.Data.SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", System.Data.SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetList<Mouse>(out mouseList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Mouse>()
            {
                ItemList = mouseList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Mouse> EditStatus(MouseEditStatusViewModel mouse)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Mouse> storedProcedureConfigs = new StoredProcedureConfigs<Mouse>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_STATUS_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, mouse.Id, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, mouse.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, mouse.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Mouse>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }
    }
}
