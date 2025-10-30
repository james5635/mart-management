namespace mart_management
{
    partial class FormSale
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
            components = new System.ComponentModel.Container();
            BtnDelete = new Button();
            BtnEdit = new Button();
            LblSale = new Label();
            DgvSale = new DataGridView();
            BtnSubmit = new Button();
            BtnUpdate = new Button();
            BtnClear = new Button();
            TxtPaymentMethod = new TextBox();
            TxtCustomerName = new TextBox();
            LblSaleDate = new Label();
            LblCustomerName = new Label();
            toolTip1 = new ToolTip(components);
            CboCustomerID = new ComboBox();
            LblPaymentMethod = new Label();
            LblCustomerID = new Label();
            DtpSaleDate = new DateTimePicker();
            BtnDetail = new Button();
            CboProductID = new ComboBox();
            LblProductID = new Label();
            LblProduct = new Label();
            TxtProductName = new TextBox();
            LblProductName = new Label();
            TxtQuantity = new TextBox();
            LblQuantity = new Label();
            TxtUnitPrice = new TextBox();
            LblUnitPrice = new Label();
            TxtSubtotal = new TextBox();
            LblSubtotal = new Label();
            LvProduct = new ListView();
            BtnAddProduct = new Button();
            BtnEditProduct = new Button();
            BtnDeleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvSale).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(877, 328);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 36);
            BtnDelete.TabIndex = 52;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(781, 328);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 51;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // LblSale
            // 
            LblSale.AutoSize = true;
            LblSale.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSale.Location = new Point(63, 11);
            LblSale.Name = "LblSale";
            LblSale.Size = new Size(51, 30);
            LblSale.TabIndex = 50;
            LblSale.Text = "Sale";
            // 
            // DgvSale
            // 
            DgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSale.Location = new Point(286, 65);
            DgvSale.Name = "DgvSale";
            DgvSale.Size = new Size(666, 246);
            DgvSale.TabIndex = 49;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(204, 692);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(75, 36);
            BtnSubmit.TabIndex = 48;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(108, 692);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 36);
            BtnUpdate.TabIndex = 47;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(9, 692);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 46;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtPaymentMethod
            // 
            TxtPaymentMethod.BorderStyle = BorderStyle.FixedSingle;
            TxtPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPaymentMethod.Location = new Point(14, 290);
            TxtPaymentMethod.Name = "TxtPaymentMethod";
            TxtPaymentMethod.Size = new Size(207, 29);
            TxtPaymentMethod.TabIndex = 45;
            // 
            // TxtCustomerName
            // 
            TxtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            TxtCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCustomerName.Location = new Point(14, 152);
            TxtCustomerName.Name = "TxtCustomerName";
            TxtCustomerName.ReadOnly = true;
            TxtCustomerName.Size = new Size(207, 29);
            TxtCustomerName.TabIndex = 43;
            // 
            // LblSaleDate
            // 
            LblSaleDate.AutoSize = true;
            LblSaleDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSaleDate.Location = new Point(14, 193);
            LblSaleDate.Name = "LblSaleDate";
            LblSaleDate.Size = new Size(71, 21);
            LblSaleDate.TabIndex = 42;
            LblSaleDate.Text = "SaleDate";
            // 
            // LblCustomerName
            // 
            LblCustomerName.AutoSize = true;
            LblCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCustomerName.Location = new Point(14, 122);
            LblCustomerName.Name = "LblCustomerName";
            LblCustomerName.Size = new Size(120, 21);
            LblCustomerName.TabIndex = 41;
            LblCustomerName.Text = "CustomerName";
            // 
            // CboCustomerID
            // 
            CboCustomerID.Font = new Font("Segoe UI", 12F);
            CboCustomerID.FormattingEnabled = true;
            CboCustomerID.Location = new Point(14, 83);
            CboCustomerID.Name = "CboCustomerID";
            CboCustomerID.Size = new Size(207, 29);
            CboCustomerID.TabIndex = 53;
            CboCustomerID.SelectionChangeCommitted += CboCustomerID_SelectionChangeCommitted;
            // 
            // LblPaymentMethod
            // 
            LblPaymentMethod.AutoSize = true;
            LblPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPaymentMethod.Location = new Point(14, 262);
            LblPaymentMethod.Name = "LblPaymentMethod";
            LblPaymentMethod.Size = new Size(124, 21);
            LblPaymentMethod.TabIndex = 44;
            LblPaymentMethod.Text = "PaymentMethod";
            // 
            // LblCustomerID
            // 
            LblCustomerID.AutoSize = true;
            LblCustomerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCustomerID.Location = new Point(14, 54);
            LblCustomerID.Name = "LblCustomerID";
            LblCustomerID.Size = new Size(93, 21);
            LblCustomerID.TabIndex = 40;
            LblCustomerID.Text = "CustomerID";
            // 
            // DtpSaleDate
            // 
            DtpSaleDate.CalendarFont = new Font("Segoe UI", 12F);
            DtpSaleDate.Location = new Point(14, 226);
            DtpSaleDate.Name = "DtpSaleDate";
            DtpSaleDate.Size = new Size(207, 23);
            DtpSaleDate.TabIndex = 55;
            // 
            // BtnDetail
            // 
            BtnDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDetail.Location = new Point(686, 328);
            BtnDetail.Name = "BtnDetail";
            BtnDetail.Size = new Size(75, 36);
            BtnDetail.TabIndex = 56;
            BtnDetail.Text = "Detail";
            BtnDetail.UseVisualStyleBackColor = true;
            // 
            // CboProductID
            // 
            CboProductID.Font = new Font("Segoe UI", 12F);
            CboProductID.FormattingEnabled = true;
            CboProductID.Location = new Point(14, 409);
            CboProductID.Name = "CboProductID";
            CboProductID.Size = new Size(141, 29);
            CboProductID.TabIndex = 58;
            CboProductID.SelectionChangeCommitted += CboProductID_SelectionChangeCommitted;
            // 
            // LblProductID
            // 
            LblProductID.AutoSize = true;
            LblProductID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProductID.Location = new Point(14, 380);
            LblProductID.Name = "LblProductID";
            LblProductID.Size = new Size(79, 21);
            LblProductID.TabIndex = 57;
            LblProductID.Text = "ProductID";
            // 
            // LblProduct
            // 
            LblProduct.AutoSize = true;
            LblProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProduct.Location = new Point(29, 334);
            LblProduct.Name = "LblProduct";
            LblProduct.Size = new Size(85, 30);
            LblProduct.TabIndex = 59;
            LblProduct.Text = "Product";
            // 
            // TxtProductName
            // 
            TxtProductName.BorderStyle = BorderStyle.FixedSingle;
            TxtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtProductName.Location = new Point(220, 409);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.ReadOnly = true;
            TxtProductName.Size = new Size(230, 29);
            TxtProductName.TabIndex = 61;
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(220, 379);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(106, 21);
            LblProductName.TabIndex = 60;
            LblProductName.Text = "ProductName";
            // 
            // TxtQuantity
            // 
            TxtQuantity.BorderStyle = BorderStyle.FixedSingle;
            TxtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantity.Location = new Point(498, 409);
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(118, 29);
            TxtQuantity.TabIndex = 63;
            TxtQuantity.TextChanged += TxtQuantity_TextChanged;
            // 
            // LblQuantity
            // 
            LblQuantity.AutoSize = true;
            LblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuantity.Location = new Point(498, 379);
            LblQuantity.Name = "LblQuantity";
            LblQuantity.Size = new Size(70, 21);
            LblQuantity.TabIndex = 62;
            LblQuantity.Text = "Quantity";
            // 
            // TxtUnitPrice
            // 
            TxtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            TxtUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUnitPrice.Location = new Point(659, 409);
            TxtUnitPrice.Name = "TxtUnitPrice";
            TxtUnitPrice.Size = new Size(131, 29);
            TxtUnitPrice.TabIndex = 65;
            TxtUnitPrice.TextChanged += TxtUnitPrice_TextChanged;
            // 
            // LblUnitPrice
            // 
            LblUnitPrice.AutoSize = true;
            LblUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUnitPrice.Location = new Point(659, 379);
            LblUnitPrice.Name = "LblUnitPrice";
            LblUnitPrice.Size = new Size(73, 21);
            LblUnitPrice.TabIndex = 64;
            LblUnitPrice.Text = "UnitPrice";
            // 
            // TxtSubtotal
            // 
            TxtSubtotal.BorderStyle = BorderStyle.FixedSingle;
            TxtSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSubtotal.Location = new Point(830, 410);
            TxtSubtotal.Name = "TxtSubtotal";
            TxtSubtotal.ReadOnly = true;
            TxtSubtotal.Size = new Size(122, 29);
            TxtSubtotal.TabIndex = 67;
            // 
            // LblSubtotal
            // 
            LblSubtotal.AutoSize = true;
            LblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtotal.Location = new Point(830, 380);
            LblSubtotal.Name = "LblSubtotal";
            LblSubtotal.Size = new Size(68, 21);
            LblSubtotal.TabIndex = 66;
            LblSubtotal.Text = "Subtotal";
            // 
            // LvProduct
            // 
            LvProduct.Location = new Point(14, 458);
            LvProduct.Name = "LvProduct";
            LvProduct.Size = new Size(798, 217);
            LvProduct.TabIndex = 68;
            LvProduct.UseCompatibleStateImageBehavior = false;
            LvProduct.View = View.Details;
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAddProduct.Location = new Point(828, 616);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(124, 36);
            BtnAddProduct.TabIndex = 69;
            BtnAddProduct.Text = "Add Product";
            BtnAddProduct.UseVisualStyleBackColor = true;
            BtnAddProduct.Click += BtnAddProduct_Click;
            // 
            // BtnEditProduct
            // 
            BtnEditProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditProduct.Location = new Point(830, 551);
            BtnEditProduct.Name = "BtnEditProduct";
            BtnEditProduct.Size = new Size(124, 36);
            BtnEditProduct.TabIndex = 70;
            BtnEditProduct.Text = "Edit Product";
            BtnEditProduct.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDeleteProduct.Location = new Point(828, 490);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(124, 36);
            BtnDeleteProduct.TabIndex = 71;
            BtnDeleteProduct.Text = "Delete Product";
            BtnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 738);
            Controls.Add(BtnDeleteProduct);
            Controls.Add(BtnEditProduct);
            Controls.Add(BtnAddProduct);
            Controls.Add(LvProduct);
            Controls.Add(TxtSubtotal);
            Controls.Add(LblSubtotal);
            Controls.Add(TxtUnitPrice);
            Controls.Add(LblUnitPrice);
            Controls.Add(TxtQuantity);
            Controls.Add(LblQuantity);
            Controls.Add(TxtProductName);
            Controls.Add(LblProductName);
            Controls.Add(LblProduct);
            Controls.Add(CboProductID);
            Controls.Add(LblProductID);
            Controls.Add(BtnDetail);
            Controls.Add(DtpSaleDate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(LblSale);
            Controls.Add(DgvSale);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(TxtPaymentMethod);
            Controls.Add(TxtCustomerName);
            Controls.Add(LblSaleDate);
            Controls.Add(LblCustomerName);
            Controls.Add(CboCustomerID);
            Controls.Add(LblPaymentMethod);
            Controls.Add(LblCustomerID);
            Name = "FormSale";
            Text = "FormSale";
            ((System.ComponentModel.ISupportInitialize)DgvSale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Label LblSale;
        private DataGridView DgvSale;
        private Button BtnSubmit;
        private Button BtnUpdate;
        private Button BtnClear;
        private TextBox TxtPaymentMethod;
        private TextBox TxtCustomerName;
        private Label LblSaleDate;
        private Label LblCustomerName;
        private ToolTip toolTip1;
        private ComboBox CboCustomerID;
        private Label LblPaymentMethod;
        private Label LblCustomerID;
        private DateTimePicker DtpSaleDate;
        private Button BtnDetail;
        private ComboBox CboProductID;
        private Label LblProductID;
        private Label LblProduct;
        private TextBox TxtProductName;
        private Label LblProductName;
        private TextBox TxtQuantity;
        private Label LblQuantity;
        private TextBox TxtUnitPrice;
        private Label LblUnitPrice;
        private TextBox TxtSubtotal;
        private Label LblSubtotal;
        private ListView LvProduct;
        private Button BtnAddProduct;
        private Button BtnEditProduct;
        private Button BtnDeleteProduct;
    }
}