using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Class;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Class> condition)
        {
            ClassBusiness classModelBusiness = new ClassBusiness();
            var result = classModelBusiness.GetAllClassSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddClassViewModel classModel)
        {
            ClassBusiness classModelBusiness = new ClassBusiness();
            var result = classModelBusiness.AddClass(classModel);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            ClassBusiness classModelBusiness = new ClassBusiness();
            var result = classModelBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            ClassBusiness classModelBusiness = new ClassBusiness();
            var result = classModelBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(ClassDeleteViewModel classModel)
        {
            ClassBusiness classModelBusiness = new ClassBusiness();
            var result = classModelBusiness.Delete(classModel);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(ClassEditViewModel classModel)
        {
            ClassBusiness classModelBusiness = new ClassBusiness();
            var result = classModelBusiness.Edit(classModel);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(ClassEditStatusViewModel classModel)
        {
            ClassBusiness classModelBusiness = new ClassBusiness();
            var result = classModelBusiness.EditStatus(classModel);
            return Ok(result);
        }
    }
}