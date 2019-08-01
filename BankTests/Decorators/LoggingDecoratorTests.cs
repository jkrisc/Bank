using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Decorators.Tests
{
    [TestClass()]
    public class LoggingDecoratorTests
    {
        [TestMethod()]
        public void GetBalanceTest()
        {
            TextBox textBox = new TextBox();
            Label label = new Label();
            ILogger multiLogger = new MultiLogger(new List<ILogger>
            {
                new TextBoxLogger(textBox),
                new LabelLogger(label)
            });
            IBank bank = new LoggingDecorator(new Bank(), multiLogger);

            bank.GetBalance();
            Assert.AreEqual("You have 5000 balance remaining." + Environment.NewLine, textBox.Text);
            Assert.AreEqual("You have 5000 balance remaining.", label.Text);
        }

        [TestMethod()]
        public void DepositTest()
        {
            TextBox textBox = new TextBox();
            Label label = new Label();
            ILogger multiLogger = new MultiLogger(new List<ILogger>
            {
                new TextBoxLogger(textBox),
                new LabelLogger(label)
            });
            IBank bank = new LoggingDecorator(new Bank(), multiLogger);

            bank.Deposit(2000);
            Assert.AreEqual("You have deposited 2000." + Environment.NewLine, textBox.Text);
            Assert.AreEqual("You have deposited 2000.", label.Text);
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            TextBox textBox = new TextBox();
            Label label = new Label();
            ILogger multiLogger = new MultiLogger(new List<ILogger>
            {
                new TextBoxLogger(textBox),
                new LabelLogger(label)
            });
            IBank bank = new LoggingDecorator(new Bank(), multiLogger);

            bank.Withdraw(2000);
            Assert.AreEqual("You have withdrawn 2000." + Environment.NewLine, textBox.Text);
            Assert.AreEqual("You have withdrawn 2000.", label.Text);
        }
    }
}