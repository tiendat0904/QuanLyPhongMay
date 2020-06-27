
using InsideAPI.BUS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserBusiness _userBUS { get; set; }
        public UserBusiness UserBusiness
        {
            get
            {
                return _userBUS = new UserBusiness(); ;
            }
        }

        [Authorize]
        public IActionResult GetUserByName()
        {
            return Ok(UserBusiness.GetUserByUserName());
        }
    }
}