using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class Createuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Meds");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ci = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Speciality_id = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Date",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Appoiment",
                value: new DateTime(2023, 6, 29, 18, 53, 39, 339, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Ci", "Email", "Name", "Password", "Role", "Speciality_id", "SurName" },
                values: new object[,]
                {
                    { 1, 30, 991234567, "W.Shake@gmail.com", "William", "password", "patient", "0", "Shakespeare" },
                    { 2, 30, 994749304, "F.Campos@gmail.com", "Frank", "password", "med", "1", "Campos" },
                    { 3, 30, 934985782, "C.Celeste@gmail.com", "Carlos", "password", "admin", "0", "Celeste" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ci = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ci = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speciality_id = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Ci = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Ci", "Email", "Name", "Password", "Role", "SurName" },
                values: new object[] { 1, 934985782, "C.Celeste@gmail.com", "Carlos", "password", "admin", "Celeste" });

            migrationBuilder.UpdateData(
                table: "Date",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Appoiment",
                value: new DateTime(2023, 6, 29, 18, 31, 7, 631, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.InsertData(
                table: "Meds",
                columns: new[] { "Id", "Ci", "Email", "Name", "Password", "Role", "Speciality_id", "SurName" },
                values: new object[] { 1, 994749304, "F.Campos@gmail.com", "Frank", "password", "med", "1", "Campos" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "Ci", "Email", "Name", "Password", "Role", "SurName" },
                values: new object[] { 1, 30, 991234567, "W.Shake@gmail.com", "William", "password", "patient", "Shakespeare" });
        }
    }
}
