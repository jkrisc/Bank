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
    public class DepositTransactionTests
    {
        [TestMethod()]
        public void ProcessTest()
        {
            IBank bank = new Bank();
            IBankTransaction transaction = new DepositTransaction(bank);
            transaction.Process(5000);
            Assert.AreEqual(10000, bank.GetBalance());
        }
    }
}