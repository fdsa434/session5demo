using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session5demo.dl.Migrations
{
    /// <inheritdoc />
    public partial class lo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "deptid",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_deptid",
                table: "employees",
                column: "deptid");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_deptid",
                table: "employees",
                column: "deptid",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_deptid",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_deptid",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "deptid",
                table: "employees");
        }
    }
}
