namespace Bank
{
    partial class frmBank
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnBalanceInquiry = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblTransactionResult = new System.Windows.Forms.Label();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmAmount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(850, 224);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(214, 196);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(12, 537);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1210, 249);
            this.txtLog.TabIndex = 4;
            this.txtLog.TabStop = false;
            // 
            // btnBalanceInquiry
            // 
            this.btnBalanceInquiry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBalanceInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceInquiry.Location = new System.Drawing.Point(174, 224);
            this.btnBalanceInquiry.Name = "btnBalanceInquiry";
            this.btnBalanceInquiry.Size = new System.Drawing.Size(214, 196);
            this.btnBalanceInquiry.TabIndex = 0;
            this.btnBalanceInquiry.Text = "Balance Inquiry";
            this.btnBalanceInquiry.UseVisualStyleBackColor = true;
            this.btnBalanceInquiry.Click += new System.EventHandler(this.btnBalanceInquiry_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(512, 224);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(214, 196);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblTransactionResult
            // 
            this.lblTransactionResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionResult.Location = new System.Drawing.Point(34, 285);
            this.lblTransactionResult.Name = "lblTransactionResult";
            this.lblTransactionResult.Size = new System.Drawing.Size(1156, 75);
            this.lblTransactionResult.TabIndex = 4;
            this.lblTransactionResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTransactionResult.Visible = false;
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btnNewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTransaction.Location = new System.Drawing.Point(819, 450);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(245, 61);
            this.btnNewTransaction.TabIndex = 2;
            this.btnNewTransaction.Text = "New Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Visible = false;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // numAmount
            // 
            this.numAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(446, 303);
            this.numAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(280, 38);
            this.numAmount.TabIndex = 0;
            this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAmount.ThousandsSeparator = true;
            this.numAmount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numAmount.Visible = false;
            // 
            // btnConfirmAmount
            // 
            this.btnConfirmAmount.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btnConfirmAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAmount.Location = new System.Drawing.Point(732, 303);
            this.btnConfirmAmount.Name = "btnConfirmAmount";
            this.btnConfirmAmount.Size = new System.Drawing.Size(95, 38);
            this.btnConfirmAmount.TabIndex = 1;
            this.btnConfirmAmount.Text = "Confirm";
            this.btnConfirmAmount.UseVisualStyleBackColor = true;
            this.btnConfirmAmount.Visible = false;
            this.btnConfirmAmount.Click += new System.EventHandler(this.btnConfirmAmount_Click);
            // 
            // frmBank
            // 
            this.AcceptButton = this.btnConfirmAmount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 798);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnBalanceInquiry);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnConfirmAmount);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.lblTransactionResult);
            this.Name = "frmBank";
            this.Text = "Bank";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnBalanceInquiry;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblTransactionResult;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnConfirmAmount;
    }
}

