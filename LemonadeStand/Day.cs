using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public int day = 1;

        //constructor

        //methods
        public void DisplayDay()
        {
            Console.WriteLine("Day {0}", day++);
        }
    }
}
