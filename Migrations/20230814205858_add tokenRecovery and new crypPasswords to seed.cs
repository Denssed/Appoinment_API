using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appoiment_API.Migrations
{
    public partial class addtokenRecoveryandnewcrypPasswordstoseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TokenRecovery",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Password", "TokenRecovery" },
                values: new object[] { "5s12JolyfpPW/omcfJAnfQ==", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "TokenRecovery" },
                values: new object[] { "5s12JolyfpPW/omcfJAnfQ==", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Speciality_id", "TokenRecovery" },
                values: new object[] { "5s12JolyfpPW/omcfJAnfQ==", "1", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Speciality_id", "TokenRecovery" },
                values: new object[] { "5s12JolyfpPW/omcfJAnfQ==", "2", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Ci", "Email", "Name", "Password", "Role", "Speciality_id", "SurName", "TokenRecovery" },
                values: new object[,]
                {
                    { 5, 30, 934985785, "A.Ramos@gmail.com", "Alex", "5s12JolyfpPW/omcfJAnfQ==", "med", "2", "Ramos", "" },
                    { 6, 30, 934985785, "S.Ramos@gmail.com", "Marcelo", "5s12JolyfpPW/omcfJAnfQ==", "med", "3", "Collantes", "" },
                    { 7, 30, 934985785, "S.Ramos@gmail.com", "Felix", "5s12JolyfpPW/omcfJAnfQ==", "med", "4", "Mesa", "" },
                    { 8, 30, 934985785, "S.Ramos@gmail.com", "Paul", "5s12JolyfpPW/omcfJAnfQ==", "med", "5", "Saltos", "" },
                    { 9, 30, 934985785, "S.Ramos@gmail.com", "Ariana", "5s12JolyfpPW/omcfJAnfQ==", "med", "6", "Uga", "" },
                    { 10, 30, 934985785, "S.Ramos@gmail.com", "Melisa", "5s12JolyfpPW/omcfJAnfQ==", "med", "7", "Campusano", "" },
                    { 11, 30, 934985785, "S.Ramos@gmail.com", "Homero", "5s12JolyfpPW/omcfJAnfQ==", "med", "1", "Salguero", "" },
                    { 12, 30, 934985785, "S.Ramos@gmail.com", "Susana", "5s12JolyfpPW/omcfJAnfQ==", "med", "1", "Mesa", "" },
                    { 13, 30, 934985785, "S.Ramos@gmail.com", "Francisco", "5s12JolyfpPW/omcfJAnfQ==", "med", "1", "Comarca", "" },
                    { 14, 30, 934985785, "S.Ramos@gmail.com", "Favio", "5s12JolyfpPW/omcfJAnfQ==", "med", "1", "Flor", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "TokenRecovery",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Speciality_id" },
                values: new object[] { "password", "0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Speciality_id" },
                values: new object[] { "password", "0" });
        }
    }
}
