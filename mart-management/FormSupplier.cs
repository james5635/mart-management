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
    public partial class FormSupplier : Form
    {
        private Supplier _currentSupplier;
        public FormSupplier()
        {
            InitializeComponent();
            ReadSupplier();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtSupplierName.Clear();
            TxtContactPerson.Clear();
            TxtPhone.Clear();
            TxtEmail.Clear();
            TxtAddress.Clear();
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();

            db.Add(new Supplier
            {
                SupplierName = TxtSupplierName.Text,
                ContactPerson = TxtContactPerson.Text,
                Phone = TxtPhone.Text,
                Email = TxtEmail.Text,
                Address = TxtAddress.Text

            });
            await db.SaveChangesAsync();
            MessageBox.Show("Supplier Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnClear_Click(null!, null!);

            ReadSupplier();
        }
        private void ReadSupplier()
        {
            using var db = new MartManagementContext();
            var suppliers = db.Suppliers.ToList().Select(s => new
            {
                s.SupplierID,
                s.SupplierName,
                s.ContactPerson,
                s.Phone,
                s.Email,
                s.Address
            }).ToList();
            DgvSupplier.DataSource = suppliers;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvSupplier.CurrentRow;
            if (selectedRow != null)
            {
                int supplierId = (int)selectedRow.Cells["SupplierID"].Value;
                var supplier = db.Suppliers.Find(supplierId);
                if (supplier != null)
                {
                    TxtSupplierName.Text = supplier.SupplierName;
                    TxtContactPerson.Text = supplier.ContactPerson;
                    TxtPhone.Text = supplier.Phone;
                    TxtEmail.Text = supplier.Email;
                    TxtAddress.Text = supplier.Address;
                }
                _currentSupplier = supplier;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentSupplier == null)
            {
                MessageBox.Show("Please select a supplier to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = new MartManagementContext();

            _currentSupplier.SupplierName = TxtSupplierName.Text;
            _currentSupplier.ContactPerson = TxtContactPerson.Text;
            _currentSupplier.Phone = TxtPhone.Text;
            _currentSupplier.Email = TxtEmail.Text;
            _currentSupplier.Address = TxtAddress.Text;

            db.Suppliers.Update(_currentSupplier);
            await db.SaveChangesAsync();
            MessageBox.Show("Supplier Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _currentSupplier = null!;
            BtnClear_Click(null!, null!);

            ReadSupplier();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvSupplier.CurrentRow;
            if (selectedRow != null)
            {
                int supplierId = (int)selectedRow.Cells["SupplierID"].Value;
                var supplier = db.Suppliers.Find(supplierId);
                if (supplier != null)
                {
                    db.Suppliers.Remove(supplier);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Supplier Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadSupplier();
                }
            }
        }
    }
}
