using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class Implant_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Specialities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "consult_cost",
                table: "Specialities",
                newName: "Consult_cost");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Roles",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Ci", "Email", "Name", "Password", "Role_id", "SurName" },
                values: new object[] { 1, 934985782, "C.Celeste@gmail.com", "Carlos", "password", 1, "Celeste" });

            migrationBuilder.InsertData(
                table: "Appoiments",
                columns: new[] { "Id", "Cost", "Date", "Especiality_id", "Med_id", "Patient_id" },
                values: new object[] { 1, 60, new DateTime(2023, 6, 8, 10, 42, 7, 392, DateTimeKind.Local).AddTicks(7659), 2, 1, 1 });

            migrationBuilder.InsertData(
                table: "Meds",
                columns: new[] { "Id", "Ci", "Email", "Name", "Password", "Role_id", "Speciality_id", "SurName" },
                values: new object[] { 1, 994749304, "F.Campos@gmail.com", "Frank", "password", 2, "1", "Campos" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "Ci", "Email", "Name", "Password", "Role_id", "SurName" },
                values: new object[] { 1, 30, 991234567, "W.Shake@gmail.com", "William", "password", 3, "Shakespeare" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Med" },
                    { 3, "Patient" }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Consult_cost", "Name" },
                values: new object[,]
                {
                    { 1, 40, "Alergologia" },
                    { 2, 60, "Cardiologia" },
                    { 3, 100, "Cirugia General" },
                    { 4, 40, "Gastroenterologia" },
                    { 5, 50, "Dermatologia" },
                    { 6, 40, "Geriatria" },
                    { 7, 40, "Ginecologia" },
                    { 8, 20, "Medicina General" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Specialities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Consult_cost",
                table: "Specialities",
                newName: "consult_cost");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "name");
        }
    }
}
