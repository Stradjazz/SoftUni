using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A supermarket has products which have quantities. Your task is to stock the shop before Exam Sunday. Until you receive the command “shopping time”, add the various
  products to the shop’s inventory, keeping track of their quantity (for inventory purposes). When you receive the aforementioned command, the students start pouring
  in before the exam and buy various products.
  The format for stocking a product is: “stock {product} {quantity}”. The format for buying a product is: “buy {product} {quantity}”.
  If a student tries to buy a product, which doesn’t exist, print “{product} doesn't exist”. If it does exist, but it’s out of stock, print “{product} out of stock”. 
  If a student tries buying more than the quantity of that product, sell them all the quantity of the product (the product is left out of stock, don’t print anything).
  When you receive the command “exam time”, your task is to print the remaining inventory in the following format: “{product} -> {quantity}”. If a product is out of stock, 
  do not print it. */
namespace _04.Exam_Shopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stocks = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                var inputData = input.Split();
                var product = inputData[1];
                var quantity = int.Parse(inputData[2]);

                if (!stocks.ContainsKey(product))
                {
                    stocks[product] = 0;
                }

                stocks[product] += quantity;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "exam time")
            {
                var inputData = input.Split();
                var product = inputData[1];
                var quantity = int.Parse(inputData[2]);

                if (!stocks.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (stocks[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        stocks[product] -= quantity;
                        if (stocks[product] < 0)
                        {
                            stocks[product] = 0;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in stocks)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
