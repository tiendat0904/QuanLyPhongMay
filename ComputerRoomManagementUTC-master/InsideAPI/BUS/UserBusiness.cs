using System;
using Common.Common;
using Common.Entity.Models.Account;
using Common.Entity.Models.User;
using InsideAPI.DAL;

namespace InsideAPI.BUS
{
    public class UserBusiness
    {
        private UserDAL _userDAL { get; set; }
        private UserDAL UserDAL
        {
            get
            {
                return _userDAL = new UserDAL(); ;
            }
        }
        public ReturnResult<Login> GetUserByUserName(Login login)
        {
            return UserDAL.GetUserByUserName(login);
        }

        public ReturnResult<User> GetUserByUserName()
        {
            return UserDAL.GetUserByUserName();
        }
    }
}
