using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Joins
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //AddEmployee("Salil", 40000, 1);
            //AddEmployee("Vijay sir", 90000, 1);
            //AddEmployee("Deepti Mam", 70000, 2);
            //AddEmployee("Rohit", 20000, 3);
            //AddEmployee("Minal Mam", 40000, 2);

            //AddDepartment("IT");
            //AddDepartment("HR");
            //AddDepartment("Payroll");

            //JoinEmployeeAndDepartment();

            //UseGroupBy();
        }


        public static void AddEmployee(string _name, int _salary, int _deptId)
        {
            Employee employee = new Employee { Emp_Name = _name,Salary = _salary, Department_Id = _deptId};

            using(MyDBContext2 context = new MyDBContext2())
            { 
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }
        public static void AddDepartment(string _deptName)
        {
            Department department = new Department { Dept_Name = _deptName};

            using (MyDBContext2 context = new MyDBContext2())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }


        public static void JoinEmployeeAndDepartment()
        {
            using(MyDBContext2 context = new MyDBContext2())
            {
                var joinedTable = context.Employees.Join(
                    context.Departments,
                    emp => emp.Department_Id,
                    dept => dept.Dept_Id,
                    (emp,dept) => new
                    {
                        Id = emp.Id,
                        emp_name = emp.Emp_Name,
                        department = dept.Dept_Name
                    }
                ).ToList();

                var joinedTableQuerySyntax = from emp in context.Employees
                                             join dept in context.Departments
                                             on emp.Department_Id equals dept.Dept_Id
                                             select new
                                             {
                                                 Id = emp.Id,
                                                 emp_name = emp.Emp_Name,
                                                 department = dept.Dept_Name
                                             };
                                             

                foreach (var emp in joinedTableQuerySyntax.ToList())
                {
                    Console.WriteLine($"{emp.Id} : {emp.emp_name} : {emp.department}");
                }
            }
        }

        public static void UseGroupBy()
        {
            using(MyDBContext2 context = new MyDBContext2())
            {
                //var EmployeesTable = context.Employees;

                List<Employee> employees = new List<Employee>()
                {
                    new Employee{Id = 1, Emp_Name = "Salil", Department_Id = 1},
                    new Employee{Id = 2, Emp_Name = "il", Department_Id = 2},
                    new Employee{Id = 3, Emp_Name = "Sal", Department_Id = 1},
                    new Employee{Id = 4, Emp_Name = "Sll", Department_Id = 2}
                };

                var foundEmp = employees.First(emp => emp.Id == 1);
                Console.WriteLine(foundEmp.Emp_Name);




                //var query = (from emp in employees
                //             group emp by emp.Department_Id into grouped
                //            from emp2 in grouped.DefaultIfEmpty()
                //            select new { groupName = emp2.Department_Id, emp2 }).ToList();
                            

                //foreach (var groupItem in query)
                //{
                //    Console.WriteLine($"GROUP : {groupItem.groupName}");

                //    foreach (var emp in query)
                //    {
                //        Console.WriteLine(emp.emp2.Emp_Name);
                //    }
                //}

                //var qs = (from std in Students
                //          join add in Address
                //          on std.AddressId equals add.Id
                //          into stdAddress
                //          from studentAddress in stdAddress.DefaultIfEmpty()
                //          select new { std, studentAddress }).ToList();


                //foreach (var result in qs)
                //{
                //    Console.WriteLine($"Student Name: {result.std.Name}");

                //    if (result.studentAddress != null)
                //    {
                //        Console.WriteLine($"Address: {result.studentAddress.AddressLine}");
                //    }
                //    else
                //    {
                //        Console.WriteLine("No Address Found");
                //    }
                //}

            }
        }




    }
}
