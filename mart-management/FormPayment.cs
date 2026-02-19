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
    public partial class FormPayment : Form
    {
        private Payment? _currentPayment;

        public FormPayment()
        {
            InitializeComponent();

            ReadSaleId();
            ReadPayment();

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CboSaleID.Text = null;
            DtpPaymentDate.Value = DateTime.Now;
            TxtAmountPaid.Clear();
            TxtPaymentMethod.Clear();

        }

        private void ReadSaleId()
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var sales = db.Sales.Select(s => new
            {
                s.SaleID
            }).ToList();
            CboSaleID.DataSource = sales;
            CboSaleID.DisplayMember = "SaleID";
            CboSaleID.DropDownStyle = ComboBoxStyle.DropDownList;
            CboSaleID.Text = null;

        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var db = DatabaseManager.Instance.CreateContext();

            db.Add(new Payment
            {
                SaleID = int.Parse(CboSaleID.Text),
                PaymentDate = DtpPaymentDate.Value,
                AmountPaid = double.Parse(TxtAmountPaid.Text),
                PaymentMethod = TxtPaymentMethod.Text
            });
            await db.SaveChangesAsync();
            MessageBox.Show("Payment Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnClear_Click(null!, null!);

            ReadPayment();
        }

        private void ReadPayment()
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var payments = db.Payments.ToList().Select(p => new
            {
                p.PaymentID,
                p.SaleID,
                p.PaymentDate,
                p.AmountPaid,
                p.PaymentMethod
            }).ToList();
            DgvPayment.DataSource = payments;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var selectedRow = DgvPayment.CurrentRow;
            if (selectedRow != null)
            {
                int paymentId = (int)selectedRow.Cells["PaymentID"].Value;
                var payment = db.Payments.Find(paymentId);
                if (payment != null)
                {
                    CboSaleID.Text = $"{payment.SaleID}";
                    DtpPaymentDate.Value = payment.PaymentDate;
                    TxtAmountPaid.Text = $"{payment.AmountPaid}";
                    TxtPaymentMethod.Text = payment.PaymentMethod;
                }
                _currentPayment = payment;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentPayment == null)
            {
                MessageBox.Show("Please select a payment to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var db = DatabaseManager.Instance.CreateContext();

            _currentPayment.SaleID = int.Parse(CboSaleID.Text);
            _currentPayment.PaymentDate = DtpPaymentDate.Value;
            _currentPayment.AmountPaid = double.Parse(TxtAmountPaid.Text);
            _currentPayment.PaymentMethod = TxtPaymentMethod.Text;

            db.Payments.Update(_currentPayment);
            await db.SaveChangesAsync();
            MessageBox.Show("Payment Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _currentPayment = null!;
            BtnClear_Click(null!, null!);

            ReadPayment();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            using var db = DatabaseManager.Instance.CreateContext();
            var selectedRow = DgvPayment.CurrentRow;
            if (selectedRow != null)
            {
                int paymentId = (int)selectedRow.Cells["PaymentID"].Value;
                var payment = db.Payments.Find(paymentId);
                if (payment != null)
                {
                    db.Payments.Remove(payment);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Payment Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadPayment();
                }
            }
        }
    }
}
