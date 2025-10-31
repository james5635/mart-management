namespace mart_management
{
    partial class FormPurchaseDetail
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
            LvPurchaseDetail = new ListView();
            LblPurchaseDetail = new Label();
            LvPurchase = new ListView();
            SuspendLayout();
            // 
            // LvPurchaseDetail
            // 
            LvPurchaseDetail.Location = new Point(12, 159);
            LvPurchaseDetail.Name = "LvPurchaseDetail";
            LvPurchaseDetail.Size = new Size(776, 279);
            LvPurchaseDetail.TabIndex = 5;
            LvPurchaseDetail.UseCompatibleStateImageBehavior = false;
            LvPurchaseDetail.ItemSelectionChanged += LvPurchaseDetail_ItemSelectionChanged;
            // 
            // LblPurchaseDetail
            // 
            LblPurchaseDetail.AutoSize = true;
            LblPurchaseDetail.Font = new Font("Segoe UI", 20F);
            LblPurchaseDetail.Location = new Point(12, 104);
            LblPurchaseDetail.Name = "LblPurchaseDetail";
            LblPurchaseDetail.Size = new Size(199, 37);
            LblPurchaseDetail.TabIndex = 4;
            LblPurchaseDetail.Text = "Purchase Detail";
            // 
            // LvPurchase
            // 
            LvPurchase.Location = new Point(12, 12);
            LvPurchase.Name = "LvPurchase";
            LvPurchase.Size = new Size(776, 72);
            LvPurchase.TabIndex = 3;
            LvPurchase.UseCompatibleStateImageBehavior = false;
            LvPurchase.ItemSelectionChanged += LvPurchase_ItemSelectionChanged;
            // 
            // FormPurchaseDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LvPurchaseDetail);
            Controls.Add(LblPurchaseDetail);
            Controls.Add(LvPurchase);
            Name = "FormPurchaseDetail";
            Text = "FormPurchaseDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LvPurchaseDetail;
        private Label LblPurchaseDetail;
        private ListView LvPurchase;
    }
}