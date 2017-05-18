using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Wallet_test;
namespace Wallet_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_500_test()
        {
            Bank b = new Bank();
            MoneyPrinter_plub mp = new MoneyPrinter_plub();
            Wallet kek=new Wallet(b,mp);
            kek.addMoney("RUB", 500);
            string lol= "RUB";
            // Assert.AreEqual((int)kek.wall["RUB"], 500);
            Assert.AreEqual(kek.getMoney(lol), 500);

        }
        [TestMethod]
        public void Add_500_then_Add_1000_EQUAL_1500()
        {
            Bank b = new Bank();
            MoneyPrinter_plub mp = new MoneyPrinter_plub();
            Wallet kek = new Wallet(b,mp);
            kek.addMoney("RUB", 500);
            kek.addMoney("RUB", 1000);
            Assert.AreEqual(kek.getMoney("RUB"), 1500);

        }

        [TestMethod]
        public void Add_Two_Currencies()
        {
            Bank b = new Bank();
            MoneyPrinter_plub mp = new MoneyPrinter_plub();
            Wallet kek = new Wallet(b, mp);
            kek.addMoney("RUB", 500);
            kek.addMoney("EUR", 1000);
            Assert.AreEqual(kek.getCount(), 2);

        }
        [TestMethod]
        public void Add_than_watch_the_list()
        {
            Bank b = new Bank();
            MoneyPrinter_plub mp = new MoneyPrinter_plub();
            Wallet kek = new Wallet(b, mp);
            kek.addMoney("RUB", 500);
            kek.addMoney("EUR", 1000);
            Assert.AreEqual(kek.toString2(),"500 RUB,1000 EUR");

        }
        [TestMethod]
        public void Test_Converter()
        {
            Bank_plub b = new Bank_plub();
            MoneyPrinter_plub mp = new MoneyPrinter_plub();
            Wallet kek = new Wallet(b, mp);
            kek.addMoney("USD", 100);
            kek.addMoney("EUR", 100);
            int total = kek.getTotalMoney("RUB");
           // total= b.convert(100, "USD", "RUB");
            Assert.AreEqual(total, 13000);

        }

        
    }
}

