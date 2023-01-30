using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace employeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class employeeMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bday",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: null);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bday",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "Employees");
        }
    }
}
