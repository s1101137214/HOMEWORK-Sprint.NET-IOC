using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    class NewemployeeDao : IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employee = new List<Employee>();

            Employee Employee1 = new Employee();
            Employee1.Id = "haha";
            Employee1.Name = "叡揚資訊!!";
            Employee1.Age = 7;
            employee.Add(Employee1);

            Employee Employee2 = new Employee();
            Employee2.Id = "KUAS";
            Employee2.Name = "高雄應用科技大學";
            employee.Add(Employee2);

            return employee;
        }

        public Employee GetEmployeeById(string id)
        {

            Employee Employee = null;

            if ("haha".Equals(id))
            {
                Employee = new Employee();
                Employee.Id = "haha";
                Employee.Name = "叡揚資訊!!!!";
            }

            return Employee;
        }
    }
}
