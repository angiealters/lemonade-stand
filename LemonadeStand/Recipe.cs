using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables
        int lemons;
        int sugar;
        int ice;
        int price;

        //constructor
        public Recipe()
        {
  
        }

        //methods
        public void CreateRecipe()
        {
            lemons = GetAmountOfLemons();
            sugar = GetAmountOfSugar();
            ice = GetAmountOfIce();
            price = GetPricePerCup();            
        }
        private int GetAmountOfLemons()
        {
            Console.WriteLine("Enter the amount of lemons you would like to use per pitcher.");
            Console.ReadLine();
            return lemons;
        }
        private int GetAmountOfSugar()
        {
            Console.WriteLine("Enter how many cups of sugar you would like to use per pitcher.");
            Console.ReadLine();
            return sugar;
        }
        private int GetAmountOfIce()
        {
            Console.WriteLine("Enter how many ice cubes you would like to use per glass.");
            Console.ReadLine();
            return ice;
        }
        private int GetPricePerCup()
        {
            Console.WriteLine("Enter the amount you would like to charge per cup of lemonade.");
            Console.ReadLine();
            return price;
        }
    }
}
