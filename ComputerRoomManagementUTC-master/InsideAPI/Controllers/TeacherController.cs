using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Teacher;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Teacher> condition)
        {
            TeacherBusiness shiftBusiness = new TeacherBusiness();
            var result = shiftBusiness.GetAllTeacherSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddTeacherModel shift)
        {
            TeacherBusiness shiftBusiness = new TeacherBusiness();
            var result = shiftBusiness.AddTeacher(shift);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            TeacherBusiness shiftBusiness = new TeacherBusiness();
            var result = shiftBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            TeacherBusiness shiftBusiness = new TeacherBusiness();
            var result = shiftBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(TeacherDeleteModel shift)
        {
            TeacherBusiness shiftBusiness = new TeacherBusiness();
            var result = shiftBusiness.Delete(shift);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(TeacherEditModel shift)
        {
            TeacherBusiness shiftBusiness = new TeacherBusiness();
            var result = shiftBusiness.Edit(shift);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(TeacherEditStatusModel shift)
        {
            TeacherBusiness shiftBusiness = new TeacherBusiness();
            var result = shiftBusiness.EditStatus(shift);
            return Ok(result);
        }
    }
}