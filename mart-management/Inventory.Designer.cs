namespace mart_management
{
    partial class Inventory
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
            LblInventory = new Label();
            DgvInventory = new DataGridView();
            BtnSubmit = new Button();
            BtnUpdate = new Button();
            BtnClear = new Button();
            TxtQuantityInStock = new TextBox();
            toolTip1 = new ToolTip(components);
            LblQuantityInStock = new Label();
            LblProductID = new Label();
            TxtProductID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvInventory).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(620, 301);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 36);
            BtnDelete.TabIndex = 52;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(524, 301);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 51;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // LblInventory
            // 
            LblInventory.AutoSize = true;
            LblInventory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblInventory.Location = new Point(59, 16);
            LblInventory.Name = "LblInventory";
            LblInventory.Size = new Size(100, 30);
            LblInventory.TabIndex = 50;
            LblInventory.Text = "Inventory";
            // 
            // DgvInventory
            // 
            DgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInventory.Location = new Point(269, 39);
            DgvInventory.Name = "DgvInventory";
            DgvInventory.Size = new Size(426, 235);
            DgvInventory.TabIndex = 49;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(14, 280);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(75, 36);
            BtnSubmit.TabIndex = 48;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(111, 227);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 36);
            BtnUpdate.TabIndex = 47;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(12, 227);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 46;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // TxtQuantityInStock
            // 
            TxtQuantityInStock.BorderStyle = BorderStyle.FixedSingle;
            TxtQuantityInStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantityInStock.Location = new Point(12, 171);
            TxtQuantityInStock.Name = "TxtQuantityInStock";
            TxtQuantityInStock.Size = new Size(174, 29);
            TxtQuantityInStock.TabIndex = 45;
            // 
            // LblQuantityInStock
            // 
            LblQuantityInStock.AutoSize = true;
            LblQuantityInStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuantityInStock.Location = new Point(12, 141);
            LblQuantityInStock.Name = "LblQuantityInStock";
            LblQuantityInStock.Size = new Size(120, 21);
            LblQuantityInStock.TabIndex = 44;
            LblQuantityInStock.Text = "QuantityInStock";
            // 
            // LblProductID
            // 
            LblProductID.AutoSize = true;
            LblProductID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProductID.Location = new Point(10, 59);
            LblProductID.Name = "LblProductID";
            LblProductID.Size = new Size(79, 21);
            LblProductID.TabIndex = 40;
            LblProductID.Text = "ProductID";
            // 
            // TxtProductID
            // 
            TxtProductID.BorderStyle = BorderStyle.FixedSingle;
            TxtProductID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtProductID.Location = new Point(12, 89);
            TxtProductID.Name = "TxtProductID";
            TxtProductID.Size = new Size(174, 29);
            TxtProductID.TabIndex = 55;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 344);
            Controls.Add(TxtProductID);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(LblInventory);
            Controls.Add(DgvInventory);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(TxtQuantityInStock);
            Controls.Add(LblQuantityInStock);
            Controls.Add(LblProductID);
            Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)DgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Label LblInventory;
        private DataGridView DgvInventory;
        private Button BtnSubmit;
        private Button BtnUpdate;
        private Button BtnClear;
        private TextBox TxtPaymentMethod;
        private TextBox TxtAmountPaid;
        private Label AmountPaid;
        private Label LblPaymentDate;
        private ToolTip toolTip1;
        private DateTimePicker DtpPaymentDate;
        private ComboBox CboSaleID;
        private Label LblQuantityInStock;
        private Label LblProductID;
        private TextBox TxtProductID;
        private TextBox TxtQuantityInStock;
    }
}