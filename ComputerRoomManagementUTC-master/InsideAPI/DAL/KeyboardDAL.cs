using Common.Common;
using Common.Entity.Models.Keyboard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.DAL
{
    public class KeyboardDAL
    {
        public ReturnResult<Keyboard> GetAllKeyboardSearched(BaseCondition<Keyboard> condition)
        {
            List<Keyboard> keyboardList = new List<Keyboard>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<Keyboard> storedProcedureConfigs = new StoredProcedureConfigs<Keyboard>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_PAGING_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("FROM_RECORD", SqlDbType.Int, condition.FROM_RECORD, ParameterDirection.Input)
                .SetParameter("PAGE_SIZE", SqlDbType.Int, condition.PAGE_SIZE, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .SetParameter("OUT_TOTAL_ROWS", SqlDbType.Int, DBNull.Value, ParameterDirection.Output)
                .GetList<Keyboard>(out keyboardList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage)
                       .GetOutValue("OUT_TOTAL_ROWS", out totalRows);
            return new ReturnResult<Keyboard>()
            {
                ItemList = keyboardList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Keyboard> Edit(KeyboardEditViewModel cpu)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Keyboard> storedProcedureConfigs = new StoredProcedureConfigs<Keyboard>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, cpu.Pk_id, 100, ParameterDirection.Input)
                .SetParameter("Name", SqlDbType.NVarChar, cpu.Name, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, cpu.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, cpu.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Keyboard>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Keyboard> Delete(KeyboardDeleteViewModel cpu)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Keyboard> storedProcedureConfigs = new StoredProcedureConfigs<Keyboard>();
            dbProvider.SetQuery(storedProcedureConfigs._DELETE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, cpu.Id, ParameterDirection.Input)
                .SetParameter("UserName", SqlDbType.NVarChar, cpu.DeletedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Keyboard>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Keyboard> GetById(int id)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            Keyboard cpu = null;
            StoredProcedureConfigs<Keyboard> storedProcedureConfigs = new StoredProcedureConfigs<Keyboard>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, id, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<Keyboard>(out cpu)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Keyboard>()
            {
                Item = cpu,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Keyboard> Add(AddKeyboardViewModel cpu)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Keyboard> storedProcedureConfigs = new StoredProcedureConfigs<Keyboard>();
            dbProvider.SetQuery(storedProcedureConfigs._INSERT_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Name", SqlDbType.NVarChar, cpu.Name, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, cpu.Status, ParameterDirection.Input)
                .SetParameter("CreatedBy", SqlDbType.NVarChar, cpu.CreatedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Keyboard>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Keyboard> GetAll()
        {
            List<Keyboard> cpuList = new List<Keyboard>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<Keyboard> storedProcedureConfigs = new StoredProcedureConfigs<Keyboard>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_ALL_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("ERROR_CODE", System.Data.SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", System.Data.SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetList<Keyboard>(out cpuList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Keyboard>()
            {
                ItemList = cpuList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Keyboard> EditStatus(KeyboardEditStatusViewModel cpu)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Keyboard> storedProcedureConfigs = new StoredProcedureConfigs<Keyboard>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_STATUS_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, cpu.Id, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, cpu.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, cpu.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Keyboard>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }
    }
}
