using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.StorageDevice;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StorageDeviceController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<StorageDevice> condition)
        {
            StorageDeviceBusiness storageDeviceBusiness = new StorageDeviceBusiness();
            var result = storageDeviceBusiness.GetAllStorageDeviceSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(AddStorageDeviceViewModel storageDevice)
        {
            StorageDeviceBusiness storageDeviceBusiness = new StorageDeviceBusiness();
            var result = storageDeviceBusiness.AddStorageDevice(storageDevice);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            StorageDeviceBusiness storageDeviceBusiness = new StorageDeviceBusiness();
            var result = storageDeviceBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(int Id)
        {
            StorageDeviceBusiness storageDeviceBusiness = new StorageDeviceBusiness();
            var result = storageDeviceBusiness.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Delete(StorageDeviceDeleteViewModel storageDevice)
        {
            StorageDeviceBusiness storageDeviceBusiness = new StorageDeviceBusiness();
            var result = storageDeviceBusiness.Delete(storageDevice);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Edit(StorageDeviceEditViewModel storageDevice)
        {
            StorageDeviceBusiness storageDeviceBusiness = new StorageDeviceBusiness();
            var result = storageDeviceBusiness.Edit(storageDevice);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult EditStatus(StorageDeviceEditStatusViewModel storageDevice)
        {
            StorageDeviceBusiness storageDeviceBusiness = new StorageDeviceBusiness();
            var result = storageDeviceBusiness.EditStatus(storageDevice);
            return Ok(result);
        }
    }
}