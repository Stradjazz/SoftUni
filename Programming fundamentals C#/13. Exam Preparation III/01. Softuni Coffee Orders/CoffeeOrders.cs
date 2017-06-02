using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class CoffeeOrders
    {
        static void Main(string[] args)
        {
            //((daysInMonth * capsulesCount) * pricePerCapsule)
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal PricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                decimal currentPrice = ((DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * (long)capsulesCount) * PricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");

                totalPrice += currentPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
