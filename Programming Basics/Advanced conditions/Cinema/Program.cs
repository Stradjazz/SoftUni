using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var price = -1.0;


            if (type == "premiere")
            {
                price = 12.00;
            }
            else if (type == "normal")
            {
                price = 7.50;
            }
            else if (type == "discount")
            {
                price = 5.00;
            }
            if (price > -1.0)

            Console.WriteLine("{0:F2} leva",(r * c) * price);
            

        }
    }
}
