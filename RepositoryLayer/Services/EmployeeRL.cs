using CommonLayer;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services
{
    public class EmployeeRL : IEmployeeRL
    {
        /// <summary>
        /// hardcoding some employees data to list
        /// </summary>
        private List<Employee> employees = new List<Employee>()
        {
            new Employee(){id = 1, name = "Employee One", salary = 10000},
            new Employee(){id = 2, name = "Employee two", salary = 20000},
            new Employee(){id = 3, name = "Employee three", salary = 30000}
        };
        /// <summary>
        /// Add new employee to the list using http post method
        /// </summary>
        /// <param name="employee">new employee details</param>
        /// <returns>new employee details</returns>
        public Employee RLAddEmployee(Employee employee)
        {
            employee.id = employees.Count + 1;
            employees.Add(employee);
            return employee;
        }
        /// <summary>
        /// remove the existing user from the list using http delete method
        /// </summary>
        /// <param name="employee">employee details to be removed </param>
        public void RLDeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
        /// <summary>
        /// get employee details with particular id using http get method
        /// </summary>
        /// <param name="id">get details of employee </param>
        /// <returns></returns>
        public Employee RLGetEmployee(int id)
        {
            return employees.Find(x => x.id == id);
        }

        /// <summary>
        /// perform HttpGet methods to get all employees from the list
        /// </summary>
        /// <returns> list of employees</returns>
        public List<Employee> RLGetEmployees()
        {
            return employees;
        }
        /// <summary>
        /// update already existing employee details with the new employee details using 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Employee RLUpdateEmployee(Employee employee)
        {
            Employee oldEmployee = RLGetEmployee(employee.id);
            oldEmployee.name = employee.name;
            oldEmployee.salary = employee.salary;
            return employee;
        }
    }
}
