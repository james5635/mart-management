using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mart_management
{
    public class MartManagementContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payements { get; set; }
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
