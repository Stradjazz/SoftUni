using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    /*Ely likes to play Pokemon Go a lot. But Pokemon Go bankrupted … So the developers made Pokemon Don’t Go out of depression. And so Ely now plays Pokemon Don’t Go. In Pokemon Don’t Go, when 
    you walk to a certain pokemon, those closer to you, naturally get further, and those further from you, get closer.
    You will receive a sequence of integers, separated by spaces – the distances to the pokemons. Then you will begin receiving integers, which will correspond to indexes in that sequence.
    When you receive an index, you must remove the element at that index from the sequence (as if you’ve captured the pokemon).
    •	You must INCREASE the value of all elements in the sequence which are LESS or EQUAL to the removed element, with the value of the removed element.
    •	You must DECREASE the value of all elements in the sequence which are GREATER than the removed element, with the value of the removed element.
    If the given index is LESS than 0, remove the first element of the sequence, and COPY the last element to its place.
    If the given index is GREATER than the last index of the sequence, remove the last element from the sequence, and COPY the first element to its place.
    The increasing and decreasing of elements should be done in these cases, also. The element, whose value you should use is the REMOVED element.
    The program ends when the sequence has no elements (there are no pokemons left for Ely to catch). */
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var sumOfRemovedElements = 0;

            while (numbers.Count > 0)
            {
                var currentIndex = int.Parse(Console.ReadLine());
                var elementToRemove = 0;

                if (currentIndex >= 0 && currentIndex < numbers.Count)
                {
                    elementToRemove = numbers[currentIndex];
                    numbers.RemoveAt(currentIndex);
                    sumOfRemovedElements += elementToRemove;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= elementToRemove)
                        {
                            numbers[i] += elementToRemove;
                        }
                        else
                        {
                            numbers[i] -= elementToRemove;
                        }
                    }
                }
                else if (currentIndex < 0)
                {
                    var firstElement = numbers[0];
                    var lastElement = numbers[numbers.Count - 1];
                    elementToRemove = firstElement;
                    sumOfRemovedElements += elementToRemove;

                    numbers.RemoveAt(0);
                    numbers.Insert(0, lastElement);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= elementToRemove)
                        {
                            numbers[i] += elementToRemove;
                        }
                        else
                        {
                            numbers[i] -= elementToRemove;
                        }
                    }


                }
                else if (currentIndex >= numbers.Count)
                {
                    var firstElement = numbers[0];
                    var lastElement = numbers[numbers.Count - 1];
                    elementToRemove = lastElement;
                    sumOfRemovedElements += elementToRemove;

                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(firstElement);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= elementToRemove)
                        {
                            numbers[i] += elementToRemove;
                        }
                        else
                        {
                            numbers[i] -= elementToRemove;
                        }
                    }
                }
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
