namespace mart_management
{
    partial class FormPayment
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
            LblPayment = new Label();
            DgvPayment = new DataGridView();
            BtnSubmit = new Button();
            BtnUpdate = new Button();
            BtnClear = new Button();
            TxtPaymentMethod = new TextBox();
            TxtAmountPaid = new TextBox();
            AmountPaid = new Label();
            LblPaymentDate = new Label();
            toolTip1 = new ToolTip(components);
            LblPaymentMethod = new Label();
            LblSaleID = new Label();
            CboSaleID = new ComboBox();
            DtpPaymentDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DgvPayment).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Location = new Point(792, 327);
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
            BtnEdit.Location = new Point(696, 327);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 36);
            BtnEdit.TabIndex = 36;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // LblPayment
            // 
            LblPayment.AutoSize = true;
            LblPayment.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPayment.Location = new Point(77, 6);
            LblPayment.Name = "LblPayment";
            LblPayment.Size = new Size(93, 30);
            LblPayment.TabIndex = 35;
            LblPayment.Text = "Payment";
            // 
            // DgvPayment
            // 
            DgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPayment.Location = new Point(300, 60);
            DgvPayment.Name = "DgvPayment";
            DgvPayment.Size = new Size(567, 246);
            DgvPayment.TabIndex = 34;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSubmit.Location = new Point(223, 366);
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
            BtnUpdate.Location = new Point(127, 366);
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
            BtnClear.Location = new Point(28, 366);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 36);
            BtnClear.TabIndex = 31;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtPaymentMethod
            // 
            TxtPaymentMethod.BorderStyle = BorderStyle.FixedSingle;
            TxtPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPaymentMethod.Location = new Point(28, 285);
            TxtPaymentMethod.Name = "TxtPaymentMethod";
            TxtPaymentMethod.Size = new Size(174, 29);
            TxtPaymentMethod.TabIndex = 26;
            // 
            // TxtAmountPaid
            // 
            TxtAmountPaid.BorderStyle = BorderStyle.FixedSingle;
            TxtAmountPaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAmountPaid.Location = new Point(28, 216);
            TxtAmountPaid.Name = "TxtAmountPaid";
            TxtAmountPaid.Size = new Size(174, 29);
            TxtAmountPaid.TabIndex = 24;
            // 
            // AmountPaid
            // 
            AmountPaid.AutoSize = true;
            AmountPaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountPaid.Location = new Point(28, 188);
            AmountPaid.Name = "AmountPaid";
            AmountPaid.Size = new Size(95, 21);
            AmountPaid.TabIndex = 23;
            AmountPaid.Text = "AmountPaid";
            // 
            // LblPaymentDate
            // 
            LblPaymentDate.AutoSize = true;
            LblPaymentDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPaymentDate.Location = new Point(28, 117);
            LblPaymentDate.Name = "LblPaymentDate";
            LblPaymentDate.Size = new Size(102, 21);
            LblPaymentDate.TabIndex = 21;
            LblPaymentDate.Text = "PaymentDate";
            // 
            // LblPaymentMethod
            // 
            LblPaymentMethod.AutoSize = true;
            LblPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPaymentMethod.Location = new Point(28, 257);
            LblPaymentMethod.Name = "LblPaymentMethod";
            LblPaymentMethod.Size = new Size(124, 21);
            LblPaymentMethod.TabIndex = 25;
            LblPaymentMethod.Text = "PaymentMethod";
            // 
            // LblSaleID
            // 
            LblSaleID.AutoSize = true;
            LblSaleID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSaleID.Location = new Point(28, 49);
            LblSaleID.Name = "LblSaleID";
            LblSaleID.Size = new Size(54, 21);
            LblSaleID.TabIndex = 19;
            LblSaleID.Text = "SaleID";
            // 
            // CboSaleID
            // 
            CboSaleID.Font = new Font("Segoe UI", 12F);
            CboSaleID.FormattingEnabled = true;
            CboSaleID.Location = new Point(28, 78);
            CboSaleID.Name = "CboSaleID";
            CboSaleID.Size = new Size(207, 29);
            CboSaleID.TabIndex = 38;
            // 
            // DtpPaymentDate
            // 
            DtpPaymentDate.CalendarFont = new Font("Segoe UI", 12F);
            DtpPaymentDate.Location = new Point(28, 153);
            DtpPaymentDate.Name = "DtpPaymentDate";
            DtpPaymentDate.Size = new Size(207, 23);
            DtpPaymentDate.TabIndex = 39;
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 415);
            Controls.Add(DtpPaymentDate);
            Controls.Add(CboSaleID);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(LblPayment);
            Controls.Add(DgvPayment);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(TxtPaymentMethod);
            Controls.Add(TxtAmountPaid);
            Controls.Add(AmountPaid);
            Controls.Add(LblPaymentDate);
            Controls.Add(LblPaymentMethod);
            Controls.Add(LblSaleID);
            Name = "FormPayment";
            Text = "FormPayment";
            ((System.ComponentModel.ISupportInitialize)DgvPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDelete;
        private Button BtnEdit;
        private Label LblPayment;
        private DataGridView DgvPayment;
        private Button BtnSubmit;
        private Button BtnUpdate;
        private Button BtnClear;
        private TextBox TxtPaymentMethod;
        private TextBox TxtAmountPaid;
        private Label AmountPaid;
        private TextBox TxtRole;
        private Label LblPaymentDate;
        private ToolTip toolTip1;
        private Label LblPaymentMethod;
        private Label LblSaleID;
        private ComboBox CboSaleID;
        private DateTimePicker DtpPaymentDate;
    }
}