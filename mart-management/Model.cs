using mart_management;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Schema;
namespace mart_management
{
    public class MartManagementContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        public string DbPath { get; }
        public MartManagementContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "mart_management.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- Seeding Order ---
            // 1. Independent tables: Employee, Customer, Supplier, Category
            // 2. Tables with dependencies: Product (needs Category)
            // 3. Inventory (needs Product)
            // 4. Purchase (needs Supplier)
            // 5. PurchaseDetail (needs Purchase, Product)
            // 6. Sale (needs Customer)
            // 7. SaleDetail (needs Sale, Product)
            // 8. Payment (needs Sale)
            // NOTE: For simplicity, a placeholder hash is used. 
            // In a real app, generate this with a password hasher.
            var placeholderHash = @"AQAAAAIAAYagAAAAEK45ThnVIMswRknV65zQCSHCGviFjMkuSj2cpYtEDfe/kJJTUe5U0JrSqwVMjsFqSw=="; // Example hash

            // 1. Employee
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = 1, FullName = "Alice Smith", Role = "Administrator", Phone = "555-0101", Email = "alice@shop.com", Username = "alice", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 2, FullName = "Bob Johnson", Role = "Saler", Phone = "555-0102", Email = "bob@shop.com", Username = "bob", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 3, FullName = "Charlie Brown", Role = "Purchaser", Phone = "555-0103", Email = "charlie@shop.com", Username = "charlie", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 4, FullName = "Dana White", Role = "Saler", Phone = "555-0104", Email = "dana@shop.com", Username = "dana", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 5, FullName = "Eve Davis", Role = "Purchaser", Phone = "555-0105", Email = "eve@shop.com", Username = "eve", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 6, FullName = "Frank Miller", Role = "Administrator", Phone = "555-0106", Email = "frank@shop.com", Username = "frank", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 7, FullName = "Grace Lee", Role = "Saler", Phone = "555-0107", Email = "grace@shop.com", Username = "grace", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 8, FullName = "Heidi Chen", Role = "Saler", Phone = "555-0108", Email = "heidi@shop.com", Username = "heidi", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 9, FullName = "Ivan Garcia", Role = "HR", Phone = "555-0109", Email = "ivan@shop.com", Username = "ivan", PasswordHash = placeholderHash },
                new Employee { EmployeeID = 10, FullName = "Judy Kim", Role = "Purchaser", Phone = "555-0110", Email = "judy@shop.com", Username = "judy", PasswordHash = placeholderHash }
            );

            // 1. Customer
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, CustomerName = "Liam Wilson", Phone = "555-0201", Email = "liam@mail.com", Address = "123 Main St" },
                new Customer { CustomerID = 2, CustomerName = "Olivia Moore", Phone = "555-0202", Email = "olivia@mail.com", Address = "456 Oak Ave" },
                new Customer { CustomerID = 3, CustomerName = "Noah Taylor", Phone = "555-0203", Email = "noah@mail.com", Address = "789 Pine Ln" },
                new Customer { CustomerID = 4, CustomerName = "Emma Anderson", Phone = "555-0204", Email = "emma@mail.com", Address = "101 Maple Dr" },
                new Customer { CustomerID = 5, CustomerName = "James Thomas", Phone = "555-0205", Email = "james@mail.com", Address = "202 Birch Pl" },
                new Customer { CustomerID = 6, CustomerName = "Sophia Jackson", Phone = "555-0206", Email = "sophia@mail.com", Address = "303 Cedar Rd" },
                new Customer { CustomerID = 7, CustomerName = "William Brown", Phone = "555-0207", Email = "william@mail.com", Address = "404 Elm Ct" },
                new Customer { CustomerID = 8, CustomerName = "Ava Harris", Phone = "555-0208", Email = "ava@mail.com", Address = "505 Spruce Way" },
                new Customer { CustomerID = 9, CustomerName = "Benjamin Martin", Phone = "555-0209", Email = "ben@mail.com", Address = "606 Fir Bvld" },
                new Customer { CustomerID = 10, CustomerName = "Mia Garcia", Phone = "555-0210", Email = "mia@mail.com", Address = "707 Willow Pass" }
            );

            // 1. Supplier
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierID = 1, SupplierName = "Global Foods Inc.", ContactPerson = "Sarah Chen", Phone = "555-0301", Email = "sarah@globalfoods.com", Address = "1 Global Way" },
                new Supplier { SupplierID = 2, SupplierName = "Beverage Co.", ContactPerson = "Mike Rivera", Phone = "555-0302", Email = "mike@bevco.com", Address = "2 Drink Blvd" },
                new Supplier { SupplierID = 3, SupplierName = "Fresh Farms Ltd.", ContactPerson = "Tom Green", Phone = "555-0303", Email = "tom@freshfarms.com", Address = "3 Produce Plaza" },
                new Supplier { SupplierID = 4, SupplierName = "SnackWorld Distributors", ContactPerson = "Lisa Ray", Phone = "555-0304", Email = "lisa@snackworld.com", Address = "4 Chip Circle" },
                new Supplier { SupplierID = 5, SupplierName = "Office Supply Kings", ContactPerson = "David Kim", Phone = "555-0305", Email = "david@officesupply.com", Address = "5 Paper St" },
                new Supplier { SupplierID = 6, SupplierName = "Hometown Bakery", ContactPerson = "Anna Brody", Phone = "555-0306", Email = "anna@hometown.com", Address = "6 Bread Ln" },
                new Supplier { SupplierID = 7, SupplierName = "Dairy Best", ContactPerson = "Paul Chu", Phone = "555-0307", Email = "paul@dairybest.com", Address = "7 Milk Row" },
                new Supplier { SupplierID = 8, SupplierName = "Clean Sweep Solutions", ContactPerson = "Emily White", Phone = "555-0308", Email = "emily@cleansweep.com", Address = "8 Soap Rd" },
                new Supplier { SupplierID = 9, SupplierName = "Tech Distributors", ContactPerson = "Kenji Watanabe", Phone = "555-0309", Email = "kenji@techdist.com", Address = "9 Circuit Ave" },
                new Supplier { SupplierID = 10, SupplierName = "General Goods Co.", ContactPerson = "Rita Patel", Phone = "555-0310", Email = "rita@genco.com", Address = "10 General St" }
            );

            // 1. Category
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Beverages", Description = "Soft drinks, juices, water, etc." },
                new Category { CategoryID = 2, CategoryName = "Produce", Description = "Fresh fruits and vegetables." },
                new Category { CategoryID = 3, CategoryName = "Snacks", Description = "Chips, cookies, candy, etc." },
                new Category { CategoryID = 4, CategoryName = "Dairy & Eggs", Description = "Milk, cheese, yogurt, eggs." },
                new Category { CategoryID = 5, CategoryName = "Bakery", Description = "Fresh bread, pastries." },
                new Category { CategoryID = 6, CategoryName = "Meat & Seafood", Description = "Packaged and fresh meats." },
                new Category { CategoryID = 7, CategoryName = "Pantry", Description = "Canned goods, pasta, sauces." },
                new Category { CategoryID = 8, CategoryName = "Cleaning", Description = "Household cleaning supplies." },
                new Category { CategoryID = 9, CategoryName = "Office", Description = "Paper, pens, and other supplies." },
                new Category { CategoryID = 10, CategoryName = "Electronics", Description = "Batteries, chargers, small gadgets." }
            );

            // 2. Product
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, ProductName = "Cola Can", CategoryID = 1, UnitPrice = 1.50, CostPrice = 0.75, Unit = "330ml Can", ReorderLevel = 50, Status = "Active" },
                new Product { ProductID = 2, ProductName = "Spring Water", CategoryID = 1, UnitPrice = 1.00, CostPrice = 0.40, Unit = "500ml Bottle", ReorderLevel = 50, Status = "Active" },
                new Product { ProductID = 3, ProductName = "Apples (Red)", CategoryID = 2, UnitPrice = 2.99, CostPrice = 1.50, Unit = "kg", ReorderLevel = 20, Status = "Active" },
                new Product { ProductID = 4, ProductName = "Potato Chips", CategoryID = 3, UnitPrice = 3.50, CostPrice = 1.75, Unit = "150g Bag", ReorderLevel = 30, Status = "Active" },
                new Product { ProductID = 5, ProductName = "Milk (Full Cream)", CategoryID = 4, UnitPrice = 2.20, CostPrice = 1.20, Unit = "1L Carton", ReorderLevel = 25, Status = "Active" },
                new Product { ProductID = 6, ProductName = "Sliced Bread", CategoryID = 5, UnitPrice = 2.50, CostPrice = 1.00, Unit = "Loaf", ReorderLevel = 15, Status = "Active" },
                new Product { ProductID = 7, ProductName = "Ground Beef", CategoryID = 6, UnitPrice = 8.99, CostPrice = 5.00, Unit = "500g Pack", ReorderLevel = 10, Status = "Active" },
                new Product { ProductID = 8, ProductName = "All-Purpose Cleaner", CategoryID = 8, UnitPrice = 4.75, CostPrice = 2.50, Unit = "750ml Bottle", ReorderLevel = 20, Status = "Active" },
                new Product { ProductID = 9, ProductName = "A4 Paper Ream", CategoryID = 9, UnitPrice = 5.00, CostPrice = 3.00, Unit = "500 Sheets", ReorderLevel = 10, Status = "Active" },
                new Product { ProductID = 10, ProductName = "AA Batteries", CategoryID = 10, UnitPrice = 6.00, CostPrice = 2.80, Unit = "4-Pack", ReorderLevel = 15, Status = "Inactive" }
            );

            // 3. Inventory
            // This data assumes these are the initial stock levels.
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { ProductID = 1, QuantityInStock = 150 },
                new Inventory { ProductID = 2, QuantityInStock = 200 },
                new Inventory { ProductID = 3, QuantityInStock = 50 },
                new Inventory { ProductID = 4, QuantityInStock = 80 },
                new Inventory { ProductID = 5, QuantityInStock = 60 },
                new Inventory { ProductID = 6, QuantityInStock = 30 },
                new Inventory { ProductID = 7, QuantityInStock = 25 },
                new Inventory { ProductID = 8, QuantityInStock = 50 },
                new Inventory { ProductID = 9, QuantityInStock = 40 },
                new Inventory { ProductID = 10, QuantityInStock = 10 } // Stock for inactive item
            );

            // 4. Purchase
            modelBuilder.Entity<Purchase>().HasData(
                new Purchase { PurchaseID = 1, SupplierID = 1, PurchaseDate = new DateTime(2025, 10, 1), TotalAmount = 112.50 },
                new Purchase { PurchaseID = 2, SupplierID = 3, PurchaseDate = new DateTime(2025, 10, 2), TotalAmount = 75.00 },
                new Purchase { PurchaseID = 3, SupplierID = 4, PurchaseDate = new DateTime(2025, 10, 3), TotalAmount = 140.00 },
                new Purchase { PurchaseID = 4, SupplierID = 7, PurchaseDate = new DateTime(2025, 10, 4), TotalAmount = 72.00 },
                new Purchase { PurchaseID = 5, SupplierID = 6, PurchaseDate = new DateTime(2025, 10, 5), TotalAmount = 30.00 },
                new Purchase { PurchaseID = 6, SupplierID = 10, PurchaseDate = new DateTime(2025, 10, 6), TotalAmount = 125.00 },
                new Purchase { PurchaseID = 7, SupplierID = 8, PurchaseDate = new DateTime(2025, 10, 7), TotalAmount = 125.00 },
                new Purchase { PurchaseID = 8, SupplierID = 5, PurchaseDate = new DateTime(2025, 10, 8), TotalAmount = 120.00 },
                new Purchase { PurchaseID = 9, SupplierID = 9, PurchaseDate = new DateTime(2025, 10, 9), TotalAmount = 28.00 },
                new Purchase { PurchaseID = 10, SupplierID = 2, PurchaseDate = new DateTime(2025, 10, 10), TotalAmount = 80.00 }
            );

            // 5. PurchaseDetail
            // (Quantities * UnitCost must equal Subtotal, and sum of Subtotals must equal Purchase.TotalAmount)
            modelBuilder.Entity<PurchaseDetail>().HasData(
                new PurchaseDetail { PurchaseDetailID = 1, PurchaseID = 1, ProductID = 1, Quantity = 150, UnitCost = 0.75, Subtotal = 112.50 },
                new PurchaseDetail { PurchaseDetailID = 2, PurchaseID = 2, ProductID = 3, Quantity = 50, UnitCost = 1.50, Subtotal = 75.00 },
                new PurchaseDetail { PurchaseDetailID = 3, PurchaseID = 3, ProductID = 4, Quantity = 80, UnitCost = 1.75, Subtotal = 140.00 },
                new PurchaseDetail { PurchaseDetailID = 4, PurchaseID = 4, ProductID = 5, Quantity = 60, UnitCost = 1.20, Subtotal = 72.00 },
                new PurchaseDetail { PurchaseDetailID = 5, PurchaseID = 5, ProductID = 6, Quantity = 30, UnitCost = 1.00, Subtotal = 30.00 },
                new PurchaseDetail { PurchaseDetailID = 6, PurchaseID = 6, ProductID = 7, Quantity = 25, UnitCost = 5.00, Subtotal = 125.00 },
                new PurchaseDetail { PurchaseDetailID = 7, PurchaseID = 7, ProductID = 8, Quantity = 50, UnitCost = 2.50, Subtotal = 125.00 },
                new PurchaseDetail { PurchaseDetailID = 8, PurchaseID = 8, ProductID = 9, Quantity = 40, UnitCost = 3.00, Subtotal = 120.00 },
                new PurchaseDetail { PurchaseDetailID = 9, PurchaseID = 9, ProductID = 10, Quantity = 10, UnitCost = 2.80, Subtotal = 28.00 },
                new PurchaseDetail { PurchaseDetailID = 10, PurchaseID = 10, ProductID = 2, Quantity = 200, UnitCost = 0.40, Subtotal = 80.00 }
            );

            // 6. Sale
            modelBuilder.Entity<Sale>().HasData(
                new Sale { SaleID = 1, CustomerID = 1, SaleDate = new DateTime(2025, 10, 20, 9, 15, 0), TotalAmount = 3.00, PaymentMethod = "Cash" },
                new Sale { SaleID = 2, CustomerID = 2, SaleDate = new DateTime(2025, 10, 20, 10, 30, 0), TotalAmount = 5.98, PaymentMethod = "Card" },
                new Sale { SaleID = 3, CustomerID = 1, SaleDate = new DateTime(2025, 10, 21, 11, 0, 0), TotalAmount = 10.50, PaymentMethod = "Card" },
                new Sale { SaleID = 4, CustomerID = 3, SaleDate = new DateTime(2025, 10, 21, 12, 10, 0), TotalAmount = 5.00, PaymentMethod = "Cash" },
                new Sale { SaleID = 5, CustomerID = null, SaleDate = new DateTime(2025, 10, 22, 14, 5, 0), TotalAmount = 6.00, PaymentMethod = "Cash" }, // Walk-in customer
                new Sale { SaleID = 6, CustomerID = 5, SaleDate = new DateTime(2025, 10, 22, 15, 20, 0), TotalAmount = 5.00, PaymentMethod = "Transfer" },
                new Sale { SaleID = 7, CustomerID = 8, SaleDate = new DateTime(2025, 10, 23, 16, 0, 0), TotalAmount = 4.75, PaymentMethod = "Card" },
                new Sale { SaleID = 8, CustomerID = null, SaleDate = new DateTime(2025, 10, 24, 9, 45, 0), TotalAmount = 6.00, PaymentMethod = "Other" }, // Walk-in customer
                new Sale { SaleID = 9, CustomerID = 10, SaleDate = new DateTime(2025, 10, 24, 10, 10, 0), TotalAmount = 2.99, PaymentMethod = "Cash" },
                new Sale { SaleID = 10, CustomerID = 4, SaleDate = new DateTime(2025, 10, 25, 11, 30, 0), TotalAmount = 4.40, PaymentMethod = "Card" }
            );

            // 7. SaleDetail
            // (Quantities * UnitPrice must equal Subtotal, and sum of Subtotals must equal Sale.TotalAmount)
            modelBuilder.Entity<SaleDetail>().HasData(
                new SaleDetail { SaleDetailID = 1, SaleID = 1, ProductID = 1, Quantity = 2, UnitPrice = 1.50, Subtotal = 3.00 },
                new SaleDetail { SaleDetailID = 2, SaleID = 2, ProductID = 3, Quantity = 2, UnitPrice = 2.99, Subtotal = 5.98 }, // 2kg of apples
                new SaleDetail { SaleDetailID = 3, SaleID = 3, ProductID = 4, Quantity = 3, UnitPrice = 3.50, Subtotal = 10.50 },
                new SaleDetail { SaleDetailID = 4, SaleID = 4, ProductID = 9, Quantity = 1, UnitPrice = 5.00, Subtotal = 5.00 },
                new SaleDetail { SaleDetailID = 5, SaleID = 5, ProductID = 2, Quantity = 6, UnitPrice = 1.00, Subtotal = 6.00 },
                new SaleDetail { SaleDetailID = 6, SaleID = 6, ProductID = 6, Quantity = 2, UnitPrice = 2.50, Subtotal = 5.00 },
                new SaleDetail { SaleDetailID = 7, SaleID = 7, ProductID = 8, Quantity = 1, UnitPrice = 4.75, Subtotal = 4.75 },
                new SaleDetail { SaleDetailID = 8, SaleID = 8, ProductID = 1, Quantity = 4, UnitPrice = 1.50, Subtotal = 6.00 },
                new SaleDetail { SaleDetailID = 9, SaleID = 9, ProductID = 3, Quantity = 1, UnitPrice = 2.99, Subtotal = 2.99 }, // 1kg of apples
                new SaleDetail { SaleDetailID = 10, SaleID = 10, ProductID = 5, Quantity = 2, UnitPrice = 2.20, Subtotal = 4.40 }
            );

            // 8. Payment
            // (Assuming 1 payment per sale, for the full amount, at the time of sale)
            modelBuilder.Entity<Payment>().HasData(
                new Payment { PaymentID = 1, SaleID = 1, PaymentDate = new DateTime(2025, 10, 20, 9, 15, 5), AmountPaid = 3.00, PaymentMethod = "Cash" },
                new Payment { PaymentID = 2, SaleID = 2, PaymentDate = new DateTime(2025, 10, 20, 10, 30, 10), AmountPaid = 5.98, PaymentMethod = "Card" },
                new Payment { PaymentID = 3, SaleID = 3, PaymentDate = new DateTime(2025, 10, 21, 11, 0, 15), AmountPaid = 10.50, PaymentMethod = "Card" },
                new Payment { PaymentID = 4, SaleID = 4, PaymentDate = new DateTime(2025, 10, 21, 12, 10, 5), AmountPaid = 5.00, PaymentMethod = "Cash" },
                new Payment { PaymentID = 5, SaleID = 5, PaymentDate = new DateTime(2025, 10, 22, 14, 5, 10), AmountPaid = 6.00, PaymentMethod = "Cash" },
                new Payment { PaymentID = 6, SaleID = 6, PaymentDate = new DateTime(2025, 10, 22, 15, 20, 30), AmountPaid = 5.00, PaymentMethod = "Transfer" },
                new Payment { PaymentID = 7, SaleID = 7, PaymentDate = new DateTime(2025, 10, 23, 16, 0, 20), AmountPaid = 4.75, PaymentMethod = "Card" },
                new Payment { PaymentID = 8, SaleID = 8, PaymentDate = new DateTime(2025, 10, 24, 9, 45, 10), AmountPaid = 6.00, PaymentMethod = "Other" },
                new Payment { PaymentID = 9, SaleID = 9, PaymentDate = new DateTime(2025, 10, 24, 10, 10, 5), AmountPaid = 2.99, PaymentMethod = "Cash" },
                new Payment { PaymentID = 10, SaleID = 10, PaymentDate = new DateTime(2025, 10, 25, 11, 30, 15), AmountPaid = 4.40, PaymentMethod = "Card" }
            );
        }
    }

    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        public int? CategoryID { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public Category Category { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        [Required]
        public double CostPrice { get; set; }

        public string Unit { get; set; }

        public int ReorderLevel { get; set; } = 0;

        [Required]
        [RegularExpression("Active|Inactive")]
        public string Status { get; set; } = "Active";

        public Inventory Inventory { get; set; }
    }

    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        public string SupplierName { get; set; }

        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
    }

    public class Purchase
    {
        [Key]
        public int PurchaseID { get; set; }

        [Required]
        public int SupplierID { get; set; }

        [ForeignKey(nameof(SupplierID))]
        public Supplier Supplier { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        public double? TotalAmount { get; set; }

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }

    public class PurchaseDetail
    {
        [Key]
        public int PurchaseDetailID { get; set; }

        [Required]
        public int PurchaseID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [ForeignKey(nameof(PurchaseID))]
        public Purchase Purchase { get; set; }

        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double UnitCost { get; set; }

        [Required]
        public double Subtotal { get; set; }
    }

    public class Inventory
    {
        [Key, ForeignKey(nameof(Product))]
        public int ProductID { get; set; }

        [Required]
        public int QuantityInStock { get; set; } = 0;

        public Product Product { get; set; }
    }

    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }

    public class Sale
    {
        [Key]
        public int SaleID { get; set; }

        public int? CustomerID { get; set; }

        [ForeignKey(nameof(CustomerID))]
        public Customer Customer { get; set; }

        [Required]
        public DateTime SaleDate { get; set; } = DateTime.Now;

        public double? TotalAmount { get; set; }

        [Required]
        [RegularExpression("Cash|Card|Transfer|Other")]
        public string PaymentMethod { get; set; }

        public ICollection<SaleDetail> SaleDetails { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }

    public class SaleDetail
    {
        [Key]
        public int SaleDetailID { get; set; }

        [Required]
        public int SaleID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [ForeignKey(nameof(SaleID))]
        public Sale Sale { get; set; }

        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        [Required]
        public double Subtotal { get; set; }
    }

    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [RegularExpression("Admin|Cashier|Stocker")]
        public string Role { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }

    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public int SaleID { get; set; }

        [ForeignKey(nameof(SaleID))]
        public Sale Sale { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        public double AmountPaid { get; set; }

        [Required]
        [RegularExpression("Cash|Card|Transfer|Other")]
        public string PaymentMethod { get; set; }
    }
}

