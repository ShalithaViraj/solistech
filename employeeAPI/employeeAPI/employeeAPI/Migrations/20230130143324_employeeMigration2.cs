using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace employeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class employeeMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
              name: "LName",
              table: "Employees",
              nullable: false
             );

            migrationBuilder.AddColumn<string>(
             name: "Bday",
             table: "Employees",
             nullable: false
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FName",
                table: "Employees",
                newName: "Name");
        }
    }
}
