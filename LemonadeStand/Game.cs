using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        Rules rules;
        Weather forecast;
        Day currentDay;
        Store store;
    

        //constructor
        public Game()
        {
            rules = new Rules();
            forecast = new Weather();
            currentDay = new Day();
            store = new Store();
        }

        //methods
        public void PlayGame()
        {
            rules.DisplayRules();
            forecast.WeeklyForecast();
            while (currentDay.day < 8)
            {
                currentDay.DisplayDay();
                forecast.DailyWeather();
                store.GoToStore();
            }
        }
    }
}
