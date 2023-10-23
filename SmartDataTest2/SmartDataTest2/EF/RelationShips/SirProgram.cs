using EFCore_Relations.Context;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Relations
{
    public class SirProgram
    {
        public static void Main(string[] args)
        {
            using (EMS_Context context = new EMS_Context())
            {
                // Write a code to load referenced table.
                var floorObj = new OfficeFloor { Floor_Name = "5th floor" };
                context.Floors.Add
                    (
                    floorObj
                    );
                context.SaveChanges();
                var empObj = new Employee
                {
                    Name = "John doe",
                    Tech = "MS",
                    AvailCanteenService = true,
                    OfficeFloorId = floorObj.FloorId,
                };

                context.Employees.Add(empObj);
                context.SaveChanges();
                context.SystemDetails.Add(new SystemDetail
                {
                    SystemName = "SDN-123",
                    SystemOS = "Windows 11",
                    SystemIP = "0.0.0.0",
                    EmpId = empObj.EmployeeId

                });

                context.SaveChanges();
            }


            //using (var context = new EMS_Context())
            //{
            //    context.Floors.Add(
            //        new OfficeFloor
            //        {
            //            Floor_Name = "5th",
            //            Employees = new List<Employee>
            //            {
            //                new Employee
            //                {
            //                    Name = "ttest", SystemDetail = new SystemDetail { }
            //                }
            //            }
            //        });
            //}

            
        }
    }
}