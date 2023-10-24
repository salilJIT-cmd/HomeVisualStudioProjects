using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDataTest2.EF.FluentApi.Models
{
    public class OfficeFloor
    {
        public int FloorId { get; set; }
        public string Floor_Name { get; set; }
        public IList<Employee> Employees { get; set; }

    }
}
