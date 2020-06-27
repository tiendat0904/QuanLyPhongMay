using Common.Common;
using Common.Entity.Models.Account;
using Common.Entity.Models.User;
using InsideAPI.Common;
using System;

using System.Data;


namespace InsideAPI.DAL
{
    public class UserDAL
    {
        public ReturnResult<Login> GetUserByUserName(Login login)
        {
            Login user = new Login();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<User> storedProcedureConfigs = new StoredProcedureConfigs<User>();
            dbProvider.SetQuery("GET_USER_PASSWORD_BY_USER_NAME", CommandType.StoredProcedure)
                .SetParameter("UserName", SqlDbType.NVarChar, login.UserName, 50, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<Login>(out user)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Login>()
            {
                Item = user,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<User> GetUserByUserName()
        {
            User user = new User();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<User> storedProcedureConfigs = new StoredProcedureConfigs<User>();
            dbProvider.SetQuery("GET_USER_BY_USER_NAME", CommandType.StoredProcedure)
                .SetParameter("UserName", SqlDbType.NVarChar, UserSessionInfo.UserName, 50, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<User>(out user)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<User>()
            {
                Item = user,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
    }
}
