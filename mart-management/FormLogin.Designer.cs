namespace mart_management
{
    partial class FormLogin
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
            TxtEmployeeID = new TextBox();
            LblEmployeeID = new Label();
            TxtUsername = new TextBox();
            LblUsername = new Label();
            TxtPassword = new TextBox();
            LblPassword = new Label();
            BtnClear = new Button();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // TxtEmployeeID
            // 
            TxtEmployeeID.BorderStyle = BorderStyle.FixedSingle;
            TxtEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEmployeeID.Location = new Point(29, 45);
            TxtEmployeeID.Name = "TxtEmployeeID";
            TxtEmployeeID.Size = new Size(174, 29);
            TxtEmployeeID.TabIndex = 57;
            // 
            // LblEmployeeID
            // 
            LblEmployeeID.AutoSize = true;
            LblEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEmployeeID.Location = new Point(29, 16);
            LblEmployeeID.Name = "LblEmployeeID";
            LblEmployeeID.Size = new Size(93, 21);
            LblEmployeeID.TabIndex = 56;
            LblEmployeeID.Text = "EmployeeID";
            // 
            // TxtUsername
            // 
            TxtUsername.BorderStyle = BorderStyle.FixedSingle;
            TxtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsername.Location = new Point(29, 119);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(174, 29);
            TxtUsername.TabIndex = 59;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsername.Location = new Point(29, 90);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(81, 21);
            LblUsername.TabIndex = 58;
            LblUsername.Text = "Username";
            // 
            // TxtPassword
            // 
            TxtPassword.BorderStyle = BorderStyle.FixedSingle;
            TxtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword.Location = new Point(29, 192);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(174, 29);
            TxtPassword.TabIndex = 61;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.Location = new Point(29, 163);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(76, 21);
            LblPassword.TabIndex = 60;
            LblPassword.Text = "Password";
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(29, 248);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 62;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(128, 248);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 36);
            BtnLogin.TabIndex = 63;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 301);
            Controls.Add(BtnLogin);
            Controls.Add(BtnClear);
            Controls.Add(TxtPassword);
            Controls.Add(LblPassword);
            Controls.Add(TxtUsername);
            Controls.Add(LblUsername);
            Controls.Add(TxtEmployeeID);
            Controls.Add(LblEmployeeID);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEmployeeID;
        private Label LblEmployeeID;
        private TextBox TxtUsername;
        private Label LblUsername;
        private TextBox TxtPassword;
        private Label LblPassword;
        private Button BtnClear;
        private Button BtnLogin;
    }
}