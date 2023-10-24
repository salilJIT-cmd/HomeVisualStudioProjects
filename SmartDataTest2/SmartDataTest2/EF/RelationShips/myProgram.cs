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
            #region AddingDataInAllTables
            using (EF_RelationsDBContext context =  new EF_RelationsDBContext())
            {
                
                //OfficeFloor officeFloor = new OfficeFloor
                //{
                //    Floor_Name = "2nd_floor"
                //};
                //context.Floors.Add(officeFloor);
                //context.SaveChanges();

                //Employee emp = new Employee
                //{
                //    Name = "Yash",
                //    Tech = "MEAN",
                //    AvailCanteenService = true,
                //    OfficeFloorId = 1

                //};
                //context.Employees.Add(emp);
                //context.SaveChanges();

                //SystemDetail sysDetails = new SystemDetail
                //{
                //    SystemName = "SDN-124",
                //    SystemIP = "172.0.1.22",
                //    SystemOS = "Windows",
                //    EmployeeId = emp.EmployeeId
                //};
                //context.SystemDetails.Add(sysDetails);
                //context.SaveChanges();

            }
            #endregion

            //FetchDataFromEmployees();'

            FetchDataFromFloors();

        }


        public static void FetchDataFromEmployees()
        {
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

                Console.WriteLine();
                Console.WriteLine("Without Joins");
                foreach (var item in queryWithoutJoin)
                {
                    Console.WriteLine($"{item.emp_name} : {item.floor_name}");
                }

                #endregion
            }
        }

        public static void FetchDataFromFloors()
        {
            using (EF_RelationsDBContext context = new EF_RelationsDBContext())
            {
                var query = context.Floors
                            .Where(floor => floor.FloorId == 1)
                            .Select(floor => new
                            {
                                floor_id = floor.FloorId,
                                floor_name = floor.Floor_Name,
                                all_emps = floor.Employees
                            });

                foreach (var floor in query)
                {
                    Console.WriteLine($"FloorId {floor.floor_id} : {floor.floor_name}");

                    foreach (var emp in floor.all_emps)
                    {
                        Console.WriteLine($"{emp.Name}");
                    }
                }
            }

        }
    }
}
