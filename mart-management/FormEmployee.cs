
using System.Threading.Tasks;

namespace mart_management
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            //Test();
        }
        private async Task Test()
        {
            using var db = new MartManagementContext();
            MessageBox.Show($"Database path: {db.DbPath}");
            db.Add(new Employee
            {
                FullName = "John Doe",
                Role = "Manager",
                Phone = "123-456-7890",
                Email = "Jonh@gmail.com",
                Username = "johndoe",
                PasswordHash = "hashed_password"
            });
            await db.SaveChangesAsync();
        }

    }
}
