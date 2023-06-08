using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class Update_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Consult_cost",
                table: "Meds");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Meds");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "Speciality",
                table: "Meds",
                newName: "Speciality_id");

            migrationBuilder.RenameColumn(
                name: "Ci",
                table: "Appoiments",
                newName: "Especiality_id");

            migrationBuilder.AddColumn<int>(
                name: "Role_id",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Role_id",
                table: "Meds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "Appoiments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Role_id",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role_id",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Role_id",
                table: "Meds");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Appoiments");

            migrationBuilder.DropColumn(
                name: "Role_id",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "Speciality_id",
                table: "Meds",
                newName: "Speciality");

            migrationBuilder.RenameColumn(
                name: "Especiality_id",
                table: "Appoiments",
                newName: "Ci");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Consult_cost",
                table: "Meds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Meds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
