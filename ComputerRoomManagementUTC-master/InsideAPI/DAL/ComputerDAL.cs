using Common.Common;
using Common.Entity.Models.Computer;
using InsideAPI.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.DAL
{
    public class ComputerDAL
    {
        public ReturnResult<Computer> GetAllComputerSearched(BaseCondition<Computer> condition, int computerRoomId)
        {
            List<Computer> computerList = new List<Computer>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("COMPUTER_GET_PAGING_BY_COMPUTER_ROOM_ID", CommandType.StoredProcedure)
                .SetParameter("COMPUTER_ROOM_ID", SqlDbType.Int, computerRoomId, ParameterDirection.Input)
                .SetParameter("FROM_RECORD", SqlDbType.Int, condition.FROM_RECORD, ParameterDirection.Input)
                .SetParameter("PAGE_SIZE", SqlDbType.Int, condition.PAGE_SIZE, ParameterDirection.Input)
                .SetParameter("IN_WHERE", SqlDbType.NVarChar, condition.IN_WHERE, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .SetParameter("OUT_TOTAL_ROWS", SqlDbType.Int, DBNull.Value, ParameterDirection.Output)
                .GetList<Computer>(out computerList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage)
                       .GetOutValue("OUT_TOTAL_ROWS", out totalRows);
            return new ReturnResult<Computer>()
            {
                ItemList = computerList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Computer> GetAll(int id)
        {
            List<Computer> computerList = new List<Computer>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            dbProvider.SetQuery("COMPUTER_GET_ALL", CommandType.StoredProcedure)
                .SetParameter("COMPUTER_ROOM_ID", System.Data.SqlDbType.Int, id, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", System.Data.SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", System.Data.SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetList<Computer>(out computerList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Computer>()
            {
                ItemList = computerList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Computer> Edit(ComputerEditModel computer)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Computer> storedProcedureConfigs = new StoredProcedureConfigs<Computer>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Name", SqlDbType.NVarChar, computer.Name, ParameterDirection.Input)
                .SetParameter("ComputerRoomId", SqlDbType.Int, computer.ComputerRoomId, ParameterDirection.Input)
                .SetParameter("StorageDeviceId", SqlDbType.Int, computer.StorageDeviceId, ParameterDirection.Input)
                .SetParameter("StorageCapacityId", SqlDbType.Int, computer.StorageCapacityId, ParameterDirection.Input)
                .SetParameter("CpuId", SqlDbType.Int, computer.CpuId, ParameterDirection.Input)
                .SetParameter("RamId", SqlDbType.Int, computer.RamId, ParameterDirection.Input)
                .SetParameter("SpeedId", SqlDbType.Int, computer.SpeedId, ParameterDirection.Input)
                .SetParameter("MonitorId", SqlDbType.Int, computer.MonitorId, ParameterDirection.Input)
                .SetParameter("MonitorSizeId", SqlDbType.Int, computer.MonitorSizeId, ParameterDirection.Input)
                .SetParameter("MouseId", SqlDbType.Int, computer.MouseId, ParameterDirection.Input)
                .SetParameter("KeyboardId", SqlDbType.Int, computer.KeyboardId, ParameterDirection.Input)
                .SetParameter("OpticalDisc", SqlDbType.Int, computer.OpticalDiscId, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, computer.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, computer.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Computer>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Computer> GetById(int id)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            Computer computer = null;
            StoredProcedureConfigs<Computer> storedProcedureConfigs = new StoredProcedureConfigs<Computer>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, id, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<Computer>(out computer)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Computer>()
            {
                Item = computer,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Computer> Add(AddComputerViewModel computer)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Computer> storedProcedureConfigs = new StoredProcedureConfigs<Computer>();
            dbProvider.SetQuery(storedProcedureConfigs._INSERT_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Name", SqlDbType.NVarChar, computer.Name, ParameterDirection.Input)
                .SetParameter("ComputerRoomId", SqlDbType.Int, computer.ComputerRoomId, ParameterDirection.Input)
                .SetParameter("StorageDeviceId", SqlDbType.Int, computer.StorageDeviceId, ParameterDirection.Input)
                .SetParameter("StorageCapacityId", SqlDbType.Int, computer.StorageCapacityId, ParameterDirection.Input)
                .SetParameter("CpuId", SqlDbType.Int, computer.CpuId, ParameterDirection.Input)
                .SetParameter("RamId", SqlDbType.Int, computer.RamId, ParameterDirection.Input)
                .SetParameter("SpeedId", SqlDbType.Int, computer.SpeedId, ParameterDirection.Input)
                .SetParameter("MonitorId", SqlDbType.Int, computer.MonitorId, ParameterDirection.Input)
                .SetParameter("MonitorSizeId", SqlDbType.Int, computer.MonitorSizeId, ParameterDirection.Input)
                .SetParameter("MouseId", SqlDbType.Int, computer.MouseId, ParameterDirection.Input)
                .SetParameter("KeyboardId", SqlDbType.Int, computer.KeyboardId, ParameterDirection.Input)
                .SetParameter("OpticalDisc", SqlDbType.Int, computer.OpticalDiscId, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, computer.Status, ParameterDirection.Input)
                .SetParameter("CreatedBy", SqlDbType.NVarChar, computer.CreatedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Computer>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }
    }
}
