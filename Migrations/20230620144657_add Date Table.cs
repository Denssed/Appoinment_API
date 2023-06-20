using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class addDateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Appoiments");

            migrationBuilder.RenameColumn(
                name: "Especiality_id",
                table: "Appoiments",
                newName: "Speciality_id");

            migrationBuilder.AddColumn<int>(
                name: "Date_id",
                table: "Appoiments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Date",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Appoiment = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Date",
                columns: new[] { "Id", "Date_Appoiment" },
                values: new object[] { 1, new DateTime(2023, 6, 20, 9, 46, 57, 185, DateTimeKind.Local).AddTicks(669) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Date");

            migrationBuilder.DropColumn(
                name: "Date_id",
                table: "Appoiments");

            migrationBuilder.RenameColumn(
                name: "Speciality_id",
                table: "Appoiments",
                newName: "Especiality_id");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Appoiments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 6, 8, 10, 42, 7, 392, DateTimeKind.Local).AddTicks(7659));
        }
    }
}
