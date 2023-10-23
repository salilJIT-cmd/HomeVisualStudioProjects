using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Prac.RelationShips.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Prac.RelationShips
{
    internal class myProgram
    {
        public static void Main(string[] args)
        {

            using(EF_RelationsDBContext context =  new EF_RelationsDBContext())
            {
                
                OfficeFloor officeFloor = new OfficeFloor
                {
                    Floor_Name = "1st_floor"
                };
                context.Floors.Add(officeFloor);
                context.SaveChanges();

                Employee emp = new Employee
                {
                    Name = "Salil",
                    Tech = "MS",
                    AvailCanteenService = true,
                    OfficeFloorId = officeFloor.FloorId

                };
                context.Employees.Add(emp);
                context.SaveChanges();

                SystemDetail sysDetails = new SystemDetail
                {
                    SystemName = "SDN-124",
                    SystemIP = "172.0.1.22",
                    SystemOS = "Windows",
                    EmployeeId = emp.EmployeeId
                };
                context.SystemDetails.Add(sysDetails);
                context.SaveChanges();

            }

            #region fetchingData
            using (EF_RelationsDBContext context = new EF_RelationsDBContext())
            {
                #region withJoins
                var queryWithJoin = context.Employees.Join(
                        context.Floors,
                        emp => emp.OfficeFloorId,
                        floor => floor.FloorId,
                        (emp, floor) => new
                        {
                            emp_name = emp.Name,
                            floor_name = floor.Floor_Name
                        }
                    );

                foreach (var item in queryWithJoin)
                {
                    Console.WriteLine($"{item.emp_name} : {item.floor_name}");
                }
                #endregion

                #region withoutJoins
                var queryWithoutJoin = context.Employees.Select(
                        emp => new
                        {
                            emp_name = emp.Name,
                            floor_name = emp.OfficeFloor.Floor_Name
                        }
                    );
                Console.WriteLine("Without Joins");
                foreach (var item in queryWithoutJoin)
                {
                    Console.WriteLine($"{item.emp_name} : {item.floor_name}");
                }

                #endregion
            }

            #endregion
        }
    }
}
