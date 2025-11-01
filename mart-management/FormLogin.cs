using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;

namespace mart_management
{
    enum EmployeeRole
    {
        HR,
        Saler,
        Purchaser,
        Administrator
    }
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtEmployeeID.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            string employeeID = TxtEmployeeID.Text.Trim();
            string username = TxtUsername.Text.Trim();
            string password = TxtPassword.Text.Trim();

            if (int.TryParse(employeeID, out _) == false)
            {
                MessageBox.Show("Employee ID must be a number.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var employee = db.Employees.Find(int.Parse(employeeID));

            if (employee == null)
            {
                MessageBox.Show("Employee ID does not exist.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (employee.Username != username || new PasswordHasher<object>()
                .VerifyHashedPassword(null, employee.PasswordHash, password)
                != PasswordVerificationResult.Success)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeRole? role;
            switch (employee.Role)
            {
                case "HR":
                    {
                        role = EmployeeRole.HR;
                        break;
                    }
                case "Saler":
                    {
                        role = EmployeeRole.Saler;
                        break;
                    }
                case "Purchaser":
                    {
                        role = EmployeeRole.Purchaser;
                        break;
                    }
                case "Administrator":
                    {
                        role = EmployeeRole.Administrator;
                        break;
                    }
                default:
                    {
                        role = null;
                        break;
                    }

            }
            if (role == null)
            {
                MessageBox.Show("The employee doesn't have permission", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (role == EmployeeRole.HR)
            {
                var form = new FormStart();

                form.BtnCategory.Enabled = false;
                form.BtnCustomer.Enabled = false;
                form.BtnSupplier.Enabled = false;
                form.BtnPayment.Enabled = false;
                form.BtnSale.Enabled = false;
                form.BtnInventory.Enabled = false;
                form.BtnProduct.Enabled = false;
                form.BtnPurchase.Enabled = false;

                form.Show();
                form.Closed += (s, args) => this.Close();
                this.Hide();
                return;
            }
            if (role == EmployeeRole.Saler)
            {
                var form = new FormStart();

                form.BtnSupplier.Enabled = false;
                form.BtnPurchase.Enabled = false;
                form.BtnInventory.Enabled = false;
                form.BtnCategory.Enabled = false;
                form.BtnEmployee.Enabled = false;

                form.Show();
                form.Closed += (s, args) => this.Close();
                this.Hide();
                return;
            }
            if (role == EmployeeRole.Purchaser)
            {
                var form = new FormStart();

                form.BtnCustomer.Enabled = false;
                form.BtnSale.Enabled = false;
                form.BtnPayment.Enabled = false;
                form.BtnInventory.Enabled = false;
                form.BtnCategory.Enabled = false;
                form.BtnEmployee.Enabled = false;

                form.Show();
                form.Closed += (s, args) => this.Close();
                this.Hide();
                return;
            }
            if (role == EmployeeRole.Administrator)
            {
                var form = new FormStart();

                form.Show();
                form.Closed += (s, args) => this.Close();
                this.Hide();
                return;

            }
        }

    }
}
