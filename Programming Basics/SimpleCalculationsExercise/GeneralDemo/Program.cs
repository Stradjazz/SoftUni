using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;
            Console.WriteLine(Math.Round(double.Parse(Console.ReadLine()) * usd, 2));
            Console.WriteLine(Math.Round(double.Parse(Console.ReadLine()) / eur, 2));
            Console.WriteLine(Math.Round(double.Parse(Console.ReadLine()) / gbp * eur, 2));
            Console.WriteLine(Math.Round(double.Parse(Console.ReadLine()) / eur * usd, 2));
        }
    }
}
