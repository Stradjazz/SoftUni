using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  You will receive a list of integers on the same line (separated by one space). On the next lines, you will start receiving a list of strings, 
 until you receive the string “end”. Your task is to insert each string (converted to integer) at a specific index in the list. 
 The index is determined by the first digit of the number. Example: 514 -> first digit – 5 -> insert 514 at the 5th index of the list. 
After you insert all the elements, print the list, separated by single spaces.
The input will always be valid and you don’t need to explicitly check if you’re inserting an element into a valid index.
*/
namespace _02.Integer_Insertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = input.Split(' ').Select(int.Parse).ToList();
            input = Console.ReadLine();

            while (input != "end")
            {
                
                //var digits = input.ToCharArray(); 
                var currentNum = int.Parse(input);
                var firstDigit = input[0].ToString();
                var index = int.Parse(firstDigit);

                list.Insert(index, currentNum);
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
