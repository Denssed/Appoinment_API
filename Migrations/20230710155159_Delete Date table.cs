using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class DeleteDatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date_Appoiment",
                table: "Appoiments");

            migrationBuilder.AddColumn<string>(
                name: "Date_timeStamp",
                table: "Appoiments",
                type: "nvarchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_timeStamp",
                value: "1689001200");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date_timeStamp",
                table: "Appoiments");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Appoiment",
                table: "Appoiments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_Appoiment",
                value: new DateTime(2016, 12, 31, 5, 10, 20, 0, DateTimeKind.Unspecified));
        }
    }
}
