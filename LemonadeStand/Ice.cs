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
            PricePerIceCube();
        }

        //methods
        public void PricePerIceCube()
        {
            cost = .01m;
        }

    }
}
