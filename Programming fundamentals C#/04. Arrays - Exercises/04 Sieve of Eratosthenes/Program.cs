using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sieve_of_Eratosthenes
{
    /*  Write a program to find all prime numbers in range [1…n]. Implement the algorithm called “Sieve of Eratosthenes”:  
        Steps in the “Sieve of Eratosthenes” algorithm:
        1.	Assign primes[0…n] = true
        2.	Assign primes[0] = primes[1] = false
        3.	Find the smallest p, which holds primes[p] = true
            •	Print p (it is prime)
            •	Assign primes[2*p] = primes[3*p] = primes[4*p] = … = false
        4.	Repeat for the next smallest p < n.    */
    class SieveEratosthenes
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
                if (checkPrime[j] == true) { Console.Write(j + " "); }
            }
            Console.WriteLine();
        }
    }
}
