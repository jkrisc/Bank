using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Decorators
{
    public class ValidatingDecorator : BankDecorator
    {
        IBank bank;

        public ValidatingDecorator(IBank bank) : base(bank)
        {
            this.bank = bank;
        }

        public override double GetBalance()
        {
            return this.bank.GetBalance();
        }

        public override void Deposit(double amount)
        {
            ValidateDeposit(amount);
            this.bank.Deposit(amount);
        }

        public override void Withdraw(double amount)
        {
            ValidateWithdrawal(amount);
            this.bank.Withdraw(amount);
        }

        public void ValidateDeposit(double amount)
        {
            string message = String.Empty;
            if (amount < 1000)
            {
                message = "Minimum deposit is 1000.";
            }
            else if (amount > 50000)
            {
                message = "Maximum deposit is 50000.";
            }

            if (message != String.Empty)
            {
                throw new InvalidOperationException(message);
            }
        }

        public void ValidateWithdrawal(double amount)
        {
            string message = String.Empty;
            
            if (amount > this.bank.GetBalance())
            {
                message = "Insufficient balance.";
            }
            else if (amount < 300)
            {
                message = "Minimum withdrawal is 300.";
            }
            else if (amount > 10000)
            {
                message = "Maximum withdrawal is 10000.";
            }

            if (message != String.Empty)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}
