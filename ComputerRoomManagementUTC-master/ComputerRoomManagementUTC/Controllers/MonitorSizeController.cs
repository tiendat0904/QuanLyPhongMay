using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.MonitorSize;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class MonitorSizeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_SIZE_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<MonitorSize>>(apiUrl);
            return Json(result);
        }

        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public MonitorSizeController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> MonitorSizePaging(BaseCondition<MonitorSize> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_SIZE_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<MonitorSize>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddMonitorSizeViewModel monitor)
        {
            monitor.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_SIZE_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<MonitorSize>>(apiUrl, JsonConvert.SerializeObject(monitor));
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <pamonitor name="id"></pamonitor>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.MONITOR_SIZE_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<MonitorSize>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(MonitorSizeEditViewModel monitor)
        {
            monitor.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_SIZE_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<MonitorSizeEditViewModel>>(apiUrl, JsonConvert.SerializeObject(monitor));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(MonitorSizeDeleteViewModel monitor)
        {
            monitor.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_SIZE_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<MonitorSize>>(apiUrl, JsonConvert.SerializeObject(monitor));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(MonitorSizeEditStatusViewModel monitor)
        {
            monitor.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_SIZE_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<MonitorSize>>(apiUrl, JsonConvert.SerializeObject(monitor));
            return Json(result);
        }
    }
}