using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDataTest2.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Age : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // In this migration, we are adding a column with a constraint
            //migrationBuilder.AddColumn<string>(
            //    name: "Age",
            //    table: "Employees",
            //    type: "int",
            //    nullable: true
            //);  

            // OR

            migrationBuilder.Sql("Alter Table Employees" +
                                " ADD Age int" +
                                " Constraint CheckAge Check(Age > 10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employees"
            );
        }
    }
}
