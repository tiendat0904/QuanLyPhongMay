using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.OpticalDisc;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OpticalDiscController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<OpticalDisc> condition)
        {
            OpticalDiscBusiness opticalDiscBusiness = new OpticalDiscBusiness();
            var result = opticalDiscBusiness.GetAllOpticalDiscSearched(condition);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            OpticalDiscBusiness opticalDiscBusiness = new OpticalDiscBusiness();
            var result = opticalDiscBusiness.GetAll();
            return Ok(result);
        }

        public IActionResult Add(AddOpticalDiscViewModel opticalDisc)
        {
            OpticalDiscBusiness opticalDiscBusiness = new OpticalDiscBusiness();
            var result = opticalDiscBusiness.AddOpticalDisc(opticalDisc);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            OpticalDiscBusiness opticalDiscBusiness = new OpticalDiscBusiness();
            var result = opticalDiscBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(OpticalDiscDeleteViewModel opticalDisc)
        {
            OpticalDiscBusiness opticalDiscBusiness = new OpticalDiscBusiness();
            var result = opticalDiscBusiness.Delete(opticalDisc);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(OpticalDiscEditViewModel opticalDisc)
        {
            OpticalDiscBusiness opticalDiscBusiness = new OpticalDiscBusiness();
            var result = opticalDiscBusiness.Edit(opticalDisc);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(OpticalDiscEditStatusViewModel opticalDisc)
        {
            OpticalDiscBusiness opticalDiscBusiness = new OpticalDiscBusiness();
            var result = opticalDiscBusiness.EditStatus(opticalDisc);
            return Ok(result);
        }
    }
}