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
            AmountOfSugar();
            PricePerCupOfSugar();
        }

        //methods
        public void AmountOfSugar()
        {
            quantity = 0;
        }
        public void PricePerCupOfSugar()
        {
            cost = .07m;
        }
    }
}
