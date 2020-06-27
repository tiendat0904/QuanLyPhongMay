
using Common.Common;
using Common.Entity.Models.MonitorSize;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MonitorSizeController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<MonitorSize> condition)
        {
            MonitorSizeBusiness monitorSizeBusiness = new MonitorSizeBusiness();
            var result = monitorSizeBusiness.GetAllMonitorSizeSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddMonitorSizeViewModel monitorSize)
        {
            MonitorSizeBusiness monitorSizeBusiness = new MonitorSizeBusiness();
            var result = monitorSizeBusiness.AddMonitorSize(monitorSize);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            MonitorSizeBusiness monitorSizeBusiness = new MonitorSizeBusiness();
            var result = monitorSizeBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            MonitorSizeBusiness monitorSizeBusiness = new MonitorSizeBusiness();
            var result = monitorSizeBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(MonitorSizeDeleteViewModel monitorSize)
        {
            MonitorSizeBusiness monitorSizeBusiness = new MonitorSizeBusiness();
            var result = monitorSizeBusiness.Delete(monitorSize);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(MonitorSizeEditViewModel monitorSize)
        {
            MonitorSizeBusiness monitorSizeBusiness = new MonitorSizeBusiness();
            var result = monitorSizeBusiness.Edit(monitorSize);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(MonitorSizeEditStatusViewModel monitorSize)
        {
            MonitorSizeBusiness monitorSizeBusiness = new MonitorSizeBusiness();
            var result = monitorSizeBusiness.EditStatus(monitorSize);
            return Ok(result);
        }
    }
}