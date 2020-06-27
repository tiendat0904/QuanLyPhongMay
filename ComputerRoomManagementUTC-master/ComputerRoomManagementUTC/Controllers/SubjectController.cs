using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Subject;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public SubjectController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> SubjectPaging(BaseCondition<Subject> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SUBJECT_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Subject>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddSubjectModel Subject)
        {
            Subject.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SUBJECT_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Subject>>(apiUrl, JsonConvert.SerializeObject(Subject));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SUBJECT_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Subject>>(apiUrl);
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <paSubject name="id"></paSubject>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.SUBJECT_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Subject>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(SubjectEditModel Subject)
        {
            Subject.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SUBJECT_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<SubjectEditModel>>(apiUrl, JsonConvert.SerializeObject(Subject));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(SubjectDeleteModel Subject)
        {
            Subject.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SUBJECT_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Subject>>(apiUrl, JsonConvert.SerializeObject(Subject));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(SubjectEditStatusModel Subject)
        {
            Subject.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.SUBJECT_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Subject>>(apiUrl, JsonConvert.SerializeObject(Subject));
            return Json(result);
        }
    }
}