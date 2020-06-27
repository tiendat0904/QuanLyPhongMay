using Common.Common;
using Common.Entity.Models.StorageCapacity;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class StorageCapacityBusiness
    {
        private StorageCapacityDAL _storageCapacityDAL;
        public StorageCapacityDAL StorageCapacityDAL
        {
            get
            {
                _storageCapacityDAL = new StorageCapacityDAL();
                return _storageCapacityDAL;
            }
        }
        public ReturnResult<StorageCapacity> GetAllStorageCapacitySearched(BaseCondition<StorageCapacity> condition)
        {
            StorageCapacityDAL storageCapacityDAL = new StorageCapacityDAL();
            var result = storageCapacityDAL.GetAllStorageCapacitySearched(condition);
            return result;
        }

        public ReturnResult<StorageCapacity> GetAll()
        {
            return StorageCapacityDAL.GetAll();
        }

        public ReturnResult<StorageCapacity> AddStorageCapacity(AddStorageCapacityViewModel storageCapacity)
        {
            return StorageCapacityDAL.Add(storageCapacity);
        }

        public ReturnResult<StorageCapacity> GetById(int Id)
        {
            return StorageCapacityDAL.GetById(Id);
        }

        public ReturnResult<StorageCapacity> Delete(StorageCapacityDeleteViewModel storageCapacity)
        {
            return StorageCapacityDAL.Delete(storageCapacity);
        }

        public ReturnResult<StorageCapacity> Edit(StorageCapacityEditViewModel storageCapacity)
        {
            return StorageCapacityDAL.Edit(storageCapacity);
        }

        public ReturnResult<StorageCapacity> EditStatus(StorageCapacityEditStatusViewModel storageCapacity)
        {
            return StorageCapacityDAL.EditStatus(storageCapacity);
        }
    }
}
