
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace mart_management
{
    public partial class FormEmployee : Form
    {
        private Employee? _currentEmployee;

        public FormEmployee()
        {
            InitializeComponent();
            ReadEmployee();
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtFullName.Clear();
            TxtRole.Clear();
            TxtPhone.Clear();
            TxtEmail.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();

            db.Add(new Employee
            {
                FullName = TxtFullName.Text,
                Role = TxtRole.Text,
                Phone = TxtPhone.Text,
                Email = TxtEmail.Text,
                Username = TxtUsername.Text,
                PasswordHash = new PasswordHasher<object>().HashPassword(null, TxtPassword.Text)
            });
            await db.SaveChangesAsync();
            MessageBox.Show("Employee Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnClear_Click(null!, null!);

            ReadEmployee();
        }

        private void ReadEmployee()
        {
            using var db = new MartManagementContext();
            var employees = db.Employees.ToList().Select(e => new
            {
                e.EmployeeID,
                e.FullName,
                e.Role,
                e.Phone,
                e.Email,
                e.Username,
                e.PasswordHash

            }).ToList();
            DgvEmployee.DataSource = employees;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvEmployee.CurrentRow;
            if (selectedRow != null)
            {
                int employeeId = (int)selectedRow.Cells["EmployeeID"].Value;
                var employee = db.Employees.Find(employeeId);
                if (employee != null)
                {
                    TxtFullName.Text = employee.FullName;
                    TxtRole.Text = employee.Role;
                    TxtPhone.Text = employee.Phone;
                    TxtEmail.Text = employee.Email;
                    TxtUsername.Text = employee.Username;
                    TxtPassword.Text = null;
                }
                _currentEmployee = employee;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentEmployee == null)
            {
                MessageBox.Show("Please select a employee to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = new MartManagementContext();

            _currentEmployee.FullName = TxtFullName.Text;
            _currentEmployee.Role = TxtRole.Text;
            _currentEmployee.Phone = TxtPhone.Text;
            _currentEmployee.Email = TxtEmail.Text;
            _currentEmployee.Username = TxtUsername.Text;
            _currentEmployee.PasswordHash = new PasswordHasher<object>().HashPassword(null, TxtPassword.Text);


            db.Employees.Update(_currentEmployee);
            await db.SaveChangesAsync();
            MessageBox.Show("Employee Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _currentEmployee = null!;
            BtnClear_Click(null!, null!);

            ReadEmployee();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvEmployee.CurrentRow;
            if (selectedRow != null)
            {
                int employeeId = (int)selectedRow.Cells["EmployeeID"].Value;
                var employee = db.Employees.Find(employeeId);
                if (employee != null)
                {
                    db.Employees.Remove(employee);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Employee Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadEmployee();
                }
            }
        }
    }
}
