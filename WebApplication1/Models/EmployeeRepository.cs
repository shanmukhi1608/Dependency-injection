using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeRepository:IEmployeeRepository
    {

        public List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee() { EmployeeId = 1, EmployeeName = "shanmukhi" };
            employees.Add(employee);

            employee = new Employee() { EmployeeId = 2, EmployeeName = "nikhila" };
            employees.Add(employee);

            return employees;
        }
    }
}
