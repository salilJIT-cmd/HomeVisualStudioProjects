using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDataTest2.EF.FluentApi.Models
{
    public class SystemDetail
    {

        public int SysDetailId { get; set; }
        public string SystemName { get; set; }

        // Write something to take EmployeeId as foregin key.
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
