using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    public static class Calculation
    {
       


        public static double DepositCoin(double payment, Customer customer, SodaMachine sodaMachine)
        {
            switch(payment)
            {

                case .01:
                    for (int i = 0; i < customer.payment.Count; i++)
                    {
                        if(customer.payment[i].Name == "Penny")
                        {
                            Coin coinToPay = customer.payment[i];
                            customer.payment.RemoveAt(i);
                            sodaMachine.Register.Add(coinToPay);
                            return coinToPay.Value;
                        }
                                     
                       
                    }
                        break;
                case .05:
                    for (int i = 0; i < customer.payment.Count; i++)
                    {
                        if (customer.payment[i].Name == "Nickel")
                        {
                            Coin coinToPay = customer.payment[i];
                            customer.payment.RemoveAt(i);
                            sodaMachine.Register.Add(coinToPay);
                            return coinToPay.Value;
                            
                        }
                    }
                    break;
                    
                   case .10:
                    for (int i = 0; i < customer.payment.Count; i++)
                    {
                        if (customer.payment[i].Name == "Dime")
                        {
                            Coin coinToPay = customer.payment[i];
                            customer.payment.RemoveAt(i);
                            sodaMachine.Register.Add(coinToPay);
                             return coinToPay.Value;
                        }
                    }
                    break;
                case .25:
                    for (int i = 0; i < customer.payment.Count; i++)
                    {
                        if (customer.payment[i].Name == "Quarter")
                        {
                            Coin coinToPay = customer.payment[i];
                            customer.payment.RemoveAt(i);
                            sodaMachine.Register.Add(coinToPay);
                            return coinToPay.Value;
                        }
                    }
                    break;
                    default:
                    {
                        Console.WriteLine("Invalid Entry");
                       
                        return DepositCoin(payment, customer, sodaMachine);
                    }

                    
            }
                    return DepositCoin(payment, customer, sodaMachine);
        }
       
    }
}
