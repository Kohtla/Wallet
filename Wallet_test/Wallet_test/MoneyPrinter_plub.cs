using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet_test
{
    public class MoneyPrinter_plub : MoneyPrinter
    {
        public string printed = "";

        public void print(string ops, string curr, string am)
        {
            printed = "# - " + ops + " - валюта: " + curr + ", в количестве: " + am;
        }
    }
}
