using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice : Items
    {
        //member variables

        //constructor
        public Ice()
        {
            name = "Ice";
            AmountOfIce();
            PricePerIceCube();
        }

        //methods
        public void AmountOfIce()
        {
            quantity = 0;
        }
        public void PricePerIceCube()
        {
            cost = .01m;
        }

    }
}
