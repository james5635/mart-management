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
            TxtUnitCost = new TextBox();
            LblUnitCost = new Label();
            TxtQuantity = new TextBox();
            LblQuantity = new Label();
            TxtProductName = new TextBox();
            LblProductName = new Label();
            LblProduct = new Label();
            CboProductID = new ComboBox();
            LblProductID = new Label();
            BtnDetail = new Button();
            BtnDelete = new Button();
            CboSupplierID = new ComboBox();
            toolTip1 = new ToolTip(components);
            BtnEdit = new Button();
            LblPurchase = new Label();
            DgvPurchase = new DataGridView();
            BtnSubmit = new Button();
            BtnUpdate = new Button();
            BtnClear = new Button();
            TxtSupplierName = new TextBox();
            LblSuppilerName = new Label();
            LblPurchaseDate = new Label();
            LblSupplierID = new Label();
            DtpPurchaseDate = new DateTimePicker();
            BtnUpdateProduct = new Button();
            BtnDeleteProduct = new Button();
            BtnEditProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvPurchase).BeginInit();
            SuspendLayout();
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAddProduct.Location = new Point(729, 597);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(124, 36);
            BtnAddProduct.TabIndex = 98;
            BtnAddProduct.Text = "Add Product";
            BtnAddProduct.UseVisualStyleBackColor = true;
            BtnAddProduct.Click += BtnAddProduct_Click;
            // 
            // LvProduct
            // 
            LvProduct.FullRowSelect = true;
            LvProduct.Location = new Point(11, 416);
            LvProduct.Name = "LvProduct";
            LvProduct.Size = new Size(696, 217);
            LvProduct.TabIndex = 97;
            LvProduct.UseCompatibleStateImageBehavior = false;
            LvProduct.View = View.Details;
            LvProduct.ItemSelectionChanged += LvProduct_ItemSelectionChanged;
            // 
            // TxtSubtotal
            // 
            TxtSubtotal.BorderStyle = BorderStyle.FixedSingle;
            TxtSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSubtotal.Location = new Point(749, 367);
            TxtSubtotal.Name = "TxtSubtotal";
            TxtSubtotal.Size = new Size(102, 29);
            TxtSubtotal.TabIndex = 96;
            // 
            // LblSubtotal
            // 
            LblSubtotal.AutoSize = true;
            LblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtotal.Location = new Point(749, 337);
            LblSubtotal.Name = "LblSubtotal";
            LblSubtotal.Size = new Size(68, 21);
            LblSubtotal.TabIndex = 95;
            LblSubtotal.Text = "Subtotal";
            // 
            // TxtUnitCost
            // 
            TxtUnitCost.BorderStyle = BorderStyle.FixedSingle;
            TxtUnitCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUnitCost.Location = new Point(589, 367);
            TxtUnitCost.Name = "TxtUnitCost";
            TxtUnitCost.Size = new Size(111, 29);
            TxtUnitCost.TabIndex = 94;
            TxtUnitCost.TextChanged += TxtUnitCost_TextChanged;
            // 
            // LblUnitCost
            // 
            LblUnitCost.AutoSize = true;
            LblUnitCost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUnitCost.Location = new Point(589, 337);
            LblUnitCost.Name = "LblUnitCost";
            LblUnitCost.Size = new Size(70, 21);
            LblUnitCost.TabIndex = 93;
            LblUnitCost.Text = "UnitCost";
            // 
            // TxtQuantity
            // 
            TxtQuantity.BorderStyle = BorderStyle.FixedSingle;
            TxtQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantity.Location = new Point(441, 367);
            TxtQuantity.Name = "TxtQuantity";
            TxtQuantity.Size = new Size(102, 29);
            TxtQuantity.TabIndex = 92;
            TxtQuantity.TextChanged += TxtQuantity_TextChanged;
            // 
            // LblQuantity
            // 
            LblQuantity.AutoSize = true;
            LblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuantity.Location = new Point(441, 337);
            LblQuantity.Name = "LblQuantity";
            LblQuantity.Size = new Size(70, 21);
            LblQuantity.TabIndex = 91;
            LblQuantity.Text = "Quantity";
            // 
            // TxtProductName
            // 
            TxtProductName.BorderStyle = BorderStyle.FixedSingle;
            TxtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtProductName.Location = new Point(201, 367);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(183, 29);
            TxtProductName.TabIndex = 90;
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(201, 337);
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
            CboProductID.SelectionChangeCommitted += CboProductID_SelectionChangeCommitted;
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
            BtnDetail.Location = new Point(585, 286);
            BtnDetail.Name = "BtnDetail";
            BtnDetail.Size = new Size(75, 36);
            BtnDetail.TabIndex = 85;
            BtnDetail.Text = "Detail";
            BtnDetail.UseVisualStyleBackColor = true;
            BtnDetail.Click += BtnDetail_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(776, 286);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 36);
            BtnDelete.TabIndex = 82;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // CboSupplierID
            // 
            CboSupplierID.Font = new Font("Segoe UI", 12F);
            CboSupplierID.FormattingEnabled = true;
            CboSupplierID.Location = new Point(11, 81);
            CboSupplierID.Name = "CboSupplierID";
            CboSupplierID.Size = new Size(207, 29);
            CboSupplierID.TabIndex = 83;
            CboSupplierID.SelectionChangeCommitted += CboSupplierID_SelectionChangeCommitted;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(680, 286);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 81;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
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
            DgvPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPurchase.Location = new Point(283, 52);
            DgvPurchase.Name = "DgvPurchase";
            DgvPurchase.Size = new Size(568, 224);
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
            BtnSubmit.Click += BtnSubmit_Click;
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
            BtnUpdate.Click += BtnUpdate_Click;
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
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtSupplierName
            // 
            TxtSupplierName.BorderStyle = BorderStyle.FixedSingle;
            TxtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSupplierName.Location = new Point(11, 150);
            TxtSupplierName.Name = "TxtSupplierName";
            TxtSupplierName.ReadOnly = true;
            TxtSupplierName.Size = new Size(207, 29);
            TxtSupplierName.TabIndex = 73;
            // 
            // LblSuppilerName
            // 
            LblSuppilerName.AutoSize = true;
            LblSuppilerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSuppilerName.Location = new Point(11, 120);
            LblSuppilerName.Name = "LblSuppilerName";
            LblSuppilerName.Size = new Size(110, 21);
            LblSuppilerName.TabIndex = 71;
            LblSuppilerName.Text = "SuppilerName";
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
            // BtnUpdateProduct
            // 
            BtnUpdateProduct.Font = new Font("Segoe UI", 11F);
            BtnUpdateProduct.Location = new Point(729, 539);
            BtnUpdateProduct.Name = "BtnUpdateProduct";
            BtnUpdateProduct.Size = new Size(122, 36);
            BtnUpdateProduct.TabIndex = 102;
            BtnUpdateProduct.Text = "Update Product";
            BtnUpdateProduct.UseVisualStyleBackColor = true;
            BtnUpdateProduct.Click += BtnUpdateProduct_Click;
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDeleteProduct.Location = new Point(727, 416);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(124, 36);
            BtnDeleteProduct.TabIndex = 101;
            BtnDeleteProduct.Text = "Delete Product";
            BtnDeleteProduct.UseVisualStyleBackColor = true;
            BtnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // BtnEditProduct
            // 
            BtnEditProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditProduct.Location = new Point(729, 477);
            BtnEditProduct.Name = "BtnEditProduct";
            BtnEditProduct.Size = new Size(124, 36);
            BtnEditProduct.TabIndex = 100;
            BtnEditProduct.Text = "Edit Product";
            BtnEditProduct.UseVisualStyleBackColor = true;
            BtnEditProduct.Click += BtnEditProduct_Click;
            // 
            // FormPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 709);
            Controls.Add(BtnUpdateProduct);
            Controls.Add(BtnDeleteProduct);
            Controls.Add(BtnEditProduct);
            Controls.Add(DtpPurchaseDate);
            Controls.Add(BtnAddProduct);
            Controls.Add(LvProduct);
            Controls.Add(TxtSubtotal);
            Controls.Add(LblSubtotal);
            Controls.Add(TxtUnitCost);
            Controls.Add(LblUnitCost);
            Controls.Add(TxtQuantity);
            Controls.Add(LblQuantity);
            Controls.Add(TxtProductName);
            Controls.Add(LblProductName);
            Controls.Add(LblProduct);
            Controls.Add(CboProductID);
            Controls.Add(LblProductID);
            Controls.Add(BtnDetail);
            Controls.Add(BtnDelete);
            Controls.Add(CboSupplierID);
            Controls.Add(BtnEdit);
            Controls.Add(LblPurchase);
            Controls.Add(DgvPurchase);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(TxtSupplierName);
            Controls.Add(LblSuppilerName);
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
        private TextBox TxtUnitCost;
        private Label LblUnitCost;
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
        private TextBox TxtSupplierName;
        private Label LblSuppilerName;
        private TextBox TxtPaymentMethod;
        private TextBox TxtCustomerName;
        private Label LblSaleDate;
        private Label LblCustomerName;
        private Label LblPurchaseDate;
        private Label LblSupplierID;
        private DateTimePicker DtpPurchaseDate;
        private Button BtnUpdateProduct;
        private Button BtnDeleteProduct;
        private Button BtnEditProduct;
    }
}