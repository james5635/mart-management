namespace mart_management
{
    partial class FormEmployee
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
            LblFullName = new Label();
            toolTip1 = new ToolTip(components);
            TxtFullName = new TextBox();
            TxtRole = new TextBox();
            LblRole = new Label();
            TxtPhone = new TextBox();
            LblPhone = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            TxtUsername = new TextBox();
            LblUsername = new Label();
            TxtPassword = new TextBox();
            LblPassword = new Label();
            BtnClear = new Button();
            BtnUpdate = new Button();
            BtnSubmit = new Button();
            DgvEmployee = new DataGridView();
            LblEmployee = new Label();
            BtnDelete = new Button();
            BtnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // LblFullName
            // 
            LblFullName.AutoSize = true;
            LblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFullName.Location = new Point(25, 52);
            LblFullName.Name = "LblFullName";
            LblFullName.Size = new Size(77, 21);
            LblFullName.TabIndex = 0;
            LblFullName.Text = "FullName";
            // 
            // TxtFullName
            // 
            TxtFullName.BorderStyle = BorderStyle.FixedSingle;
            TxtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFullName.Location = new Point(25, 84);
            TxtFullName.Name = "TxtFullName";
            TxtFullName.Size = new Size(174, 29);
            TxtFullName.TabIndex = 1;
            // 
            // TxtRole
            // 
            TxtRole.BorderStyle = BorderStyle.FixedSingle;
            TxtRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRole.Location = new Point(25, 151);
            TxtRole.Name = "TxtRole";
            TxtRole.Size = new Size(174, 29);
            TxtRole.TabIndex = 3;
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblRole.Location = new Point(25, 120);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(41, 21);
            LblRole.TabIndex = 2;
            LblRole.Text = "Role";
            // 
            // TxtPhone
            // 
            TxtPhone.BorderStyle = BorderStyle.FixedSingle;
            TxtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPhone.Location = new Point(25, 219);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(174, 29);
            TxtPhone.TabIndex = 5;
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPhone.Location = new Point(25, 191);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(54, 21);
            LblPhone.TabIndex = 4;
            LblPhone.Text = "Phone";
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEmail.Location = new Point(25, 288);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(174, 29);
            TxtEmail.TabIndex = 7;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEmail.Location = new Point(25, 260);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(48, 21);
            LblEmail.TabIndex = 6;
            LblEmail.Text = "Email";
            // 
            // TxtUsername
            // 
            TxtUsername.BorderStyle = BorderStyle.FixedSingle;
            TxtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsername.Location = new Point(25, 360);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(174, 29);
            TxtUsername.TabIndex = 9;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsername.Location = new Point(25, 332);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(81, 21);
            LblUsername.TabIndex = 8;
            LblUsername.Text = "Username";
            // 
            // TxtPassword
            // 
            TxtPassword.BorderStyle = BorderStyle.FixedSingle;
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword.Location = new Point(25, 432);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(174, 29);
            TxtPassword.TabIndex = 11;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.Location = new Point(25, 404);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(76, 21);
            LblPassword.TabIndex = 10;
            LblPassword.Text = "Password";
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(25, 481);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 12;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(124, 481);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 36);
            BtnUpdate.TabIndex = 13;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(220, 481);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(75, 36);
            BtnSubmit.TabIndex = 14;
            BtnSubmit.Text = "Submit";
            BtnSubmit.UseVisualStyleBackColor = true;
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // DgvEmployee
            // 
            DgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEmployee.Location = new Point(238, 71);
            DgvEmployee.Name = "DgvEmployee";
            DgvEmployee.Size = new Size(810, 348);
            DgvEmployee.TabIndex = 15;
            // 
            // LblEmployee
            // 
            LblEmployee.AutoSize = true;
            LblEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEmployee.Location = new Point(74, 9);
            LblEmployee.Name = "LblEmployee";
            LblEmployee.Size = new Size(103, 30);
            LblEmployee.TabIndex = 16;
            LblEmployee.Text = "Employee";
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(973, 432);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 36);
            BtnDelete.TabIndex = 18;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Location = new Point(877, 432);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 17;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 533);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(LblEmployee);
            Controls.Add(DgvEmployee);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(TxtPassword);
            Controls.Add(LblPassword);
            Controls.Add(TxtUsername);
            Controls.Add(LblUsername);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            Controls.Add(TxtPhone);
            Controls.Add(LblPhone);
            Controls.Add(TxtRole);
            Controls.Add(LblRole);
            Controls.Add(TxtFullName);
            Controls.Add(LblFullName);
            Name = "FormEmployee";
            Text = "FormEmployee";
            ((System.ComponentModel.ISupportInitialize)DgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFullName;
        private ToolTip toolTip1;
        private TextBox TxtFullName;
        private TextBox TxtRole;
        private Label LblRole;
        private TextBox TxtPhone;
        private Label LblPhone;
        private TextBox TxtEmail;
        private Label LblEmail;
        private TextBox TxtUsername;
        private Label LblUsername;
        private TextBox TxtPassword;
        private Label LblPassword;
        private Button BtnClear;
        private Button BtnUpdate;
        private Button BtnSubmit;
        private DataGridView DgvEmployee;
        private Label LblEmployee;
        private Button BtnDelete;
        private Button BtnEdit;
    }
}