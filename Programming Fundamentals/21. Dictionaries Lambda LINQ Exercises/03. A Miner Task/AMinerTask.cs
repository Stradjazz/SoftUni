using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    /*You are given a sequence of strings, each on a new line.Every odd line on the console is representing a resource(e.g.Gold, Silver, Copper, and so on), and every even – quantity. Your task is 
    to collect the resources and print them each on a new line.
    Print the resources and their quantities in format: { resource} –> { quantity}
    The quantities inputs will be in the range[1 … 2 000 000 000]*/
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var minerStock = new Dictionary<string, long>();
            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                var quantities = long.Parse(Console.ReadLine());

                if (!minerStock.ContainsKey(resource))
                {
                    minerStock.Add(resource, quantities);
                }
                else
                {
                    minerStock[resource] += quantities;
                }

            }

            foreach (var item in minerStock)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
