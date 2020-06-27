using Common.Common;
using Common.Entity.Models.Employee;
using InsideAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class EmployeeBusiness
    {
        private EmployeeDAL _employeeDAL;
        public EmployeeDAL EmployeeDAL
        {
            get
            {
                _employeeDAL = new EmployeeDAL();
                return _employeeDAL;
            }
        }
        public ReturnResult<Employee> GetAllEmployeeSearched(BaseCondition<Employee> condition)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            var result = employeeDAL.GetAllEmployeeSearched(condition);
            return result;
        }

        public ReturnResult<Employee> GetAll()
        {
            return EmployeeDAL.GetAll();
        }

        public ReturnResult<Employee> AddEmployee(AddEmployeeModel employee)
        {
            return EmployeeDAL.Add(employee);
        }

        public ReturnResult<Employee> GetById(int Id)
        {
            return EmployeeDAL.GetById(Id);
        }

        public ReturnResult<Employee> Delete(EmployeeDeleteModel employee)
        {
            return EmployeeDAL.Delete(employee);
        }

        public ReturnResult<Employee> Edit(EmployeeEditModel employee)
        {
            return EmployeeDAL.Edit(employee);
        }

        public ReturnResult<Employee> EditStatus(EmployeeEditStatusModel employee)
        {
            return EmployeeDAL.EditStatus(employee);
        }
    }
}
