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
            day.weather.WeeklyForecast();
            while (day.day < 8)
            {
                day.DisplayDay();
                GoToStore();
                player.PlayerStart();
                day.CustomerBuy(player);
                day.DisplayTotalProfit(player);
            }
            EndGame();


        }
        private void GoToStore()
        {
            Console.WriteLine($"You have {player.inventory.cups.Count} cups, and ${player.money.cash}");
            int cups = store.GetNumberOfCups();
            store.AddCupsToInventory(cups);
            Console.WriteLine($"You have {player.inventory.lemons.Count} lemons, and ${player.money.cash}");
            int lemons = store.GetNumberOfLemons();
            store.AddLemonsToInventory(lemons);
            Console.WriteLine($"You have {player.inventory.sugar.Count} cups of sugar, and ${player.money.cash}");
            int sugar = store.GetCupsOfSugar();
            store.AddSugarToInventory(sugar);
            Console.WriteLine($"You have {player.inventory.ice.Count} ice cubes, and ${player.money.cash}");
            int ice = store.GetNumberOfIceCubes();
            store.AddIceToInventory(ice);          
        }
        private void EndGame()
        {
            Console.WriteLine("Would you like to play again, or quit?"
                + "\n Enter 'yes' to play again"
                + "\n Enter 'no' to quit");
            string restart = Console.ReadLine();
            switch (restart)
            {
                case "yes":
                    PlayGame();
                    break;
                case "no":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That was not a valid entry. Please try again.");
                    EndGame();
                    break;
            }
        }
    }
}
