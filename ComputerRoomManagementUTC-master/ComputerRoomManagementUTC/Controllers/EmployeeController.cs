using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Employee;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public EmployeeController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> EmployeePaging(BaseCondition<Employee> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.EMPLOYEE_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Employee>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddEmployeeModel Employee)
        {
            Employee.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.EMPLOYEE_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Employee>>(apiUrl, JsonConvert.SerializeObject(Employee));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.EMPLOYEE_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Employee>>(apiUrl);
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <paEmployee name="id"></paEmployee>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.EMPLOYEE_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Employee>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(EmployeeEditModel Employee)
        {
            Employee.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.EMPLOYEE_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<EmployeeEditModel>>(apiUrl, JsonConvert.SerializeObject(Employee));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(EmployeeDeleteModel Employee)
        {
            Employee.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.EMPLOYEE_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Employee>>(apiUrl, JsonConvert.SerializeObject(Employee));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(EmployeeEditStatusModel Employee)
        {
            Employee.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.EMPLOYEE_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Employee>>(apiUrl, JsonConvert.SerializeObject(Employee));
            return Json(result);
        }
    }
}