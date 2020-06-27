using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Computer;

using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace ComputerRoomManagementUTC.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        private static int ComputerRoomId;
        public ComputerController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetPagingByComputerId(BaseCondition<Computer> condition, int computerRoomId)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.COMPUTER_GET_PAGING_BY_ROOM_ID, computerRoomId));
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Computer>>(apiUrl, JsonConvert.SerializeObject(condition));
            ViewBag.PAGE_INDEX = condition.PAGE_INDEX;
            ViewBag.PAGE_SIZE = condition.PAGE_SIZE;
            ComputerRoomId = computerRoomId;
            ViewBag.ComputerRoomId = computerRoomId;
            return View("ComputerPagingByComputerRoom", result);
        }

        [HttpPost]
        public async Task<IActionResult> Test(BaseCondition<Computer> condition, int computerRoomId)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.COMPUTER_GET_PAGING_BY_ROOM_ID, computerRoomId));
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Computer>>(apiUrl, JsonConvert.SerializeObject(condition));
            ViewBag.PAGE_INDEX = condition.PAGE_INDEX;
            ViewBag.PAGE_SIZE = condition.PAGE_SIZE;
            ComputerRoomId = computerRoomId;
            ViewBag.ComputerRoomId = computerRoomId;
            return Json(result);
        }
        /// <summary>
        /// Display add form view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Add()
        {
            ViewBag.ComputerRoomId = ComputerRoomId;
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Computer>>(apiUrl);
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Add(AddComputerViewModel computer)
        {
            computer.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Computer>>(apiUrl, JsonConvert.SerializeObject(computer));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int computerId)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.COMPUTER_GET_BY_ID, computerId));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Computer>>(apiUrl);
            ViewBag.ComputerRoomId = ComputerRoomId;
            return View(result.Item);
        }


        [HttpPost]
        public async Task<ActionResult> Edit(ComputerEditModel computer)
        {
            
            computer.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Computer>>(apiUrl, JsonConvert.SerializeObject(computer));
            return Json(result);
        }

        public async Task<ActionResult> ExportExcel(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.COMPUTER_GET_ALL, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<ComputerExportModel>>(apiUrl);
            var file = ExcelUtilities.CreateExcelFile<ComputerExportModel>("computer.xls", result.ItemList);
            return File(file, "application/ms-excel", "ComputerList.xlsx");
        }
    }
}