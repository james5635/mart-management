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
    public partial class FormPurchase : Form
    {
        private Purchase? _currentPurchase;
        private List<PurchaseDetail> _currentPurchaseDetails;
        private ListViewItem _currentLvProductItem;

        public FormPurchase()
        {
            InitializeComponent();

            ReadSupplierId();
            ReadProductId();
            ReadPurchase();
        }


        private void ReadSupplierId()
        {
            using var db = new MartManagementContext();
            var suppliers = db.Suppliers.Select(s => new
            {
                s.SupplierID,
                s.SupplierName
            }).ToList();
            CboSupplierID.DataSource = suppliers;
            CboSupplierID.DisplayMember = "SupplierID";
            CboSupplierID.ValueMember = "SupplierName";
            CboSupplierID.DropDownStyle = ComboBoxStyle.DropDownList;
            CboSupplierID.Text = null;
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

        private void CboSupplierID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtSupplierName.Text = CboSupplierID.SelectedValue.ToString();
        }

        private void CboProductID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TxtProductName.Text = CboProductID.SelectedValue.ToString();

            using var db = new MartManagementContext();
            var product = db.Products.FirstOrDefault(p => p.ProductID == int.Parse(CboProductID.Text));
            if (product != null)
            {
                TxtUnitCost.Text = product.CostPrice.ToString("F2");
            }
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtQuantity.Text, out int quantity) && double.TryParse(TxtUnitCost.Text, out double unitCost))
            {
                double subtotal = quantity * unitCost;
                TxtSubtotal.Text = subtotal.ToString("F2");
            }
            else
            {
                TxtSubtotal.Clear();
            }
        }

        private void TxtUnitCost_TextChanged(object sender, EventArgs e)
        {
            TxtQuantity_TextChanged(null!, null!);

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CboSupplierID.Text = null;
            TxtSupplierName.Clear();
            DtpPurchaseDate.Value = DateTime.Now;

            CboProductID.Text = null;
            TxtProductName.Clear();
            TxtQuantity.Clear();
            TxtUnitCost.Clear();
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
                LvProduct.Columns.Add(LblUnitCost.Text, 100);
                LvProduct.Columns.Add(LblSubtotal.Text, 100);
            }

            // Create and add items
            ListViewItem product = new ListViewItem(CboProductID.Text);
            product.SubItems.Add(TxtProductName.Text);
            product.SubItems.Add(TxtQuantity.Text);
            product.SubItems.Add(TxtUnitCost.Text);
            product.SubItems.Add(TxtSubtotal.Text);
            LvProduct.Items.Add(product);

            CboProductID.Text = null;
            TxtProductName.Clear();
            TxtQuantity.Clear();
            TxtUnitCost.Clear();
            TxtSubtotal.Clear();
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();

            var purchase = db.Add(new Purchase
            {
                SupplierID = int.Parse(CboSupplierID.Text),
                PurchaseDate = DtpPurchaseDate.Value,
                TotalAmount = LvProduct.Items.Cast<ListViewItem>().Sum(item => double.Parse(item.SubItems[4].Text)),
            });
            await db.SaveChangesAsync();

            foreach (ListViewItem item in LvProduct.Items)
            {
                db.Add(new PurchaseDetail
                {
                    PurchaseID = purchase.Entity.PurchaseID,
                    ProductID = int.Parse(item.SubItems[0].Text),
                    Quantity = int.Parse(item.SubItems[2].Text),
                    UnitCost = double.Parse(item.SubItems[3].Text),
                    Subtotal = double.Parse(item.SubItems[4].Text),
                });
            }
            await db.SaveChangesAsync();

            MessageBox.Show("Purchase Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnClear_Click(null!, null!);
            ReadPurchase();
        }

        private void ReadPurchase()
        {
            using var db = new MartManagementContext();
            var purchases = db.Purchases
                .Include(p => p.Supplier) // 👈 load related Customer
                .Select(p => new
                {
                    p.PurchaseID,
                    p.SupplierID,
                    p.Supplier.SupplierName, // 👈 now accessible
                    p.PurchaseDate,
                    p.TotalAmount,
                }).ToList();
            DgvPurchase.DataSource = purchases;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            using var db = new MartManagementContext();
            var selectedRow = DgvPurchase.CurrentRow;
            if (selectedRow != null)
            {
                int purchaseId = (int)selectedRow.Cells["PurchaseID"].Value;
                var purchase = db.Purchases.Include(p => p.Supplier)
                    .FirstOrDefault(p => p.PurchaseID == purchaseId);
                if (purchase != null)
                {
                    CboSupplierID.Text = purchase.SupplierID.ToString();
                    TxtSupplierName.Text = purchase.Supplier.SupplierName;
                    DtpPurchaseDate.Value = purchase.PurchaseDate;
                }

                // Load PurchaseDetails for the selected Sale
                LvProduct.Columns.Clear();
                LvProduct.Items.Clear();
                var purchaseDetails = db.PurchaseDetails
                    .Include(pd => pd.Product)
                    .Where(pd => pd.PurchaseID == purchase.PurchaseID)
                    .ToList();
                if (LvProduct.Columns.Count == 0)
                {
                    // Add columns
                    LvProduct.Columns.Add(LblProductID.Text, 150);
                    LvProduct.Columns.Add(LblProductName.Text, 100);
                    LvProduct.Columns.Add(LblQuantity.Text, 100);
                    LvProduct.Columns.Add(LblUnitCost.Text, 100);
                    LvProduct.Columns.Add(LblSubtotal.Text, 100);
                }
                foreach (var pd in purchaseDetails)
                {
                    // Create and add items
                    ListViewItem product = new ListViewItem(pd.ProductID.ToString());
                    product.SubItems.Add(pd.Product.ProductName);
                    product.SubItems.Add(pd.Quantity.ToString());
                    product.SubItems.Add(pd.UnitCost.ToString("F2"));
                    product.SubItems.Add(pd.Subtotal.ToString("F2"));
                    LvProduct.Items.Add(product);
                }

                _currentPurchase = purchase;
                _currentPurchaseDetails = purchaseDetails;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentPurchase == null)
            {
                MessageBox.Show("Please select a purchase to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = new MartManagementContext();

            _currentPurchase.Supplier = null; // clear tracked navigation

            _currentPurchase.SupplierID = int.Parse(CboSupplierID.Text);
            _currentPurchase.PurchaseDate = DtpPurchaseDate.Value;
            _currentPurchase.TotalAmount = LvProduct.Items.Cast<ListViewItem>().Sum(item => double.Parse(item.SubItems[4].Text));
            db.Purchases.Update(_currentPurchase);
            await db.SaveChangesAsync();

            foreach (var pd in _currentPurchaseDetails)
            {
                db.PurchaseDetails.Remove(pd);
                await db.SaveChangesAsync();
            }

            foreach (ListViewItem item in LvProduct.Items)
            {
                db.Add(new PurchaseDetail
                {
                    PurchaseID = _currentPurchase.PurchaseID,
                    ProductID = int.Parse(item.SubItems[0].Text),
                    Quantity = int.Parse(item.SubItems[2].Text),
                    UnitCost = double.Parse(item.SubItems[3].Text),
                    Subtotal = double.Parse(item.SubItems[4].Text),
                });
                await db.SaveChangesAsync();
            }

            MessageBox.Show("Purchase Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _currentPurchase = null!;
            BtnClear_Click(null!, null!);
            ReadPurchase();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvPurchase.CurrentRow;
            if (selectedRow != null)
            {
                int purchaseId = (int)selectedRow.Cells["PurchaseID"].Value;
                var purchase = db.Purchases.Find(purchaseId);
                if (purchase != null)
                {
                    var purchaseDetails = db.PurchaseDetails
                        .Where(pd => pd.PurchaseID == purchase.PurchaseID)
                        .ToList();

                    foreach (var pd in purchaseDetails)
                    {
                        db.PurchaseDetails.Remove(pd);
                        await db.SaveChangesAsync();
                    }

                    db.Purchases.Remove(purchase);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Purchase Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadPurchase();
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
                TxtUnitCost.Text = item.SubItems[3].Text;
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
                _currentLvProductItem.SubItems[3].Text = TxtUnitCost.Text;
                _currentLvProductItem.SubItems[4].Text = TxtSubtotal.Text;

                CboProductID.Text = null;
                TxtProductName.Clear();
                TxtQuantity.Clear();
                TxtUnitCost.Clear();
                TxtSubtotal.Clear();

                _currentLvProductItem = null!;
            }
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            using var db = new MartManagementContext();
            var selectedRow = DgvPurchase.CurrentRow;
            if (selectedRow != null)
            {
                int purchaseId = (int)selectedRow.Cells["PurchaseID"].Value;
                var purchase = db.Purchases.Include(p => p.Supplier).Include(p => p.PurchaseDetails)
                    .ThenInclude(pd => pd.Product).ThenInclude(p => p.Category)
                    .FirstOrDefault(p => p.PurchaseID == purchaseId);
                new FormPurchaseDetail(purchase).ShowDialog();
            }
        }
    }
}

