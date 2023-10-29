using Microsoft.AspNetCore.Mvc;
using WebEFAPI_2.Contexts;
using WebEFAPI_2.Models;

namespace WebEFAPI_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        [HttpGet]
        [Route("all")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Employee>))]
        public ActionResult GetAllEmployees()
        {
            using(CompanyDBContext context =  new CompanyDBContext())
            {
                var EmployeeTable = context.Employees.ToList();
                return Ok(EmployeeTable);
            }
        }


        [HttpGet]
        [Route("{_id:int?}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        public ActionResult GetEmployeeById(int _id = 1) // default value to id
        {
            if (_id <= 0) return BadRequest("Id should be greater than 0");

            using (CompanyDBContext context = new CompanyDBContext())
            {
                var foundEmp = context.Employees.Find(_id);

                if (foundEmp == null) return NotFound("Employee Not found");
 
                return Ok(foundEmp);
            }
        }


        [HttpPost]
        [Route("AddEmp")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        //public ActionResult AddEmployee(string name, int age, string city)
        public ActionResult AddEmployee([FromBody] Employee emp)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            using (CompanyDBContext context = new CompanyDBContext())
            {
                Employee newEmp = new Employee
                {
                    Emp_Name = emp.Emp_Name,
                    Emp_Age = emp.Emp_Age,
                    Emp_City = emp.Emp_City
                };
                context.Employees.Add(newEmp);
                context.SaveChanges();
                return Ok("Employee Added");
            }
        }


        [HttpDelete]
        [Route("{_id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        public ActionResult DeleteEmployee(int _id)
        {
            if (_id <= 0) return BadRequest("Id should be greater than 0");

            using (CompanyDBContext context = new CompanyDBContext())
            {
                var foundEmp = context.Employees.Find(_id);

                if (foundEmp == null) return NotFound("Employee Not found");

                context.Employees.Remove(foundEmp);
                context.SaveChanges();
                return Ok("Employee Deleted");
            }
        }


        [HttpPatch]
        [Route("{_id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        public ActionResult UpdateEmployeeName(int _id, string _name)
        {
            if (_id <= 0) return BadRequest("Id should be greater than 0");

            using (CompanyDBContext context = new CompanyDBContext())
            {
                var foundEmp = context.Employees.Find(_id);

                if (foundEmp == null) return NotFound("Employee Not found");

                foundEmp.Emp_Name = _name;
                context.SaveChanges();
                return Ok(foundEmp);
            }
        }

    }
}
