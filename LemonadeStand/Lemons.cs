using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemons : Items
    {
        //member variables

        //constructor
        public Lemons()
        {
            name = "Lemons";
            PricePerLemon();
        }

        //methods

        public void PricePerLemon()
        {
            cost = .06m;
        }

    }
}
