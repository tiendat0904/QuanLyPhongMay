using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Monitor;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MonitorController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<Monitor> condition)
        {
            MonitorBusiness monitorBusiness = new MonitorBusiness();
            var result = monitorBusiness.GetAllMonitorSearched(condition);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            MonitorBusiness monitorBusiness = new MonitorBusiness();
            var result = monitorBusiness.GetAll();
            return Ok(result);
        }
        public IActionResult Add(AddMonitorViewModel monitor)
        {
            MonitorBusiness monitorBusiness = new MonitorBusiness();
            var result = monitorBusiness.AddMonitor(monitor);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            MonitorBusiness monitorBusiness = new MonitorBusiness();
            var result = monitorBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(MonitorDeleteViewModel monitor)
        {
            MonitorBusiness monitorBusiness = new MonitorBusiness();
            var result = monitorBusiness.Delete(monitor);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(MonitorEditViewModel monitor)
        {
            MonitorBusiness monitorBusiness = new MonitorBusiness();
            var result = monitorBusiness.Edit(monitor);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(MonitorEditStatusViewModel monitor)
        {
            MonitorBusiness monitorBusiness = new MonitorBusiness();
            var result = monitorBusiness.EditStatus(monitor);
            return Ok(result);
        }
    }
}