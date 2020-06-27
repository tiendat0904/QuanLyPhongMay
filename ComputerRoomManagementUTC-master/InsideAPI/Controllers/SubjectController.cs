using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Subject;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Subject> condition)
        {
            SubjectBusiness subjectBusiness = new SubjectBusiness();
            var result = subjectBusiness.GetAllSubjectSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddSubjectModel subject)
        {
            SubjectBusiness subjectBusiness = new SubjectBusiness();
            var result = subjectBusiness.AddSubject(subject);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            SubjectBusiness subjectBusiness = new SubjectBusiness();
            var result = subjectBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            SubjectBusiness subjectBusiness = new SubjectBusiness();
            var result = subjectBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(SubjectDeleteModel subject)
        {
            SubjectBusiness subjectBusiness = new SubjectBusiness();
            var result = subjectBusiness.Delete(subject);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(SubjectEditModel subject)
        {
            SubjectBusiness subjectBusiness = new SubjectBusiness();
            var result = subjectBusiness.Edit(subject);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(SubjectEditStatusModel subject)
        {
            SubjectBusiness subjectBusiness = new SubjectBusiness();
            var result = subjectBusiness.EditStatus(subject);
            return Ok(result);
        }
    }
}