using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    /* You manage your own pizza restaurant and you are in charge of the orders. Your pizza is made only from ingredients, which have a specific length.
    On the first line, you will receive an array of strings with the possible ingredients. On the next line, you will receive an integer, which represents the length 
    of the strings, which we will used in the recipe. Your recipe should not use more than 10 ingredients. If you collect 10 ingredients stop the program and print the result.*/
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split().ToArray();
            int ingredientLength = int.Parse(Console.ReadLine());
            int counter = 0;
            
            string[] pizzaIngredients = new string[10];

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (counter >= 10)
                {
                    break;
                }
                else if(counter < 10)
                {
                    if (ingredients[i].Length == ingredientLength)
                    {
                        Console.WriteLine($"Adding {ingredients[i]}.");
                        pizzaIngredients[counter] = ingredients[i];
                        counter++;
                    }
                }
                
            }

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.Write($"The ingredients are: ");
            for (int i = 0; i < counter; i++)
            {
                if (i == counter - 1)
                {
                    Console.WriteLine($"{pizzaIngredients[i]}.");
                }
                else
                {
                    Console.Write($"{pizzaIngredients[i]}, ");
                }
            }
            
        }
    }
}
