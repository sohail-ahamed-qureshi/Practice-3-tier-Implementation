using CommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusineeLayer.Interfaces
{
    public interface IEmployeeBL
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(int id);

        Employee AddEmployee(Employee employee);

        Employee UpdateEmployee( Employee employee);

        void DeleteEmployee(Employee employee);
    }
}
