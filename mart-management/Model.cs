using Microsoft.EntityFrameworkCore;
namespace mart_management
{

    public class MartManagementContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

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

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }


}
