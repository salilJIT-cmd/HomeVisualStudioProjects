using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_Relations;
using Microsoft.EntityFrameworkCore;

namespace SmartDataTest2.EF.RelationShips.sirModels
{
    public class EMS_Context : DbContext
    {
        public DbSet<OfficeFloor> Floors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SystemDetail> SystemDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                //@"Server=(localdb)\MSSQLLocalDB;Database=EFCore_consoleApp;Trusted_Connection=True;MultipleActiveResultSets=true"
                @"Server=DESKTOP-NLUJ81E\SQLEXPRESS2022;Database=EFCore_Relations;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You can configure your model in OnModelCreating directly.
            // You can create separate methods for model configuration and can call it from here.
            // You can create separate class and method for model configuration and can call it from here.
            // base.OnModelCreating(modelBuilder);

            // Model configuration of Office floor class
            modelBuilder.Entity<OfficeFloor>()
               .HasKey(floor => floor.FloorId);

            modelBuilder.Entity<OfficeFloor>()
           .Property(s => s.Floor_Name)
           .IsRequired();

            // One to many relation between floor and employee table.
            modelBuilder.Entity<OfficeFloor>()
                .HasMany(floor => floor.Employees)
                .WithOne(floor => floor.OfficeFloor)
                .HasForeignKey(ad => ad.OfficeFloorId);


            // Model configuration of Employee class
            modelBuilder.Entity<Employee>()
             .HasKey(s => s.EmployeeId);

            // One to one relation between Employee and SystemDetails.
            modelBuilder.Entity<Employee>()
                .HasOne<SystemDetail>()
                .WithOne(ad => ad.Employee)
            .HasForeignKey<SystemDetail>(ad => ad.EmpId);


            // Model configuration of SystemDetail class
            modelBuilder.Entity<SystemDetail>()
                .HasKey(sysDetail => sysDetail.SysDetailId);
        }
    }
}
