using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class EmployeeService : IEmployeeService
    {

        public IEmployeeDao EmployeeDao = new newemployee();

        public IList<Employee> GetAllEmployees()
        {
            return EmployeeDao.GetAllEmployees();
        }

        public Employee GetEmployeeById(string id)
        {
             return EmployeeDao.GetEmployeeById(id);
        }

    }

}
