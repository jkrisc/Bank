using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankDecorator : IBank
    {
        private IBank bank;

        public BankDecorator(IBank bank)
        {
            this.bank = bank;
        }

        public abstract double GetBalance();

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);
    }
}
