using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Prac.RelationShips.Models
{
    public class SystemDetail
    {
        [Key]
        public int SysDetailId { get; set; }
        public string SystemName { get; set; }
        public string SystemIP { get; set; }
        public string SystemOS { get; set; }

        // Write something to take EmployeeId as foregin key.
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }  
    }
}
