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
    /// <summary>
    /// FormSale integrates three design patterns:
    /// - STATE PATTERN: OrderContext manages sale lifecycle (Draft → Confirmed → Completed/Cancelled)
    /// - STRATEGY PATTERN: PaymentProcessor with selectable IPaymentStrategy (Cash/Card/Transfer)
    /// - DECORATOR PATTERN: IProductPricing with TaxDecorator/DiscountDecorator for price adjustments
    /// - SINGLETON PATTERN: DatabaseManager.Instance for database access
    /// </summary>
    public partial class FormSale : Form
    {
        private Sale? _currentSale;
        private List<SaleDetail> _currentSaleDetails;
        private ListViewItem _currentLvProductItem;

        // === STATE PATTERN === 
        private OrderContext _orderContext = new OrderContext();

        // === STRATEGY PATTERN ===
        private PaymentProcessor _paymentProcessor = new PaymentProcessor();

        public FormSale()
        {
            InitializeComponent();

            ReadCustomerId();
            ReadProductId();
            ReadSale();
            InitializePaymentStrategies(); // Strategy Pattern
            UpdateStateDisplay();          // State Pattern
        }

        // =============================================
        // STRATEGY PATTERN: Initialize payment methods
        // =============================================
        private void InitializePaymentStrategies()
        {
            var strategies = new List<IPaymentStrategy>
            {
                new CashPayment(),
                new CardPayment(),
                new TransferPayment()
            };
            CboPaymentMethod.DataSource = strategies;
            CboPaymentMethod.DisplayMember = "MethodName";
            CboPaymentMethod.Text = null;
        }

        private void CboPaymentMethod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CboPaymentMethod.SelectedItem is IPaymentStrategy strategy)
            {
                _paymentProcessor.SetStrategy(strategy);
            }
        }

        // =============================================
        // STATE PATTERN: Update state label display
        // =============================================
        private void UpdateStateDisplay()
        {
            LblStateValue.Text = _orderContext.CurrentState.StateName;

            // Color-code the state
            switch (_orderContext.CurrentState.StateName)
            {
                case "Draft":
                    LblStateValue.ForeColor = Color.DarkGreen;
                    break;
                case "Confirmed":
                    LblStateValue.ForeColor = Color.DarkOrange;
                    break;
                case "Completed":
                    LblStateValue.ForeColor = Color.Blue;
                    break;
                case "Cancelled":
                    LblStateValue.ForeColor = Color.Red;
                    break;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            _orderContext.Confirm();
            UpdateStateDisplay();
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            _orderContext.Complete();
            UpdateStateDisplay();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _orderContext.Cancel();
            UpdateStateDisplay();
        }

        // =============================================
        // DECORATOR PATTERN: Apply pricing decorators
        // =============================================
        private double GetDecoratedPrice(double basePrice)
        {
            // Wrap base price with decorators
            IProductPricing pricing = new BaseProductPricing(basePrice);
            pricing = new TaxDecorator(pricing, 10);       // 10% tax
            pricing = new DiscountDecorator(pricing, 5);    // 5% discount

            // Display decorator description
            LblPriceInfo.Text = pricing.GetDescription();

            return pricing.GetPrice();
        }

        // =============================================
        // EXISTING LOGIC (uses Singleton + patterns)
        // =============================================
        private void ReadCustomerId()
        {
            // SINGLETON PATTERN: Use DatabaseManager instead of `new MartManagementContext()`
            using var db = DatabaseManager.Instance.CreateContext();
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
            using var db = DatabaseManager.Instance.CreateContext();
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

            using var db = DatabaseManager.Instance.CreateContext();
            var product = db.Products.FirstOrDefault(p => p.ProductID == int.Parse(CboProductID.Text));
            if (product != null)
            {
                // DECORATOR PATTERN: Apply tax + discount decorators to unit price
                double decoratedPrice = GetDecoratedPrice(product.UnitPrice);
                TxtUnitPrice.Text = decoratedPrice.ToString("F2");
            }
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
            CboPaymentMethod.Text = null;

            CboProductID.Text = null;
            TxtProductName.Clear();
            TxtQuantity.Clear();
            TxtUnitPrice.Clear();
            TxtSubtotal.Clear();
            LblPriceInfo.Text = "";

            LvProduct.Columns.Clear();
            LvProduct.Items.Clear();

            // Reset State Pattern
            _orderContext = new OrderContext();
            _paymentProcessor = new PaymentProcessor();
            UpdateStateDisplay();
        }


        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // STATE PATTERN: Check if adding items is allowed in the current state
            _orderContext.AddItem();
            if (_orderContext.CurrentState.StateName != "Draft")
            {
                return; // State machine rejected the action
            }

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

            CboProductID.Text = null;
            TxtProductName.Clear();
            TxtQuantity.Clear();
            TxtUnitPrice.Clear();
            TxtSubtotal.Clear();
            LblPriceInfo.Text = "";
        }
        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            // STATE PATTERN: Only allow submit when confirmed
            if (_orderContext.CurrentState.StateName != "Confirmed")
            {
                MessageBox.Show("Please confirm the order before submitting. Current state: " + _orderContext.CurrentState.StateName,
                    "State Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // STRATEGY PATTERN: Process payment using selected strategy
            if (CboPaymentMethod.SelectedItem is IPaymentStrategy strategy)
            {
                _paymentProcessor.SetStrategy(strategy);
            }

            double totalAmount = LvProduct.Items.Cast<ListViewItem>().Sum(item => double.Parse(item.SubItems[4].Text));
            if (!_paymentProcessor.Process(totalAmount))
            {
                return; // Payment failed
            }

            using var db = DatabaseManager.Instance.CreateContext();

            string paymentMethodName = _paymentProcessor.GetStrategy()?.MethodName ?? "Cash";

            var sale = db.Add(new Sale
            {
                CustomerID = int.Parse(CboCustomerID.Text),
                SaleDate = DtpSaleDate.Value,
                TotalAmount = totalAmount,
                PaymentMethod = paymentMethodName,
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

            // STATE PATTERN: Complete the order
            _orderContext.Complete();
            UpdateStateDisplay();

            // STRATEGY PATTERN: Show receipt
            string receipt = _paymentProcessor.GetReceipt(totalAmount);
            MessageBox.Show(receipt, "Sale Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnClear_Click(null!, null!);
            ReadSale();
        }
        private void ReadSale()
        {
            using var db = DatabaseManager.Instance.CreateContext();
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
            using var db = DatabaseManager.Instance.CreateContext();
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

                    // Strategy Pattern: Set the payment method ComboBox
                    for (int i = 0; i < CboPaymentMethod.Items.Count; i++)
                    {
                        if (CboPaymentMethod.Items[i] is IPaymentStrategy s && s.MethodName == sale.PaymentMethod)
                        {
                            CboPaymentMethod.SelectedIndex = i;
                            _paymentProcessor.SetStrategy(s);
                            break;
                        }
                    }
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

                _currentSale = sale;
                _currentSaleDetails = saleDetails;

                // State Pattern: Reset to Draft for editing
                _orderContext = new OrderContext();
                UpdateStateDisplay();
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentSale == null)
            {
                MessageBox.Show("Please select a sale to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = DatabaseManager.Instance.CreateContext();

            _currentSale.Customer = null; // clear tracked navigation

            string paymentMethodName = _paymentProcessor.GetStrategy()?.MethodName ?? "Cash";

            _currentSale.CustomerID = int.Parse(CboCustomerID.Text);
            _currentSale.SaleDate = DtpSaleDate.Value;
            _currentSale.TotalAmount = LvProduct.Items.Cast<ListViewItem>().Sum(item => double.Parse(item.SubItems[4].Text));
            _currentSale.PaymentMethod = paymentMethodName;
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
            using var db = DatabaseManager.Instance.CreateContext();
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
            using var db = DatabaseManager.Instance.CreateContext();
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
