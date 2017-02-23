using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cups : Items
    {
        //member variables

        //constructor
        public Cups()
        {
            name = "Cups";
            PricePerCup();
        }

        //methods
        public void PricePerCup()
        {
            cost = .02m;
        }

    }
}
