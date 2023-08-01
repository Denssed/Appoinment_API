using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class changestringtodoubleondate_datestampappoiment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Date_timeStamp",
                table: "Appoiments",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_timeStamp",
                value: 1689001200.0);

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_timeStamp",
                value: 1689001300.0);

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_timeStamp",
                value: 1689001300.0);

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date_timeStamp",
                value: 1689001300.0);

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date_timeStamp",
                value: 1689001300.0);

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date_timeStamp",
                value: 1689001300.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date_timeStamp",
                table: "Appoiments",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_timeStamp",
                value: "1689001200");

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_timeStamp",
                value: "1689001300");

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_timeStamp",
                value: "1689001300");

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date_timeStamp",
                value: "1689001300");

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date_timeStamp",
                value: "1689001300");

            migrationBuilder.UpdateData(
                table: "Appoiments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date_timeStamp",
                value: "1689001300");
        }
    }
}
