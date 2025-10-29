using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mart_management
{
    public partial class FormCustomer : Form
    {
        private Customer _currentCustomer;
        public FormCustomer()
        {
            InitializeComponent();
            ReadCustomer();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCustomerName.Clear();
            TxtPhone.Clear();
            TxtEmail.Clear();
            TxtAddress.Clear();
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();

            db.Add(new Customer
            {
                CustomerName = TxtCustomerName.Text,
                Phone = TxtPhone.Text,
                Email = TxtEmail.Text,
                Address = TxtAddress.Text
            });
            await db.SaveChangesAsync();
            MessageBox.Show("Customer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnClear_Click(null!, null!);

            ReadCustomer();
        }
        private void ReadCustomer()
        {
            using var db = new MartManagementContext();
            var customers = db.Customers.ToList().Select(c => new
            {
                c.CustomerID,
                c.CustomerName,
                c.Phone,
                c.Email,
                c.Address
            }).ToList();
            DgvCustomer.DataSource = customers;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvCustomer.CurrentRow;
            if (selectedRow != null)
            {
                int customerId = (int)selectedRow.Cells["CustomerID"].Value;
                var customer = db.Customers.Find(customerId);
                if (customer != null)
                {
                    TxtCustomerName.Text = customer.CustomerName;
                    TxtPhone.Text = customer.Phone;
                    TxtEmail.Text = customer.Email;
                    TxtAddress.Text = customer.Address;
                }
                _currentCustomer = customer;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = new MartManagementContext();

            _currentCustomer.CustomerName = TxtCustomerName.Text;
            _currentCustomer.Phone = TxtPhone.Text;
            _currentCustomer.Email = TxtEmail.Text;
            _currentCustomer.Address = TxtAddress.Text;

            db.Customers.Update(_currentCustomer);
            await db.SaveChangesAsync();
            MessageBox.Show("Customer Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _currentCustomer = null!;
            BtnClear_Click(null!, null!);

            ReadCustomer();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvCustomer.CurrentRow;
            if (selectedRow != null)
            {
                int customerId = (int)selectedRow.Cells["CustomerID"].Value;
                var customer = db.Customers.Find(customerId);
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Customer Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadCustomer();
                }
            }
        }
    }
}
