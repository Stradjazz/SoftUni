using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string currencyIn = Console.ReadLine();
            string currencyOut = Console.ReadLine();
            Dictionary<string, decimal> currencies = new Dictionary<string, decimal>() { { "BGN", 1 }, { "USD", 1.79549m }, { "EUR", 1.95583m }, { "GBP", 2.53405m } };
            decimal result = amount * (currencies[currencyIn] / currencies[currencyOut]);
            Console.WriteLine("{0} {1}", Math.Round(result, 2), currencyOut);
        }
    }
}
