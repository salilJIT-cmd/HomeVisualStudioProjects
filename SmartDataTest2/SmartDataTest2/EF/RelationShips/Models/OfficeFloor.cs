using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Prac.RelationShips.Models
{
    public class OfficeFloor
    {
        [Key]
        public int FloorId { get; set; }
        public string Floor_Name { get; set; }

        // Define one-to-many relation betweem Floor and employee.
        public IList<Employee> Employees { get; set; }

        // The above property indicates that an "OfficeFloor" can have a collection of related
        // "Employee" entities, establishing a one-to-many relationship
        // between "OfficeFloor" and "Employee."
        // Entity Framework will recognize this relationship
        // and create a foreign key in the "Employee" table that
        // references the primary key of the "OfficeFloor" table.
        // This foreign key will typically be named something like "OfficeFloorId" by convention.
    }
}
