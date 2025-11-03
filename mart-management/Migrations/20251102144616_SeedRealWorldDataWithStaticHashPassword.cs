using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mart_management.Migrations
{
    /// <inheritdoc />
    public partial class SeedRealWorldDataWithStaticHashPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Administrator", "alice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Saler", "bob" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Purchaser", "charlie" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Saler", "dana" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Purchaser", "eve" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Administrator", "frank" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Saler", "grace" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Saler", "heidi" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "HR", "ivan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw==", "Purchaser", "judy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Admin", "admin_alice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Cashier", "cashier_bob" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Stocker", "stocker_charlie" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Cashier", "cashier_dana" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Stocker", "stocker_eve" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Admin", "admin_frank" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Cashier", "cashier_grace" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Cashier", "cashier_heidi" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Stocker", "stocker_ivan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "PasswordHash", "Role", "Username" },
                values: new object[] { "password", "Stocker", "stocker_judy" });
        }
    }
}
