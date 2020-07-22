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

        public void BackPackContain()
        {
            if (sodaMachine.Soda.Count -- == backpack.backpack.can.Count++)

        }
    }
}
