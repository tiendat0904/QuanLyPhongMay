using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.CPU;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CPUController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<CPU> condition)
        {
            CPUBusiness ramBusiness = new CPUBusiness();
            var result = ramBusiness.GetAllCpuSearched(condition);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            CPUBusiness cpuBusiness = new CPUBusiness();
            var result = cpuBusiness.GetAll();
            return Ok(result);
        }
        public IActionResult Add(AddCpuViewModel ram)
        {
            CPUBusiness ramBusiness = new CPUBusiness();
            var result = ramBusiness.AddCpu(ram);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            CPUBusiness ramBusiness = new CPUBusiness();
            var result = ramBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(CpuDeleteViewModel ram)
        {
            CPUBusiness ramBusiness = new CPUBusiness();
            var result = ramBusiness.Delete(ram);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(CpuEditViewModel ram)
        {
            CPUBusiness ramBusiness = new CPUBusiness();
            var result = ramBusiness.Edit(ram);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(CpuEditStatusViewModel ram)
        {
            CPUBusiness ramBusiness = new CPUBusiness();
            var result = ramBusiness.EditStatus(ram);
            return Ok(result);
        }
    }
}