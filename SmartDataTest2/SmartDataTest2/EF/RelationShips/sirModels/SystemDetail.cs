using System;

namespace EFCore_Relations
{
    public class SystemDetail
    {
        public int SysDetailId { get; set; }
        public string SystemName { get; set; }
        public string SystemIP { get; set; }
        public string SystemOS { get; set; }

        // Write something to take EmployeeId as foregin key.
        public Employee Employee { get; set; }

        public int EmpId { get; set; }
    }
}
