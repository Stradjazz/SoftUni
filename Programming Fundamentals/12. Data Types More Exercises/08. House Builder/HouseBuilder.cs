using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    /*You are a house builder and you need to buy the materials for one of your clients. This is quite a special house and it needs 
     special materials. The house needs 4 sbyte variables and 10 int variables. You will receive two numbers from the console, which will 
     be the prices of the materials. One will be an integer and the other will be sbyte, but you do not know the order in which they 
     will be given. The int number will be the price of the int materials and the sbyte number will be the price of the sbyte materials.
     Calculate the total price of the materials and print them on the console.*/
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            long firstNum = int.Parse(Console.ReadLine());
            long secondNum = int.Parse(Console.ReadLine());

            long intPrice = Math.Max(firstNum, secondNum) * 10;
            long sbytePrice = Math.Min(firstNum, secondNum) * 4;
            long totalPrice = intPrice + sbytePrice;

            Console.WriteLine(totalPrice);
        }
    }
}
