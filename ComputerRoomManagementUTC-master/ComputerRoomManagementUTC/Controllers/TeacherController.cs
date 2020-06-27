using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Shift;
using Common.Entity.Models.Teacher;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public TeacherController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> TeacherPaging(BaseCondition<Teacher> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.TEACHER_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Teacher>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddTeacherModel Teacher)
        {
            Teacher.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.TEACHER_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Teacher>>(apiUrl, JsonConvert.SerializeObject(Teacher));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.TEACHER_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Teacher>>(apiUrl);
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <paTeacher name="id"></paTeacher>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.TEACHER_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Teacher>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(TeacherEditModel Teacher)
        {
            Teacher.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.TEACHER_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<TeacherEditModel>>(apiUrl, JsonConvert.SerializeObject(Teacher));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(TeacherDeleteModel Teacher)
        {
            Teacher.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.TEACHER_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Teacher>>(apiUrl, JsonConvert.SerializeObject(Teacher));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(TeacherEditStatusModel Teacher)
        {
            Teacher.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.TEACHER_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Teacher>>(apiUrl, JsonConvert.SerializeObject(Teacher));
            return Json(result);
        }
    }
}