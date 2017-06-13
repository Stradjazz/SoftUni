using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Upgraded_Matcher
{
    /*For this task, you can use your solution from Inventory Matcher. You will again receive 3 arrays – one with strings, one with longs and one with decimals. 
    Again, the price and quantity correspond to a name, which is located on same index as the name.
    This time only the arrays containing the names and the array containing the prices will have the same length. If in the quantities array there is no index, which corresponds 
    to the name, you should assume the quantity is 0.
    On top of that the products, which you receive after the arrays will contain not only a string for the name, but also a long, which is the quantity that must be ordered. 
    If you have enough quantity, calculate the total price by multiplying the ordered quantity times the price and print it in the following format:
    {quantity ordered} x {product name} costs {total price of the order}
    Format the price to the 2nd decimal place. Do not forget to decrease the quantity of the product.
    If you do not have enough quantities print: We do not have enough {product name} */
    class UpgradedMatcher
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
                string[] inputParts = input.Split(' ').ToArray();
                string currentProduct = inputParts[0];
                long orderQuantity = long.Parse(inputParts[1]);
                
                index = Array.IndexOf(products, currentProduct);
                decimal totalPrice = orderQuantity * prices[index];

                if (index > quantities.Length - 1 || orderQuantity > quantities[index])
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }
                else
                {
                    Console.WriteLine($"{products[index]} x {orderQuantity} costs {totalPrice:F2}");
                    quantities[index] -= orderQuantity;
                }

                input = Console.ReadLine();
            }
        }
    }
}
