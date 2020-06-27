using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Computer;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        [Route("{computerRoomId}")]
        public IActionResult GetPagingByComputerId(BaseCondition<Computer> condition, int computerRoomId)
        {
            ComputerBusiness computerBusiness = new ComputerBusiness();
            var result = computerBusiness.GetAllComputerSearched(condition, computerRoomId);
            return Ok(result);
        }

        public IActionResult Add(AddComputerViewModel computer)
        {
            ComputerBusiness computerBusiness = new ComputerBusiness();
            var result = computerBusiness.Add(computer);
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetAll(int id)
        {
            ComputerBusiness computerBusiness = new ComputerBusiness();
            var result = computerBusiness.GetAll(id);
            return Ok(result);
        }

        [Route("{computerId}")]
        public IActionResult GetById(int computerId)
        {
            ComputerBusiness computerBusiness = new ComputerBusiness();
            var result = computerBusiness.GetById(computerId);
            return Ok(result);
        }

        public IActionResult Edit(ComputerEditModel computer)
        {
            ComputerBusiness computerBusiness = new ComputerBusiness();
            var result = computerBusiness.Edit(computer);
            return Ok(result);
        }
    }
}