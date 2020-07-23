using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
    class BackPack
    {
        public SodaMachine sodaMachine;
        public BackPack backpack;
        public List<Can> can;


        public BackPack()
        {
            sodaMachine = new SodaMachine();
            backpack = new BackPack();
            can = new List<Can>();

        }
        public void SodaCanToBackpack()
        {
            for (int i = 0; i <sodaMachine.Soda.Count; i++)
                if (sodaMachine.Soda[i].Name == "Cola")
                {
                    Can canToRemove = sodaMachine.Soda[i];
                    sodaMachine.Soda.RemoveAt(i);
                    backpack.can.Add(canToRemove);
                    break;
                }
        }
    }
}
