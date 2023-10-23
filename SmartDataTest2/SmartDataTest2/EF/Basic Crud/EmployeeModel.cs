using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BasicCrud
{
    internal class EmployeeModel
    {
        public int Id { get; set; }
        // by default the above field is taken as Primary key
        // by the sql server and also it added Identity to it.
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
