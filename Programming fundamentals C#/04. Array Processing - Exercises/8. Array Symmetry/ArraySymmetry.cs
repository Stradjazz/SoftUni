﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Array_Symmetry
{
    //Read an array of strings and find out if it’s symmetric. If it is, print “Yes”, otherwise print “No”.
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] reversed = new string[words.Length];
            bool symmetry = true; 

            for (int i = 0; i < words.Length; i++)
            {
                reversed[i] = words[i];
            }
            Array.Reverse(reversed);
            for (int i = 0; i < words.Length; i++)
            {
                if (reversed[i] != words[i])
                {
                    symmetry = false;
                }
            }
            if (symmetry)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
