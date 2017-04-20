using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
    class Animals
    {
        static void Main(string[] args)
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            var input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                var tokens = input.Split(' ').ToArray();
                string type = tokens[0];
                string name = tokens[1];

                switch (type)
                {
                    case "Dog":
                        var currentDog = GetDogInfo(tokens);
                        dogs.Add(currentDog.Name, currentDog);
                        break;

                    case "Cat":
                        var currentCat = GetCatInfo(tokens);
                        cats.Add(currentCat.Name, currentCat);
                        break;

                    case "Snake":
                        var currentSnake = GetSnakeInfo(tokens);
                        snakes.Add(currentSnake.Name, currentSnake);
                        break;

                    case "talk":
                        if (dogs.ContainsKey(name))
                        {
                            dogs[name].ProduceSound();
                        }
                        else if (cats.ContainsKey(name))
                        {
                            cats[name].ProduceSound();
                        }
                        else if (snakes.ContainsKey(name))
                        {
                            snakes[name].ProduceSound();
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        static public Dog GetDogInfo(string[] tokens)
        {
           return new Dog
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                NumberOfLegs = int.Parse(tokens[3])
            };
        }
        static public Cat GetCatInfo(string[] tokens)
        {
            return new Cat
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                IntelligenceQuotient = int.Parse(tokens[3])
            };
        }
        static public Snake GetSnakeInfo(string[] tokens)
        {
            return new Snake
            {
                Name = tokens[1],
                Age = int.Parse(tokens[2]),
                CrueltyCoefficient = int.Parse(tokens[3])
            };
        }

    }
}
