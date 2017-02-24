using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables
        Player player;

        //constructor
        public Store(Player player)
        {
            this.player = player; 
 
        }

        //methods
        public int GetNumberOfCups()
        {
            Console.WriteLine("How many cups would you like to buy? Cups are .02 cents each.");
            int amountOfCups = int.Parse(Console.ReadLine());
            if (player.money.cash > 0)
            {
                player.money.SubtractFromCash(amountOfCups * .02m);
            }
            return amountOfCups;
        }
        public void AddCupsToInventory(int amountOfCups)
        {
            for (int i=0; i<amountOfCups; i++)
            {
                Cups cups = new Cups();
                player.inventory.cups.Add(cups);
            }
        }
        public int GetNumberOfLemons()
        {
            Console.WriteLine("How many lemons would you like to buy? Lemons are .06 cents each.");
            int amountOfLemons = int.Parse(Console.ReadLine());
            if (player.money.cash > 0)
            {
              player.money.SubtractFromCash(amountOfLemons * .06m);
            }
            return amountOfLemons;
        }
        public void AddLemonsToInventory(int amountOfLemons)
        {
            for (int i=0; i<amountOfLemons; i++)
            {
                Lemons lemons = new Lemons();
                player.inventory.lemons.Add(lemons);
            }
        }
        public int GetCupsOfSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to buy? One cup is .07 cents.");
            int amountOfSugar = int.Parse(Console.ReadLine());
            if (player.money.cash > 0)
            {
                player.money.SubtractFromCash(amountOfSugar * .07m);
            }
            return amountOfSugar;
        }
        public void AddSugarToInventory(int amountOfSugar)
        {
            for (int i=0; i<amountOfSugar; i++)
            {
                Sugar sugar = new Sugar();
                player.inventory.sugar.Add(sugar);
            }
        }
        public int GetNumberOfIceCubes()
        {
            Console.WriteLine("How many ice cubes would you like to buy? Ice cubes are .01 cent each.");
            int amountOfIce = int.Parse(Console.ReadLine());
            if (player.money.cash > 0)
            {
                player.money.SubtractFromCash(amountOfIce * .01m);
            }
            return amountOfIce;
        }
        public void AddIceToInventory(int amountOfIce)
        {
            for (int i=0; i<amountOfIce; i++)
            {
                Ice ice = new Ice();
                player.inventory.ice.Add(ice);
            }
        }
    }
}

