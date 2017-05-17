using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Wallet_test;
namespace Wallet_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Wallet kek=new Wallet();
            kek.addMoney("RUB", 500);
            Assert.AreEqual(kek.getMoney("RUB"),500);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Wallet kek = new Wallet();
            kek.addMoney("RUB", 500);
            kek.addMoney("RUB", 1000);
            Assert.AreEqual(kek.getMoney("RUB"), 1500);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Wallet kek = new Wallet();
            kek.addMoney("RUB", 500);
            kek.addMoney("EUR", 1000);
            Assert.AreEqual(kek.getCount(), 2);

        }
        [TestMethod]
        public void TestMethod4()
        {
            Wallet kek = new Wallet();
            kek.addMoney("RUB", 500);
            kek.addMoney("EUR", 1000);
            Assert.AreEqual(kek.toString2(),"500 RUB,1000 EUR");

        }
    }
}

