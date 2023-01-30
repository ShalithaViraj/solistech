using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace employeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class employeeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
            table: "Employees",
            name: "Name",
            newName: "FName"
);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
