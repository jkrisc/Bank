using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class WithdrawTransaction : BankTransaction
    {
        IBank bank;

        public WithdrawTransaction(IBank bank) : base(bank)
        {
            this.bank = bank;
        }

        public override void Process(double amount)
        {
            this.bank.Withdraw(amount);
        }
    }
}
