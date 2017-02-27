using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public int day = 1;
        int customerCount;
        decimal totalProfit;
        public Weather weather;
        List<Customer> customers;


        //constructor
        public Day()
        {
            weather = new Weather();
            customerCount = 0;

        }

        //methods
        public void DisplayDay()
        {
            Console.WriteLine("Day {0}", day++);
            weather.DailyWeather();
        }
        public void DisplayTotalProfit(Player player)
        {
            totalProfit = player.recipe.price * customerCount;
            Console.WriteLine($"You have had a total of {customerCount} customers, and have made a total of ${totalProfit}.");          
        }

        private void GetCustomers()
        {
            customers = new List<Customer>();
            Random random = new Random();
            
            for (int i = 0; i < 100; i++)
            {
                customers.Add(new Customer(random.Next(55, 86)));
            }
        }
        public void CustomerBuy(Player player)
        {
            GetCustomers();
            foreach (Customer customer in customers)
            {
                if (customer.temperaturePreference <= 80 && weather.temperature >= 80)
                {
                    player.money.AddToCash(player.recipe.price);
                    player.SellCupOfLemonade();
                    customerCount++;
                }
                else if (customer.temperaturePreference <= 75 && weather.temperature >= 75)
                {
                    player.money.AddToCash(player.recipe.price);
                    player.SellCupOfLemonade();
                    customerCount++;
                }
                else if (customer.temperaturePreference <= 70 && weather.temperature >= 70)
                {
                    player.money.AddToCash(player.recipe.price);
                    player.SellCupOfLemonade();
                    customerCount++;
                }
                else if (customer.temperaturePreference <= 65 && weather.temperature >= 65)
                {
                    player.money.AddToCash(player.recipe.price);
                    player.SellCupOfLemonade();
                    customerCount++;
                }
                else if (customer.temperaturePreference <= 60 && weather.temperature >= 60)
                {
                    player.money.AddToCash(player.recipe.price);
                    player.SellCupOfLemonade();
                    customerCount++;
                }
                else if (customer.temperaturePreference <= 55 && weather.temperature >= 55)
                {
                    player.money.AddToCash(player.recipe.price);
                    player.SellCupOfLemonade();
                    customerCount++;
                }
                else
                {

                }
            }
        }
    }
}
