using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        Rules rules;
        Day day;
        Player player;
        Store store;


        //constructor
        public Game()
        {
            rules = new Rules();
            day = new Day();
            player = new Player();
            store = new Store(player);
        }

        //methods
        public void PlayGame()
        {
            rules.DisplayRules();
            day.DisplayDay();
            GoToStore();
            player.PlayerStart();
            day.CustomerBuy(player);

        }
        private void GoToStore()
        {
            int cups = store.GetNumberOfCups();
            store.AddCupsToInventory(cups);
            int lemons = store.GetNumberOfLemons();
            store.AddLemonsToInventory(lemons);
            int sugar = store.GetCupsOfSugar();
            store.AddSugarToInventory(sugar);
            int ice = store.GetNumberOfIceCubes();
            store.AddIceToInventory(ice);
        }
    }
}
