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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mart_management
{
    public partial class FormProduct : Form
    {
        private Product? _currentProduct;

        public FormProduct()
        {
            InitializeComponent();

            ReadCategoryId();
            ReadProduct();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtProductName.Clear();
            CboCategoryID.Text = null;
            TxtCategoryName.Clear();
            TxtUnitPrice.Clear();
            TxtCostPrice.Clear();
            TxtUnit.Clear();
            TxtReorderLevel.Clear();
            TxtStatus.Clear();
        }
        private void ReadCategoryId()
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var categories = db.Categories.Select(c => new
            {
                c.CategoryID,
                c.CategoryName
            }).ToList();
            CboCategoryID.DataSource = categories;
            CboCategoryID.DisplayMember = "CategoryID";
            CboCategoryID.ValueMember = "CategoryName";
            CboCategoryID.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCategoryID.Text = null;
        }

        private void CboCategoryID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtCategoryName.Text = CboCategoryID.SelectedValue.ToString();
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            // SINGLETON PATTERN: Use DatabaseManager
            using var db = DatabaseManager.Instance.CreateContext();

            // BUILDER PATTERN: Construct product step-by-step
            var product = new ProductBuilder()
                .SetName(TxtProductName.Text)
                .SetCategory(int.Parse(CboCategoryID.Text))
                .SetPricing(double.Parse(TxtUnitPrice.Text), double.Parse(TxtCostPrice.Text))
                .SetUnit(TxtUnit.Text)
                .SetReorderLevel(int.Parse(TxtReorderLevel.Text))
                .SetStatus(TxtStatus.Text)
                .Build();

            db.Add(product);
            await db.SaveChangesAsync();
            MessageBox.Show("Product Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnClear_Click(null!, null!);

            ReadCategoryId();
            ReadProduct();
        }

        private void ReadProduct()
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var products = db.Products.Include(p => p.Category).ToList().Select(p => new
            {
                p.ProductID,
                p.ProductName,
                p.CategoryID,
                p.Category.CategoryName,
                p.UnitPrice,
                p.CostPrice,
                p.Unit,
                p.ReorderLevel,
                p.Status,
            }).ToList();
            DgvProduct.DataSource = products;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var selectedRow = DgvProduct.CurrentRow;
            if (selectedRow != null)
            {
                int productId = (int)selectedRow.Cells["ProductID"].Value;
                var product = db.Products.Include(p => p.Category)
                    .FirstOrDefault(p => p.ProductID == productId);
                if (product != null)
                {
                    TxtProductName.Text = product.ProductName;
                    CboCategoryID.Text = product.CategoryID.ToString();
                    TxtCategoryName.Text = product.Category.CategoryName;
                    TxtUnitPrice.Text = product.UnitPrice.ToString();
                    TxtCostPrice.Text = product.CostPrice.ToString();
                    TxtUnit.Text = product.Unit;
                    TxtReorderLevel.Text = product.ReorderLevel.ToString();
                    TxtStatus.Text = product.Status;
                }
                _currentProduct = product;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (_currentProduct == null)
            {
                MessageBox.Show("Please select a product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = DatabaseManager.Instance.CreateContext();

            _currentProduct.ProductName = TxtProductName.Text;
            _currentProduct.CategoryID = int.Parse(CboCategoryID.Text);
            _currentProduct.UnitPrice = double.Parse(TxtUnitPrice.Text);
            _currentProduct.CostPrice = double.Parse(TxtCostPrice.Text);
            _currentProduct.Unit = TxtUnit.Text;
            _currentProduct.ReorderLevel = int.Parse(TxtReorderLevel.Text);
            _currentProduct.Status = TxtStatus.Text;

            db.Products.Update(_currentProduct);
            await db.SaveChangesAsync();
            MessageBox.Show("Product Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _currentProduct = null!;
            BtnClear_Click(null!, null!);

            ReadCategoryId();
            ReadProduct();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var selectedRow = DgvProduct.CurrentRow;
            if (selectedRow != null)
            {
                int productId = (int)selectedRow.Cells["ProductID"].Value;
                var product = db.Products.Find(productId);
                if (product != null)
                {
                    db.Products.Remove(product);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Product Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadCategoryId();
                    ReadProduct();
                }
            }
        }
    }
}
