using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerRoomManagementUTC.Models;
using Microsoft.AspNetCore.Authorization;
using ComputerRoomManagementUTC.Helper;

namespace ComputerRoomManagementUTC.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserSessionHelper _userSessionHelper;
        public HomeController(UserSessionHelper userSessionHelper)
        {
            _userSessionHelper = userSessionHelper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //if (_userSessionHelper.GetUserSession().IsUserLoggedIn)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Account");
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return PartialView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
