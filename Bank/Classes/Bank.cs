using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank : IBank
    {
        private static readonly double _initialBalance = 5000.00;

        private double _currentBalance { get; set; }

        public Bank()
        {
            this._currentBalance = _initialBalance;
        }

        public double GetBalance()
        {
            return this._currentBalance;
        }

        public void Deposit(double amount)
        {
            this._currentBalance += amount;
        }

        public void Withdraw(double amount)
        {
            this._currentBalance -= amount;
        }

    }
}
