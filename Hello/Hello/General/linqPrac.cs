using System.Collections.Generic;
using System;
using System.Reflection;
using System.Linq;

namespace Linq
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee {Id=1,Name="Abc",Emp_code="EMP-1", Technology="MS" },
                new Employee {Id=2,Name="Xyz",Technology="MS",Emp_code="EMP-2" },
                new Employee {Id=3,Name="Test",Technology="MEAN",Emp_code="EMP-3" }
            };

            List<EmpSalary> employeeSalaries = new List<EmpSalary>()
            {
                new EmpSalary {Id=1,Salary="2000",IsActive=true,Emp_code = "EMP-1"},
                new EmpSalary {Id=2,Salary="1000",IsActive=false,Emp_code = "EMP-2"},
                new EmpSalary {Id=3,Salary="1000",IsActive=false,Emp_code = "EMP-3"},
            };

            #region Method syntax examples
            // Method syntax.
            var methodSyntax = employees.Where(emp => emp.Technology == "MS").
                Join(
                employeeSalaries.Where(empsal => empsal.IsActive),
                emp => emp.Emp_code,
                empSal => empSal.Emp_code,
                (emp, empSal) =>
                new EmployeeSalary
                {
                    Id = emp.Id,
                    Name = emp.Name,
                    Salary = empSal.Salary,
                    Active = empSal.IsActive == true ? "Yes" : "No",
                    Emp_code = emp.Emp_code
                }
                );

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Salary + " " + item.Active + " " + item.Emp_code);
            }

            var empGroup_method = employees.
                GroupBy(emp => emp.Technology).
                Select(empGroup => new
                {
                    Tech = empGroup.Key,
                    Employees = empGroup.Count(),
                });

            #endregion


            #region Query syntax examples

            // Query syntax
            var msEmployees = from e in employees
                              join sal in employeeSalaries
                              on e.Emp_code equals sal.Emp_code
                              where e.Technology == "MS"
                              //& sal.IsActive==true
                              select new EmployeeSalary
                              {
                                  Id = e.Id,
                                  Name = e.Name,
                                  Salary = sal.Salary,
                                  Active = sal.IsActive == true ? "Yes" : "No",
                                  Emp_code = e.Emp_code
                              };
            /*
                                foreach ( var emp in msEmployees )
                                {
                                    Console.WriteLine( emp.Id +" "+emp.Name+" "+emp.Salary+" "+emp.Active+" "+emp.Emp_code );
                                }
            */
            // Anonymous objects
            var empSalaries = from e in employees
                              join sal in employeeSalaries on e.Id equals sal.Id
                              where e.Technology == "MS"
                              //& sal.IsActive==true
                              select new
                              {
                                  e.Id,
                                  sal.Salary,
                                  e.Name,
                                  Active = sal.IsActive == true ? "Yes" : "No"
                              };

            var empGrouping = from e in employees
                              group e by e.Technology into emp
                              //select emp;
                              select new
                              {
                                  Tech = emp.Key,
                                  Employees = emp.Count(),
                              };

            #endregion

            Console.WriteLine();
        }
    }

    public class EmployeeSalary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public string Active { get; set; }
        public string Emp_code { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Technology { get; set; }
        public string Emp_code { get; set; }
    }
    public class EmpSalary
    {
        public int Id { get; set; }
        public string Salary { get; set; }
        public bool IsActive { get; set; }
        public string Emp_code { get; set; }
    }
}

