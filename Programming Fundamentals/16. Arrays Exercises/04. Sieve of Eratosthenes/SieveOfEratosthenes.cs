using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    //Write a program to find all prime numbers in range[1…n]. Implement the algorithm called “Sieve of Eratosthenes”
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            bool[] checkPrime = new bool[input + 1];
            for (int i = 0; i <= input; i++)
            {
                checkPrime[i] = true;
            }
            checkPrime[0] = false;
            checkPrime[1] = false;
            for (int i = 0; i < input + 1; i++)
            {
                if (checkPrime[i])
                {
                    for (int j = 2; (j * i) <= input; j++)
                    {
                        checkPrime[j * i] = false;
                    }
                }
            }
            for (int j = 2; j <= input; j++)
            {
                if (checkPrime[j] == true)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
