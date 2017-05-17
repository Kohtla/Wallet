using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wallet_test
{
   public class Wallet
    {
        Hashtable wall = new Hashtable();
        Bank bank;
        public Wallet(Bank n1){
            bank = n1;
            }
   
        public void addMoney(string n, int amount)
        {
            if (wall[n] == null)
            {
                wall.Add(n, amount);

            }
            else {
                wall[n] = (int)wall[n]+ amount;
            }

        }
        int tryremov(string n, int amount) {
            if ((int)wall[n] < amount)
            {
                throw new System.OverflowException();

            }
            else
            {
                
                return (int)wall[n] - amount;
            }
            }
        public void removeMoney(string n, int amount)
        {
            try
            {
                wall[n] = tryremov(n, amount);
                if ((int)wall[n] == 0) wall.Remove(n);
            }
            catch(OverflowException e) {
                    
            }

        }
        public int getMoney(string n) {
            if (wall[n] == null)
            {
                return (int)wall[n];
            }
            else return 0;
        }
        public int getCount() {
            string str = "";
            ICollection leys = wall.Keys;
            return wall.Count;

        }
        public string toString2()
        {
            string str = "";
            ICollection leys = wall.Keys;
            foreach (string s in leys) {
                str = str +  wall[s].ToString() + " " + s + ",";
            }
           str=str.Substring(0, str.Length- 1);
            return str;
        }
        public int getTotalMoney(string a1)
        {
            int total=0;
            ICollection leys = wall.Keys;
            foreach(string s in leys)
            {
                if (s == a1)
                {
                    total = total + (int)wall[s];
                }
                else {
                    total = total + bank.convert((int)wall[s], s, a1);
                }

            }
            return total;

        }
    }


    public class Bank {
        Hashtable curse = new Hashtable();
        public Bank() {
            //RUB, USD, GBP
            curse.Add("RUBUSD", 20);
            curse.Add("RUBGPB", 16);
            curse.Add("USDRUB",60000);
            curse.Add("USDGPB", 850);
            curse.Add("GPBRUB", 70000);
            curse.Add("GPBUSD", 1200);

        }

        public int convert(int amount, string n1, string n2) {
            Random a = new Random();
            //  int rnd = a.Next(100, 120);
            string str = n1 + n2;
            int l1 = (int)curse[str];
            //int rnd = 100;
            //double m1 = (double)curse[n1 + n2];
            int kek = l1 * amount;
            return kek/1000;

        }
    }
}
