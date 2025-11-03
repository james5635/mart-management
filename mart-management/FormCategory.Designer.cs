namespace mart_management
{
    partial class FormCategory
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
            LblCategory = new Label();
            DgvCategory = new DataGridView();
            BtnSubmit = new Button();
            BtnUpdate = new Button();
            BtnClear = new Button();
            TxtDescription = new TextBox();
            toolTip1 = new ToolTip(components);
            TxtCategoryName = new TextBox();
            LblDescription = new Label();
            LblCategoryName = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvCategory).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(675, 293);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 36);
            BtnDelete.TabIndex = 65;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(579, 293);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 64;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // LblCategory
            // 
            LblCategory.AutoSize = true;
            LblCategory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCategory.Location = new Point(66, 17);
            LblCategory.Name = "LblCategory";
            LblCategory.Size = new Size(96, 30);
            LblCategory.TabIndex = 63;
            LblCategory.Text = "Category";
            // 
            // DgvCategory
            // 
            DgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategory.Location = new Point(276, 40);
            DgvCategory.Name = "DgvCategory";
            DgvCategory.Size = new Size(474, 235);
            DgvCategory.TabIndex = 62;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(21, 281);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(75, 36);
            BtnSubmit.TabIndex = 61;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(118, 228);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 36);
            BtnUpdate.TabIndex = 60;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(19, 228);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 59;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtDescription
            // 
            TxtDescription.BorderStyle = BorderStyle.FixedSingle;
            TxtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDescription.Location = new Point(19, 172);
            TxtDescription.Name = "TxtDescription";
            TxtDescription.Size = new Size(174, 29);
            TxtDescription.TabIndex = 58;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            TxtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCategoryName.Location = new Point(19, 90);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.Size = new Size(174, 29);
            TxtCategoryName.TabIndex = 66;
            // 
            // LblDescription
            // 
            LblDescription.AutoSize = true;
            LblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescription.Location = new Point(19, 142);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(89, 21);
            LblDescription.TabIndex = 57;
            LblDescription.Text = "Description";
            // 
            // LblCategoryName
            // 
            LblCategoryName.AutoSize = true;
            LblCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCategoryName.Location = new Point(17, 60);
            LblCategoryName.Name = "LblCategoryName";
            LblCategoryName.Size = new Size(115, 21);
            LblCategoryName.TabIndex = 56;
            LblCategoryName.Text = "CategoryName";
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 356);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(LblCategory);
            Controls.Add(DgvCategory);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(TxtDescription);
            Controls.Add(TxtCategoryName);
            Controls.Add(LblDescription);
            Controls.Add(LblCategoryName);
            Name = "FormCategory";
            Text = "FormCategory";
            ((System.ComponentModel.ISupportInitialize)DgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Label LblCategory;
        private DataGridView DgvCategory;
        private Button BtnSubmit;
        private Button BtnUpdate;
        private Button BtnClear;
        private TextBox TxtDescription;
        private ToolTip toolTip1;
        private TextBox TxtCategoryName;
        private Label LblDescription;
        private Label LblCategoryName;
    }
}