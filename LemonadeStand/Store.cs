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
        Inventory currentInventory;
        Money currentMoney;

        //constructor
        public Store()
        {
            currentInventory = new Inventory();
            currentMoney = new Money();
        }

        //methods
        public void GoToStore()
        {
            currentInventory.DisplayInventory();
            currentMoney.DisplayMoney();
            PurchaseCups();
            PurchaseLemons();
            PurchaseSugar();
            PurchaseIce();
        }
        private void PurchaseCups()
        {
            Console.WriteLine("Choose how many cups you would like to purchase from the following options:"
                + "\n 25 cups for .50 cents"
                + "\n 50 cups for .75 cents"
                + "\n 100 cups for $1.25"
                + "\n Enter the number of cups, or enter '0' to skip cups");
            string cupSelection = Console.ReadLine();

            switch (cupSelection)
            {
                case "25":
                    currentInventory.cups += 25;
                    currentMoney.cash -= .50;
                    break;
                case "50":
                    currentInventory.cups += 50;
                    currentMoney.cash -= .75;
                    break;
                case "100":
                    currentInventory.cups += 100;
                    currentMoney.cash -= 1.25;
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Please enter '0', '25', '50', or '100'.");
                    PurchaseCups();
                    break;
            }
            currentInventory.DisplayInventory();
            currentMoney.DisplayMoney();
        }
        private void PurchaseLemons()
        {
            Console.WriteLine("Choose how many lemons you would like to purchase from the following options:"
                + "\n 10 lemons for .75 cents"
                + "\n 20 lemons for $1.25"
                + "\n 40 lemons for $2.50"
                + "\n Enter the number of lemons, or enter '0' to skip lemons.");
            string lemonSelection = Console.ReadLine();

            switch (lemonSelection)
            {
                case "10":
                    currentInventory.lemons += 10;
                    currentMoney.cash -= .75;
                    break;
                case "20":
                    currentInventory.lemons += 20;
                    currentMoney.cash -= 1.25;
                    break;
                case "40":
                    currentInventory.lemons += 40;
                    currentMoney.cash -= 2.50;
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Please enter '0', '10', '20', or '40'.");
                    PurchaseLemons();
                    break;
            }
            currentInventory.DisplayInventory();
            currentMoney.DisplayMoney();

        }
        private void PurchaseSugar()
        {
            Console.WriteLine("Choose how many cups of sugar you would like to purchase from the following options:"
                + "\n 10 cups of sugar for $1.00"
                + "\n 30 cups of sugar for $2.75"
                + "\n 50 cups of sugar for $4.50"
                + "\n Enter the number of cups of sugar, or enter '0' to skip sugar.");
            string sugarSelection = Console.ReadLine();

            switch (sugarSelection)
            {
                case "10":
                    currentInventory.sugar += 10;
                    currentMoney.cash -= 1;
                    break;
                case "30":
                    currentInventory.sugar += 30;
                    currentMoney.cash -= 2.75;
                    break;
                case "50":
                    currentInventory.sugar += 50;
                    currentMoney.cash -= 4.5;
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Please enter '0', '10', '30', or '50'.");
                    PurchaseSugar();
                    break;
            }
            currentInventory.DisplayInventory();
            currentMoney.DisplayMoney();
        }
        private void PurchaseIce()
        {
            Console.WriteLine("Choose how many ice cubes you would like to purchase from the following options:"
                + "\n 100 ice cubes for $1.00"
                + "\n 200 ice cubes for $1.75"
                + "\n 400 ice cubes for $3.25"
                + "\n Enter the number of ice cubes, or enter '0' to skip ice cubes.");
            string iceSelection = Console.ReadLine();

            switch (iceSelection)
            {
                case "100":
                    currentInventory.ice += 100;
                    currentMoney.cash -= 1;
                    break;
                case "200":
                    currentInventory.ice += 200;
                    currentMoney.cash -= 1.75;
                    break;
                case "400":
                    currentInventory.ice += 400;
                    currentMoney.cash -= 3.25;
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Please enter '0', '100', '200', or '400'.");
                    PurchaseIce();
                    break;
            }
            currentInventory.DisplayInventory();
            currentMoney.DisplayMoney();
        }
    }
}
