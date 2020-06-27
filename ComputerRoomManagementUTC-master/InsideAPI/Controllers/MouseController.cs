using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Mouse;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MouseController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Mouse> condition)
        {
            MouseBusiness mouseBusiness = new MouseBusiness();
            var result = mouseBusiness.GetAllMouseSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddMouseViewModel mouse)
        {
            MouseBusiness mouseBusiness = new MouseBusiness();
            var result = mouseBusiness.AddMouse(mouse);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            MouseBusiness mouseBusiness = new MouseBusiness();
            var result = mouseBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            MouseBusiness mouseBusiness = new MouseBusiness();
            var result = mouseBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(MouseDeleteViewModel mouse)
        {
            MouseBusiness mouseBusiness = new MouseBusiness();
            var result = mouseBusiness.Delete(mouse);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(MouseEditViewModel mouse)
        {
            MouseBusiness mouseBusiness = new MouseBusiness();
            var result = mouseBusiness.Edit(mouse);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(MouseEditStatusViewModel mouse)
        {
            MouseBusiness mouseBusiness = new MouseBusiness();
            var result = mouseBusiness.EditStatus(mouse);
            return Ok(result);
        }
    }
}