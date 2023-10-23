using Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.General
{
    public class Employee2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Technology { get; set; }
        public int Salary { get; set; }
    }
    internal class groupPrac
    {
        public static void Main(string[] args)
        {
            List<Employee2> employees = new List<Employee2>()
            {
                new Employee2 {Id=1,Name="Abc",Technology="MS", Salary=50000},
                new Employee2 {Id=2,Name="Xyz",Technology="MS",Salary=60000},
                new Employee2 {Id=3,Name="Test",Technology="MEAN",Salary=30000 },
                new Employee2 {Id=4,Name="dsg",Technology="MS",Salary=40000 },
                new Employee2 {Id=5,Name="hra",Technology="MEAN",Salary=80000 },
            };

            List<EmpSalary> employeeSalaries = new List<EmpSalary>()
            {
                new EmpSalary {Id=1,Salary="2000",IsActive=true,Emp_code = "EMP-1"},
                new EmpSalary {Id=2,Salary="1000",IsActive=false,Emp_code = "EMP-2"},
                new EmpSalary {Id=3,Salary="1000",IsActive=false,Emp_code = "EMP-3"},
            };

            var query = employees
                        .GroupBy(emp => emp.Technology)
                        .Select(empGroup => new
                        {
                            groupKey = empGroup.Key,
                            MaxSalary = empGroup.Max(emp => emp.Salary),
                        });

            foreach(var empGroup in query)
            {
                Console.WriteLine("Group " + empGroup.groupKey);
                Console.WriteLine("MaxSalary " + empGroup.MaxSalary);

            }
        }
    }
}
