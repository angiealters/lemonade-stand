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
        public decimal cash;

        //constructor
        public Money()
        {
            cash = 20.00m;
        }

        //methods
        public void DisplayMoney()
        {
            Console.WriteLine($"You have ${cash}.");
        }
/*        public bool SubtractFromCash(decimal amount)
        {
            if(cash - amount >= 0)
            {
                cash -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddToCash(decimal amount)
        {
            cash += amount;
        }
*/
    }
}
