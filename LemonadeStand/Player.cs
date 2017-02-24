using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        public Recipe recipe;
        public Money money;
        public Inventory inventory;

        //constructor
        public Player()
        {
            recipe = new Recipe();
            money = new Money();
            inventory = new Inventory(recipe);
        }

        //methods
        public void PlayerStart()
        {
            recipe.CreateRecipe();
            MakePitcherOfLemonade();

        }
        public void MakePitcherOfLemonade()
        {
            for (int i = 0; i < recipe.lemons; i++)
            {
                inventory.lemons.RemoveAt(0);
            }
            for (int i = 0; i < recipe.sugar; i++)
            {
                inventory.sugar.RemoveAt(0);
            }
            for (int i = 0; i < recipe.ice; i++)
            {
                inventory.ice.RemoveAt(0);
            }
            for (int i = 0; i < recipe.cups; i++)
            {
                inventory.cups.RemoveAt(0);
            }
        }
        public void MakePitchers()
        {
            Console.WriteLine("How many pitchers would you like to make?");
  
        }
    }
}
