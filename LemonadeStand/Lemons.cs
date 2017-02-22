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
//            AmountOfLemons();
            PricePerLemon();
        }

        //methods
//        public void AmountOfLemons()
//        {
//            quantity = 0;
//        }
        public void PricePerLemon()
        {
            cost = .06m;
        }

    }
}
