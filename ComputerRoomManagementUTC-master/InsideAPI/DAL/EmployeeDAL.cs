using Common.Common;
using Common.Entity.Models.Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.DAL
{
    public class EmployeeDAL
    {
        public ReturnResult<Employee> GetAllEmployeeSearched(BaseCondition<Employee> condition)
        {
            List<Employee> employeeList = new List<Employee>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<Employee> storedProcedureConfigs = new StoredProcedureConfigs<Employee>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_PAGING_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("FROM_RECORD", SqlDbType.Int, condition.FROM_RECORD, ParameterDirection.Input)
                .SetParameter("PAGE_SIZE", SqlDbType.Int, condition.PAGE_SIZE, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .SetParameter("OUT_TOTAL_ROWS", SqlDbType.Int, DBNull.Value, ParameterDirection.Output)
                .GetList<Employee>(out employeeList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage)
                       .GetOutValue("OUT_TOTAL_ROWS", out totalRows);
            return new ReturnResult<Employee>()
            {
                ItemList = employeeList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Employee> Edit(EmployeeEditModel employee)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Employee> storedProcedureConfigs = new StoredProcedureConfigs<Employee>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, employee.Pk_id, ParameterDirection.Input)
                .SetParameter("Name", SqlDbType.NVarChar, employee.Name, ParameterDirection.Input)
                .SetParameter("Dob", SqlDbType.DateTime, employee.Dob, ParameterDirection.Input)
                .SetParameter("Gender", SqlDbType.Int, employee.Gender, ParameterDirection.Input)
                .SetParameter("PhoneNumber", SqlDbType.Int, employee.PhoneNumber, ParameterDirection.Input)
                .SetParameter("FK_ComputerRoomId", SqlDbType.Int, employee.FK_ComputerRoomId, ParameterDirection.Input)
                .SetParameter("FK_ProvinceId", SqlDbType.Int, employee.FK_ProvinceId, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, employee.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, employee.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Employee>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Employee> Delete(EmployeeDeleteModel employee)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Employee> storedProcedureConfigs = new StoredProcedureConfigs<Employee>();
            dbProvider.SetQuery(storedProcedureConfigs._DELETE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, employee.Id, ParameterDirection.Input)
                .SetParameter("UserName", SqlDbType.NVarChar, employee.DeletedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Employee>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Employee> GetById(int id)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            Employee employee = null;
            StoredProcedureConfigs<Employee> storedProcedureConfigs = new StoredProcedureConfigs<Employee>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, id, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<Employee>(out employee)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Employee>()
            {
                Item = employee,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Employee> Add(AddEmployeeModel employee)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Employee> storedProcedureConfigs = new StoredProcedureConfigs<Employee>();
            dbProvider.SetQuery(storedProcedureConfigs._INSERT_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Name", SqlDbType.NVarChar, employee.Name, ParameterDirection.Input)
                .SetParameter("Dob", SqlDbType.DateTime, employee.Dob, ParameterDirection.Input)
                .SetParameter("Gender", SqlDbType.Int, employee.Gender, ParameterDirection.Input)
                .SetParameter("PhoneNumber", SqlDbType.Int, employee.PhoneNumber, ParameterDirection.Input)
                .SetParameter("FK_ComputerRoomId",  SqlDbType.Int, employee.FK_ComputerRoomId, ParameterDirection.Input)
                .SetParameter("FK_ProvinceId", SqlDbType.Int, employee.FK_ProvinceId, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, employee.Status, ParameterDirection.Input)
                .SetParameter("CreatedBy", SqlDbType.NVarChar, employee.CreatedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Employee>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Employee> GetAll()
        {
            List<Employee> employeeList = new List<Employee>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<Employee> storedProcedureConfigs = new StoredProcedureConfigs<Employee>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_ALL_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("ERROR_CODE", System.Data.SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", System.Data.SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetList<Employee>(out employeeList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Employee>()
            {
                ItemList = employeeList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Employee> EditStatus(EmployeeEditStatusModel employee)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Employee> storedProcedureConfigs = new StoredProcedureConfigs<Employee>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_STATUS_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, employee.Id, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, employee.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, employee.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Employee>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }
    }
}
