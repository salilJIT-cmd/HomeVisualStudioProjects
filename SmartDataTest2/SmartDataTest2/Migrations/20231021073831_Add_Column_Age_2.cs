using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDataTest2.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Age_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // In this migration, we are doing the same thing that we did in the previous migration
            // New point is, we can use both EF methods and SQL methods
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Employees",
                type: "int",
                nullable: true
            );
            migrationBuilder.Sql("Alter Table Employees" +
                                  " Add Constraint CheckAge2 Check(Age > 20)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
