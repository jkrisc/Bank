using Bank.Decorators;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmBank : Form
    {
        IBank bank = null;
        IBankTransaction transaction = null;

        public frmBank()
        {
            InitializeComponent();

            List<ILogger> loggers = new List<ILogger>();
            loggers.Add(new TextBoxLogger(txtLog));
            loggers.Add(new LabelLogger(lblTransactionResult));

            // this allows logging onto different controls
            ILogger multiLogger = new MultiLogger(loggers);

            IBank bankWithValidator = new ValidatingDecorator(new Bank());
            bank = new LoggingDecorator(bankWithValidator, multiLogger);
        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {
            ShowTransactionView();
            bank.GetBalance();
            ShowTransactionResult();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            ShowTransactionWithInputView();

            // prepares a deposit transaction on bank to be processed once amount is confirmed
            transaction = new DepositTransaction(bank);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            ShowTransactionWithInputView();

            // prepares a withdraw transaction on bank to be processed once amount is confirmed
            transaction = new WithdrawTransaction(bank);
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            ResetControlsToDefault();
        }

        private void btnConfirmAmount_Click(object sender, EventArgs e)
        {
            // processes the prepared transaction
            transaction.Process((double)numAmount.Value);

            ShowTransactionResult();
            ToggleTransactionInputVisibility(false);
        }

        private void ShowTransactionView()
        {
            ToggleTransactionMenuVisibility(false);
            btnNewTransaction.Visible = true;
            ShowTransactionResult();
        }

        private void ShowTransactionWithInputView()
        {
            ToggleTransactionMenuVisibility(false);
            ToggleTransactionInputVisibility(true);
            btnNewTransaction.Visible = true;

            numAmount.Focus();
            numAmount.Select(0, numAmount.Text.Length);
        }

        private void ShowTransactionResult()
        {
            lblTransactionResult.Visible = true;
        }

        private void ShowTransactionMenu()
        {
            ResetControlsToDefault();
        }

        private void ResetControlsToDefault()
        {
            ToggleTransactionMenuVisibility(true);
            ToggleTransactionInputVisibility(false);

            btnNewTransaction.Visible =
                lblTransactionResult.Visible = false;

            numAmount.Value = 0;
            lblTransactionResult.Text = String.Empty;
        }

        private void ToggleTransactionMenuVisibility(bool visible)
        {
            btnBalanceInquiry.Visible =
                btnDeposit.Visible =
                btnWithdraw.Visible = visible;
        }

        private void ToggleTransactionInputVisibility(bool visible)
        {
            numAmount.Visible =
                btnConfirmAmount.Visible = visible;
        }
    }
}
