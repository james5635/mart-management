namespace mart_management
{
    partial class FormPurchase
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
            BtnAddProduct = new Button();
            LvProduct = new ListView();
            TxtSubtotal = new TextBox();
            LblSubtotal = new Label();
            TxtUnitPrice = new TextBox();
            LblUnitPrice = new Label();
            TxtQuantity = new TextBox();
            LblQuantity = new Label();
            TxtProductName = new TextBox();
            LblProductName = new Label();
            LblProduct = new Label();
            CboProductID = new ComboBox();
            LblProductID = new Label();
            BtnDetail = new Button();
            BtnDelete = new Button();
            this.CboSupplierID = new ComboBox();
            toolTip1 = new ToolTip(components);
            BtnEdit = new Button();
            LblPurchase = new Label();
            DgvPurchase = new DataGridView();
            BtnSubmit = new Button();
            BtnUpdate = new Button();
            BtnClear = new Button();
            this.TxtSuppilerName = new TextBox();
            this.LblSuppilerName = new Label();
            LblPurchaseDate = new Label();
            LblSupplierID = new Label();
            DtpPurchaseDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DgvPurchase).BeginInit();
            SuspendLayout();
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAddProduct.Location = new Point(695, 648);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(124, 36);
            BtnAddProduct.TabIndex = 98;
            BtnAddProduct.Text = "Add Product";
            BtnAddProduct.UseVisualStyleBackColor = true;
            // 
            // LvProduct
            // 
            LvProduct.Location = new Point(11, 416);
            LvProduct.Name = "LvProduct";
            LvProduct.Size = new Size(808, 217);
            LvProduct.TabIndex = 97;
            LvProduct.UseCompatibleStateImageBehavior = false;
            // 
            // TxtSubtotal
            // 
            TxtSubtotal.BorderStyle = BorderStyle.FixedSingle;
            TxtSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSubtotal.Location = new Point(717, 368);
            TxtSubtotal.Name = "TxtSubtotal";
            TxtSubtotal.Size = new Size(102, 29);
            TxtSubtotal.TabIndex = 96;
            // 
            // LblSubtotal
            // 
            LblSubtotal.AutoSize = true;
            LblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtotal.Location = new Point(717, 338);
            LblSubtotal.Name = "LblSubtotal";
            LblSubtotal.Size = new Size(68, 21);
            LblSubtotal.TabIndex = 95;
            LblSubtotal.Text = "Subtotal";
            // 
            // TxtUnitPrice
            // 
            TxtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            TxtUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUnitPrice.Location = new Point(572, 367);
            TxtUnitPrice.Name = "TxtUnitPrice";
            TxtUnitPrice.Size = new Size(111, 29);
            TxtUnitPrice.TabIndex = 94;
            // 
            // LblUnitPrice
            // 
            LblUnitPrice.AutoSize = true;
            LblUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUnitPrice.Location = new Point(572, 337);
            LblUnitPrice.Name = "LblUnitPrice";
            LblUnitPrice.Size = new Size(73, 21);
            LblUnitPrice.TabIndex = 93;
            LblUnitPrice.Text = "UnitPrice";
            // 
            // TxtQuantity
            // 
            TxtQuantity.BorderStyle = BorderStyle.FixedSingle;
            TxtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantity.Location = new Point(415, 368);
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(102, 29);
            TxtQuantity.TabIndex = 92;
            // 
            // LblQuantity
            // 
            LblQuantity.AutoSize = true;
            LblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuantity.Location = new Point(415, 338);
            LblQuantity.Name = "LblQuantity";
            LblQuantity.Size = new Size(70, 21);
            LblQuantity.TabIndex = 91;
            LblQuantity.Text = "Quantity";
            // 
            // TxtProductName
            // 
            TxtProductName.BorderStyle = BorderStyle.FixedSingle;
            TxtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtProductName.Location = new Point(188, 367);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(167, 29);
            TxtProductName.TabIndex = 90;
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(188, 337);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(106, 21);
            LblProductName.TabIndex = 89;
            LblProductName.Text = "ProductName";
            // 
            // LblProduct
            // 
            LblProduct.AutoSize = true;
            LblProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProduct.Location = new Point(26, 292);
            LblProduct.Name = "LblProduct";
            LblProduct.Size = new Size(85, 30);
            LblProduct.TabIndex = 88;
            LblProduct.Text = "Product";
            // 
            // CboProductID
            // 
            CboProductID.Font = new Font("Segoe UI", 12F);
            CboProductID.FormattingEnabled = true;
            CboProductID.Location = new Point(11, 367);
            CboProductID.Name = "CboProductID";
            CboProductID.Size = new Size(124, 29);
            CboProductID.TabIndex = 87;
            // 
            // LblProductID
            // 
            LblProductID.AutoSize = true;
            LblProductID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProductID.Location = new Point(11, 338);
            LblProductID.Name = "LblProductID";
            LblProductID.Size = new Size(79, 21);
            LblProductID.TabIndex = 86;
            LblProductID.Text = "ProductID";
            // 
            // BtnDetail
            // 
            BtnDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDetail.Location = new Point(553, 284);
            BtnDetail.Name = "BtnDetail";
            BtnDetail.Size = new Size(75, 36);
            BtnDetail.TabIndex = 85;
            BtnDetail.Text = "Detail";
            BtnDetail.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(744, 284);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 36);
            BtnDelete.TabIndex = 82;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // CboSupplierID
            // 
            this.CboSupplierID.Font = new Font("Segoe UI", 12F);
            this.CboSupplierID.FormattingEnabled = true;
            this.CboSupplierID.Location = new Point(11, 81);
            this.CboSupplierID.Name = "CboSupplierID";
            this.CboSupplierID.Size = new Size(207, 29);
            this.CboSupplierID.TabIndex = 83;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(648, 284);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 81;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // LblPurchase
            // 
            LblPurchase.AutoSize = true;
            LblPurchase.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPurchase.Location = new Point(60, 9);
            LblPurchase.Name = "LblPurchase";
            LblPurchase.Size = new Size(97, 30);
            LblPurchase.TabIndex = 80;
            LblPurchase.Text = "Purchase";
            // 
            // DgvPurchase
            // 
            DgvPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPurchase.Location = new Point(283, 52);
            DgvPurchase.Name = "DgvPurchase";
            DgvPurchase.Size = new Size(536, 224);
            DgvPurchase.TabIndex = 79;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(201, 650);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(75, 36);
            BtnSubmit.TabIndex = 78;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(105, 650);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 36);
            BtnUpdate.TabIndex = 77;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(6, 650);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 76;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // TxtSuppilerName
            // 
            this.TxtSuppilerName.BorderStyle = BorderStyle.FixedSingle;
            this.TxtSuppilerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtSuppilerName.Location = new Point(11, 150);
            this.TxtSuppilerName.Name = "TxtSuppilerName";
            this.TxtSuppilerName.ReadOnly = true;
            this.TxtSuppilerName.Size = new Size(207, 29);
            this.TxtSuppilerName.TabIndex = 73;
            // 
            // LblSuppilerName
            // 
            this.LblSuppilerName.AutoSize = true;
            this.LblSuppilerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LblSuppilerName.Location = new Point(11, 120);
            this.LblSuppilerName.Name = "LblSuppilerName";
            this.LblSuppilerName.Size = new Size(110, 21);
            this.LblSuppilerName.TabIndex = 71;
            this.LblSuppilerName.Text = "SuppilerName";
            // 
            // LblPurchaseDate
            // 
            LblPurchaseDate.AutoSize = true;
            LblPurchaseDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPurchaseDate.Location = new Point(12, 200);
            LblPurchaseDate.Name = "LblPurchaseDate";
            LblPurchaseDate.Size = new Size(105, 21);
            LblPurchaseDate.TabIndex = 74;
            LblPurchaseDate.Text = "PurchaseDate";
            // 
            // LblSupplierID
            // 
            LblSupplierID.AutoSize = true;
            LblSupplierID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSupplierID.Location = new Point(11, 52);
            LblSupplierID.Name = "LblSupplierID";
            LblSupplierID.Size = new Size(83, 21);
            LblSupplierID.TabIndex = 70;
            LblSupplierID.Text = "SupplierID";
            // 
            // DtpPurchaseDate
            // 
            DtpPurchaseDate.CalendarFont = new Font("Segoe UI", 12F);
            DtpPurchaseDate.Location = new Point(12, 237);
            DtpPurchaseDate.Name = "DtpPurchaseDate";
            DtpPurchaseDate.Size = new Size(207, 23);
            DtpPurchaseDate.TabIndex = 99;
            // 
            // FormPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 709);
            Controls.Add(DtpPurchaseDate);
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
            Controls.Add(BtnDelete);
            Controls.Add(this.CboSupplierID);
            Controls.Add(BtnEdit);
            Controls.Add(LblPurchase);
            Controls.Add(DgvPurchase);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(this.TxtSuppilerName);
            Controls.Add(this.LblSuppilerName);
            Controls.Add(LblPurchaseDate);
            Controls.Add(LblSupplierID);
            Name = "FormPurchase";
            Text = "FormPurchase";
            ((System.ComponentModel.ISupportInitialize)DgvPurchase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddProduct;
        private ListView LvProduct;
        private TextBox TxtSubtotal;
        private Label LblSubtotal;
        private TextBox TxtUnitPrice;
        private Label LblUnitPrice;
        private TextBox TxtQuantity;
        private Label LblQuantity;
        private TextBox TxtProductName;
        private Label LblProductName;
        private Label LblProduct;
        private ComboBox CboProductID;
        private Label LblProductID;
        private Button BtnDetail;
        private DateTimePicker DtpSaleDate;
        private Button BtnDelete;
        private ComboBox CboSupplierID;
        private ComboBox CboCustomerID;
        private ToolTip toolTip1;
        private Button BtnEdit;
        private Label LblPurchase;
        private DataGridView DgvPurchase;
        private Button BtnSubmit;
        private Button BtnUpdate;
        private Button BtnClear;
        private TextBox TxtSuppilerName;
        private Label LblSuppilerName;
        private TextBox TxtPaymentMethod;
        private TextBox TxtCustomerName;
        private Label LblSaleDate;
        private Label LblCustomerName;
        private Label LblPurchaseDate;
        private Label LblSupplierID;
        private DateTimePicker DtpPurchaseDate;
    }
}