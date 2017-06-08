using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Debugging_Be_Positive
{
    //Debugging exercises on broken code
    class BePositive
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        found = true;
                        
                        Console.Write(currentNum + " "); 
                    }
                    else
                    {
                        if (j < numbers.Count - 1)
                        {
                            currentNum += numbers[j + 1];

                            if (currentNum >= 0)
                            {
                                found = true;

                                Console.Write(currentNum + " ");
                            }
                            j++;
                        }
                        
                    }
                    
                }
                 if (!found)
                {
                    Console.Write("(empty)");
                }
                Console.WriteLine();
            }
        }
    }
}
