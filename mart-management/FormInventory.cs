using Microsoft.EntityFrameworkCore;
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
    public partial class FormInventory : Form
    {
        private Inventory? _currentInventory;

        public FormInventory()
        {
            InitializeComponent();

            ReadProductId();
            ReadInventory();
        }



        private void BtnClear_Click(object sender, EventArgs e)
        {
            CboProductID.Text = null;
            TxtProductName.Clear();
            TxtQuantityInStock.Clear();
        }
        private void ReadProductId()
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var inventories = db.Inventories.ToList();
            var products = db.Products
                .Where(p => !db.Inventories.Any(i => i.ProductID == p.ProductID))
                .ToList()
                .Select(p => new
                {
                    p.ProductID,
                    p.ProductName
                }).ToList();

            CboProductID.DataSource = products;
            CboProductID.DisplayMember = "ProductID";
            CboProductID.ValueMember = "ProductName";
            CboProductID.Text = null;
            CboProductID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = DatabaseManager.Instance.CreateContext();

            db.Add(new Inventory
            {
                ProductID = int.Parse(CboProductID.Text),
                QuantityInStock = int.Parse(TxtQuantityInStock.Text)

            });
            await db.SaveChangesAsync();
            MessageBox.Show("Inventory Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnClear_Click(null!, null!);

            ReadProductId();
            ReadInventory();
        }
        private void ReadInventory()
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var inventories = db.Inventories.Include(i => i.Product)
                .ToList().Select(i => new
                {
                    i.ProductID,
                    i.Product.ProductName,
                    i.QuantityInStock
                }).ToList();
            DgvInventory.DataSource = inventories;
        }

        private void CboProductID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtProductName.Text = CboProductID.SelectedValue.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var selectedRow = DgvInventory.CurrentRow;
            if (selectedRow != null)
            {
                int productId = (int)selectedRow.Cells["ProductID"].Value;
                var inventory = db.Inventories.Include(i => i.Product)
                    .FirstOrDefault(i => i.ProductID == productId);

                if (inventory != null)
                {
                    CboProductID.DataSource = db.Inventories
                        .Where(i => i.ProductID == inventory.ProductID)
                        .ToList()
                        .Select(i => new
                        {
                            i.ProductID,
                            i.Product.ProductName
                        }).ToList();
                    CboProductID.DisplayMember = "ProductID";
                    CboProductID.ValueMember = "ProductName";
                    CboProductID.Text = $"{inventory.ProductID}";
                    TxtProductName.Text = inventory.Product.ProductName;
                    TxtQuantityInStock.Text = inventory.QuantityInStock.ToString();
                }
                _currentInventory = inventory;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentInventory == null)
            {
                MessageBox.Show("Please select a inventory to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = DatabaseManager.Instance.CreateContext();

            _currentInventory.ProductID = int.Parse(CboProductID.Text);
            _currentInventory.QuantityInStock = int.Parse(TxtQuantityInStock.Text);

            db.Inventories.Update(_currentInventory);
            await db.SaveChangesAsync();
            MessageBox.Show("Inventory Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _currentInventory = null!;
            BtnClear_Click(null!, null!);

            ReadProductId();
            ReadInventory();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var selectedRow = DgvInventory.CurrentRow;
            if (selectedRow != null)
            {
                int productId = (int)selectedRow.Cells["ProductID"].Value;
                var inventory = db.Inventories.Find(productId);
                if (inventory != null)
                {
                    db.Inventories.Remove(inventory);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Inventory Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadProductId();
                    ReadInventory();
                }
            }
        }
    }
}
