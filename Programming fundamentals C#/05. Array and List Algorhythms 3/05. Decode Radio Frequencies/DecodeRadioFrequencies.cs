using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You are given an array of doubles (one line, space-separated). Your task is to convert the double values to their character representations and insert them 
  into a list like so:
•	Example: 83.105
•	Extract the left part of the number and convert it to its ASCII code representation: 83 -> S
•	Extract the right part of the number and convert I to its ASCII code representation: 105 -> i
•	Insert the left character at the position equal to the index of the double number in the original array. -> Index of double: 0 -> insert S at index 0
•	Insert the right character at the position equal to the index of the double number in the original array, counted in reverse: 
    index of the double: 0 -> insert “i” at index 0, counted in reverse (so, the end of the list)
Repeat the aforementioned algorithm for each element of the double array, until you run out of elements. When you do, print the list with no delimiter. 
If any of the parts of the double number are 0 (such as 86.0 or 0.97), ignore them and do not insert them anywhere.
*/
namespace _05.Decode_Radio_Frequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<char> firstHalf = new List<char>();
            List<char> secondHalf = new List<char>();

            //reading the frequency values and separating them in two
            for (int i = 0; i < input.Length; i++)
            {
                var freqValues = input[i].Split('.').Select(int.Parse).ToArray();
                var firstValue = freqValues[0];
                var secondValue = freqValues[1];
                
                //getting the values for both halfs

                if (firstValue != 0)
                {
                    firstHalf.Add((char)firstValue);
                }
                if (secondValue != 0)
                {
                    secondHalf.Add((char)secondValue);
                }
                
            }
            secondHalf.Reverse();

            var result = firstHalf.Concat(secondHalf);
            Console.WriteLine(string.Join("", result));
        }
    }
}
