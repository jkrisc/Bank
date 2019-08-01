using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Tests
{
    [TestClass()]
    public class BankTests
    {
        [TestMethod()]
        public void GetBalanceTest()
        {
            IBank bank = new Bank();
            Assert.AreEqual(5000, bank.GetBalance());
        }

        [TestMethod()]
        public void DepositTest()
        {
            IBank bank = new Bank();
            bank.Deposit(1000);
            Assert.AreEqual(6000, bank.GetBalance());
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            IBank bank = new Bank();
            bank.Withdraw(5000);
            Assert.AreEqual(0, bank.GetBalance());
        }
    }
}