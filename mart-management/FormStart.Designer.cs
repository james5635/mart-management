namespace mart_management
{
    partial class FormStart
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
            BtnCategory = new Button();
            TxtCustomer = new Button();
            BtnSupplier = new Button();
            BtnEmployee = new Button();
            SuspendLayout();
            // 
            // BtnCategory
            // 
            BtnCategory.Font = new Font("Segoe UI", 12F);
            BtnCategory.Location = new Point(12, 12);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(288, 36);
            BtnCategory.TabIndex = 0;
            BtnCategory.Text = "Category";
            BtnCategory.UseVisualStyleBackColor = true;
            BtnCategory.Click += BtnCategory_Click;
            // 
            // TxtCustomer
            // 
            TxtCustomer.Font = new Font("Segoe UI", 12F);
            TxtCustomer.Location = new Point(12, 54);
            TxtCustomer.Name = "TxtCustomer";
            TxtCustomer.Size = new Size(288, 36);
            TxtCustomer.TabIndex = 1;
            TxtCustomer.Text = "Customer";
            TxtCustomer.UseVisualStyleBackColor = true;
            TxtCustomer.Click += TxtCustomer_Click;
            // 
            // BtnSupplier
            // 
            BtnSupplier.Font = new Font("Segoe UI", 12F);
            BtnSupplier.Location = new Point(12, 96);
            BtnSupplier.Name = "BtnSupplier";
            BtnSupplier.Size = new Size(288, 36);
            BtnSupplier.TabIndex = 2;
            BtnSupplier.Text = "Supplier";
            BtnSupplier.UseVisualStyleBackColor = true;
            BtnSupplier.Click += BtnSupplier_Click;
            // 
            // BtnEmployee
            // 
            BtnEmployee.Font = new Font("Segoe UI", 12F);
            BtnEmployee.Location = new Point(12, 138);
            BtnEmployee.Name = "BtnEmployee";
            BtnEmployee.Size = new Size(288, 36);
            BtnEmployee.TabIndex = 3;
            BtnEmployee.Text = "Employee";
            BtnEmployee.UseVisualStyleBackColor = true;
            BtnEmployee.Click += BtnEmployee_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 450);
            Controls.Add(BtnEmployee);
            Controls.Add(BtnSupplier);
            Controls.Add(TxtCustomer);
            Controls.Add(BtnCategory);
            Name = "FormStart";
            Text = "FormStart";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCategory;
        private Button TxtCustomer;
        private Button BtnSupplier;
        private Button BtnEmployee;
    }
}