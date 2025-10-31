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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            new FormCategory().Show();
        }

        private void TxtCustomer_Click(object sender, EventArgs e)
        {
            new FormCustomer().Show();
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            new FormSupplier().Show();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            new FormEmployee().Show();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            new FormPayment().Show();
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {
            new FormSale().Show();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            new FormInventory().Show();
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            new FormProduct().Show();
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            new FormPurchase().Show();
        }
    }
}
