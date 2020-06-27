using Common.Common;
using Common.Entity.Models.StorageDevice;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class StorageDeviceBusiness
    {
        private StorageDeviceDAL _storageDeviceDAL;
        public StorageDeviceDAL StorageDeviceDAL
        {
            get
            {
                _storageDeviceDAL = new StorageDeviceDAL();
                return _storageDeviceDAL;
            }
        }
        public ReturnResult<StorageDevice> GetAllStorageDeviceSearched(BaseCondition<StorageDevice> condition)
        {
            StorageDeviceDAL storageDeviceDAL = new StorageDeviceDAL();
            var result = storageDeviceDAL.GetAllStorageDeviceSearched(condition);
            return result;
        }

        public ReturnResult<StorageDevice> GetAll()
        {
            return StorageDeviceDAL.GetAll();
        }

        public ReturnResult<StorageDevice> AddStorageDevice(AddStorageDeviceViewModel storageDevice)
        {
            return StorageDeviceDAL.Add(storageDevice);
        }

        public ReturnResult<StorageDevice> GetById(int Id)
        {
            return StorageDeviceDAL.GetById(Id);
        }

        public ReturnResult<StorageDevice> Delete(StorageDeviceDeleteViewModel storageDevice)
        {
            return StorageDeviceDAL.Delete(storageDevice);
        }

        public ReturnResult<StorageDevice> Edit(StorageDeviceEditViewModel storageDevice)
        {
            return StorageDeviceDAL.Edit(storageDevice);
        }

        public ReturnResult<StorageDevice> EditStatus(StorageDeviceEditStatusViewModel storageDevice)
        {
            return StorageDeviceDAL.EditStatus(storageDevice);
        }
    }
}
