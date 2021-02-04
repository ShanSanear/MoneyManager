using System;
using MoneyManager;
using NUnit.Framework;

namespace MoneyManagerTest
{
    public class AccountTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckForInitialCreationValue()
        {
            var acc = new Account(100);
            int cashValue = acc.GetCash();
            Assert.AreEqual(100, cashValue);
        }

        [Test]
        public void CheckForSettingCashValue()
        {
            var acc = new Account(0);
            acc.SetCash(100);
            int cashValue = acc.GetCash();
            Assert.AreEqual(100, cashValue);
        }
        [Test]
        public void CheckForDecreasingCashValue()
        {
            var acc = new Account(0);
            acc.SetCash(100);
            acc.DecreaseCash(50);
            int cashValue = acc.GetCash();
            Assert.AreEqual(50, cashValue);
        }

        [Test]
        public void CheckForIncreasingCashValue()
        {
            var acc = new Account(200);
            acc.IncreaseCash(100);
            int cashvalue = acc.GetCash();
            Assert.AreEqual(300, cashvalue);
        }

        [Test]
        public void CheckForErrorWhenIncreasingWithNegativeValue()
        {
            var acc = new Account(0);
            Assert.Throws<InvalidOperationException>(() => acc.IncreaseCash(-100));
        }
        
        [Test]
        public void CheckForErrorWhenDecreasingWithNegativeValue()
        {
            var acc = new Account(0);
            Assert.Throws<InvalidOperationException>(() => acc.DecreaseCash(-100));
        }
    }
}