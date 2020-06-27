using Common.Common;
using Common.Entity.Models.Account;
using Common.Entity.Models.User;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ComputerRoomManagementUTC.Helper;

namespace ComputerRoomManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserSessionHelper _userSessionHelper;

        public AccountController(UserSessionHelper userSessionHelper)
        {

            _userSessionHelper = userSessionHelper;
        }

        [HttpPost]
        public async Task<ActionResult> Login(Login login)
        {

  
            int errorCode = 0;
            string errorMessage = string.Empty;
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<LoginResult>>("https://localhost:44356/api/Account/Login", JsonConvert.SerializeObject(login));
            var jwtToken = result.Item.token;
            if(string.IsNullOrEmpty(jwtToken))
            {
                errorCode = 1;
                errorMessage = "Incorrect username or password";
            }
            else
            {
                var respone = HttpUtilities.GetAsyncApi<ReturnResult<User>>("https://localhost:44356/api/Users/GetUserByName", jwtToken);
                if (respone.Result.Item != null)
                {
                    var userInfo = respone.Result.Item;
                    _userSessionHelper.SetUserSession(userInfo, jwtToken);
                }
                else
                {
                    errorCode = 1;
                    errorMessage = "Failed to get data form server";
                }
            }
            var userSession = _userSessionHelper.GetUserSession();
            var jsonResult = new
            {
                ErrorCode = errorCode,
                ErrorMessage = errorMessage
            };
            return Json(jsonResult);
        }

        public ActionResult Index()
        {
            //if (_userSessionHelper.GetUserSession().IsUserLoggedIn)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            //    return View("Login");
            //}
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            _userSessionHelper.DeleteSesssion();
            return RedirectToAction("Index", "Account");
        }
    }
}