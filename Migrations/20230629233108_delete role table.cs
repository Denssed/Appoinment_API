using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class deleteroletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropColumn(
                name: "Role_id",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Role_id",
                table: "Meds");

            migrationBuilder.DropColumn(
                name: "Role_id",
                table: "Admins");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Patients",
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

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Date",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Appoiment",
                value: new DateTime(2023, 6, 29, 18, 31, 7, 631, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Meds",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: "med");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: "patient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Meds");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Admins");

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
                name: "Role_id",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Date",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Appoiment",
                value: new DateTime(2023, 6, 20, 9, 46, 57, 185, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Meds",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role_id",
                value: 3);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Med" },
                    { 3, "Patient" }
                });
        }
    }
}
