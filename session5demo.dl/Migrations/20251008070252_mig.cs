using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session5demo.dl.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isdeleted",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "Isdeleted",
                table: "departments");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "employees",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "createdby",
                table: "employees",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "modifiedon",
                table: "employees",
                newName: "LastModifiedOn");

            migrationBuilder.RenameColumn(
                name: "modifiedby",
                table: "employees",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "departments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "departments",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "createdon",
                table: "departments",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "createdby",
                table: "departments",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "departments",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "modifiedon",
                table: "departments",
                newName: "LastModifiedOn");

            migrationBuilder.RenameColumn(
                name: "modifiedby",
                table: "departments",
                newName: "LastModifiedBy");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "employees",
                newName: "createdon");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "employees",
                newName: "createdby");

            migrationBuilder.RenameColumn(
                name: "LastModifiedOn",
                table: "employees",
                newName: "modifiedon");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "employees",
                newName: "modifiedby");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "departments",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "departments",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "departments",
                newName: "createdon");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "departments",
                newName: "createdby");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "departments",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "LastModifiedOn",
                table: "departments",
                newName: "modifiedon");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "departments",
                newName: "modifiedby");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Isdeleted",
                table: "employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Isdeleted",
                table: "departments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
