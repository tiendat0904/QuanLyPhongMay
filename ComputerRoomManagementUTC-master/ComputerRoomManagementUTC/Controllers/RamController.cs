using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.RAM;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace InsideApi.Controllers
{
    public class RamController : Controller
    {
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public RamController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> RamPaging(BaseCondition<RAM> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<RAM>>(apiUrl, JsonConvert.SerializeObject(condition));
            ViewBag.PAGE_INDEX = condition.PAGE_INDEX;
            ViewBag.PAGE_SIZE = condition.PAGE_SIZE;
            return View(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<RAM>>(apiUrl);
            return Json(result);
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
        public async Task<ActionResult> Add(AddRamViewModel ram)
        {
            ram.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<RAM>>(apiUrl, JsonConvert.SerializeObject(ram));
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
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.RAM_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<RAM>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(RamEditViewModel ram)
        {
            ram.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<RamEditViewModel>>(apiUrl, JsonConvert.SerializeObject(ram));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(RamDeleteViewModel ram)
        {
            ram.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<RAM>>(apiUrl, JsonConvert.SerializeObject(ram));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(RamEditStatusViewModel ram)
        {
            ram.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<RAM>>(apiUrl, JsonConvert.SerializeObject(ram));
            return Json(result);
        }
    }
}