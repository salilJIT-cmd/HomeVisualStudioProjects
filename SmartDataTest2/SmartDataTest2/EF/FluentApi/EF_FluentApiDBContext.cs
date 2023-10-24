using Microsoft.EntityFrameworkCore;
using SmartDataTest2.EF.FluentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDataTest2.EF.FluentApi
{
    internal class EF_FluentApiDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OfficeFloor> OfficeFloor { get; set; }
        public DbSet<SystemDetail> SystemDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
            Server=LAPTOP-TG7EDFJP\SQLEXPRESS;
            Database=EF_FluentApiDB;
            Trusted_Connection=true;
            TrustServerCertificate=true;
            MultipleActiveResultSets=true;
            ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OfficeFloor>()
                            .HasKey(floor => floor.FloorId);

            modelBuilder.Entity<Employee>()
                            .HasKey(emp => emp.Emp_Id);

            modelBuilder.Entity<SystemDetail>()
                            .HasKey(sd => sd.SysDetailId);

            //modelBuilder.Entity<Employee>()
            //                .HasOne(emp => emp.OfficeFloor)
            //                .WithMany()
            //                .HasForeignKey(emp => emp.OfficeFloorID);

            // Define one-to-many relationship between OfficeFloor and Employee
            modelBuilder.Entity<OfficeFloor>()
                                .HasMany(of => of.Employees)
                                .WithOne(e => e.OfficeFloor)
                                .HasForeignKey(e => e.OfficeFloorID);

            modelBuilder.Entity<Employee>()
                        .HasOne(e => e.SystemDetail)
                        .WithOne(sd => sd.Employee)
                        .HasForeignKey<SystemDetail>(sd => sd.EmployeeId);
        }   

    }
}
