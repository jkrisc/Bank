using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Decorators.Tests
{
    [TestClass()]
    public class ValidatingDecoratorTests
    {
        [TestMethod()]
        public void ValidateDepositTest()
        {
            IBank bank = new ValidatingDecorator(new Bank());

            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                bank.Deposit(100000);
            });

            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                bank.Deposit(100);
            });
        }

        [TestMethod()]
        public void ValidateWithdrawalTest()
        {
            IBank bank = new ValidatingDecorator(new Bank());

            var notEnoughBalance = Assert.ThrowsException<InvalidOperationException>(() =>
            {
                bank.Withdraw(5001);
            });
            Assert.AreEqual("Insufficient balance.", notEnoughBalance.Message);

            bank.Deposit(50000);
            var overTheLimit = Assert.ThrowsException<InvalidOperationException>(() =>
            {
                bank.Withdraw(50000);
            });
            Assert.AreEqual("Maximum withdrawal is 10000.", overTheLimit.Message);

            var underTheLimit = Assert.ThrowsException<InvalidOperationException>(() =>
            {
                bank.Withdraw(100);
            });
            Assert.AreEqual("Minimum withdrawal is 300.", underTheLimit.Message);
        }
    }
}