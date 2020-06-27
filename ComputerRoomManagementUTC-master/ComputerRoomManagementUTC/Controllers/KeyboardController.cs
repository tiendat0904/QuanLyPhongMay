using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Keyboard;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class KeyboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public KeyboardController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.KEYBOARD_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Keyboard>>(apiUrl);
            return Json(result);
        }
        [HttpGet]
        public async Task<ActionResult> KeyboardPaging(BaseCondition<Keyboard> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.KEYBOARD_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Keyboard>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddKeyboardViewModel keyboard)
        {
            keyboard.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.KEYBOARD_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Keyboard>>(apiUrl, JsonConvert.SerializeObject(keyboard));
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <pakeyboard name="id"></pakeyboard>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.KEYBOARD_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Keyboard>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(KeyboardEditViewModel keyboard)
        {
            keyboard.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.KEYBOARD_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<KeyboardEditViewModel>>(apiUrl, JsonConvert.SerializeObject(keyboard));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(KeyboardDeleteViewModel keyboard)
        {
            keyboard.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.KEYBOARD_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Keyboard>>(apiUrl, JsonConvert.SerializeObject(keyboard));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(KeyboardEditStatusViewModel keyboard)
        {
            keyboard.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.KEYBOARD_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Keyboard>>(apiUrl, JsonConvert.SerializeObject(keyboard));
            return Json(result);
        }
    }
}