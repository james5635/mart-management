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

    public partial class FormSaleDetail : Form
    {

        private FormSaleDetail()
        {
            InitializeComponent();
        }
        public FormSaleDetail(Sale sale) : this()
        {
            LvSale.FullRowSelect = true;
            LvSale.View = View.Details;
            LvSale.HideSelection = true;

            if (LvSale.Columns.Count == 0)
            {
                // Add columns
                LvSale.Columns.Add("SaleID", 150);
                LvSale.Columns.Add("CustomerID", 100);
                LvSale.Columns.Add("CustomerName", 100);
                LvSale.Columns.Add("SaleDate", 100);
                LvSale.Columns.Add("TotalAmount", 100);
                LvSale.Columns.Add("PaymentMethod", 150);

                // Create and add items
                ListViewItem saleItem = new ListViewItem($"{sale.SaleID}");
                saleItem.SubItems.Add($"{sale.CustomerID}");
                saleItem.SubItems.Add(sale.Customer.CustomerName);
                saleItem.SubItems.Add(sale.SaleDate.ToString());
                saleItem.SubItems.Add($"{sale.TotalAmount}");
                saleItem.SubItems.Add(sale.PaymentMethod);
                LvSale.Items.Add(saleItem);
            }

            LvSaleDetail.FullRowSelect = true;
            LvSaleDetail.View = View.Details;
            LvSaleDetail.HideSelection = true;

            if (LvSaleDetail.Columns.Count == 0)
            {
                // Add columns
                LvSaleDetail.Columns.Add("ProductID", 100);
                LvSaleDetail.Columns.Add("ProductName", 100);
                LvSaleDetail.Columns.Add("CategoryName", 100);
                LvSaleDetail.Columns.Add("Quantity", 100);
                LvSaleDetail.Columns.Add("UnitPrice", 100);
                LvSaleDetail.Columns.Add("Subtotal", 100);
                LvSaleDetail.Columns.Add("Unit", 100);
                // Create and add items
                foreach (var detail in sale.SaleDetails)
                {
                    ListViewItem detailItem = new ListViewItem($"{detail.SaleDetailID}");
                    detailItem.SubItems.Add($"{detail.ProductID}");
                    detailItem.SubItems.Add(detail.Product.ProductName);
                    detailItem.SubItems.Add(detail.Product.Category.CategoryName);
                    detailItem.SubItems.Add($"{detail.Quantity}");
                    detailItem.SubItems.Add($"{detail.UnitPrice}");
                    detailItem.SubItems.Add($"{detail.Subtotal}");
                    detailItem.SubItems.Add($"{detail.Product.Unit}");
                    LvSaleDetail.Items.Add(detailItem);
                }
            }
        }


        private void LvSale_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected == false)
                if (LvSale.FocusedItem != null)
                {
                    LvSale.FocusedItem.Focused = false;
                }
        }

        private void LvSaleDetail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected == false)
                if (LvSaleDetail.FocusedItem != null)
                {
                    LvSaleDetail.FocusedItem.Focused = false;
                }
        }
    }
}

