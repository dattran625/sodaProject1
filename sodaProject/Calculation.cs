using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    class Calculation
    {
        static public Wallet wallet;
        static public SodaMachine sodaMachine;
        static public Can can;


        static void DepositCoin(double money)
        {
            switch(money)
            {

                case (1):
                    for (int i = 0; i < wallet.Money.Count; i++)
                    {
                        if(wallet.Money[i].Name == "Penny")
                        {
                            Coin coinToPay = wallet.Money[i];
                            wallet.Money.RemoveAt(i);
                            sodaMachine.Register.Add(coinToPay);
                            break;
                        }
                    }
                    break;
                case (5):
                    for (int i = 0; i < wallet.Money.Count; i++)
                    {
                        if (wallet.Money[i].Name == "Nickel")
                        {
                            Coin coinToPay = wallet.Money[i];
                            wallet.Money.RemoveAt(i);
                            sodaMachine.Register.Add(coinToPay);
                            break;
                        }
                    }
                    break;
                    
                   case (10):
                    for (int i = 0; i < wallet.Money.Count; i++)
                    {
                        if (wallet.Money[i].Name == "Dime")
                        {
                            Coin coinToPay = wallet.Money[i];
                            wallet.Money.RemoveAt(i);
                            sodaMachine.Register.Add(coinToPay);
                            break;
                        }
                    }
                    break;
                case (25):
                    for (int i = 0; i < wallet.Money.Count; i++)
                    {
                        if (wallet.Money[i].Name == "Quarter")
                        {
                            Coin coinToPay = wallet.Money[i];
                            wallet.Money.RemoveAt(i);
                            sodaMachine.Register.Add(coinToPay);
                            break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;

                    
            }
        }
    }
}
