using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.OpticalDisc;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class OpticalDiscController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public OpticalDiscController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.OPTICAL_DISC_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<OpticalDisc>>(apiUrl);
            return Json(result);
        }
        [HttpGet]
        public async Task<ActionResult> OpticalDiscPaging(BaseCondition<OpticalDisc> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.OPTICAL_DISC_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<OpticalDisc>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddOpticalDiscViewModel opticalDisc)
        {
            opticalDisc.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.OPTICAL_DISC_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<OpticalDisc>>(apiUrl, JsonConvert.SerializeObject(opticalDisc));
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <paopticalDisc name="id"></paopticalDisc>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.OPTICAL_DISC_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<OpticalDisc>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(OpticalDiscEditViewModel opticalDisc)
        {
            opticalDisc.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.OPTICAL_DISC_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<OpticalDiscEditViewModel>>(apiUrl, JsonConvert.SerializeObject(opticalDisc));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(OpticalDiscDeleteViewModel opticalDisc)
        {
            opticalDisc.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.OPTICAL_DISC_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<OpticalDisc>>(apiUrl, JsonConvert.SerializeObject(opticalDisc));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(OpticalDiscEditStatusViewModel opticalDisc)
        {
            opticalDisc.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.OPTICAL_DISC_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<OpticalDisc>>(apiUrl, JsonConvert.SerializeObject(opticalDisc));
            return Json(result);
        }
    }
}