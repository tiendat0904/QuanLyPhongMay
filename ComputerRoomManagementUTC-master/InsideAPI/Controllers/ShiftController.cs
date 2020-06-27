using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Shift;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Shift> condition)
        {
            ShiftBusiness shiftBusiness = new ShiftBusiness();
            var result = shiftBusiness.GetAllShiftSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddShiftModel shift)
        {
            ShiftBusiness shiftBusiness = new ShiftBusiness();
            var result = shiftBusiness.AddShift(shift);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            ShiftBusiness shiftBusiness = new ShiftBusiness();
            var result = shiftBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            ShiftBusiness shiftBusiness = new ShiftBusiness();
            var result = shiftBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(ShiftDeleteModel shift)
        {
            ShiftBusiness shiftBusiness = new ShiftBusiness();
            var result = shiftBusiness.Delete(shift);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(ShiftEditModel shift)
        {
            ShiftBusiness shiftBusiness = new ShiftBusiness();
            var result = shiftBusiness.Edit(shift);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(ShiftEditStatusModel shift)
        {
            ShiftBusiness shiftBusiness = new ShiftBusiness();
            var result = shiftBusiness.EditStatus(shift);
            return Ok(result);
        }
    }
}