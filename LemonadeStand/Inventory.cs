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
        public List<Cups> cups;
        public List<Lemons> lemons;
        public List<Sugar> sugar;
        public List<Ice> ice;

        //constructor
        public Inventory()
        {
            cups = new List<Cups>();
            lemons = new List<Lemons>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();

        }

        //methods
        /*         public void DisplayInventory()
                {
                    Console.WriteLine("You have {0} cups", cups);
                }
              private void AmountOfCups()
                {
                    Console.WriteLine($"You have {cups} cups.");
                }
                private void AmountOfLemons()
                {
                    Console.WriteLine($"You have {lemons} lemons.");
                }
                private void AmountOfSugar()
                {
                    Console.WriteLine($"You have {sugar} cups of sugar.");
                }
                private void AmountOfIce()
                {
                    Console.WriteLine($"You have {ice} ice cubes.");
                }
        */
    }
}
