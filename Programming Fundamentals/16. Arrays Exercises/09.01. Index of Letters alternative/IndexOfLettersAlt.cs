﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._01.Index_of_Letters_alternative
{
    /*Write a program that creates an array containing all letters from the alphabet (a-z). Read a lowercase word from the console and 
     print the index of each of its letters in the letters array.*/
    class IndexOfLettersAlt
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", input[i], input[i] - 'a');
            }
        }
    }
}
