using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public abstract class BankTransaction : IBankTransaction
    {
        IBank bank;

        public BankTransaction(IBank bank)
        {
            this.bank = bank;
        }

        public abstract void Process(double amount);
    }
}
