using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.StorageCapacity;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StorageCapacityController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<StorageCapacity> condition)
        {
            StorageCapacityBusiness storageCapacityBusiness = new StorageCapacityBusiness();
            var result = storageCapacityBusiness.GetAllStorageCapacitySearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddStorageCapacityViewModel storageCapacity)
        {
            StorageCapacityBusiness storageCapacityBusiness = new StorageCapacityBusiness();
            var result = storageCapacityBusiness.AddStorageCapacity(storageCapacity);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            StorageCapacityBusiness storageCapacityBusiness = new StorageCapacityBusiness();
            var result = storageCapacityBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            StorageCapacityBusiness storageCapacityBusiness = new StorageCapacityBusiness();
            var result = storageCapacityBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(StorageCapacityDeleteViewModel storageCapacity)
        {
            StorageCapacityBusiness storageCapacityBusiness = new StorageCapacityBusiness();
            var result = storageCapacityBusiness.Delete(storageCapacity);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(StorageCapacityEditViewModel storageCapacity)
        {
            StorageCapacityBusiness storageCapacityBusiness = new StorageCapacityBusiness();
            var result = storageCapacityBusiness.Edit(storageCapacity);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(StorageCapacityEditStatusViewModel storageCapacity)
        {
            StorageCapacityBusiness storageCapacityBusiness = new StorageCapacityBusiness();
            var result = storageCapacityBusiness.EditStatus(storageCapacity);
            return Ok(result);
        }
    }
}