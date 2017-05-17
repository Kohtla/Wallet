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
        public Wallet(){
            
            }
   
        public void addMoney(string n, int amount)
        {
            if (wall[n] == null)
            {
                wall[n] = amount;

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
    }
}
