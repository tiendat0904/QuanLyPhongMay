using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagementUTC.Interfaces
{
    public interface IAppUrlHelper
    {
        string GetApiUrl(string urlPath);
    }
}
