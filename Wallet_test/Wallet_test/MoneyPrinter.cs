using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet_test
{
    public class MoneyPrinter
    {
        public void print(string ops, string curr, string am)
        {
            System.Diagnostics.Trace.WriteLine("# - " + ops + " - валюта: " + curr + ", в количестве: " + am);
            
        }
    }
}
