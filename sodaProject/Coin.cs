using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    public abstract class Coin
    {
        public string Name;
        protected double value;
        protected double coinInventory;
        public double Value 
        {
            get
            {
                return value;
            }
          
        }
        
       
        
    }


}
