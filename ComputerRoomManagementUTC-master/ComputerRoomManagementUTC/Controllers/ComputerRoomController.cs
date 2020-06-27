using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.ComputerRoom;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class ComputerRoomController : Controller
    {
        
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public ComputerRoomController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> ComputerRoomPaging(BaseCondition<ComputerRoom> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_ROOM_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<ComputerRoom>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddComputerRoomViewModel computerRoom)
        {
            computerRoom.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_ROOM_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<ComputerRoom>>(apiUrl, JsonConvert.SerializeObject(computerRoom));
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <pacomputerRoom name="id"></pacomputerRoom>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Detail(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.COMPUTER_GET_PAGING_BY_ROOM_ID));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<ComputerRoom>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ComputerRoomEditViewModel computerRoom)
        {
            computerRoom.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_ROOM_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<ComputerRoomEditViewModel>>(apiUrl, JsonConvert.SerializeObject(computerRoom));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_ROOM_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<ComputerRoom>>(apiUrl);
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(ComputerRoomDeleteViewModel computerRoom)
        {
            computerRoom.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_ROOM_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<ComputerRoom>>(apiUrl, JsonConvert.SerializeObject(computerRoom));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(ComputerRoomEditStatusViewModel computerRoom)
        {
            computerRoom.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.COMPUTER_ROOM_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<ComputerRoom>>(apiUrl, JsonConvert.SerializeObject(computerRoom));
            return Json(result);
        }
    }
}