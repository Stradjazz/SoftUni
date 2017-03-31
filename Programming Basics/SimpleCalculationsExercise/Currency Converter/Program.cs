using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = decimal.Parse(Console.ReadLine());
            var currencyA = Console.ReadLine();
            var currencyB = Console.ReadLine();
            decimal enter = 0m;
            decimal exit = 0m;

            if (currencyA == "BGN")
            {
                enter = 1m;
            }
            else if (currencyA == "USD")
            {
                enter = 1.79549m;
            }
            else if (currencyA == "EUR")
            {
                enter = 1.95583m;
            }
            else if (currencyA == "GBP")
            {
                enter = 2.53405m;
            }
            if (currencyB == "BGN")
            {
                exit = 1m;
            }
            else if (currencyB == "USD")
            {
                exit = 1.79549m;
            }
            else if (currencyB == "EUR")
            {
                exit = 1.95583m;
            }
            else if (currencyB == "GBP")
            {
                exit = 2.53405m;
            }

            var sum = amount * enter / exit;

            Console.WriteLine(Math.Round(sum, 2));

        }
    }
}
