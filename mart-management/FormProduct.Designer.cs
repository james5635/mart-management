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
            this.TxtUnit = new TextBox();
            this.LblUnit = new Label();
            this.TxtCostPrice = new TextBox();
            this.LblCostPrice = new Label();
            this.TxtUnitPrice = new TextBox();
            this.TxtCategoryName = new TextBox();
            this.LblCategoryName = new Label();
            LblCategoryID = new Label();
            TxtProductName = new TextBox();
            toolTip1 = new ToolTip(components);
            this.LblUnitPrice = new Label();
            LblProductName = new Label();
            this.TxtStatus = new TextBox();
            this.LblStatus = new Label();
            this.TxtReorderLevel = new TextBox();
            this.LblReorderLevel = new Label();
            CboCategoryID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgvProduct).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(939, 446);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 36);
            BtnDelete.TabIndex = 37;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(843, 446);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 36;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
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
            DgvProduct.Size = new Size(779, 348);
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
            // 
            // TxtUnit
            // 
            this.TxtUnit.BorderStyle = BorderStyle.FixedSingle;
            this.TxtUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtUnit.Location = new Point(22, 432);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.Size = new Size(174, 29);
            this.TxtUnit.TabIndex = 30;
            // 
            // LblUnit
            // 
            this.LblUnit.AutoSize = true;
            this.LblUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LblUnit.Location = new Point(22, 404);
            this.LblUnit.Name = "LblUnit";
            this.LblUnit.Size = new Size(39, 21);
            this.LblUnit.TabIndex = 29;
            this.LblUnit.Text = "Unit";
            // 
            // TxtCostPrice
            // 
            this.TxtCostPrice.BorderStyle = BorderStyle.FixedSingle;
            this.TxtCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtCostPrice.Location = new Point(22, 360);
            this.TxtCostPrice.Name = "TxtCostPrice";
            this.TxtCostPrice.Size = new Size(174, 29);
            this.TxtCostPrice.TabIndex = 28;
            // 
            // LblCostPrice
            // 
            this.LblCostPrice.AutoSize = true;
            this.LblCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LblCostPrice.Location = new Point(22, 332);
            this.LblCostPrice.Name = "LblCostPrice";
            this.LblCostPrice.Size = new Size(75, 21);
            this.LblCostPrice.TabIndex = 27;
            this.LblCostPrice.Text = "CostPrice";
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            this.TxtUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtUnitPrice.Location = new Point(22, 288);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new Size(174, 29);
            this.TxtUnitPrice.TabIndex = 26;
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            this.TxtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtCategoryName.Location = new Point(22, 219);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.ReadOnly = true;
            this.TxtCategoryName.Size = new Size(174, 29);
            this.TxtCategoryName.TabIndex = 24;
            // 
            // LblCategoryName
            // 
            this.LblCategoryName.AutoSize = true;
            this.LblCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LblCategoryName.Location = new Point(22, 191);
            this.LblCategoryName.Name = "LblCategoryName";
            this.LblCategoryName.Size = new Size(115, 21);
            this.LblCategoryName.TabIndex = 23;
            this.LblCategoryName.Text = "CategoryName";
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
            this.LblUnitPrice.AutoSize = true;
            this.LblUnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LblUnitPrice.Location = new Point(22, 260);
            this.LblUnitPrice.Name = "LblUnitPrice";
            this.LblUnitPrice.Size = new Size(73, 21);
            this.LblUnitPrice.TabIndex = 25;
            this.LblUnitPrice.Text = "UnitPrice";
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
            this.TxtStatus.BorderStyle = BorderStyle.FixedSingle;
            this.TxtStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtStatus.Location = new Point(22, 577);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new Size(174, 29);
            this.TxtStatus.TabIndex = 41;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LblStatus.Location = new Point(22, 549);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new Size(52, 21);
            this.LblStatus.TabIndex = 40;
            this.LblStatus.Text = "Status";
            // 
            // TxtReorderLevel
            // 
            this.TxtReorderLevel.BorderStyle = BorderStyle.FixedSingle;
            this.TxtReorderLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtReorderLevel.Location = new Point(22, 505);
            this.TxtReorderLevel.Name = "TxtReorderLevel";
            this.TxtReorderLevel.Size = new Size(174, 29);
            this.TxtReorderLevel.TabIndex = 39;
            // 
            // LblReorderLevel
            // 
            this.LblReorderLevel.AutoSize = true;
            this.LblReorderLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LblReorderLevel.Location = new Point(22, 477);
            this.LblReorderLevel.Name = "LblReorderLevel";
            this.LblReorderLevel.Size = new Size(102, 21);
            this.LblReorderLevel.TabIndex = 38;
            this.LblReorderLevel.Text = "ReorderLevel";
            // 
            // CboCategoryID
            // 
            CboCategoryID.Font = new Font("Segoe UI", 12F);
            CboCategoryID.FormattingEnabled = true;
            CboCategoryID.Location = new Point(22, 154);
            CboCategoryID.Name = "CboCategoryID";
            CboCategoryID.Size = new Size(174, 29);
            CboCategoryID.TabIndex = 42;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 684);
            Controls.Add(CboCategoryID);
            Controls.Add(this.TxtStatus);
            Controls.Add(this.LblStatus);
            Controls.Add(this.TxtReorderLevel);
            Controls.Add(this.LblReorderLevel);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(LblProduct);
            Controls.Add(DgvProduct);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(this.TxtUnit);
            Controls.Add(this.LblUnit);
            Controls.Add(this.TxtCostPrice);
            Controls.Add(this.LblCostPrice);
            Controls.Add(this.TxtUnitPrice);
            Controls.Add(this.TxtCategoryName);
            Controls.Add(this.LblCategoryName);
            Controls.Add(LblCategoryID);
            Controls.Add(TxtProductName);
            Controls.Add(this.LblUnitPrice);
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