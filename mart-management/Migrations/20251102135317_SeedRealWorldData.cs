using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mart_management.Migrations
{
    /// <inheritdoc />
    public partial class SeedRealWorldData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Beverages", "Soft drinks, juices, water, etc." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Produce", "Fresh fruits and vegetables." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Snacks", "Chips, cookies, candy, etc." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Dairy & Eggs", "Milk, cheese, yogurt, eggs." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bakery", "Fresh bread, pastries." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Meat & Seafood", "Packaged and fresh meats." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Pantry", "Canned goods, pasta, sauces." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Cleaning", "Household cleaning supplies." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Office", "Paper, pens, and other supplies." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Electronics", "Batteries, chargers, small gadgets." });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "123 Main St", "Liam Wilson", "liam@mail.com", "555-0201" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "456 Oak Ave", "Olivia Moore", "olivia@mail.com", "555-0202" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "789 Pine Ln", "Noah Taylor", "noah@mail.com", "555-0203" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "101 Maple Dr", "Emma Anderson", "emma@mail.com", "555-0204" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "202 Birch Pl", "James Thomas", "james@mail.com", "555-0205" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "303 Cedar Rd", "Sophia Jackson", "sophia@mail.com", "555-0206" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "404 Elm Ct", "William Brown", "william@mail.com", "555-0207" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "505 Spruce Way", "Ava Harris", "ava@mail.com", "555-0208" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "606 Fir Bvld", "Benjamin Martin", "ben@mail.com", "555-0209" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "707 Willow Pass", "Mia Garcia", "mia@mail.com", "555-0210" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "alice@shop.com", "Alice Smith", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0101", "Admin", "admin_alice" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "bob@shop.com", "Bob Johnson", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0102", "cashier_bob" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "charlie@shop.com", "Charlie Brown", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0103", "Stocker", "stocker_charlie" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "dana@shop.com", "Dana White", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0104", "cashier_dana" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "eve@shop.com", "Eve Davis", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0105", "stocker_eve" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "frank@shop.com", "Frank Miller", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0106", "admin_frank" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "grace@shop.com", "Grace Lee", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0107", "Cashier", "cashier_grace" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "heidi@shop.com", "Heidi Chen", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0108", "cashier_heidi" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "ivan@shop.com", "Ivan Garcia", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0109", "Stocker", "stocker_ivan" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "judy@shop.com", "Judy Kim", "AQAAAAIAAYagAAAAEAJuJHqDq4wmR+C7aqW3Sc3p89dA+NIQ5VTFmslz+d9GNtVZ9/XlXGOdQJLlQLpX2A==", "555-0110", "Stocker", "stocker_judy" });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "QuantityInStock",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "QuantityInStock",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "QuantityInStock",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "QuantityInStock",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "QuantityInStock",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "QuantityInStock",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "QuantityInStock",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "QuantityInStock",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "QuantityInStock",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "QuantityInStock",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1,
                columns: new[] { "AmountPaid", "PaymentDate" },
                values: new object[] { 3.0, new DateTime(2025, 10, 20, 9, 15, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 2,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 5.9800000000000004, new DateTime(2025, 10, 20, 10, 30, 10, 0, DateTimeKind.Unspecified), "Card" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 3,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 10.5, new DateTime(2025, 10, 21, 11, 0, 15, 0, DateTimeKind.Unspecified), "Card" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 4,
                columns: new[] { "AmountPaid", "PaymentDate" },
                values: new object[] { 5.0, new DateTime(2025, 10, 21, 12, 10, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 5,
                columns: new[] { "AmountPaid", "PaymentDate" },
                values: new object[] { 6.0, new DateTime(2025, 10, 22, 14, 5, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 6,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 5.0, new DateTime(2025, 10, 22, 15, 20, 30, 0, DateTimeKind.Unspecified), "Transfer" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 7,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 4.75, new DateTime(2025, 10, 23, 16, 0, 20, 0, DateTimeKind.Unspecified), "Card" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 8,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 6.0, new DateTime(2025, 10, 24, 9, 45, 10, 0, DateTimeKind.Unspecified), "Other" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 9,
                columns: new[] { "AmountPaid", "PaymentDate" },
                values: new object[] { 2.9900000000000002, new DateTime(2025, 10, 24, 10, 10, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 10,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 4.4000000000000004, new DateTime(2025, 10, 25, 11, 30, 15, 0, DateTimeKind.Unspecified), "Card" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 1, 0.75, "Cola Can", 50, "330ml Can", 1.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 1, 0.40000000000000002, "Spring Water", 50, "500ml Bottle", 1.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 2, 1.5, "Apples (Red)", 20, "kg", 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 3, 1.75, "Potato Chips", 30, "150g Bag", 3.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 4, 1.2, "Milk (Full Cream)", 25, "1L Carton", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 5, 1.0, "Sliced Bread", 15, "Loaf", 2.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 6, 5.0, "Ground Beef", 10, "500g Pack", 8.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 8, 2.5, "All-Purpose Cleaner", 20, "750ml Bottle", 4.75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 9, 3.0, "A4 Paper Ream", 10, "500 Sheets", 5.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Status", "Unit", "UnitPrice" },
                values: new object[] { 10, 2.7999999999999998, "AA Batteries", 15, "Inactive", "4-Pack", 6.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 1,
                columns: new[] { "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 150, 112.5, 0.75 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 2,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 3, 50, 75.0, 1.5 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 3,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 4, 80, 140.0, 1.75 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 4,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 5, 60, 72.0, 1.2 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 5,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 6, 30, 30.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 6,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 7, 25, 125.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 7,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 8, 50, 125.0, 2.5 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 8,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 9, 40, 120.0, 3.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 9,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 10, 10, 28.0, 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 10,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 2, 200, 80.0, 0.40000000000000002 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 1,
                columns: new[] { "PurchaseDate", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 112.5 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 2,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 75.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 3,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 140.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 4,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 72.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 5,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 30.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 6,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 125.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 7,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 125.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 8,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 120.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 9,
                columns: new[] { "PurchaseDate", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 28.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 10,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 80.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 1,
                columns: new[] { "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 2, 3.0, 1.5 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 2,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 3, 2, 5.9800000000000004, 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 3,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 4, 3, 10.5, 3.5 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 4,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 9, 1, 5.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 5,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 2, 6, 6.0, 1.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 6,
                columns: new[] { "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 2, 5.0, 2.5 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 7,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 8, 1, 4.75, 4.75 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 8,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 1, 4, 6.0, 1.5 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 9,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 3, 1, 2.9900000000000002, 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 10,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 5, 2, 4.4000000000000004, 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 1,
                columns: new[] { "SaleDate", "TotalAmount" },
                values: new object[] { new DateTime(2025, 10, 20, 9, 15, 0, 0, DateTimeKind.Unspecified), 3.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 2,
                columns: new[] { "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { "Card", new DateTime(2025, 10, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), 5.9800000000000004 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 3,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 1, "Card", new DateTime(2025, 10, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), 10.5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 4,
                columns: new[] { "CustomerID", "SaleDate", "TotalAmount" },
                values: new object[] { 3, new DateTime(2025, 10, 21, 12, 10, 0, 0, DateTimeKind.Unspecified), 5.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 5,
                columns: new[] { "CustomerID", "SaleDate", "TotalAmount" },
                values: new object[] { null, new DateTime(2025, 10, 22, 14, 5, 0, 0, DateTimeKind.Unspecified), 6.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 6,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 5, "Transfer", new DateTime(2025, 10, 22, 15, 20, 0, 0, DateTimeKind.Unspecified), 5.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 7,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 8, "Card", new DateTime(2025, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 4.75 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 8,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { null, "Other", new DateTime(2025, 10, 24, 9, 45, 0, 0, DateTimeKind.Unspecified), 6.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 9,
                columns: new[] { "CustomerID", "SaleDate", "TotalAmount" },
                values: new object[] { 10, new DateTime(2025, 10, 24, 10, 10, 0, 0, DateTimeKind.Unspecified), 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 10,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 4, "Card", new DateTime(2025, 10, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 1,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "1 Global Way", "Sarah Chen", "sarah@globalfoods.com", "555-0301", "Global Foods Inc." });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 2,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "2 Drink Blvd", "Mike Rivera", "mike@bevco.com", "555-0302", "Beverage Co." });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 3,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "3 Produce Plaza", "Tom Green", "tom@freshfarms.com", "555-0303", "Fresh Farms Ltd." });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 4,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "4 Chip Circle", "Lisa Ray", "lisa@snackworld.com", "555-0304", "SnackWorld Distributors" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 5,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "5 Paper St", "David Kim", "david@officesupply.com", "555-0305", "Office Supply Kings" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 6,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "6 Bread Ln", "Anna Brody", "anna@hometown.com", "555-0306", "Hometown Bakery" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 7,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "7 Milk Row", "Paul Chu", "paul@dairybest.com", "555-0307", "Dairy Best" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 8,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "8 Soap Rd", "Emily White", "emily@cleansweep.com", "555-0308", "Clean Sweep Solutions" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 9,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "9 Circuit Ave", "Kenji Watanabe", "kenji@techdist.com", "555-0309", "Tech Distributors" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 10,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "10 General St", "Rita Patel", "rita@genco.com", "555-0310", "General Goods Co." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 1", "Description for Category 1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 2", "Description for Category 2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 3", "Description for Category 3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 4", "Description for Category 4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 5", "Description for Category 5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 6", "Description for Category 6" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 7", "Description for Category 7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 8", "Description for Category 8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 9", "Description for Category 9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Category 10", "Description for Category 10" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 1", "Customer 1", "customer1@example.com", "0987654301" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 2", "Customer 2", "customer2@example.com", "0987654302" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 3", "Customer 3", "customer3@example.com", "0987654303" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 4", "Customer 4", "customer4@example.com", "0987654304" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 5", "Customer 5", "customer5@example.com", "0987654305" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 6", "Customer 6", "customer6@example.com", "0987654306" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 7", "Customer 7", "customer7@example.com", "0987654307" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 8", "Customer 8", "customer8@example.com", "0987654308" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 9", "Customer 9", "customer9@example.com", "0987654309" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Address", "CustomerName", "Email", "Phone" },
                values: new object[] { "Customer Address 10", "Customer 10", "customer10@example.com", "0987654310" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "employee1@example.com", "Employee 1", "hash1", "0991234501", "Stocker", "user1" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "employee2@example.com", "Employee 2", "hash2", "0991234502", "user2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "employee3@example.com", "Employee 3", "hash3", "0991234503", "Admin", "user3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "employee4@example.com", "Employee 4", "hash4", "0991234504", "user4" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "employee5@example.com", "Employee 5", "hash5", "0991234505", "user5" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "employee6@example.com", "Employee 6", "hash6", "0991234506", "user6" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "employee7@example.com", "Employee 7", "hash7", "0991234507", "Stocker", "user7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Username" },
                values: new object[] { "employee8@example.com", "Employee 8", "hash8", "0991234508", "user8" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "employee9@example.com", "Employee 9", "hash9", "0991234509", "Admin", "user9" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10,
                columns: new[] { "Email", "FullName", "PasswordHash", "Phone", "Role", "Username" },
                values: new object[] { "employee10@example.com", "Employee 10", "hash10", "0991234510", "Cashier", "user10" });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "QuantityInStock",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "QuantityInStock",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "QuantityInStock",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "QuantityInStock",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "QuantityInStock",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "QuantityInStock",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "QuantityInStock",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "QuantityInStock",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "QuantityInStock",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "QuantityInStock",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1,
                columns: new[] { "AmountPaid", "PaymentDate" },
                values: new object[] { 101.0, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 2,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 102.0, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 3,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 103.0, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 4,
                columns: new[] { "AmountPaid", "PaymentDate" },
                values: new object[] { 104.0, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 5,
                columns: new[] { "AmountPaid", "PaymentDate" },
                values: new object[] { 105.0, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 6,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 106.0, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 7,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 107.0, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 8,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 108.0, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 9,
                columns: new[] { "AmountPaid", "PaymentDate" },
                values: new object[] { 109.0, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 10,
                columns: new[] { "AmountPaid", "PaymentDate", "PaymentMethod" },
                values: new object[] { 110.0, new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cash" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 2, 9.0, "Product 1", 5, "pcs", 11.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 3, 10.0, "Product 2", 5, "pcs", 12.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 4, 11.0, "Product 3", 5, "pcs", 13.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 5, 12.0, "Product 4", 5, "pcs", 14.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 6, 13.0, "Product 5", 5, "pcs", 15.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 7, 14.0, "Product 6", 5, "pcs", 16.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 8, 15.0, "Product 7", 5, "pcs", 17.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 9, 16.0, "Product 8", 5, "pcs", 18.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Unit", "UnitPrice" },
                values: new object[] { 10, 17.0, "Product 9", 5, "pcs", 19.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CategoryID", "CostPrice", "ProductName", "ReorderLevel", "Status", "Unit", "UnitPrice" },
                values: new object[] { 1, 18.0, "Product 10", 5, "Active", "pcs", 20.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 1,
                columns: new[] { "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 11, 99.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 2,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 2, 12, 120.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 3,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 3, 13, 143.0, 11.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 4,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 4, 14, 168.0, 12.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 5,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 5, 15, 195.0, 13.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 6,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 6, 16, 224.0, 14.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 7,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 7, 17, 255.0, 15.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 8,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 8, 18, 288.0, 16.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 9,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 9, 19, 323.0, 17.0 });

            migrationBuilder.UpdateData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailID",
                keyValue: 10,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitCost" },
                values: new object[] { 10, 20, 360.0, 18.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 1,
                columns: new[] { "PurchaseDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 101.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 2,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 102.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 3,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 103.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 4,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 104.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 5,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 105.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 6,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 106.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 7,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 107.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 8,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 108.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 9,
                columns: new[] { "PurchaseDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 109.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseID",
                keyValue: 10,
                columns: new[] { "PurchaseDate", "SupplierID", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 110.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 1,
                columns: new[] { "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 3, 48.0, 16.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 2,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 2, 4, 68.0, 17.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 3,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 3, 5, 90.0, 18.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 4,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 4, 6, 114.0, 19.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 5,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 5, 7, 140.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 6,
                columns: new[] { "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 8, 168.0, 21.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 7,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 7, 9, 198.0, 22.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 8,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 8, 10, 230.0, 23.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 9,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 9, 11, 264.0, 24.0 });

            migrationBuilder.UpdateData(
                table: "SaleDetails",
                keyColumn: "SaleDetailID",
                keyValue: 10,
                columns: new[] { "ProductID", "Quantity", "Subtotal", "UnitPrice" },
                values: new object[] { 10, 12, 300.0, 25.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 1,
                columns: new[] { "SaleDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 201.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 2,
                columns: new[] { "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { "Cash", new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 202.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 3,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 3, "Cash", new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 203.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 4,
                columns: new[] { "CustomerID", "SaleDate", "TotalAmount" },
                values: new object[] { 4, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 204.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 5,
                columns: new[] { "CustomerID", "SaleDate", "TotalAmount" },
                values: new object[] { 5, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 205.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 6,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 6, "Cash", new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 206.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 7,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 7, "Cash", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 207.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 8,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 8, "Cash", new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 208.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 9,
                columns: new[] { "CustomerID", "SaleDate", "TotalAmount" },
                values: new object[] { 9, new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleID",
                keyValue: 10,
                columns: new[] { "CustomerID", "PaymentMethod", "SaleDate", "TotalAmount" },
                values: new object[] { 10, "Cash", new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 1,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 1", "Contact 1", "supplier1@example.com", "0123456701", "Supplier 1" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 2,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 2", "Contact 2", "supplier2@example.com", "0123456702", "Supplier 2" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 3,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 3", "Contact 3", "supplier3@example.com", "0123456703", "Supplier 3" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 4,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 4", "Contact 4", "supplier4@example.com", "0123456704", "Supplier 4" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 5,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 5", "Contact 5", "supplier5@example.com", "0123456705", "Supplier 5" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 6,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 6", "Contact 6", "supplier6@example.com", "0123456706", "Supplier 6" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 7,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 7", "Contact 7", "supplier7@example.com", "0123456707", "Supplier 7" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 8,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 8", "Contact 8", "supplier8@example.com", "0123456708", "Supplier 8" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 9,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 9", "Contact 9", "supplier9@example.com", "0123456709", "Supplier 9" });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 10,
                columns: new[] { "Address", "ContactPerson", "Email", "Phone", "SupplierName" },
                values: new object[] { "Address 10", "Contact 10", "supplier10@example.com", "0123456710", "Supplier 10" });
        }
    }
}
