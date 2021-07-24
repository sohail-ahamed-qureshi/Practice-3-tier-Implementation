using BusineeLayer.Interfaces;
using CommonLayer;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusineeLayer.Services
{
    public class EmployeeBL : IEmployeeBL
    {

        private IEmployeeRL Employee;
        public EmployeeBL(IEmployeeRL Employee)
        {
            this.Employee = Employee;
        }
  
        public Employee AddEmployee(Employee employee)
        {
            Employee.RLAddEmployee(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            Employee.RLDeleteEmployee(employee);
        }
        public Employee GetEmployee(int id)
        {
            return Employee.RLGetEmployee(id);
        }

        public List<Employee> GetEmployees()
        {
            return Employee.RLGetEmployees();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var newEmployee = Employee.RLUpdateEmployee(employee);
            return newEmployee;
        }
    }
}
