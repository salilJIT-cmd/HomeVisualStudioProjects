using System;
using System.ComponentModel.DataAnnotations;

namespace EFCore_Relations
{
    public class OfficeFloor
    {
        public int FloorId { get; set; }
        public string Floor_Name { get; set; }

        // Write something to define one-to-many relation betweem Floor and employee.
        public IList<Employee> Employees { get; set; }
    }
}
