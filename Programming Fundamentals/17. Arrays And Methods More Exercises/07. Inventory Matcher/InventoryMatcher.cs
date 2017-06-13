using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    /*You will be given three arrays on different lines. The first one will contain strings, which will represent the name of products. Second one will contain longs and will 
    represent the quantities of the products. The third one will contain double and represents the price of the product. 
    After which, you will be given names of products on new lines, until you receive the command “done”. For each given product name print:
    {name of the product} costs: {price}; Available quantity: {quantity}
    The names, prices and quantities of the products are in the same indices in the 3 arrays. */
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            int index = 0;

            string input = Console.ReadLine();

            while (input != "done")
            {
                index = Array.IndexOf(products, input);
                Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");

                input = Console.ReadLine();
            }
        }
    }
}
