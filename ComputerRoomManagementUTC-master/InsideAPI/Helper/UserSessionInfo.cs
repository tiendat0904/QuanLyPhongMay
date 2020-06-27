using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Common
{
    public static class UserSessionInfo
    {
        public static string UserId { get; set; }
        public static string UserName { get; set; }
        public static string IsAdmin { get; set; }
        public static string Token { get; set; }
       
        
    }
}
