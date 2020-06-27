using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Monitor;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Monitor = Common.Entity.Models.Monitor.Monitor;

namespace ComputerRoomManagementUTC.Controllers
{
    public class MonitorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public MonitorController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Monitor>>(apiUrl);
            return Json(result);
        }
        [HttpGet]
        public async Task<ActionResult> MonitorPaging(BaseCondition<Monitor> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Monitor>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddMonitorViewModel monitorSize)
        {
            monitorSize.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Monitor>>(apiUrl, JsonConvert.SerializeObject(monitorSize));
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.MONITOR_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Monitor>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(MonitorEditViewModel monitorSize)
        {
            monitorSize.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<MonitorEditViewModel>>(apiUrl, JsonConvert.SerializeObject(monitorSize));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(MonitorDeleteViewModel monitorSize)
        {
            monitorSize.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Monitor>>(apiUrl, JsonConvert.SerializeObject(monitorSize));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(MonitorEditStatusViewModel monitorSize)
        {
            monitorSize.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MONITOR_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Monitor>>(apiUrl, JsonConvert.SerializeObject(monitorSize));
            return Json(result);
        }
    }
}
