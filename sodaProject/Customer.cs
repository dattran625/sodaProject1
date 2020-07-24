using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    public class Customer
    {
        public Wallet wallet;
        public BackPack backpack;
        public List<Coin> payment;
      
        public Customer()
        {
            wallet = new Wallet();
            payment = new List<Coin>();
           
            payment.Add(new Penny());
            payment.Add(new Nickle());
            payment.Add(new Dime());
            payment.Add(new Quarter());
            
        }

        public  double ValueOfListOfCoins(List<Coin> coins)
        {
            double totalOfCoinValue = 0;
            foreach (Coin item in coins)
            {
                totalOfCoinValue += item.Value;
            }
            return totalOfCoinValue;
        }






    }
}
