using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Decorators
{
    public class LoggingDecorator : BankDecorator
    {
        IBank bank;
        ILogger logger;

        public LoggingDecorator(IBank bank, ILogger logger) : base(bank)
        {
            this.bank = bank;
            this.logger = logger;
        }

        public override double GetBalance()
        {
            double balance = this.bank.GetBalance();
            logger.LogSuccess(String.Format("You have {0} balance remaining.", balance));

            return balance;
        }

        public override void Deposit(double amount)
        {
            try
            {
                this.bank.Deposit(amount);
                logger.LogSuccess(String.Format("You have deposited {0}.", amount));
            }
            catch (InvalidOperationException ex)
            {
                logger.LogError(ex.Message);
            }
        }

        public override void Withdraw(double amount)
        {
            try
            {
                this.bank.Withdraw(amount);
                logger.LogSuccess(String.Format("You have withdrawn {0}.", amount));
            }
            catch (InvalidOperationException ex)
            {
                logger.LogError(ex.Message);
            }
        }
    }
}
