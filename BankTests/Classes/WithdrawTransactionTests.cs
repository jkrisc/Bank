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
    public class WithdrawTransactionTests
    {
        [TestMethod()]
        public void ProcessTest()
        {
            IBank bank = new Bank();
            IBankTransaction transaction = new WithdrawTransaction(bank);
            transaction.Process(5000);
            Assert.AreEqual(0, bank.GetBalance());
        }
    }
}