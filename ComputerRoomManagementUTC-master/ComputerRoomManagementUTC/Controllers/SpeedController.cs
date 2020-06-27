using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Speed;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class SpeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public SpeedController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SPEED_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Speed>>(apiUrl);
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> SpeedPaging(BaseCondition<Speed> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SPEED_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Speed>>(apiUrl, JsonConvert.SerializeObject(condition));
            ViewBag.PAGE_INDEX = condition.PAGE_INDEX;
            ViewBag.PAGE_SIZE = condition.PAGE_SIZE;
            return View(result);
        }

        /// <summary>
        /// Display add form view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(AddSpeedViewModel speed)
        {
            speed.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SPEED_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Speed>>(apiUrl, JsonConvert.SerializeObject(speed));
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <paspeed name="id"></paspeed>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.SPEED_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Speed>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(SpeedEditViewModel speed)
        {
            speed.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SPEED_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<SpeedEditViewModel>>(apiUrl, JsonConvert.SerializeObject(speed));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(SpeedDeleteViewModel speed)
        {
            speed.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SPEED_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Speed>>(apiUrl, JsonConvert.SerializeObject(speed));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(SpeedEditStatusViewModel speed)
        {
            speed.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SPEED_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Speed>>(apiUrl, JsonConvert.SerializeObject(speed));
            return Json(result);
        }
    }
}