using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    //Write a class Sale holding the following data: town, product, price, quantity. 
    //Read a list of sales and calculate and print the total sales by town as shown in the output. Order alphabetically the towns in the output.
    class SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sales = new SortedDictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                Sale currentSale = ReadSale();
                if (!sales.ContainsKey(currentSale.Town))
                {
                    sales[currentSale.Town] = 0;
                }
                sales[currentSale.Town] += currentSale.Quantity * currentSale.Price;
            }
            foreach (var sale in sales)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:F2}");
            }

            
        }
        public static Sale ReadSale()
        {
            var saleParams = Console.ReadLine()
                .Split(' ')
                .ToArray();
            return new Sale
            {
                Town = saleParams[0],
                Product = saleParams[1],
                Price = decimal.Parse(saleParams[2]),
                Quantity = decimal.Parse(saleParams[3])
            };
        }
    }
}
