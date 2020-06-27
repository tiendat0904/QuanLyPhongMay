using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.StorageCapacity;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class StorageCapacityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public StorageCapacityController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_CAPACITY_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<StorageCapacity>>(apiUrl);
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> StorageCapacityPaging(BaseCondition<StorageCapacity> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_CAPACITY_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageCapacity>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddStorageCapacityViewModel storageCapacity)
        {
            storageCapacity.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_CAPACITY_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageCapacity>>(apiUrl, JsonConvert.SerializeObject(storageCapacity));
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <pastorageCapacity name="id"></pastorageCapacity>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.STORAGE_CAPACITY_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<StorageCapacity>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(StorageCapacityEditViewModel storageCapacity)
        {
            storageCapacity.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_CAPACITY_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageCapacityEditViewModel>>(apiUrl, JsonConvert.SerializeObject(storageCapacity));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(StorageCapacityDeleteViewModel storageCapacity)
        {
            storageCapacity.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_CAPACITY_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageCapacity>>(apiUrl, JsonConvert.SerializeObject(storageCapacity));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(StorageCapacityEditStatusViewModel storageCapacity)
        {
            storageCapacity.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STORAGE_CAPACITY_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StorageCapacity>>(apiUrl, JsonConvert.SerializeObject(storageCapacity));
            return Json(result);
        }
    }
}