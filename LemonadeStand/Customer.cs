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
        int temp;
        int price;

        //constructor
        public Customer()
        {

        }

        //methods
        public void GetCustomers()
        {

        }
        private void CustomerPurchase()
        {
            Random random = new Random();

            if (temp > 75)
            {
                price = random.Next(25, 76);
            }
            else if (temp > 66 && temp < 74)
            {

            }
            else if (temp < 65)
            {

            }
        }
    }
}
