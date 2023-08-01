using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class adduserandappoimenttoseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Med_id",
                value: 2);

            migrationBuilder.InsertData(
                table: "Appoiments",
                columns: new[] { "Id", "Cost", "Date_timeStamp", "Med_id", "Patient_id", "Speciality_id" },
                values: new object[,]
                {
                    { 2, 70, "1689001300", 2, 1, 2 },
                    { 3, 80, "1689001300", 2, 1, 2 },
                    { 4, 60, "1689001300", 2, 4, 2 },
                    { 5, 600, "1689001300", 2, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Ci", "Email", "Name", "Password", "Role", "Speciality_id", "SurName" },
                values: new object[] { 4, 30, 934985785, "S.Ramos@gmail.com", "Sebastion", "password", "patient", "0", "Ramos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Med_id",
                value: 1);
        }
    }
}
