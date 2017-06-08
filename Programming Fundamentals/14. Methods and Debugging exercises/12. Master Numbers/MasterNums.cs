using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    //Write a program to print all master numbers in the range [1…n].
    class MasterNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 7)
            {
                List<int> result = MasterNumbers(n);

                foreach (int number in result)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Not a valid number!");
            }
        }
        static List<int> MasterNumbers(int inputNum)
        {
            int currentNum = 7;
            List<int> masterNumbers = new List<int>();
            while (currentNum <= inputNum)
            {
                bool isPalindrome = IsPalindromeCheck(currentNum);
                if (isPalindrome)
                {
                    bool sumDivides7 = SumOfDigitsCheck(currentNum);
                    if (sumDivides7)
                    {
                        bool containsEven = ContainsEvenDigitCheck(currentNum);
                        if (containsEven)
                        {
                            masterNumbers.Add(currentNum);
                        }
                    }
                }
                currentNum++;
            }//end while loop
            return masterNumbers;
        }
        public static bool IsPalindromeCheck(int currentNum)
        {
            bool isPalindrome = false;
            int counterPairs = 0;
            char[] digitsCurrentNum = (currentNum.ToString()).ToCharArray();
            int lenghtCurrentNum = digitsCurrentNum.Length;

            for (int palindrome = 0; palindrome < lenghtCurrentNum / 2; palindrome++)
            {
                if (digitsCurrentNum[palindrome] == digitsCurrentNum[lenghtCurrentNum - 1 - palindrome])
                {
                    counterPairs += 1;
                }
            }

            if (counterPairs == lenghtCurrentNum / 2)
            {
                isPalindrome = true;
            }
            else if (counterPairs != lenghtCurrentNum / 2)
            {
                isPalindrome = false;
            }
            return isPalindrome;
        }

        public static bool SumOfDigitsCheck(int currentNum)
        {
            bool sumDivided7 = false;
            long sumOfDigits = 0;

            while (currentNum > 0)
            {
                sumOfDigits += (long)currentNum % 10;
                currentNum /= 10;
            }

            if (sumOfDigits % 7 == 0)
            {
                sumDivided7 = true;
            }
            else
            {
                sumDivided7 = false;
            }
            return sumDivided7;
        }
        public static bool ContainsEvenDigitCheck(int currentNum)
        {
            bool containsEven = false;
            while (currentNum > 0)
            {
                int currentDigit = currentNum % 10;
                if (currentDigit % 2 == 0)
                {
                    containsEven = true;
                    break;
                }
                else
                {
                    currentNum /= 10;
                }
            }
            return containsEven;
        }
    }
}
