namespace mart_management
{
    partial class FormSaleDetail
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
            LvSale = new ListView();
            LblSaleDetail = new Label();
            LvSaleDetail = new ListView();
            SuspendLayout();
            // 
            // LvSale
            // 
            LvSale.Location = new Point(12, 12);
            LvSale.Name = "LvSale";
            LvSale.Size = new Size(776, 72);
            LvSale.TabIndex = 0;
            LvSale.UseCompatibleStateImageBehavior = false;
            // 
            // LblSaleDetail
            // 
            LblSaleDetail.AutoSize = true;
            LblSaleDetail.Font = new Font("Segoe UI", 20F);
            LblSaleDetail.Location = new Point(12, 104);
            LblSaleDetail.Name = "LblSaleDetail";
            LblSaleDetail.Size = new Size(143, 37);
            LblSaleDetail.TabIndex = 1;
            LblSaleDetail.Text = "Sale Detail";
            // 
            // LvSaleDetail
            // 
            LvSaleDetail.Location = new Point(12, 159);
            LvSaleDetail.Name = "LvSaleDetail";
            LvSaleDetail.Size = new Size(776, 279);
            LvSaleDetail.TabIndex = 2;
            LvSaleDetail.UseCompatibleStateImageBehavior = false;
            // 
            // FormSaleDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LvSaleDetail);
            Controls.Add(LblSaleDetail);
            Controls.Add(LvSale);
            Name = "FormSaleDetail";
            Text = "FormSaleDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LvSale;
        private Label LblSaleDetail;
        private ListView LvSaleDetail;
    }
}