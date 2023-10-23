using ConsoleApp2.Joins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BasicCrud
{
    internal class MyDBContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
            Server=LAPTOP-TG7EDFJP\SQLEXPRESS;
            Database=EF_MyDBJoins;
            Trusted_Connection=true;
            TrustServerCertificate=true;
            MultipleActiveResultSets=true;
            ");
            //optionsBuilder.UseSqlServer(@"Server=LAPTOP-TG7EDFJP\SQLEXPRESS;Database=Practice;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=true;");
        }
    }
}
