using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mart_management.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedRealWorldData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9,
                column: "PasswordHash",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10,
                column: "PasswordHash",
                value: "password");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==");
        }
    }
}
