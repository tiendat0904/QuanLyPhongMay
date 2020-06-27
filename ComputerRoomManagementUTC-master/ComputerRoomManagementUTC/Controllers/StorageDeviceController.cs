using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.StorageDevice;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class StorageDeviceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public StorageDeviceController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_DEVICE_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<StorageDevice>>(apiUrl);
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> StorageDevicePaging(BaseCondition<StorageDevice> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_DEVICE_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageDevice>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddStorageDeviceViewModel mouse)
        {
            mouse.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_DEVICE_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageDevice>>(apiUrl, JsonConvert.SerializeObject(mouse));
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
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.STORAGE_DEVICE_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<StorageDevice>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(StorageDeviceEditViewModel mouse)
        {
            mouse.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_DEVICE_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageDeviceEditViewModel>>(apiUrl, JsonConvert.SerializeObject(mouse));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(StorageDeviceDeleteViewModel mouse)
        {
            mouse.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_DEVICE_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageDevice>>(apiUrl, JsonConvert.SerializeObject(mouse));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(StorageDeviceEditStatusViewModel mouse)
        {
            mouse.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_DEVICE_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageDevice>>(apiUrl, JsonConvert.SerializeObject(mouse));
            return Json(result);
        }
    }
}