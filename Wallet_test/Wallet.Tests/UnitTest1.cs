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
            Bank b = new Bank();
            Wallet kek=new Wallet(b);
            kek.addMoney("RUB", 500);
            Assert.AreEqual(kek.getMoney("RUB"),500);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Bank b = new Bank();
            Wallet kek = new Wallet(b);
            kek.addMoney("RUB", 500);
            kek.addMoney("RUB", 1000);
            Assert.AreEqual(kek.getMoney("RUB"), 1500);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Bank b = new Bank();
            Wallet kek = new Wallet(b);
            kek.addMoney("RUB", 500);
            kek.addMoney("EUR", 1000);
            Assert.AreEqual(kek.getCount(), 2);

        }
        [TestMethod]
        public void TestMethod4()
        {
            Bank b = new Bank();
            Wallet kek = new Wallet(b);
            kek.addMoney("RUB", 500);
            kek.addMoney("EUR", 1000);
            Assert.AreEqual(kek.toString2(),"500 RUB,1000 EUR");

        }
        [TestMethod]
        public void TestMethod5()
        {
            Bank b = new Bank();
            //Wallet kek = new Wallet(b);
            //kek.addMoney("USD", 100);
            //kek.addMoney("EUR", 100);
            //int total = kek.getTotalMoney("RUB");
           int total= b.convert(100, "USD", "RUB");
            Assert.AreEqual(total, 6000);

        }
    }
}

