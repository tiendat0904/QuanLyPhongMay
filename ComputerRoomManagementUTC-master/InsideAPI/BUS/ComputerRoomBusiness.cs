using Common.Common;
using Common.Entity.Models.ComputerRoom;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class ComputerRoomBusiness
    {
        private ComputerRoomDAL _computerRoomDAL;
        public ComputerRoomDAL ComputerRoomDAL
        {
            get
            {
                _computerRoomDAL = new ComputerRoomDAL();
                return _computerRoomDAL;
            }
        }
        public ReturnResult<ComputerRoom> GetAllComputerRoomSearched(BaseCondition<ComputerRoom> condition)
        {
            ComputerRoomDAL computerRoomDAL = new ComputerRoomDAL();
            var result = computerRoomDAL.GetAllComputerRoomSearched(condition);
            return result;
        }

        public ReturnResult<ComputerRoom> GetAll()
        {
            return ComputerRoomDAL.GetAll();
        }

        public ReturnResult<ComputerRoom> AddComputerRoom(AddComputerRoomViewModel computerRoom)
        {
            return ComputerRoomDAL.Add(computerRoom);
        }

        public ReturnResult<ComputerRoom> GetById(int Id)
        {
            return ComputerRoomDAL.GetById(Id);
        }

        public ReturnResult<ComputerRoom> Delete(ComputerRoomDeleteViewModel computerRoom)
        {
            return ComputerRoomDAL.Delete(computerRoom);
        }

        public ReturnResult<ComputerRoom> Edit(ComputerRoomEditViewModel computerRoom)
        {
            return ComputerRoomDAL.Edit(computerRoom);
        }

        public ReturnResult<ComputerRoom> EditStatus(ComputerRoomEditStatusViewModel computerRoom)
        {
            return ComputerRoomDAL.EditStatus(computerRoom);
        }
    }
}
