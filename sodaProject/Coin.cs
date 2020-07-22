using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    abstract class Coin
    {
        public string Name;
        protected double value;
        public double Value 
        {
            get
            {
                return value;
            }
          
        }
       
        
    }


}
