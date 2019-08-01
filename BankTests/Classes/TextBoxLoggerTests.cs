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
    public class TextBoxLoggerTests
    {
        [TestMethod()]
        public void LogSuccessTest()
        {
            TextBox textBox = new TextBox();
            ILogger logger = new TextBoxLogger(textBox);

            IBank bank = new LoggingDecorator(new Bank(), logger);
            bank.GetBalance();

            Assert.AreEqual("You have 5000 balance remaining." + Environment.NewLine, textBox.Text);
        }

        [TestMethod()]
        public void LogErrorTest()
        {
            TextBox textBox = new TextBox();
            ILogger logger = new TextBoxLogger(textBox);

            IBank bank = new LoggingDecorator(new ValidatingDecorator(new Bank()), logger);
            bank.Deposit(60000);

            Assert.AreEqual("Transaction failed: Maximum deposit is 50000." + Environment.NewLine, textBox.Text);
        }
    }
}