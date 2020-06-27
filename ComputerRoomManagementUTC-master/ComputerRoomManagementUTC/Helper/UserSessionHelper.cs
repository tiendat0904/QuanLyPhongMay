using Common.Entity.Models.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagementUTC.Helper
{
    public class UserSessionHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string USER_NAME = "UserName";
        private const string IS_ADMIN = "IsAdmin";
        private const string PHONE_NUMBER = "PhoneNumber";
        private const string TITLE = "Title";
        private const string TOKEN = "Token";
        public UserSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void SetUserSession(User user, string token)
        {
            _httpContextAccessor.HttpContext.Session.SetString(USER_NAME, user.UserName);
            if (user.IsAdmin)
            {
                _httpContextAccessor.HttpContext.Session.SetInt32(IS_ADMIN, 1);
            }
            else
            {
                _httpContextAccessor.HttpContext.Session.SetInt32(IS_ADMIN, 0);
            }
            _httpContextAccessor.HttpContext.Session.SetInt32(PHONE_NUMBER, user.PhoneNumber);
            _httpContextAccessor.HttpContext.Session.SetString(TITLE, user.Title);
            _httpContextAccessor.HttpContext.Session.SetString(TOKEN, token);
        }

        public UserSession GetUserSession()
        {
            var userSession = new UserSession();
            userSession.UserName = _httpContextAccessor.HttpContext.Session.GetString(USER_NAME);
            userSession.Title = _httpContextAccessor.HttpContext.Session.GetString(TITLE);
            userSession.Token = _httpContextAccessor.HttpContext.Session.GetString(TOKEN);
            if(_httpContextAccessor.HttpContext.Session.GetInt32(IS_ADMIN) == 1)
            {
                userSession.IsAdmin = true;
            }
            else
            {
                userSession.IsAdmin = false;
            }
            return userSession;
        }

        public void DeleteSesssion()
        {
            _httpContextAccessor.HttpContext.Session.Remove(USER_NAME);
            _httpContextAccessor.HttpContext.Session.Remove(PHONE_NUMBER);
            _httpContextAccessor.HttpContext.Session.Remove(IS_ADMIN);
            _httpContextAccessor.HttpContext.Session.Remove(TITLE);
            _httpContextAccessor.HttpContext.Session.Remove(TOKEN);
        }
    }
}
