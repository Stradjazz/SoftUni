using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SoftUni_Coffee_Orders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            //price = (daysInMonth * capsulesCount) * pricePerCapsule
            var ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            
            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), @"d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());
                
                var daysInMonth = CalculateDaysInMonth(orderDate);

                decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        private static int CalculateDaysInMonth(DateTime orderDate)
        {
            var daysInMonth = 0;
            var year = orderDate.Year;
            var month = orderDate.Month;

            daysInMonth = DateTime.DaysInMonth(year, month);

            return daysInMonth;
        }
    }
}
