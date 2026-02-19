namespace mart_management
{
    partial class FormStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCategory = new Button();
            BtnCustomer = new Button();
            BtnSupplier = new Button();
            BtnEmployee = new Button();
            BtnPayment = new Button();
            BtnSale = new Button();
            BtnInventory = new Button();
            BtnProduct = new Button();
            BtnPurchase = new Button();
            SuspendLayout();
            // 
            // BtnCategory
            // 
            BtnCategory.Font = new Font("Segoe UI", 12F);
            BtnCategory.Location = new Point(12, 12);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(288, 36);
            BtnCategory.TabIndex = 0;
            BtnCategory.Text = "Category";
            BtnCategory.UseVisualStyleBackColor = true;
            BtnCategory.Click += BtnCategory_Click;
            // 
            // BtnCustomer
            // 
            BtnCustomer.Font = new Font("Segoe UI", 12F);
            BtnCustomer.Location = new Point(12, 54);
            BtnCustomer.Name = "BtnCustomer";
            BtnCustomer.Size = new Size(288, 36);
            BtnCustomer.TabIndex = 1;
            BtnCustomer.Text = "Customer";
            BtnCustomer.UseVisualStyleBackColor = true;
            BtnCustomer.Click += BtnCustomer_Click;
            // 
            // BtnSupplier
            // 
            BtnSupplier.Font = new Font("Segoe UI", 12F);
            BtnSupplier.Location = new Point(12, 96);
            BtnSupplier.Name = "BtnSupplier";
            BtnSupplier.Size = new Size(288, 36);
            BtnSupplier.TabIndex = 2;
            BtnSupplier.Text = "Supplier";
            BtnSupplier.UseVisualStyleBackColor = true;
            BtnSupplier.Click += BtnSupplier_Click;
            // 
            // BtnEmployee
            // 
            BtnEmployee.Font = new Font("Segoe UI", 12F);
            BtnEmployee.Location = new Point(12, 138);
            BtnEmployee.Name = "BtnEmployee";
            BtnEmployee.Size = new Size(288, 36);
            BtnEmployee.TabIndex = 3;
            BtnEmployee.Text = "Employee";
            BtnEmployee.UseVisualStyleBackColor = true;
            BtnEmployee.Click += BtnEmployee_Click;
            // 
            // BtnPayment
            // 
            BtnPayment.Font = new Font("Segoe UI", 12F);
            BtnPayment.Location = new Point(12, 180);
            BtnPayment.Name = "BtnPayment";
            BtnPayment.Size = new Size(288, 36);
            BtnPayment.TabIndex = 4;
            BtnPayment.Text = "Payment";
            BtnPayment.UseVisualStyleBackColor = true;
            BtnPayment.Click += BtnPayment_Click;
            // 
            // BtnSale
            // 
            BtnSale.Font = new Font("Segoe UI", 12F);
            BtnSale.Location = new Point(12, 222);
            BtnSale.Name = "BtnSale";
            BtnSale.Size = new Size(288, 36);
            BtnSale.TabIndex = 5;
            BtnSale.Text = "Sale";
            BtnSale.UseVisualStyleBackColor = true;
            BtnSale.Click += BtnSale_Click;
            // 
            // BtnInventory
            // 
            BtnInventory.Font = new Font("Segoe UI", 12F);
            BtnInventory.Location = new Point(12, 264);
            BtnInventory.Name = "BtnInventory";
            BtnInventory.Size = new Size(288, 36);
            BtnInventory.TabIndex = 6;
            BtnInventory.Text = "Inventory";
            BtnInventory.UseVisualStyleBackColor = true;
            BtnInventory.Click += BtnInventory_Click;
            // 
            // BtnProduct
            // 
            BtnProduct.Font = new Font("Segoe UI", 12F);
            BtnProduct.Location = new Point(12, 306);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(288, 36);
            BtnProduct.TabIndex = 7;
            BtnProduct.Text = "Product";
            BtnProduct.UseVisualStyleBackColor = true;
            BtnProduct.Click += BtnProduct_Click;
            // 
            // BtnPurchase
            // 
            BtnPurchase.Font = new Font("Segoe UI", 12F);
            BtnPurchase.Location = new Point(12, 348);
            BtnPurchase.Name = "BtnPurchase";
            BtnPurchase.Size = new Size(288, 36);
            BtnPurchase.TabIndex = 8;
            BtnPurchase.Text = "Purchase";
            BtnPurchase.UseVisualStyleBackColor = true;
            BtnPurchase.Click += BtnPurchase_Click;
            // 
            // BtnReport (Composite Pattern)
            // 
            BtnReport = new Button();
            BtnReport.Font = new Font("Segoe UI", 12F);
            BtnReport.Location = new Point(12, 390);
            BtnReport.Name = "BtnReport";
            BtnReport.Size = new Size(288, 36);
            BtnReport.TabIndex = 9;
            BtnReport.Text = "Report (Composite)";
            BtnReport.UseVisualStyleBackColor = true;
            BtnReport.Click += BtnReport_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 500);
            Controls.Add(BtnReport);
            Controls.Add(BtnPurchase);
            Controls.Add(BtnProduct);
            Controls.Add(BtnInventory);
            Controls.Add(BtnSale);
            Controls.Add(BtnPayment);
            Controls.Add(BtnEmployee);
            Controls.Add(BtnSupplier);
            Controls.Add(BtnCustomer);
            Controls.Add(BtnCategory);
            Name = "FormStart";
            Text = "FormStart";
            ResumeLayout(false);
        }

        #endregion

        public Button BtnCategory;
        public Button BtnCustomer;
        public Button BtnSupplier;
        public Button BtnEmployee;
        public Button BtnPayment;
        public Button BtnSale;
        public Button BtnInventory;
        public Button BtnProduct;
        public Button BtnPurchase;
        public Button BtnReport;
    }
}