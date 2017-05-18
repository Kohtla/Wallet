using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet_test
{
   public class Bank_plub : Bank
    {
        public int convert(int amount, string n1, string n2)
        {
            int rnd = 100;
            string str = n1 + n2;
            int l1 = (int)curse[str];
            //int rnd = 100;
            int m1 = (int)curse[n1 + n2];
            int kek = m1 * (rnd / 100) * amount;
            return kek / 1000;
          

        }
    }
}
