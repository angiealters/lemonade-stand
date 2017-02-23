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
        public int lemons;
        public int sugar;
        public int ice;
        public int price;

        //constructor
        public Recipe()
        {

  
        }

        //methods
        public void CreateRecipe()
        {
            GetAmountOfLemons();
            GetAmountOfSugar();
            GetAmountOfIce();
            GetPricePerCup();            
        }
        public void GetAmountOfLemons()
        {
            Console.WriteLine("Enter the amount of lemons you would like to use per pitcher.");
            lemons = int.Parse(Console.ReadLine());
        }
        public void GetAmountOfSugar()
        {
            Console.WriteLine("Enter how many cups of sugar you would like to use per pitcher.");
            sugar = int.Parse(Console.ReadLine());
        }
        public void GetAmountOfIce()
        {
            Console.WriteLine("Enter how many ice cubes you would like to use per pitcher.");
            ice = int.Parse(Console.ReadLine());
        }
        public void GetPricePerCup()
        {
            Console.WriteLine("Enter the amount you would like to charge per cup of lemonade.");
            price = int.Parse(Console.ReadLine());
        }
    }
}
