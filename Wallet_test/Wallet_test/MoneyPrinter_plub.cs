using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet_test
{
    public class MoneyPrinter_plub : MoneyPrinter
    {
        private string printed { get; set; }

        public string print(string ops, string curr, string am)
        {
            printed = ops + curr +am;
        }
    }
}
