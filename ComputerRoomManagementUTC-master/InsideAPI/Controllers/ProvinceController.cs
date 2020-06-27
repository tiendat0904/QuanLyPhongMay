using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Province;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Province> condition)
        {
            ProvinceBusiness provinceBusiness = new ProvinceBusiness();
            var result = provinceBusiness.GetAllProvinceSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddProvinceViewModel province)
        {
            ProvinceBusiness provinceBusiness = new ProvinceBusiness();
            var result = provinceBusiness.AddProvince(province);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            ProvinceBusiness provinceBusiness = new ProvinceBusiness();
            var result = provinceBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            ProvinceBusiness provinceBusiness = new ProvinceBusiness();
            var result = provinceBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(ProvinceDeleteViewModel province)
        {
            ProvinceBusiness provinceBusiness = new ProvinceBusiness();
            var result = provinceBusiness.Delete(province);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(ProvinceEditViewModel province)
        {
            ProvinceBusiness provinceBusiness = new ProvinceBusiness();
            var result = provinceBusiness.Edit(province);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(ProvinceEditStatusViewModel province)
        {
            ProvinceBusiness provinceBusiness = new ProvinceBusiness();
            var result = provinceBusiness.EditStatus(province);
            return Ok(result);
        }
    }
}