using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using WebAPI_1.Models;

namespace WebAPI_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<Employee> GetAllEmployees()
        {

            return CompanyRepository.employees;
        }

        // Route Contraints
        // example - id:int
        // See more - 
        // https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2#route-constraints
        [HttpGet("{id:int}")]
        
        // Handling StatusCode
        // ActionResult<T> allows you to specify the HTTP status code for the response.
        // For example, you can use Ok(result) to return a 200 OK status code
        // along with the data in result.
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            // StatusCode - 400
            if (id <= 0) return BadRequest("Employee Id should be greater than 0");

            var foundEmp = CompanyRepository.employees
                            .Where(emp => emp.Emp_Id == id).FirstOrDefault();

            // StatusCode - 404
            if(foundEmp == null) return NotFound("Employee with the given Id not found");
            
            // StatusCode - 200
            return Ok(foundEmp);
        }


        // string datatype is not allowed in the route
        [HttpGet("{name:alpha}")]
        public Employee GetEmployeeByName(string name)
        {
            var foundEmp = CompanyRepository.employees
                            .Where(emp => emp.Emp_Name == name).FirstOrDefault();

            return foundEmp;
        }



        [HttpDelete]
        [Route("{id:int}")]
        public bool DeleteEmployeeById(int id)
        {
            var foundEmp = CompanyRepository.employees
                            .Where(emp => emp.Emp_Id == id).FirstOrDefault();

            CompanyRepository.employees.Remove(foundEmp);
            return true;
        }


        [HttpPost]
        public ActionResult<string> AddEmployee(int id, string name, int age, string city)
        {

            var alreadyExistEmployee = CompanyRepository.employees
                                            .Where(emp => emp.Emp_Id == id).FirstOrDefault();

            if (alreadyExistEmployee != null) {
                return BadRequest($"Employee with Id {id} already exists!");
            }

            if (id <= 0) return BadRequest("Employee Id should be greater than 0");

            Employee newEmp = new Employee
            {
                Emp_Id = id,
                Emp_Name = name,
                Emp_Age = age,
                Emp_City = city
            };

            CompanyRepository.employees.Add(newEmp);
            return Ok("Employee Added");

        }
            
        // OR 
        // I can take a full employee object from the request body

        [HttpPost]
        [Route("AddEmp")]
        public ActionResult<string> AddEmployeeWithObject([FromBody] Employee emp)
        {

            if (emp == null) return BadRequest();


            var newEmp_Id = CompanyRepository.employees.LastOrDefault().Emp_Id + 1;

            Employee newEmp = new Employee
            {
                Emp_Id = newEmp_Id,
                Emp_Name = emp.Emp_Name,
                Emp_Age = emp.Emp_Age,
                Emp_City = emp.Emp_City
            };

            CompanyRepository.employees.Add(newEmp);
            return Ok("Employee Added");

        }




        [HttpPut]
        [Route("{id:int}")]
        // Documenting
        // Below we are documeting responses along with their return types
        // It provides clear documentation for your API consumers.
        // They can understand what types of responses to expect for
        // different scenarios without having to go through documentation or guess.
        [ProducesResponseType(200, Type = typeof(Employee))]
        [ProducesResponseType(400, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)] // not need to remember statuscodes
        public ActionResult UpdateEmployeeName(int id, string name)
        {
            var foundEmp = CompanyRepository.employees
                                            .Where(emp => emp.Emp_Id == id).FirstOrDefault();

            if (id <= 0) return BadRequest("Employee Id should be greater than 0");

            if (foundEmp == null)
            {
                return NotFound($"Employee with Id {id} not found!");
            }

            foundEmp.Emp_Name = name;
            return Ok(foundEmp);
        }
    }
}
