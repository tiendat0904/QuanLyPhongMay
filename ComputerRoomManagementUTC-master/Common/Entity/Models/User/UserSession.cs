using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.User
{
    public class UserSession
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public bool IsAdmin { get; set; }
        public string Title { get; set; }
        public bool IsUserLoggedIn => string.IsNullOrEmpty(Token) ? false : true;
    }
}
