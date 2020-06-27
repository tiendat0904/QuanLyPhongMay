using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Shift;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class ShiftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public ShiftController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> ShiftPaging(BaseCondition<Shift> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SHIFT_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Shift>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddShiftModel Shift)
        {
            Shift.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SHIFT_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Shift>>(apiUrl, JsonConvert.SerializeObject(Shift));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SHIFT_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Shift>>(apiUrl);
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <paShift name="id"></paShift>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.SHIFT_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Shift>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ShiftEditModel Shift)
        {
            Shift.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SHIFT_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<ShiftEditModel>>(apiUrl, JsonConvert.SerializeObject(Shift));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(ShiftDeleteModel Shift)
        {
            Shift.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SHIFT_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Shift>>(apiUrl, JsonConvert.SerializeObject(Shift));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(ShiftEditStatusModel Shift)
        {
            Shift.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SHIFT_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Shift>>(apiUrl, JsonConvert.SerializeObject(Shift));
            return Json(result);
        }
    }
}