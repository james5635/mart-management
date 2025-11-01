using mart_management;
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

            // ---- Seed Categories ----
            modelBuilder.Entity<Category>().HasData(
                Enumerable.Range(1, 10).Select(i => new Category
                {
                    CategoryID = i,
                    CategoryName = $"Category {i}",
                    Description = $"Description for Category {i}"
                })
            );

            // ---- Seed Customers ----
            modelBuilder.Entity<Customer>().HasData(
                Enumerable.Range(1, 10).Select(i => new Customer
                {
                    CustomerID = i,
                    CustomerName = $"Customer {i}",
                    Phone = $"09876543{i:D2}",
                    Email = $"customer{i}@example.com",
                    Address = $"Customer Address {i}"
                })
            );

            // ---- Seed Suppliers ----
            modelBuilder.Entity<Supplier>().HasData(
                Enumerable.Range(1, 10).Select(i => new Supplier
                {
                    SupplierID = i,
                    SupplierName = $"Supplier {i}",
                    ContactPerson = $"Contact {i}",
                    Phone = $"01234567{i:D2}",
                    Email = $"supplier{i}@example.com",
                    Address = $"Address {i}"
                })
            );

            // ---- Seed Products ----
            modelBuilder.Entity<Product>().HasData(
                Enumerable.Range(1, 10).Select(i => new Product
                {
                    ProductID = i,
                    ProductName = $"Product {i}",
                    CategoryID = (i % 10) + 1,
                    UnitPrice = 10 + i,
                    CostPrice = 8 + i,
                    Unit = "pcs",
                    ReorderLevel = 5,
                    Status = "Active"
                })
            );

           

            // ---- Seed Purchases ----
            modelBuilder.Entity<Purchase>().HasData(
                Enumerable.Range(1, 10).Select(i => new Purchase
                {
                    PurchaseID = i,
                    SupplierID = i,
                    PurchaseDate = new DateTime(2024, 01, 01).AddDays(-i),
                    TotalAmount = 100 + i
                })
            );

            // ---- Seed PurchaseDetails ----
            modelBuilder.Entity<PurchaseDetail>().HasData(
                Enumerable.Range(1, 10).Select(i => new PurchaseDetail
                {
                    PurchaseDetailID = i,
                    PurchaseID = i,
                    ProductID = i,
                    Quantity = 10 + i,
                    UnitCost = 8 + i,
                    Subtotal = (10 + i) * (8 + i)
                })
            );

            // ---- Seed Inventory ----
            modelBuilder.Entity<Inventory>().HasData(
                Enumerable.Range(1, 10).Select(i => new Inventory
                {
                    ProductID = i,
                    QuantityInStock = 50 + i
                })
            );

           

            // ---- Seed Sales ----
            modelBuilder.Entity<Sale>().HasData(
                Enumerable.Range(1, 10).Select(i => new Sale
                {
                    SaleID = i,
                    CustomerID = i,
                    SaleDate = new DateTime(2024, 01, 01).AddDays(-i),
                    TotalAmount = 200 + i,
                    PaymentMethod = "Cash"
                })
            );

            // ---- Seed SaleDetails ----
            modelBuilder.Entity<SaleDetail>().HasData(
                Enumerable.Range(1, 10).Select(i => new SaleDetail
                {
                    SaleDetailID = i,
                    SaleID = i,
                    ProductID = i,
                    Quantity = 2 + i,
                    UnitPrice = 15 + i,
                    Subtotal = (2 + i) * (15 + i)
                })
            );

            // ---- Seed Employees ----
            modelBuilder.Entity<Employee>().HasData(
                Enumerable.Range(1, 10).Select(i => new Employee
                {
                    EmployeeID = i,
                    FullName = $"Employee {i}",
                    Role = i % 3 == 0 ? "Admin" : i % 2 == 0 ? "Cashier" : "Stocker",
                    Phone = $"09912345{i:D2}",
                    Email = $"employee{i}@example.com",
                    Username = $"user{i}",
                    PasswordHash = $"hash{i}"
                })
            );

            // ---- Seed Payments ----
            modelBuilder.Entity<Payment>().HasData(
                Enumerable.Range(1, 10).Select(i => new Payment
                {
                    PaymentID = i,
                    SaleID = i,
                    PaymentDate = new DateTime(2024, 01, 01).AddDays(-i),
                    AmountPaid = 100 + i,
                    PaymentMethod = "Cash"
                })
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

