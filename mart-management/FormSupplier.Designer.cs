namespace mart_management
{
    partial class FormSupplier
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
            LblSupplier = new Label();
            DgvSupplier = new DataGridView();
            BtnSubmit = new Button();
            BtnUpdate = new Button();
            BtnClear = new Button();
            TxtAddress = new TextBox();
            LblAddress = new Label();
            TxtEmail = new TextBox();
            TxtPhone = new TextBox();
            LblPhone = new Label();
            TxtContactPerson = new TextBox();
            LblContactPerson = new Label();
            TxtSupplierName = new TextBox();
            toolTip1 = new ToolTip(components);
            LblEmail = new Label();
            LblSupplierName = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(857, 417);
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
            BtnEdit.Location = new Point(761, 417);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 36;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // LblSupplier
            // 
            LblSupplier.AutoSize = true;
            LblSupplier.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSupplier.Location = new Point(70, 9);
            LblSupplier.Name = "LblSupplier";
            LblSupplier.Size = new Size(88, 30);
            LblSupplier.TabIndex = 35;
            LblSupplier.Text = "Supplier";
            // 
            // DgvSupplier
            // 
            DgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSupplier.Location = new Point(234, 71);
            DgvSupplier.Name = "DgvSupplier";
            DgvSupplier.Size = new Size(698, 331);
            DgvSupplier.TabIndex = 34;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(216, 427);
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
            BtnUpdate.Location = new Point(120, 427);
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
            BtnClear.Location = new Point(21, 427);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 31;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtAddress
            // 
            TxtAddress.BorderStyle = BorderStyle.FixedSingle;
            TxtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAddress.Location = new Point(21, 360);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(174, 29);
            TxtAddress.TabIndex = 28;
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAddress.Location = new Point(21, 332);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(66, 21);
            LblAddress.TabIndex = 27;
            LblAddress.Text = "Address";
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEmail.Location = new Point(21, 288);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(174, 29);
            TxtEmail.TabIndex = 26;
            // 
            // TxtPhone
            // 
            TxtPhone.BorderStyle = BorderStyle.FixedSingle;
            TxtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPhone.Location = new Point(21, 219);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(174, 29);
            TxtPhone.TabIndex = 24;
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPhone.Location = new Point(21, 191);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(54, 21);
            LblPhone.TabIndex = 23;
            LblPhone.Text = "Phone";
            // 
            // TxtContactPerson
            // 
            TxtContactPerson.BorderStyle = BorderStyle.FixedSingle;
            TxtContactPerson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtContactPerson.Location = new Point(21, 151);
            TxtContactPerson.Name = "TxtContactPerson";
            TxtContactPerson.Size = new Size(174, 29);
            TxtContactPerson.TabIndex = 22;
            // 
            // LblContactPerson
            // 
            LblContactPerson.AutoSize = true;
            LblContactPerson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContactPerson.Location = new Point(21, 120);
            LblContactPerson.Name = "LblContactPerson";
            LblContactPerson.Size = new Size(110, 21);
            LblContactPerson.TabIndex = 21;
            LblContactPerson.Text = "ContactPerson";
            // 
            // TxtSupplierName
            // 
            TxtSupplierName.BorderStyle = BorderStyle.FixedSingle;
            TxtSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSupplierName.Location = new Point(21, 84);
            TxtSupplierName.Name = "TxtSupplierName";
            TxtSupplierName.Size = new Size(174, 29);
            TxtSupplierName.TabIndex = 20;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEmail.Location = new Point(21, 260);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(48, 21);
            LblEmail.TabIndex = 25;
            LblEmail.Text = "Email";
            // 
            // LblSupplierName
            // 
            LblSupplierName.AutoSize = true;
            LblSupplierName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSupplierName.Location = new Point(21, 52);
            LblSupplierName.Name = "LblSupplierName";
            LblSupplierName.Size = new Size(110, 21);
            LblSupplierName.TabIndex = 19;
            LblSupplierName.Text = "SupplierName";
            // 
            // FormSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 477);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(LblSupplier);
            Controls.Add(DgvSupplier);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(TxtAddress);
            Controls.Add(LblAddress);
            Controls.Add(TxtEmail);
            Controls.Add(TxtPhone);
            Controls.Add(LblPhone);
            Controls.Add(TxtContactPerson);
            Controls.Add(LblContactPerson);
            Controls.Add(TxtSupplierName);
            Controls.Add(LblEmail);
            Controls.Add(LblSupplierName);
            Name = "FormSupplier";
            Text = "FormSupplier";
            ((System.ComponentModel.ISupportInitialize)DgvSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Label LblSupplier;
        private DataGridView DgvSupplier;
        private Button BtnSubmit;
        private Button BtnUpdate;
        private Button BtnClear;
        private TextBox TxtAddress;
        private Label LblAddress;
        private TextBox TxtEmail;
        private TextBox TxtPhone;
        private Label LblPhone;
        private TextBox TxtContactPerson;
        private Label LblContactPerson;
        private TextBox TxtSupplierName;
        private ToolTip toolTip1;
        private Label LblEmail;
        private Label LblSupplierName;
    }
}