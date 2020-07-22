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
        //private double penny;
        //private double nickle;
        //private double dime;
        //private double quarter;

        //public double Penny
        //{
        //    get { return penny; }
        //    set { Penny = value; }
        //}
        //public double Nickle
        //{
        //    get { return nickle; }
        //    set { Nickle = value; }
        //}
    }


}
