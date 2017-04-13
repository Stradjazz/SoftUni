using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Until you receive the command "stop", you will either receive an integer, or the command bang on every line.
If you receive an integer, place it at the front of the list. If, however, you receive the command bang, remove the first element whose value is smaller than 
the average of the elements of the list, print "shot {element}" and then decrement every element in the list by 1.
If you receive "bang" and there are no elements left in the list, print "nobody left to shoot! last one was {lastRemovedInt}" and end the program. 
When you finally do receive the command "end", either print "survivors: {elements, separated by space}" if there are any, or "you shot them all. last one standing 
was {lastRemovedInt}". */

namespace _01.Shoot_List_Elements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<int> numbers = new List<int>();

            var lastElement = 0;
            var average = 0.0;        

            while (input != "stop")
            {
                if (input != "bang")
                {
                    numbers.Insert(0, int.Parse(input));
                }
                else
                {
                    average = numbers.Average();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        lastElement = numbers[i];
                        if (lastElement < average)
                        {
                            numbers.RemoveAt(i);
                            if (numbers.Count > 0)
                            {
                                Console.WriteLine($"shot {lastElement}");
                            }
                            else
                            {
                                Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
                            }
                            
                            break;
                        }
                        else if (numbers.Count == 1 && average <= lastElement)
                        {
                            numbers.Remove(lastElement);
                            Console.WriteLine($"shot {lastElement}");
                            break;
                        }
                        
                    }
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }

                input = Console.ReadLine();

                if (numbers.Count == 0)
                {
                    break;
                }
            }

            if (lastElement >= average && numbers.Count == 0 && input != "stop")
            {
                Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
            }
            else if (numbers.Count == 0 && input == "stop")
            {
                Console.WriteLine($"you shot them all. last one was {lastElement}");
            }
            else if (numbers.Count >= 1)
            {
                Console.WriteLine($"survivors: {string.Join(" ", numbers)}");
            }

        }  
    }
}
