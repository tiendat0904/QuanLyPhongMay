using Common.Common;
using Common.Entity.Models.StorageDevice;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.DAL
{
    public class StorageDeviceDAL
    {
        public ReturnResult<StorageDevice> GetAllStorageDeviceSearched(BaseCondition<StorageDevice> condition)
        {
            List<StorageDevice> storageDeviceList = new List<StorageDevice>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<StorageDevice> storedProcedureConfigs = new StoredProcedureConfigs<StorageDevice>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_PAGING_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("FROM_RECORD", SqlDbType.Int, condition.FROM_RECORD, ParameterDirection.Input)
                .SetParameter("PAGE_SIZE", SqlDbType.Int, condition.PAGE_SIZE, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .SetParameter("OUT_TOTAL_ROWS", SqlDbType.Int, DBNull.Value, ParameterDirection.Output)
                .GetList<StorageDevice>(out storageDeviceList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage)
                       .GetOutValue("OUT_TOTAL_ROWS", out totalRows);
            return new ReturnResult<StorageDevice>()
            {
                ItemList = storageDeviceList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<StorageDevice> Edit(StorageDeviceEditViewModel storageDevice)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<StorageDevice> storedProcedureConfigs = new StoredProcedureConfigs<StorageDevice>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, storageDevice.Pk_id, 100, ParameterDirection.Input)
                .SetParameter("Name", SqlDbType.NVarChar, storageDevice.Name, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, storageDevice.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, storageDevice.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StorageDevice>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<StorageDevice> Delete(StorageDeviceDeleteViewModel storageDevice)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<StorageDevice> storedProcedureConfigs = new StoredProcedureConfigs<StorageDevice>();
            dbProvider.SetQuery(storedProcedureConfigs._DELETE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, storageDevice.Id, ParameterDirection.Input)
                .SetParameter("UserName", SqlDbType.NVarChar, storageDevice.DeletedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StorageDevice>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<StorageDevice> GetById(int id)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StorageDevice storageDevice = null;
            StoredProcedureConfigs<StorageDevice> storedProcedureConfigs = new StoredProcedureConfigs<StorageDevice>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, id, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<StorageDevice>(out storageDevice)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StorageDevice>()
            {
                Item = storageDevice,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<StorageDevice> Add(AddStorageDeviceViewModel storageDevice)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<StorageDevice> storedProcedureConfigs = new StoredProcedureConfigs<StorageDevice>();
            dbProvider.SetQuery(storedProcedureConfigs._INSERT_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Name", SqlDbType.NVarChar, storageDevice.Name, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, storageDevice.Status, ParameterDirection.Input)
                .SetParameter("CreatedBy", SqlDbType.NVarChar, storageDevice.CreatedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StorageDevice>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<StorageDevice> GetAll()
        {
            List<StorageDevice> storageDeviceList = new List<StorageDevice>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<StorageDevice> storedProcedureConfigs = new StoredProcedureConfigs<StorageDevice>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_ALL_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("ERROR_CODE", System.Data.SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", System.Data.SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetList<StorageDevice>(out storageDeviceList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StorageDevice>()
            {
                ItemList = storageDeviceList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<StorageDevice> EditStatus(StorageDeviceEditStatusViewModel storageDevice)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<StorageDevice> storedProcedureConfigs = new StoredProcedureConfigs<StorageDevice>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_STATUS_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, storageDevice.Id, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, storageDevice.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, storageDevice.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<StorageDevice>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }
    }
}
