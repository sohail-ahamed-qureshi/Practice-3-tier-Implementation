using CommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRL
    {
        List<Employee> RLGetEmployees();

        Employee RLGetEmployee(int id);

        Employee RLAddEmployee(Employee employee);

        Employee RLUpdateEmployee(Employee employee);

        void RLDeleteEmployee(Employee employee);
    }
}
