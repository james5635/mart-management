namespace mart_management
{
    partial class FormProduct
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
            LblProduct = new Label();
            DgvProduct = new DataGridView();
            BtnSubmit = new Button();
            BtnUpdate = new Button();
            BtnClear = new Button();
            TxtUnit = new TextBox();
            LblUnit = new Label();
            TxtCostPrice = new TextBox();
            LblCostPrice = new Label();
            TxtUnitPrice = new TextBox();
            TxtCategoryName = new TextBox();
            LblCategoryName = new Label();
            LblCategoryID = new Label();
            TxtProductName = new TextBox();
            toolTip1 = new ToolTip(components);
            LblUnitPrice = new Label();
            LblProductName = new Label();
            TxtStatus = new TextBox();
            LblStatus = new Label();
            TxtReorderLevel = new TextBox();
            LblReorderLevel = new Label();
            CboCategoryID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgvProduct).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(1105, 440);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 36);
            BtnDelete.TabIndex = 37;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(1009, 440);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 36;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // LblProduct
            // 
            LblProduct.AutoSize = true;
            LblProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProduct.Location = new Point(71, 9);
            LblProduct.Name = "LblProduct";
            LblProduct.Size = new Size(85, 30);
            LblProduct.TabIndex = 35;
            LblProduct.Text = "Product";
            // 
            // DgvProduct
            // 
            DgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProduct.Location = new Point(235, 71);
            DgvProduct.Name = "DgvProduct";
            DgvProduct.Size = new Size(945, 348);
            DgvProduct.TabIndex = 34;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(220, 633);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(75, 36);
            BtnSubmit.TabIndex = 33;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(124, 633);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 36);
            BtnUpdate.TabIndex = 32;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(25, 633);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 31;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtUnit
            // 
            TxtUnit.BorderStyle = BorderStyle.FixedSingle;
            TxtUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUnit.Location = new Point(22, 432);
            TxtUnit.Name = "TxtUnit";
            TxtUnit.Size = new Size(174, 29);
            TxtUnit.TabIndex = 30;
            // 
            // LblUnit
            // 
            LblUnit.AutoSize = true;
            LblUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUnit.Location = new Point(22, 404);
            LblUnit.Name = "LblUnit";
            LblUnit.Size = new Size(39, 21);
            LblUnit.TabIndex = 29;
            LblUnit.Text = "Unit";
            // 
            // TxtCostPrice
            // 
            TxtCostPrice.BorderStyle = BorderStyle.FixedSingle;
            TxtCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCostPrice.Location = new Point(22, 360);
            TxtCostPrice.Name = "TxtCostPrice";
            TxtCostPrice.Size = new Size(174, 29);
            TxtCostPrice.TabIndex = 28;
            // 
            // LblCostPrice
            // 
            LblCostPrice.AutoSize = true;
            LblCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCostPrice.Location = new Point(22, 332);
            LblCostPrice.Name = "LblCostPrice";
            LblCostPrice.Size = new Size(75, 21);
            LblCostPrice.TabIndex = 27;
            LblCostPrice.Text = "CostPrice";
            // 
            // TxtUnitPrice
            // 
            TxtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            TxtUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUnitPrice.Location = new Point(22, 288);
            TxtUnitPrice.Name = "TxtUnitPrice";
            TxtUnitPrice.Size = new Size(174, 29);
            TxtUnitPrice.TabIndex = 26;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            TxtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCategoryName.Location = new Point(22, 219);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.ReadOnly = true;
            TxtCategoryName.Size = new Size(174, 29);
            TxtCategoryName.TabIndex = 24;
            // 
            // LblCategoryName
            // 
            LblCategoryName.AutoSize = true;
            LblCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCategoryName.Location = new Point(22, 191);
            LblCategoryName.Name = "LblCategoryName";
            LblCategoryName.Size = new Size(115, 21);
            LblCategoryName.TabIndex = 23;
            LblCategoryName.Text = "CategoryName";
            // 
            // LblCategoryID
            // 
            LblCategoryID.AutoSize = true;
            LblCategoryID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCategoryID.Location = new Point(22, 120);
            LblCategoryID.Name = "LblCategoryID";
            LblCategoryID.Size = new Size(88, 21);
            LblCategoryID.TabIndex = 21;
            LblCategoryID.Text = "CategoryID";
            // 
            // TxtProductName
            // 
            TxtProductName.BorderStyle = BorderStyle.FixedSingle;
            TxtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtProductName.Location = new Point(22, 84);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(174, 29);
            TxtProductName.TabIndex = 20;
            // 
            // LblUnitPrice
            // 
            LblUnitPrice.AutoSize = true;
            LblUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUnitPrice.Location = new Point(22, 260);
            LblUnitPrice.Name = "LblUnitPrice";
            LblUnitPrice.Size = new Size(73, 21);
            LblUnitPrice.TabIndex = 25;
            LblUnitPrice.Text = "UnitPrice";
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProductName.Location = new Point(22, 52);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(106, 21);
            LblProductName.TabIndex = 19;
            LblProductName.Text = "ProductName";
            // 
            // TxtStatus
            // 
            TxtStatus.BorderStyle = BorderStyle.FixedSingle;
            TxtStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtStatus.Location = new Point(22, 577);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(174, 29);
            TxtStatus.TabIndex = 41;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(22, 549);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(52, 21);
            LblStatus.TabIndex = 40;
            LblStatus.Text = "Status";
            // 
            // TxtReorderLevel
            // 
            TxtReorderLevel.BorderStyle = BorderStyle.FixedSingle;
            TxtReorderLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtReorderLevel.Location = new Point(22, 505);
            TxtReorderLevel.Name = "TxtReorderLevel";
            TxtReorderLevel.Size = new Size(174, 29);
            TxtReorderLevel.TabIndex = 39;
            // 
            // LblReorderLevel
            // 
            LblReorderLevel.AutoSize = true;
            LblReorderLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblReorderLevel.Location = new Point(22, 477);
            LblReorderLevel.Name = "LblReorderLevel";
            LblReorderLevel.Size = new Size(102, 21);
            LblReorderLevel.TabIndex = 38;
            LblReorderLevel.Text = "ReorderLevel";
            // 
            // CboCategoryID
            // 
            CboCategoryID.Font = new Font("Segoe UI", 12F);
            CboCategoryID.FormattingEnabled = true;
            CboCategoryID.Location = new Point(22, 154);
            CboCategoryID.Name = "CboCategoryID";
            CboCategoryID.Size = new Size(174, 29);
            CboCategoryID.TabIndex = 42;
            CboCategoryID.SelectionChangeCommitted += CboCategoryID_SelectionChangeCommitted;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 684);
            Controls.Add(CboCategoryID);
            Controls.Add(TxtStatus);
            Controls.Add(LblStatus);
            Controls.Add(TxtReorderLevel);
            Controls.Add(LblReorderLevel);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(LblProduct);
            Controls.Add(DgvProduct);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(TxtUnit);
            Controls.Add(LblUnit);
            Controls.Add(TxtCostPrice);
            Controls.Add(LblCostPrice);
            Controls.Add(TxtUnitPrice);
            Controls.Add(TxtCategoryName);
            Controls.Add(LblCategoryName);
            Controls.Add(LblCategoryID);
            Controls.Add(TxtProductName);
            Controls.Add(LblUnitPrice);
            Controls.Add(LblProductName);
            Name = "FormProduct";
            Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)DgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Label LblProduct;
        private DataGridView DgvProduct;
        private Button BtnSubmit;
        private Button BtnUpdate;
        private Button BtnClear;
        private TextBox TxtUnit;
        private Label LblUnit;
        private TextBox TxtCostPrice;
        private Label LblCostPrice;
        private TextBox TxtPassword;
        private Label LblPassword;
        private TextBox txtUsername;
        private Label LblUsername;
        private TextBox TxtEmail;
        private TextBox TxtPhone;
        private Label LblPhone;
        private TextBox TxtRole;
        private Label LblCategoryName;
        private Label LblCategoryID;
        private TextBox TxtProductName;
        private ToolTip toolTip1;
        private Label LblUnitPrice;
        private Label LblEmail;
        private Label LblProductName;
        private TextBox TxtStatus;
        private Label LblStatus;
        private TextBox TxtReorderLevel;
        private Label LblReorderLevel;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private ComboBox CboCategoryID;
        private TextBox TxtUnitPrice;
        private TextBox TxtCategoryName;
    }
}