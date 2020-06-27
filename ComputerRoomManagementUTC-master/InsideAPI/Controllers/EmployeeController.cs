using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Employee;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Employee> condition)
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            var result = employeeBusiness.GetAllEmployeeSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddEmployeeModel employee)
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            var result = employeeBusiness.AddEmployee(employee);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            var result = employeeBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            var result = employeeBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(EmployeeDeleteModel employee)
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            var result = employeeBusiness.Delete(employee);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditModel employee)
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            var result = employeeBusiness.Edit(employee);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(EmployeeEditStatusModel employee)
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            var result = employeeBusiness.EditStatus(employee);
            return Ok(result);
        }
    }
}