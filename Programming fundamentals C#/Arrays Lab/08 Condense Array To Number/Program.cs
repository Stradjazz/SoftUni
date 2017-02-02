﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condense_Array_To_Number
{
    class CondenseArrayToNumber
    {
        /*Write a program to read an array of integers and condense them by summing adjacent couples of elements 
          until a single integer is obtained. For example, if we have 3 elements {2, 10, 3}, we sum the first two and the 
          second two elements and obtain {2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.*/

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] condensed = new int[numbers.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }
                numbers = condensed;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
