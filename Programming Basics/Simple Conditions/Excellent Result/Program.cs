﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double note = double.Parse(Console.ReadLine());
            if (note >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}