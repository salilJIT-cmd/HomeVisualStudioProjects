using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDataTest2.EF.FluentApi.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public int Salary { get; set; }
        public int OfficeFloorID { get; set; }

        public OfficeFloor OfficeFloor { get; set; }

        public SystemDetail SystemDetail { get; set; }
    }
}
