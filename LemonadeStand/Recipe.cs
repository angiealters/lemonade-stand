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
        public int cups;
        public decimal price;


        //constructor
        public Recipe()
        {

  
        }

        //methods
        public void CreateRecipe()
        {
            SetAmountOfLemons();
            SetAmountOfSugar();
            SetAmountOfIce();
            AmountOfCups();
            SetPricePerCup();            
        }
        private void SetAmountOfLemons()
        {
            try
            {
                Console.WriteLine("Enter the amount of lemons you would like to use per pitcher.");
                lemons = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");
                SetAmountOfLemons();
            }
        }
        private void SetAmountOfSugar()
        {
            try
            {
                Console.WriteLine("Enter how many cups of sugar you would like to use per pitcher.");
                sugar = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");
                SetAmountOfSugar();
            }
        }
        private void SetAmountOfIce()
        {
            try
            {
                Console.WriteLine("Enter how many ice cubes you would like to use per pitcher.");
                ice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");
                SetAmountOfIce();
            }
        }
        private void AmountOfCups()
        {
            cups = 10;
        }
        private void SetPricePerCup()
        {
            try
            {
                Console.WriteLine("Enter the amount you would like to charge per cup of lemonade.");
                price = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid decimal number.");
                SetPricePerCup();
            }
        }
    }
}
