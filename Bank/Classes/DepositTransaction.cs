using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public class DepositTransaction : BankTransaction
    {
        IBank bank;

        public DepositTransaction(IBank bank) : base(bank)
        {
            this.bank = bank;
        }

        public override void Process(double amount)
        {
            this.bank.Deposit(amount);
        }
    }
}
