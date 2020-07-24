using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    public class Wallet
    {
        public List<Coin> Money;

        public Wallet()
        {
            Money = new List<Coin>();

            for (int i = 0; i < 10; i++)
            {
                Money.Add(new Dime());
            }
            for (int i = 0; i < 8; i++)

            {
                Money.Add(new Quarter());
            }
            for (int i = 0; i < 15; i++)
            {
                Money.Add(new Nickle());
            }
            for (int i = 0; i < 50; i++)
            {
                Money.Add(new Penny());
            }
        }
    }
}
