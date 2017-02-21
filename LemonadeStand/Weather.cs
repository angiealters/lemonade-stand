using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        int temperature;
        string weather;
        string[] weatherConditions = { "cloudy", "sunny", "gloomy with rain", "partly cloudy"};


        //constructor

        //methods
        public void WeeklyForecast()
        {            
            Console.WriteLine("Here is your weekly forecast:"
                + "\n Sunday will be sunny, with a high of 72 degrees."
                + "\n Monday will be partly cloudy, with a high of 65 degrees."
                + "\n Tuesday will be cloudy, with a high of 61 degrees."
                + "\n Wednesday will be gloomy with rain, with a high of 56 degrees."
                + "\n Thursday will be partly cloudy, with a high of 68 degrees."
                + "\n Friday will be cloudy, with a high of 75 degrees."
                + "\n Saturday will be sunny, with a high of 83 degrees.");
        }
        public void DailyWeather()
        {
            Random random = new Random();
            temperature = random.Next(55, 86);
            weather = weatherConditions[random.Next(0, weatherConditions.Length)];

            Console.WriteLine($"The forecast today is {weather}, with a high of {temperature} degrees.");

        }
    }
}
