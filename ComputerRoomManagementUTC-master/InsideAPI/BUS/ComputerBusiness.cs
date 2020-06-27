using Common.Common;
using Common.Entity.Models.Computer;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class ComputerBusiness
    {
        private ComputerDAL _computerDAL;
        public ComputerDAL ComputerDAL
        {
            get
            {
                _computerDAL = new ComputerDAL();
                return _computerDAL;
            }
        }
        public ReturnResult<Computer> GetAllComputerSearched(BaseCondition<Computer> condition, int computerRoomId)
        {
            ComputerDAL computerDAL = new ComputerDAL();
            var result = computerDAL.GetAllComputerSearched(condition, computerRoomId);
            return result;
        }

        public ReturnResult<Computer> Add(AddComputerViewModel computer)
        {
            ComputerDAL computerDAL = new ComputerDAL();
            var result = computerDAL.Add(computer);
            return result;
        }

        public ReturnResult<Computer> GetById(int id)
        {
            ComputerDAL computerDAL = new ComputerDAL();
            var result = computerDAL.GetById(id);
            return result;
        }

        public ReturnResult<Computer> GetAll(int id)
        {
            ComputerDAL computerDAL = new ComputerDAL();
            var result = computerDAL.GetAll(id);
            return result;
        }

        public ReturnResult<Computer> Edit(ComputerEditModel computer)
        {
            ComputerDAL computerDAL = new ComputerDAL();
            var result = computerDAL.Edit(computer);
            return result;
        }
    }
}
