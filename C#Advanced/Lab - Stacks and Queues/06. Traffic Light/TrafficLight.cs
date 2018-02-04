using System;
using System.Collections.Generic;

namespace _06._Traffic_Light
{
    class TrafficLight
    {
        static void Main(string[] args)
        {
            var maxCars = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var carsQueue = new Queue<string>();
            var totalCounter = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    var possibleCars = Math.Min(carsQueue.Count, maxCars);
                    for (int counter = 0; counter < possibleCars; counter++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        totalCounter++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"{totalCounter} cars passed the crossroads.");
        }
    }
}
