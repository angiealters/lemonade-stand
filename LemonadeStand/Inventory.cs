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
        Recipe recipe;

        //constructor
        public Inventory(Recipe recipe)
        {
            cups = new List<Cups>();
            lemons = new List<Lemons>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            this.recipe = recipe;
        }

        //methods
        public void MakePitcherOfLemonade()
        {
            for (int i=0; i < recipe.lemons; i++)
            {
                lemons.RemoveAt(0);
            }
            for (int i=0; i < recipe.sugar; i++)
            {
                sugar.RemoveAt(0);
            }
            for (int i=0; i < recipe.ice; i++)
            {
                ice.RemoveAt(0);
            }
         }
    }
}
