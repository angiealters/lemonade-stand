using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        //member variables
        int temperaturePreferance;
        decimal maxPrice;

        //constructor
        public Customer()
        {

        }

        //methods
        public void GetCustomers()
        {

        }
        public void CustomerPurchase()
        {
            Random random = new Random();

            if (temperaturePreferance > 75)
            {
                maxPrice = (random.Next(25, 76) / 100);
            }
            else if (temperaturePreferance > 66 && temperaturePreferance < 74)
            {
                maxPrice = (random.Next(15, 51) / 100);
            }
            else if (temperaturePreferance < 65)
            {
                maxPrice = (random.Next(10, 26) / 100);
            }
        }
    }
}
