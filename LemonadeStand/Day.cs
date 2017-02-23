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
        Weather weather;
        Customer customer;

        //constructor
        public Day()
        {
            weather = new Weather();
            customer = new Customer();
        }

        //methods
        public void DisplayDay()
        {
            weather.WeeklyForecast();
            Console.WriteLine("Day {0}", day++);
            weather.DailyWeather();
        }

    }
}
