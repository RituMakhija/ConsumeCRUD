using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        Employee[] employees = new Employee[]
        {
            new Employee { ID = 1 , Name = "Mark" , JoiningDate = DateTime.Parse(DateTime.Today.ToString()) , Age = 23 },
            new Employee { ID = 2 , Name = "John" , JoiningDate = DateTime.Parse(DateTime.Today.ToString()) , Age = 24 },
            new Employee { ID = 3 , Name = "Mary" , JoiningDate=DateTime.Parse(DateTime.Today.ToString()) , Age = 23 },
            new Employee { ID = 4 , Name = "Penny" , JoiningDate=DateTime.Parse(DateTime.Today.ToString()) , Age = 23 }
        };

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault((m) => m.ID == id);
            if(employee==null)
            {
                return NotFound();
            }           
            return Ok(employee);           
        }
    }
}
