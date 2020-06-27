using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Speed;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SpeedController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Speed> condition)
        {
            SpeedBusiness speedBusiness = new SpeedBusiness();
            var result = speedBusiness.GetAllSpeedSearched(condition);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            SpeedBusiness speedBusiness = new SpeedBusiness();
            var result = speedBusiness.GetAll();
            return Ok(result);
        }

        public IActionResult Add(AddSpeedViewModel speed)
        {
            SpeedBusiness speedBusiness = new SpeedBusiness();
            var result = speedBusiness.AddSpeed(speed);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            SpeedBusiness speedBusiness = new SpeedBusiness();
            var result = speedBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(SpeedDeleteViewModel speed)
        {
            SpeedBusiness speedBusiness = new SpeedBusiness();
            var result = speedBusiness.Delete(speed);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(SpeedEditViewModel speed)
        {
            SpeedBusiness speedBusiness = new SpeedBusiness();
            var result = speedBusiness.Edit(speed);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(SpeedEditStatusViewModel speed)
        {
            SpeedBusiness speedBusiness = new SpeedBusiness();
            var result = speedBusiness.EditStatus(speed);
            return Ok(result);
        }
    }
}
