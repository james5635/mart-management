namespace mart_management
{
    partial class FormReport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            TvReport = new TreeView();
            TxtReportOutput = new TextBox();
            LblTitle = new Label();
            SuspendLayout();
            // 
            // TvReport
            // 
            TvReport.Font = new Font("Segoe UI", 10F);
            TvReport.Location = new Point(12, 45);
            TvReport.Name = "TvReport";
            TvReport.Size = new Size(460, 300);
            TvReport.TabIndex = 1;
            // 
            // TxtReportOutput
            // 
            TxtReportOutput.Font = new Font("Consolas", 9F);
            TxtReportOutput.Location = new Point(490, 45);
            TxtReportOutput.Multiline = true;
            TxtReportOutput.Name = "TxtReportOutput";
            TxtReportOutput.ReadOnly = true;
            TxtReportOutput.ScrollBars = ScrollBars.Both;
            TxtReportOutput.Size = new Size(380, 300);
            TxtReportOutput.TabIndex = 2;
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LblTitle.Location = new Point(12, 9);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(123, 25);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Sales Report";
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 361);
            Controls.Add(TxtReportOutput);
            Controls.Add(TvReport);
            Controls.Add(LblTitle);
            Name = "FormReport";
            Text = "Sales Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView TvReport;
        private TextBox TxtReportOutput;
        private Label LblTitle;
    }
}
