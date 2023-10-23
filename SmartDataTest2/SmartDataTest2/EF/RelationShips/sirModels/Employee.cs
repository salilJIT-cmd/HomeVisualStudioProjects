using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_Relations
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Tech { get; set; }

        public bool? AvailCanteenService { get; set; }
        // Write something to take FloorId as foregin key.
        // Write something to define a one-to-one relation with Systemdetail class.

        public OfficeFloor OfficeFloor { get; set; }

        public int OfficeFloorId {  get; set; }
        
        public SystemDetail? SystemDetail { get; set; } 
    }
}

