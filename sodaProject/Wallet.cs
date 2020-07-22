using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    class Wallet
    {
        public List<Coin> Money;

        public Wallet()
        {
            Money = new List<Coin>();

            Money.Add(new Dime());
            Money.Add(new Quarter());
        }
    }
}
