using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.ComputerRoom;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ComputerRoomController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<ComputerRoom> condition)
        {
            ComputerRoomBusiness computerRoomBusiness = new ComputerRoomBusiness();
            var result = computerRoomBusiness.GetAllComputerRoomSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddComputerRoomViewModel computerRoom)
        {
            ComputerRoomBusiness computerRoomBusiness = new ComputerRoomBusiness();
            var result = computerRoomBusiness.AddComputerRoom(computerRoom);
            return Ok(result);
        }

        public IActionResult GetAll()
        {
            ComputerRoomBusiness computerRoomBusiness = new ComputerRoomBusiness();
            var result = computerRoomBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            ComputerRoomBusiness computerRoomBusiness = new ComputerRoomBusiness();
            var result = computerRoomBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(ComputerRoomDeleteViewModel computerRoom)
        {
            ComputerRoomBusiness computerRoomBusiness = new ComputerRoomBusiness();
            var result = computerRoomBusiness.Delete(computerRoom);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(ComputerRoomEditViewModel computerRoom)
        {
            ComputerRoomBusiness computerRoomBusiness = new ComputerRoomBusiness();
            var result = computerRoomBusiness.Edit(computerRoom);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(ComputerRoomEditStatusViewModel computerRoom)
        {
            ComputerRoomBusiness computerRoomBusiness = new ComputerRoomBusiness();
            var result = computerRoomBusiness.EditStatus(computerRoom);
            return Ok(result);
        }
    }
}