using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Mouse;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class MouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public MouseController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> MousePaging(BaseCondition<Mouse> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Mouse>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddMouseViewModel mouse)
        {
            mouse.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Mouse>>(apiUrl, JsonConvert.SerializeObject(mouse));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Mouse>>(apiUrl);
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <pamouse name="id"></pamouse>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.MOUSE_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Mouse>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(MouseEditViewModel mouse)
        {
            mouse.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<MouseEditViewModel>>(apiUrl, JsonConvert.SerializeObject(mouse));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(MouseDeleteViewModel mouse)
        {
            mouse.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Mouse>>(apiUrl, JsonConvert.SerializeObject(mouse));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(MouseEditStatusViewModel mouse)
        {
            mouse.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Mouse>>(apiUrl, JsonConvert.SerializeObject(mouse));
            return Json(result);
        }
    }
}