using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Money
    {
        //member variables
        public double cash;

        //constructor
        public Money()
        {
            this.cash = 20.00;
        }

        //methods
        public void DisplayMoney()
        {
            Console.WriteLine($"You have ${cash}.");
        }
    }
}
