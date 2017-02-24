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
        public Weather weather;
        public List<Customer> customers = new List<Customer>();

        //constructor
        public Day()
        {
            weather = new Weather();

        }

        //methods
        public void DisplayDay()
        {
            weather.WeeklyForecast();
            Console.WriteLine("Day {0}", day++);
            weather.DailyWeather();
        }
        public void GetCustomers()
        {
            Random random = new Random();
            
            for (int i = 0; i < 100; i++)
            {
                customers.Add(new Customer(random.Next(55, 86)));
            }
        }
        public void GetCustomersMoney(Player player)
        {
            GetCustomers();
            foreach (Customer customer in customers)
            {
                if (customer.temperaturePreference < 80 && weather.temperature > 80)
                {
                    player.money.AddToCash(player.recipe.price);
                }
                else if (customer.temperaturePreference < 75 && weather.temperature > 75)
                {
                    player.money.AddToCash(player.recipe.price);
                }
                else if (customer.temperaturePreference < 70 && weather.temperature > 70)
                {
                    player.money.AddToCash(player.recipe.price);
                }
                else if (customer.temperaturePreference < 65 && weather.temperature > 65)
                {
                    player.money.AddToCash(player.recipe.price);
                }
                else if (customer.temperaturePreference < 60 && weather.temperature > 60)
                {
                    player.money.AddToCash(player.recipe.price);
                }
                else if (customer.temperaturePreference < 55 && weather.temperature > 55)
                {
                    player.money.AddToCash(player.recipe.price);
                }
                else
                {

                }
            }
        }
/*        public void CustomerPurchase(Player player, Customer customer)
        {
            if (customer.temperaturePreference > 80 && customer.maxPrice >= .35m)
            {
                player.money.AddToCash(player.recipe.price);
            }
            else if (customer.temperaturePreference > 75 && customer.maxPrice >= .30m)
            {
                player.money.AddToCash(player.recipe.price);
            }
            else if (customer.temperaturePreference > 70 && customer.maxPrice >= .25m)
            {
                player.money.AddToCash(player.recipe.price);
            }
            else if (customer.temperaturePreference > 65 && customer.maxPrice >= .20m)
            {
                player.money.AddToCash(player.recipe.price);
            }
            else if (customer.temperaturePreference > 60 && customer.maxPrice >= .15m)
            {
                player.money.AddToCash(player.recipe.price);
            }
            else if (customer.temperaturePreference >= 55 && customer.maxPrice >= .10m)
            {
                player.money.AddToCash(player.recipe.price);
            }
            else
            {

            }
        }
*/
    }
}
