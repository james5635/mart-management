using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mart_management.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Category 1", "Description for Category 1" },
                    { 2, "Category 2", "Description for Category 2" },
                    { 3, "Category 3", "Description for Category 3" },
                    { 4, "Category 4", "Description for Category 4" },
                    { 5, "Category 5", "Description for Category 5" },
                    { 6, "Category 6", "Description for Category 6" },
                    { 7, "Category 7", "Description for Category 7" },
                    { 8, "Category 8", "Description for Category 8" },
                    { 9, "Category 9", "Description for Category 9" },
                    { 10, "Category 10", "Description for Category 10" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "CustomerName", "Email", "Phone" },
                values: new object[,]
                {
                    { 1, "Customer Address 1", "Customer 1", "customer1@example.com", "0987654301" },
                    { 2, "Customer Address 2", "Customer 2", "customer2@example.com", "0987654302" },
                    { 3, "Customer Address 3", "Customer 3", "customer3@example.com", "0987654303" },
                    { 4, "Customer Address 4", "Customer 4", "customer4@example.com", "0987654304" },
                    { 5, "Customer Address 5", "Customer 5", "customer5@example.com", "0987654305" },
                    { 6, "Customer Address 6", "Customer 6", "customer6@example.com", "0987654306" },
                    { 7, "Customer Address 7", "Customer 7", "customer7@example.com", "0987654307" },
                    { 8, "Customer Address 8", "Customer 8", "customer8@example.com", "0987654308" },
                    { 9, "Customer Address 9", "Customer 9", "customer9@example.com", "0987654309" },
                    { 10, "Customer Address 10", "Customer 10", "customer10@example.com", "0987654310" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "employee1@example.com", "Employee 1", "hash1", "0991234501", "Stocker", "user1" },
                    { 2, "employee2@example.com", "Employee 2", "hash2", "0991234502", "Cashier", "user2" },
                    { 3, "employee3@example.com", "Employee 3", "hash3", "0991234503", "Admin", "user3" },
                    { 4, "employee4@example.com", "Employee 4", "hash4", "0991234504", "Cashier", "user4" },
                    { 5, "employee5@example.com", "Employee 5", "hash5", "0991234505", "Stocker", "user5" },
                    { 6, "employee6@example.com", "Employee 6", "hash6", "0991234506", "Admin", "user6" },
                    { 7, "employee7@example.com", "Employee 7", "hash7", "0991234507", "Stocker", "user7" },
                    { 8, "employee8@example.com", "Employee 8", "hash8", "0991234508", "Cashier", "user8" },
                    { 9, "employee9@example.com", "Employee 9", "hash9", "0991234509", "Admin", "user9" },
                    { 10, "employee10@example.com", "Employee 10", "hash10", "0991234510", "Cashier", "user10" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { 1, "Address 1", "Contact 1", "supplier1@example.com", "0123456701", "Supplier 1" },
                    { 2, "Address 2", "Contact 2", "supplier2@example.com", "0123456702", "Supplier 2" },
                    { 3, "Address 3", "Contact 3", "supplier3@example.com", "0123456703", "Supplier 3" },
                    { 4, "Address 4", "Contact 4", "supplier4@example.com", "0123456704", "Supplier 4" },
                    { 5, "Address 5", "Contact 5", "supplier5@example.com", "0123456705", "Supplier 5" },
                    { 6, "Address 6", "Contact 6", "supplier6@example.com", "0123456706", "Supplier 6" },
                    { 7, "Address 7", "Contact 7", "supplier7@example.com", "0123456707", "Supplier 7" },
                    { 8, "Address 8", "Contact 8", "supplier8@example.com", "0123456708", "Supplier 8" },
                    { 9, "Address 9", "Contact 9", "supplier9@example.com", "0123456709", "Supplier 9" },
                    { 10, "Address 10", "Contact 10", "supplier10@example.com", "0123456710", "Supplier 10" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Status", "Unit", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 2, 9.0, "Product 1", 5, "Active", "pcs", 11.0 },
                    { 2, 3, 10.0, "Product 2", 5, "Active", "pcs", 12.0 },
                    { 3, 4, 11.0, "Product 3", 5, "Active", "pcs", 13.0 },
                    { 4, 5, 12.0, "Product 4", 5, "Active", "pcs", 14.0 },
                    { 5, 6, 13.0, "Product 5", 5, "Active", "pcs", 15.0 },
                    { 6, 7, 14.0, "Product 6", 5, "Active", "pcs", 16.0 },
                    { 7, 8, 15.0, "Product 7", 5, "Active", "pcs", 17.0 },
                    { 8, 9, 16.0, "Product 8", 5, "Active", "pcs", 18.0 },
                    { 9, 10, 17.0, "Product 9", 5, "Active", "pcs", 19.0 },
                    { 10, 1, 18.0, "Product 10", 5, "Active", "pcs", 20.0 }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseID", "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 28, 3, 31, 1, 143, DateTimeKind.Local).AddTicks(7248), 1, 101.0 },
                    { 2, new DateTime(2025, 10, 27, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6226), 2, 102.0 },
                    { 3, new DateTime(2025, 10, 26, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6426), 3, 103.0 },
                    { 4, new DateTime(2025, 10, 25, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6440), 4, 104.0 },
                    { 5, new DateTime(2025, 10, 24, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6446), 5, 105.0 },
                    { 6, new DateTime(2025, 10, 23, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6476), 6, 106.0 },
                    { 7, new DateTime(2025, 10, 22, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6495), 7, 107.0 },
                    { 8, new DateTime(2025, 10, 21, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6501), 8, 108.0 },
                    { 9, new DateTime(2025, 10, 20, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6507), 9, 109.0 },
                    { 10, new DateTime(2025, 10, 19, 3, 31, 1, 149, DateTimeKind.Local).AddTicks(6517), 10, 110.0 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleID", "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, "Cash", new DateTime(2025, 10, 28, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(2744), 201.0 },
                    { 2, 2, "Cash", new DateTime(2025, 10, 27, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6659), 202.0 },
                    { 3, 3, "Cash", new DateTime(2025, 10, 26, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6684), 203.0 },
                    { 4, 4, "Cash", new DateTime(2025, 10, 25, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6697), 204.0 },
                    { 5, 5, "Cash", new DateTime(2025, 10, 24, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6709), 205.0 },
                    { 6, 6, "Cash", new DateTime(2025, 10, 23, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6742), 206.0 },
                    { 7, 7, "Cash", new DateTime(2025, 10, 22, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6751), 207.0 },
                    { 8, 8, "Cash", new DateTime(2025, 10, 21, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6759), 208.0 },
                    { 9, 9, "Cash", new DateTime(2025, 10, 20, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6768), 209.0 },
                    { 10, 10, "Cash", new DateTime(2025, 10, 19, 3, 31, 1, 154, DateTimeKind.Local).AddTicks(6780), 210.0 }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "ProductID", "QuantityInStock" },
                values: new object[,]
                {
                    { 1, 51 },
                    { 2, 52 },
                    { 3, 53 },
                    { 4, 54 },
                    { 5, 55 },
                    { 6, 56 },
                    { 7, 57 },
                    { 8, 58 },
                    { 9, 59 },
                    { 10, 60 }
                });

            migrationBuilder.InsertData(
                table: "Payements",
                columns: new[] { "PaymentID", "AmountPaid", "PaymentDate", "PaymentMethod", "SaleID" },
                values: new object[,]
                {
                    { 1, 101.0, new DateTime(2025, 10, 28, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(7972), "Cash", 1 },
                    { 2, 102.0, new DateTime(2025, 10, 27, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9540), "Cash", 2 },
                    { 3, 103.0, new DateTime(2025, 10, 26, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9549), "Cash", 3 },
                    { 4, 104.0, new DateTime(2025, 10, 25, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9554), "Cash", 4 },
                    { 5, 105.0, new DateTime(2025, 10, 24, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9559), "Cash", 5 },
                    { 6, 106.0, new DateTime(2025, 10, 23, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9577), "Cash", 6 },
                    { 7, 107.0, new DateTime(2025, 10, 22, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9727), "Cash", 7 },
                    { 8, 108.0, new DateTime(2025, 10, 21, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9735), "Cash", 8 },
                    { 9, 109.0, new DateTime(2025, 10, 20, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9740), "Cash", 9 },
                    { 10, 110.0, new DateTime(2025, 10, 19, 3, 31, 1, 156, DateTimeKind.Local).AddTicks(9749), "Cash", 10 }
                });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailID", "ProductID", "PurchaseID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[,]
                {
                    { 1, 1, 1, 11, 99.0, 9.0 },
                    { 2, 2, 2, 12, 120.0, 10.0 },
                    { 3, 3, 3, 13, 143.0, 11.0 },
                    { 4, 4, 4, 14, 168.0, 12.0 },
                    { 5, 5, 5, 15, 195.0, 13.0 },
                    { 6, 6, 6, 16, 224.0, 14.0 },
                    { 7, 7, 7, 17, 255.0, 15.0 },
                    { 8, 8, 8, 18, 288.0, 16.0 },
                    { 9, 9, 9, 19, 323.0, 17.0 },
                    { 10, 10, 10, 20, 360.0, 18.0 }
                });

            migrationBuilder.InsertData(
                table: "SaleDetails",
                columns: new[] { "SaleDetailID", "ProductID", "Quantity", "SaleID", "Subtotal", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 3, 1, 48.0, 16.0 },
                    { 2, 2, 4, 2, 68.0, 17.0 },
                    { 3, 3, 5, 3, 90.0, 18.0 },
                    { 4, 4, 6, 4, 114.0, 19.0 },
                    { 5, 5, 7, 5, 140.0, 20.0 },
                    { 6, 6, 8, 6, 168.0, 21.0 },
                    { 7, 7, 9, 7, 198.0, 22.0 },
                    { 8, 8, 10, 8, 230.0, 23.0 },
                    { 9, 9, 11, 9, 264.0, 24.0 },
                    { 10, 10, 12, 10, 300.0, 25.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Payements",
                keyColumn: "PaymentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 10);
        }
    }
}
