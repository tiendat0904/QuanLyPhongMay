using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Province;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class ProvinceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public ProvinceController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> ProvincePaging(BaseCondition<Province> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.PROVINCE_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Province>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddProvinceViewModel Province)
        {
            Province.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.PROVINCE_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Province>>(apiUrl, JsonConvert.SerializeObject(Province));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.PROVINCE_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Province>>(apiUrl);
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <paProvince name="id"></paProvince>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.PROVINCE_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Province>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ProvinceEditViewModel Province)
        {
            Province.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.PROVINCE_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<ProvinceEditViewModel>>(apiUrl, JsonConvert.SerializeObject(Province));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(ProvinceDeleteViewModel Province)
        {
            Province.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.PROVINCE_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Province>>(apiUrl, JsonConvert.SerializeObject(Province));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(ProvinceEditStatusViewModel Province)
        {
            Province.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.PROVINCE_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Province>>(apiUrl, JsonConvert.SerializeObject(Province));
            return Json(result);
        }
    }
}