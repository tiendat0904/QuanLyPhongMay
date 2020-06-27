using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.RAM;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RAMController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<RAM> condition)
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.GetAllRamSearched(condition);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.GetAll();
            return Ok(result);
        }

        public IActionResult Add(AddRamViewModel ram)
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.AddRam(ram);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(RamDeleteViewModel ram)
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.Delete(ram);
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Edit(RamEditViewModel ram)
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.Edit(ram);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(RamEditStatusViewModel ram)
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.EditStatus(ram);
            return Ok(result);
        }
    }
}