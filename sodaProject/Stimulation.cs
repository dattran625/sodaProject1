using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    class Stimulation
    {
        public SodaMachine sodaMachine;
        public Customer customer;
        
        public  Stimulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
            

        }

        public void Run()
        {
            StaticUserInterfaces.DisplaySelection();


            StaticUserInterfaces.CoinSelectionDisplay();

            if ( customer.ValueOfListOfCoins(customer.payment) > sodaMachine.Soda[0].Price)

            {
                Console.WriteLine(" Your Change is :  + customer.ValueOfListOfCoins(customer.payment) - sodaMachine.Soda[0].Price)");
            }
            else if ( customer.ValueOfListOfCoins(customer.payment) < sodaMachine.Soda[0].Price)
            {
                Console.WriteLine(" please insert more coins");

            } 
            else if ( customer.ValueOfListOfCoins(customer.payment) == sodaMachine.Soda[0].Price)
            {
                Console.WriteLine(" Please take your Drink");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }





        //}
        //public void REturnChange(double refundAmount)
       // {
           // double totalRefund = 0;
            //(refundAmount > totalRefund)
           // {
               // if(refundAmount > 0.25)
                //{

               // }
          //  }
       // }

    }
}
