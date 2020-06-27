using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.StudySchedule;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudyScheduleController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<StudySchedule> condition)
        {
            StudyScheduleBusiness shiftBusiness = new StudyScheduleBusiness();
            var result = shiftBusiness.GetAllStudyScheduleSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddStudyScheduleModel shift)
        {
            StudyScheduleBusiness shiftBusiness = new StudyScheduleBusiness();
            var result = shiftBusiness.AddStudySchedule(shift);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            StudyScheduleBusiness shiftBusiness = new StudyScheduleBusiness();
            var result = shiftBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            StudyScheduleBusiness shiftBusiness = new StudyScheduleBusiness();
            var result = shiftBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(StudyScheduleDeleteModel shift)
        {
            StudyScheduleBusiness shiftBusiness = new StudyScheduleBusiness();
            var result = shiftBusiness.Delete(shift);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(StudyScheduleEditModel shift)
        {
            StudyScheduleBusiness shiftBusiness = new StudyScheduleBusiness();
            var result = shiftBusiness.Edit(shift);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(StudyScheduleEditStatusModel shift)
        {
            StudyScheduleBusiness shiftBusiness = new StudyScheduleBusiness();
            var result = shiftBusiness.EditStatus(shift);
            return Ok(result);
        }
    }
}