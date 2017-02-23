using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Items
    {
        //member variables

        //constructor
        public Sugar()
        {
            name = "Sugar";
            PricePerCupOfSugar();
        }

        //methods
        public void PricePerCupOfSugar()
        {
            cost = .07m;
        }
    }
}
