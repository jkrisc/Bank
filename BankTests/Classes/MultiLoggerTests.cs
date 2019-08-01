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
    public class MultiLoggerTests
    {
        [TestMethod()]
        public void LogSuccessTest()
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
        public void LogErrorTest()
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
    }
}