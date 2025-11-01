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
    public partial class FormPurchaseDetail : Form
    {
        private FormPurchaseDetail()
        {
            InitializeComponent();
        }
        public FormPurchaseDetail(Purchase purchase) : this()
        {
            LvPurchase.FullRowSelect = true;
            LvPurchase.View = View.Details;
            LvPurchase.HideSelection = true;

            if (LvPurchase.Columns.Count == 0)
            {
                // Add columns
                LvPurchase.Columns.Add("PurchaseID", 150);
                LvPurchase.Columns.Add("SupplierID", 100);
                LvPurchase.Columns.Add("SupplierName", 100);
                LvPurchase.Columns.Add("PurchaseDate", 100);
                LvPurchase.Columns.Add("TotalAmount", 100);

                // Create and add items
                ListViewItem purchaseItem = new ListViewItem($"{purchase.PurchaseID}");
                purchaseItem.SubItems.Add($"{purchase.SupplierID}");
                purchaseItem.SubItems.Add(purchase.Supplier.SupplierName);
                purchaseItem.SubItems.Add(purchase.PurchaseDate.ToString());
                purchaseItem.SubItems.Add($"{purchase.TotalAmount}");
                LvPurchase.Items.Add(purchaseItem);
            }

            LvPurchaseDetail.FullRowSelect = true;
            LvPurchaseDetail.View = View.Details;
            LvPurchaseDetail.HideSelection = true;

            if (LvPurchaseDetail.Columns.Count == 0)
            {
                // Add columns
                LvPurchaseDetail.Columns.Add("ProductID", 100);
                LvPurchaseDetail.Columns.Add("ProductName", 100);
                LvPurchaseDetail.Columns.Add("CategoryName", 100);
                LvPurchaseDetail.Columns.Add("Quantity", 100);
                LvPurchaseDetail.Columns.Add("UnitCost", 100);
                LvPurchaseDetail.Columns.Add("Subtotal", 100);
                LvPurchaseDetail.Columns.Add("Unit", 100);
                // Create and add items
                foreach (var detail in purchase.PurchaseDetails)
                {
                    ListViewItem detailItem = new ListViewItem($"{detail.ProductID}");
                    detailItem.SubItems.Add(detail.Product.ProductName);
                    detailItem.SubItems.Add(detail.Product.Category.CategoryName);
                    detailItem.SubItems.Add($"{detail.Quantity}");
                    detailItem.SubItems.Add($"{detail.UnitCost}");
                    detailItem.SubItems.Add($"{detail.Subtotal}");
                    detailItem.SubItems.Add($"{detail.Product.Unit}");
                    LvPurchaseDetail.Items.Add(detailItem);
                }
            }
        }

        private void LvPurchase_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected == false)
                if (LvPurchase.FocusedItem != null)
                {
                    LvPurchase.FocusedItem.Focused = false;
                }
        }

        private void LvPurchaseDetail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected == false)
                if (LvPurchaseDetail.FocusedItem != null)
                {
                    LvPurchaseDetail.FocusedItem.Focused = false;
                }
        }
    }
}
