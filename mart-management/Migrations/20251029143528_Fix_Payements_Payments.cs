using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mart_management.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Payements_Payments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payements_Sales_SaleID",
                table: "Payements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payements",
                table: "Payements");

            migrationBuilder.RenameTable(
                name: "Payements",
                newName: "Payments");

            migrationBuilder.RenameIndex(
                name: "IX_Payements_SaleID",
                table: "Payments",
                newName: "IX_Payments_SaleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "PaymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Sales_SaleID",
                table: "Payments",
                column: "SaleID",
                principalTable: "Sales",
                principalColumn: "SaleID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Sales_SaleID",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payements");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_SaleID",
                table: "Payements",
                newName: "IX_Payements_SaleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payements",
                table: "Payements",
                column: "PaymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Payements_Sales_SaleID",
                table: "Payements",
                column: "SaleID",
                principalTable: "Sales",
                principalColumn: "SaleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
