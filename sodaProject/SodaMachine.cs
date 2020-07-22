using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    class SodaMachine
    {
        public List<Can> Soda;
        public List<Coin> Register;

        



        public SodaMachine()
        {
            
            Soda = new List<Can>();
            for (int i = 0; i < 10; i++)
            {
                Soda.Add(new Cola());
            }
            for (int i = 0; i < 10; i++)
            {
                Soda.Add(new RootBeer());
            }
            for (int i = 0; i < 10; i++)
            {
                Soda.Add(new OrangeSoda());
            }

            Register = new List<Coin>();
            for (int i = 0; i < 50; i++)
            {
                Register.Add(new Penny());
            }
            for (int i = 0; i < 10; i++)
            {
                Register.Add(new Dime());
            }
            for (int i = 0; i < 20; i++)
            {
                Register.Add(new Nickle());
            }
            for (int i = 0; i < 20; i++)
            {
                Register.Add(new Quarter());
            }


        }
        
        
            
        
    }  
}
