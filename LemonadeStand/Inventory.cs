using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables
        public double cups;
        public double lemons;
        public double sugar;
        public double ice;

        //constructor
        public Inventory()
        {
            this.cups = 0;
            this.lemons = 0;
            this.sugar = 0;
            this.ice = 0;
        }

        //methods
        public void DisplayInventory()
        {
            Console.WriteLine($"You have {cups} cups, {lemons} lemons, {sugar} cups of sugar, and {ice} ice cubes.");
        }
 /*       private void AmountOfCups()
        {
            cups = 0;
            Console.WriteLine($"You have {cups} cups.");
        }
        private void AmountOfLemons()
        {
            lemons = 0;
            Console.WriteLine($"You have {lemons} lemons.");
        }
        private void AmountOfSugar()
        {
            sugar = 0;
            Console.WriteLine($"You have {sugar} cups of sugar.");
        }
        private void AmountOfIce()
        {
            ice = 0;
            Console.WriteLine($"You have {ice} ice cubes.");
        }
   */
    }
}
