using ComputerRoomManagementUTC.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRoomManagementUTC.Helper
{
    public class AppUrlHelper : IAppUrlHelper
    {
        private readonly IConfiguration _configuration;
        public AppUrlHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetApiUrl(string urlPath)
        {
            string domainName = _configuration.GetValue<string>("ApiUrl");
            StringBuilder stringBuilder = new StringBuilder(domainName);
            stringBuilder.Append(urlPath);
            return stringBuilder.ToString();
        }
    }
}
