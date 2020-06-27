using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.StudySchedule;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class StudyScheduleController : Controller
    {
        public static byte[] file { get; set; }
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public StudyScheduleController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> StudySchedulePaging(BaseCondition<StudySchedule> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STUDY_SCHEDULE_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StudySchedule>>(apiUrl, JsonConvert.SerializeObject(condition));
            ViewBag.PAGE_INDEX = condition.PAGE_INDEX;
            ViewBag.PAGE_SIZE = condition.PAGE_SIZE;
            ViewBag.StudyScheduleList = JsonConvert.SerializeObject(result.ItemList);
            ViewBag.ExistingStudySchedule = JsonConvert.SerializeObject(result.ItemList.Where(x => (x.EndDate >= DateTime.Now) && (x.Status == 1)));
            return View(result);
        }

        [HttpPost]
        public async Task<ActionResult> Search(BaseCondition<StudySchedule> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STUDY_SCHEDULE_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StudySchedule>>(apiUrl, JsonConvert.SerializeObject(condition));
            ViewBag.PAGE_INDEX = condition.PAGE_INDEX;
            ViewBag.PAGE_SIZE = condition.PAGE_SIZE;
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
        public async Task<ActionResult> Add(AddStudyScheduleModel StudySchedule)
        {
            StudySchedule.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STUDY_SCHEDULE_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StudySchedule>>(apiUrl, JsonConvert.SerializeObject(StudySchedule));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STUDY_SCHEDULE_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<StudySchedule>>(apiUrl);
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <paStudySchedule name="id"></paStudySchedule>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.STUDY_SCHEDULE_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<StudySchedule>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(StudyScheduleEditModel StudySchedule)
        {
            StudySchedule.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STUDY_SCHEDULE_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StudyScheduleEditModel>>(apiUrl, JsonConvert.SerializeObject(StudySchedule));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(StudyScheduleDeleteModel StudySchedule)
        {
            StudySchedule.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STUDY_SCHEDULE_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StudySchedule>>(apiUrl, JsonConvert.SerializeObject(StudySchedule));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(StudyScheduleEditStatusModel StudySchedule)
        {
            StudySchedule.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.STUDY_SCHEDULE_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<StudySchedule>>(apiUrl, JsonConvert.SerializeObject(StudySchedule));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> CreateFilteredItem(List<StudySchedule> filterItems)
        {
            StudyScheduleController.file = ExcelUtilities.CreateExcelFile<StudySchedule>("StudySchedule.xls", filterItems);
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult> ExportFilteredItem(List<StudySchedule> filterItems)
        {
            return File(StudyScheduleController.file, "application/ms-excel", "StudySchedule.xlsx");
        }
    }
}