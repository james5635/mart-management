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
    public partial class FormSale : Form
    {
        private Sale? _currentSale;
        private List<SaleDetail> _currentSaleDetails;
        private ListViewItem _currentLvProductItem;

        public FormSale()
        {
            InitializeComponent();

            ReadCustomerId();
            ReadProductId();
            ReadSale();
        }

        private void ReadCustomerId()
        {
            using var db = new MartManagementContext();
            var customers = db.Customers.Select(c => new
            {
                c.CustomerID,
                c.CustomerName
            }).ToList();
            CboCustomerID.DataSource = customers;
            CboCustomerID.DisplayMember = "CustomerID";
            CboCustomerID.ValueMember = "CustomerName";
            CboCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCustomerID.Text = null;

        }

        private void ReadProductId()
        {
            using var db = new MartManagementContext();
            var products = db.Products.Select(p => new
            {
                p.ProductID,
                p.ProductName
            }).ToList();
            CboProductID.DataSource = products;
            CboProductID.DisplayMember = "ProductID";
            CboProductID.ValueMember = "ProductName";
            CboProductID.DropDownStyle = ComboBoxStyle.DropDownList;
            CboProductID.Text = null;
        }
        private void CboCustomerID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtCustomerName.Text = CboCustomerID.SelectedValue.ToString();
        }

        private void CboProductID_SelectionChangeCommitted(object sender, EventArgs e)
        {

            TxtProductName.Text = CboProductID.SelectedValue.ToString();
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtQuantity.Text, out int quantity) && double.TryParse(TxtUnitPrice.Text, out double unitPrice))
            {
                double subtotal = quantity * unitPrice;
                TxtSubtotal.Text = subtotal.ToString("F2");
            }
            else
            {
                TxtSubtotal.Clear();
            }
        }

        private void TxtUnitPrice_TextChanged(object sender, EventArgs e)
        {

            TxtQuantity_TextChanged(null!, null!);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CboCustomerID.Text = null;
            TxtCustomerName.Clear();
            DtpSaleDate.Value = DateTime.Now;
            TxtPaymentMethod.Clear();

            CboProductID.Text = null;
            TxtProductName.Clear();
            TxtQuantity.Clear();
            TxtUnitPrice.Clear();
            TxtSubtotal.Clear();

            LvProduct.Columns.Clear();
            LvProduct.Items.Clear();
        }


        private void BtnAddProduct_Click(object sender, EventArgs e)
        {

            if (LvProduct.Columns.Count == 0)
            {
                // Add columns
                LvProduct.Columns.Add(LblProductID.Text, 150);
                LvProduct.Columns.Add(LblProductName.Text, 100);
                LvProduct.Columns.Add(LblQuantity.Text, 100);
                LvProduct.Columns.Add(LblUnitPrice.Text, 100);
                LvProduct.Columns.Add(LblSubtotal.Text, 100);
            }

            // Create and add items
            ListViewItem product = new ListViewItem(CboProductID.Text);
            product.SubItems.Add(TxtProductName.Text);
            product.SubItems.Add(TxtQuantity.Text);
            product.SubItems.Add(TxtUnitPrice.Text);
            product.SubItems.Add(TxtSubtotal.Text);
            LvProduct.Items.Add(product);
        }
        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();

            var sale = db.Add(new Sale
            {
                CustomerID = int.Parse(CboCustomerID.Text),
                SaleDate = DtpSaleDate.Value,
                TotalAmount = LvProduct.Items.Cast<ListViewItem>().Sum(item => double.Parse(item.SubItems[4].Text)),
                PaymentMethod = TxtPaymentMethod.Text,
            });
            await db.SaveChangesAsync();

            foreach (ListViewItem item in LvProduct.Items)
            {
                db.Add(new SaleDetail
                {
                    SaleID = sale.Entity.SaleID,
                    ProductID = int.Parse(item.SubItems[0].Text),
                    Quantity = int.Parse(item.SubItems[2].Text),
                    UnitPrice = double.Parse(item.SubItems[3].Text),
                    Subtotal = double.Parse(item.SubItems[4].Text),
                });
            }
            await db.SaveChangesAsync();

            MessageBox.Show("Sale Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnClear_Click(null!, null!);
            ReadSale();
        }
        private void ReadSale()
        {
            using var db = new MartManagementContext();
            var sales = db.Sales
                .Include(s => s.Customer) // 👈 load related Customer
                .Select(s => new
                {
                    s.SaleID,
                    s.CustomerID,
                    s.Customer.CustomerName, // 👈 now accessible
                    s.SaleDate,
                    s.TotalAmount,
                    s.PaymentMethod
                }).ToList();
            DgvSale.DataSource = sales;
        }



        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvSale.CurrentRow;
            if (selectedRow != null)
            {
                int saleId = (int)selectedRow.Cells["SaleID"].Value;
                var sale = db.Sales.Include(s => s.Customer)
                    .FirstOrDefault(s => s.SaleID == saleId);
                if (sale != null)
                {
                    CboCustomerID.Text = sale.CustomerID.ToString();
                    TxtCustomerName.Text = sale.Customer.CustomerName;
                    DtpSaleDate.Value = sale.SaleDate;
                    TxtPaymentMethod.Text = sale.PaymentMethod;
                }

                // Load SaleDetails for the selected Sale
                LvProduct.Columns.Clear();
                LvProduct.Items.Clear();
                var saleDetails = db.SaleDetails
                    .Include(sd => sd.Product)
                    .Where(sd => sd.SaleID == sale.SaleID)
                    .ToList();
                if (LvProduct.Columns.Count == 0)
                {
                    // Add columns
                    LvProduct.Columns.Add(LblProductID.Text, 150);
                    LvProduct.Columns.Add(LblProductName.Text, 100);
                    LvProduct.Columns.Add(LblQuantity.Text, 100);
                    LvProduct.Columns.Add(LblUnitPrice.Text, 100);
                    LvProduct.Columns.Add(LblSubtotal.Text, 100);
                }
                foreach (var sd in saleDetails)
                {
                    // Create and add items
                    ListViewItem product = new ListViewItem(sd.ProductID.ToString());
                    product.SubItems.Add(sd.Product.ProductName);
                    product.SubItems.Add(sd.Quantity.ToString());
                    product.SubItems.Add(sd.UnitPrice.ToString("F2"));
                    product.SubItems.Add(sd.Subtotal.ToString("F2"));
                    LvProduct.Items.Add(product);
                }





                //var products = db.SaleDetails
                //    .Include(sd => sd.Sale)
                //    .Include(sd => sd.Product)
                //    .Where(sd => sd.SaleID == sale.SaleID)
                //    .ToList().Select(sd => new
                //    {
                //        sd.ProductID,
                //        sd.Product.ProductName,
                //        sd.Quantity,
                //        sd.UnitPrice,
                //        sd.Subtotal
                //    }).ToList();


                _currentSale = sale;
                _currentSaleDetails = saleDetails;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentSale == null)
            {
                MessageBox.Show("Please select a sale to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = new MartManagementContext();

            _currentSale.CustomerID = int.Parse(CboCustomerID.Text);
            _currentSale.SaleDate = DtpSaleDate.Value;
            _currentSale.TotalAmount = LvProduct.Items.Cast<ListViewItem>().Sum(item => double.Parse(item.SubItems[4].Text));
            _currentSale.PaymentMethod = TxtPaymentMethod.Text;
            db.Sales.Update(_currentSale);
            await db.SaveChangesAsync();

            foreach (var sd in _currentSaleDetails)
            {
                db.SaleDetails.Remove(sd);
                await db.SaveChangesAsync();
            }

            foreach (ListViewItem item in LvProduct.Items)
            {
                db.Add(new SaleDetail
                {
                    SaleID = _currentSale.SaleID,
                    ProductID = int.Parse(item.SubItems[0].Text),
                    Quantity = int.Parse(item.SubItems[2].Text),
                    UnitPrice = double.Parse(item.SubItems[3].Text),
                    Subtotal = double.Parse(item.SubItems[4].Text),
                });
                await db.SaveChangesAsync();
            }

            MessageBox.Show("Sale Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _currentSale = null!;
            BtnClear_Click(null!, null!);
            ReadSale();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvSale.CurrentRow;
            if (selectedRow != null)
            {
                int saleId = (int)selectedRow.Cells["SaleID"].Value;
                var sale = db.Sales.Find(saleId);
                if (sale != null)
                {
                    var saleDetails = db.SaleDetails
                        .Where(sd => sd.SaleID == sale.SaleID)
                        .ToList();

                    foreach (var sd in saleDetails)
                    {
                        db.SaleDetails.Remove(sd);
                        await db.SaveChangesAsync();
                    }

                    db.Sales.Remove(sale);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Sale Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadSale();
                }
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LvProduct.SelectedItems)
            {
                LvProduct.Items.Remove(item);
            }
        }

        private void LvProduct_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected == false)
                if (LvProduct.FocusedItem != null)
                {
                    LvProduct.FocusedItem.Focused = false;
                }
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            var item = LvProduct.FocusedItem;

            if (item != null)
            {
                CboProductID.Text = item.SubItems[0].Text;
                TxtProductName.Text = item.SubItems[1].Text;
                TxtQuantity.Text = item.SubItems[2].Text;
                TxtUnitPrice.Text = item.SubItems[3].Text;
                TxtSubtotal.Text = item.SubItems[4].Text;

                _currentLvProductItem = item;

            }

        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (_currentLvProductItem != null)
            {
                _currentLvProductItem.SubItems[0].Text = CboProductID.Text;
                _currentLvProductItem.SubItems[1].Text = TxtProductName.Text;
                _currentLvProductItem.SubItems[2].Text = TxtQuantity.Text;
                _currentLvProductItem.SubItems[3].Text = TxtUnitPrice.Text;
                _currentLvProductItem.SubItems[4].Text = TxtSubtotal.Text;

                CboProductID.Text = null;
                TxtProductName.Clear();
                TxtQuantity.Clear();
                TxtUnitPrice.Clear();
                TxtSubtotal.Clear();

                _currentLvProductItem = null!;
            }

        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvSale.CurrentRow;
            if (selectedRow != null)
            {
                int saleId = (int)selectedRow.Cells["SaleID"].Value;
                var sale = db.Sales.Include(s => s.Customer).Include(s => s.SaleDetails)
                    .ThenInclude(sd => sd.Product).ThenInclude(p => p.Category)
                    .FirstOrDefault(s => s.SaleID == saleId);
                new FormSaleDetail(sale).ShowDialog();
            }
        }
    }
}
