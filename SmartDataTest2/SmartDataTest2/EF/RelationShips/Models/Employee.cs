using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Prac.RelationShips.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Tech { get; set; }

        public bool? AvailCanteenService { get; set; }


        // Defining Relationships:::


        // Write something to take FloorId as foreign key.
        public int OfficeFloorId { get; set; }

        // Write something to represent one to one relation with Floor
        // (that means one employee can only have one floor)
        public OfficeFloor OfficeFloor { get; set; }

        // Write something to define a one-to-one relation with Systemdetail class.
        public SystemDetail? SystemDetail { get; set; }

    }
}

