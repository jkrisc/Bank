﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IBank
    {
        double GetBalance();

        void Deposit(double amount);

        void Withdraw(double amount);
    }
}
