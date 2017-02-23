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
        string[] weatherConditions = { "cloudy", "sunny", "gloomy with rain", "partly cloudy", "mostly sunny", "hazy"};
        Random random = new Random();


        //constructor

        //methods
        public void WeeklyForecast()
        {
            for (int i=1; i < 8; i++)
            {
                temperature = random.Next(55, 86);
                weather = weatherConditions[random.Next(0, weatherConditions.Length)];
                Console.WriteLine($"Day{i} will be {weather}, with a high of {temperature} degrees.");
            }
        }
        public void DailyWeather()
        {
 //           Random random = new Random();
            temperature = random.Next(55, 86);
            weather = weatherConditions[random.Next(0, weatherConditions.Length)];

            Console.WriteLine($"The forecast today is {weather}, with a high of {temperature} degrees.");

        }
    }
}
