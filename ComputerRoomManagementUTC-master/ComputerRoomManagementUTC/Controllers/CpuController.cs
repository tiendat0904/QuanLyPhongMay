using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.CPU;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class CpuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public CpuController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> CpuPaging(BaseCondition<CPU> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.CPU_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<CPU>>(apiUrl, JsonConvert.SerializeObject(condition));
            ViewBag.PAGE_INDEX = condition.PAGE_INDEX;
            ViewBag.PAGE_SIZE = condition.PAGE_SIZE;
            return View(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.CPU_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<CPU>>(apiUrl);
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
        public async Task<ActionResult> Add(AddCpuViewModel cpu)
        {
            cpu.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.CPU_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<CPU>>(apiUrl, JsonConvert.SerializeObject(cpu));
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <pacpu name="id"></pacpu>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.CPU_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<CPU>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(CpuEditViewModel cpu)
        {
            cpu.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.CPU_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<CpuEditViewModel>>(apiUrl, JsonConvert.SerializeObject(cpu));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(CpuDeleteViewModel cpu)
        {
            cpu.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.CPU_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<CPU>>(apiUrl, JsonConvert.SerializeObject(cpu));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(CpuEditStatusViewModel cpu)
        {
            cpu.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.CPU_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<CPU>>(apiUrl, JsonConvert.SerializeObject(cpu));
            return Json(result);
        }
    }
}