using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Decorators;

namespace Bank.Tests
{
    [TestClass()]
    public class LabelLoggerTests
    {
        [TestMethod()]
        public void LogSuccessTest()
        {
            Label label = new Label();
            ILogger logger = new LabelLogger(label);

            IBank bank = new LoggingDecorator(new Bank(), logger);
            bank.GetBalance();

            Assert.AreEqual("You have 5000 balance remaining.", label.Text);
        }

        [TestMethod()]
        public void LogErrorTest()
        {
            Label label = new Label();
            ILogger logger = new LabelLogger(label);

            IBank bank =new LoggingDecorator(new ValidatingDecorator(new Bank()), logger);
            bank.Deposit(60000);

            Assert.AreEqual("Transaction failed: Maximum deposit is 50000.", label.Text);
        }
    }
}