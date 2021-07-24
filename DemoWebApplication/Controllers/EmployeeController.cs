using BusineeLayer.Interfaces;
using CommonLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApplication.Controllers
{

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeBL Employee;
        public EmployeeController(IEmployeeBL Employee)
        {
            this.Employee = Employee;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public ActionResult GetEmployee()
        
        {
            List<Employee> employees = Employee.GetEmployees();
            return Ok(employees);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public ActionResult GetEmployees(int id)
        {
            Employee employee = Employee.GetEmployee(id);
            return Ok(new { Data = employee });
        }

        [HttpPost]
        [Route("api/[controller]")]
        public ActionResult PostEmployee(Employee employee)
        {
            Employee.AddEmployee(employee);
            return Created(employee.id.ToString(), employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            Employee employee = Employee.GetEmployee(id);
            if (employee != null)
            {
                Employee.DeleteEmployee(employee);
                return Ok(new { Success = true, Message = $"Employee Id: {id} Delete SuccessFull " });
            }
            return NotFound($"Employee Id: {id} not Found");

        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public ActionResult EditEmployee(int id, Employee employee)
        {
            Employee OldEmployee = Employee.GetEmployee(id);
            if (OldEmployee != null)
            {
                employee.id = OldEmployee.id;
                var newEmployee = Employee.UpdateEmployee(employee);
                return Ok(new { Success = true, Message = $"Employee Id: {id} Update SuccessFull ", Data = newEmployee });
            }
            return NotFound($"Employee Id: {id} not Found");
        }
    }
}
