using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session5demo.dl.Migrations
{
    /// <inheritdoc />
    public partial class lk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "employees");
        }
    }
}
