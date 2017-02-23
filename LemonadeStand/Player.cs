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
        Recipe recipe;
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
            inventory.MakePitcherOfLemonade();

        }
    }
}
