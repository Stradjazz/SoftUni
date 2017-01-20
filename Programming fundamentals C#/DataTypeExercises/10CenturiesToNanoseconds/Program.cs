using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            byte century = byte.Parse(Console.ReadLine());
            //conversion
            int years = century * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            ulong seconds = (ulong)(minutes * 60);
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            //printing
            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
