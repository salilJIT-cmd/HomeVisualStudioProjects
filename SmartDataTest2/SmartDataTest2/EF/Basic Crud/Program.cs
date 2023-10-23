using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BasicCrud
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Adding Employees
            //AddEmployee("Vijay Sir", 80000);
            //AddEmployee("Rohit", 40000);
            //AddEmployee("Anchal", 30000);
            //AddEmployee("Apeksha", 40000);

            // List your employees
            //GetEmployees();

            // Get employee by its ID
            //FindEmployeeById(2);

            // Deleting Employee
            //DeleteEmployeeById(3);
            //GetEmployees();
            //UpdateEmployee(5, "Kuch bhi");

            GetEmployeesByCondition();

        }

        // CRUD Operations
        public static void AddEmployee(string _name, int _salary)
        {
            EmployeeModel newEmp = new EmployeeModel { Name = _name, Salary = _salary };

            // Write code to insert the employee.
            using (MyDBContext context = new MyDBContext())
            {
                context.Employees.Add(newEmp);
                context.SaveChanges();
            }
        }

        public static void GetEmployees()
        {
            // Write code to get the list of employees.
            using (MyDBContext context = new MyDBContext())
            {
                var employees = context.Employees;
                var empList = employees.ToList();
                foreach (var emp in empList)
                {
                    Console.WriteLine($"{emp.Id} : {emp.Name} : {emp.Salary}");
                }
            }
        }

        public static void FindEmployeeById(int _id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var foundEmp = context.Employees.Find(_id);

                if (foundEmp != null)
                {
                    Console.WriteLine($"{foundEmp.Id} : {foundEmp.Name} : {foundEmp.Salary}");
                }
                else
                {
                    Console.WriteLine("No employee found with the given Id");
                }
            }
        }

        public static void DeleteEmployeeById(int _id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var foundEmp = context.Employees.Find(_id);

                if (foundEmp != null)
                {
                    context.Employees.Remove(foundEmp);
                    context.SaveChanges();
                }

            }
        }

        public static void UpdateEmployee(int _id, string _name)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var foundEmp = context.Employees.Find(_id);
                if (foundEmp != null)
                {
                    foundEmp.Name = _name;
                    context.SaveChanges();
                }
            }
        }


        // Other Functions
        public static void GetEmployeesByCondition()
        {
            using(MyDBContext context = new MyDBContext())
            {

                var gotEmployees = context.Employees.Where(emp => emp.Salary > 50000);
                foreach (var emp in gotEmployees)
                {
                    Console.WriteLine($"{emp.Id} : {emp.Name} : {emp.Salary}");
                }
            }
        }

        
    }

}