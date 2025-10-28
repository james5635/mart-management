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
    public partial class FormCategory : Form
    {

        private Category _currentCategory;

        public FormCategory()
        {
            InitializeComponent();
            ReadCategory();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCategoryName.Clear();
            TxtDescription.Clear();
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();

            db.Add(new Category
            {
                CategoryName = TxtCategoryName.Text,
                Description = TxtDescription.Text
            });
            await db.SaveChangesAsync();
            MessageBox.Show("Category Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            TxtCategoryName.Clear();
            TxtDescription.Clear();

            ReadCategory();
        }
        private void ReadCategory()
        {
            using var db = new MartManagementContext();
            var categories = db.Categories.ToList().Select(c => new
            {
                c.CategoryID,
                c.CategoryName,
                c.Description
            }).ToList();
            DgvCategory.DataSource = categories;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvCategory.CurrentRow;
            if (selectedRow != null)
            {
                int categoryId = (int)selectedRow.Cells["CategoryID"].Value;
                var category = db.Categories.Find(categoryId);
                if (category != null)
                {
                    TxtCategoryName.Text = category.CategoryName;
                    TxtDescription.Text = category.Description;
                }
                _currentCategory = category;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentCategory == null)
            {
                MessageBox.Show("Please select a category to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = new MartManagementContext();

            _currentCategory.CategoryName = TxtCategoryName.Text;
            _currentCategory.Description = TxtDescription.Text;

            db.Categories.Update(_currentCategory);
            await db.SaveChangesAsync();
            MessageBox.Show("Category Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _currentCategory = null!;
            TxtCategoryName.Clear();
            TxtDescription.Clear();

            ReadCategory();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvCategory.CurrentRow;
            if (selectedRow != null)
            {
                int categoryId = (int)selectedRow.Cells["CategoryID"].Value;
                var category = db.Categories.Find(categoryId);
                if (category != null)
                {
                    db.Categories.Remove(category);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Category Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadCategory();
                }
            }
        }
    }
}
