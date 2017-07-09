using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                var tokens = commandLine.Split();
                var command = tokens[0];

                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(tokens[1]);
                        if (index < 0 || index >= numbers.Length)
                        {
                            Console.WriteLine("Invalid index");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        Exchange(numbers, index);
                        break;

                    case "max":
                        var numGender = tokens[1];
                        var maxOddOrEven = MaxOddOrEven(numbers, numGender);
                        if (maxOddOrEven == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
	                    {
                            Console.WriteLine(Array.LastIndexOf(numbers, maxOddOrEven));
                        }
                        break;

                    case "min":
                        numGender = tokens[1];
                        var minOddOrEven = MinOddOrEven(numbers, numGender);
                        if (minOddOrEven == int.MaxValue)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(Array.LastIndexOf(numbers, minOddOrEven));
                        }
                        break;

                    case "first":
                        var count = int.Parse(tokens[1]);
                        numGender = tokens[2];
                        if (count <= numbers.Length)
                        {
                            Console.WriteLine($"[{string.Join(", ", FirstCountElements(numbers, count, numGender))}]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        
                        break;

                    case "last":
                        count = int.Parse(tokens[1]);
                        numGender = tokens[2];
                        if (count <= numbers.Length)
                        {
                            Console.WriteLine($"[{string.Join(", ", LastCountElements(numbers, count, numGender))}]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static List<int> LastCountElements(int[] numbers, int count, string numGender)
        {
            var elementsList = new List<int>();
            if (numGender == "odd")
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        elementsList.Add(numbers[i]);
                    }
                }

            }
            else
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        elementsList.Add(numbers[i]);
                    }
                }
            }
            return elementsList.Take(count).Reverse().ToList();
        }
        private static List<int> FirstCountElements(int[] numbers, int count, string numGender)
        {
            var elementsList = new List<int>();
            if (numGender == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        elementsList.Add(numbers[i]);
                    }
                }
                
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        elementsList.Add(numbers[i]);
                    }
                }
            }
            return elementsList.Take(count).ToList();
        }

        private static int MinOddOrEven(int[] numbers, string numGender)
        {
            var currentMin = int.MaxValue;
            if (numGender == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0 && numbers[i] < currentMin)
                    {
                        currentMin = numbers[i];
                    }
                };
                return currentMin;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] < currentMin)
                    {
                        currentMin = numbers[i];
                    }
                }
                return currentMin;
            }
        }

        private static int MaxOddOrEven(int[] numbers, string numGender)
        {
            var currentMax = -1;
            if (numGender == "odd")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0 && numbers[i] > currentMax)
                    {
                        currentMax = numbers[i];
                    }
                };
                return currentMax;
            }
            else 
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && numbers[i] > currentMax)
                    {
                        currentMax = numbers[i];
                    }
                }
                return currentMax;
            }
        }
        private static void Exchange(int[] numbers, int index)
        {
            
            var firstPart = numbers.Take(index + 1).ToList();
            var secondPart = numbers.Skip(index + 1).ToList();

            var resultArray = new List<int>();
            resultArray.AddRange(secondPart);
            resultArray.AddRange(firstPart);

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = resultArray[i];
            }

        }
    }
}
