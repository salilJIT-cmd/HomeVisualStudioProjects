using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice_smartdata
{
    public class Student1
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int AddressId { get; set; }
    }
    public class Address1
    {

        public int Id { get; set; }

        public string AddressLine { get; set; }
    }
    public class program3
    {

        public static void Main(string[] args)
        {
            var Students = new List<Student>()

            {
                new Student(){Id = 1, Name = "achal",AddressId = 1},
                new Student(){Id = 2, Name = "salil",AddressId = 2},
                new Student(){Id = 3, Name = "dolly"},
                new Student(){Id = 4, Name = "karma",AddressId = 3},
                new Student(){Id = 5, Name = "rohit",AddressId = 5},

            };


            var Address = new List<Address>()
            {
                 new Address(){Id = 1,AddressLine = "abc 1"},
                 new Address(){Id = 2,AddressLine = "def 2"},
                 new Address(){Id = 3,AddressLine = "ghi 3"}

            };

            var qs = (from std in Students
                      join add in Address
                      on std.AddressId equals add.Id into stdAddress
                      from studentAddress in stdAddress.DefaultIfEmpty()
                      select new { std, studentAddress }).ToList();


            foreach (var result in qs)
            {
                Console.WriteLine($"Student Name: {result.std.Name}");

                if (result.studentAddress != null)
                {
                    Console.WriteLine($"Address: {result.studentAddress.AddressLine}");
                }
                else
                {
                    Console.WriteLine("No Address Found");
                }
            }

        }
    }
}