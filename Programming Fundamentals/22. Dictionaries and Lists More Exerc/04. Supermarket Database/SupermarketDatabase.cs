using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    /* Write a program, which keeps information about products and their prices. Each product has a name, a price and its quantity. If the product doesn’t exist in the database yet, add it with its starting 
    quantity. If you receive a product, which already exists in the database, increase its quantity by the input quantity and if its price is different, replace the price as well.
    You will receive products’ names, prices and quantities on new lines. Until you receive the command “stocked”, keep adding items to the database. When you do receive the command “stocked”, print the items 
    with their names, prices, quantities and total price of all the products with that name. When you’re done printing the items, print the grand total price of all the items.
    Note: The grand total is calculated, based on the latest price of the products. */
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var priceList = new Dictionary<string, double>();
            var stockList = new Dictionary<string, int>();
            var totalList = new Dictionary<string, double>();

            while (inputLine != "stocked")
            {
                var tokens = inputLine.Split();
                var productName = tokens[0];
                var price = double.Parse(tokens[1]);
                var quantity = int.Parse(tokens[2]);

                if (!stockList.ContainsKey(productName))
                {
                    stockList[productName] = 0;
                    priceList[productName] = 0.0;
                    totalList[productName] = 0.0;
                }
                stockList[productName] += quantity;
                priceList[productName] = price;
                totalList[productName] = price * quantity;

                inputLine = Console.ReadLine();
            }
            
            foreach (var entry in stockList)
            {
                var product = entry.Key;
                var quantity = entry.Value;
                var price = priceList[product];
                var total = price * quantity;
                totalList[product] = total;

                Console.WriteLine($"{product}: ${price:F2} * {quantity} = ${total:F2}");
            }
            Console.WriteLine(new string('-', 30));

            double grandTotal = totalList.Values.Sum();
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
