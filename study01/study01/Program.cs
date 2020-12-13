using System;
using System.Collections.Generic;

namespace study01
{
    class Program
    {
        /*
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greather than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greather than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greather than 10");
                Console.WriteLine("And The first number is greather than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greather than 10");
                Console.WriteLine("Or the first number is not greather the second");
            }
            
            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greather than 10");
                Console.WriteLine("Or the first number is greather than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greather than 10");
                Console.WriteLine("And the first number is not greather than the second");
            }
        }
        */

        /*
        static void ExploreLoof()
        {
            int sum = 0;
            
            for (int i = 0; i < 21; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
        */

        static void ExploreList()
        {
            var names = new List<string> { "KHJcode", "Ana", "Felipe" };
            names.Add("Tom");
            names.Add("Kate");
            names.Remove("Ana");

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"This array has {names.Count} people in it");

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            int index = names.IndexOf("Ana");
            
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, returns {index}");
            } else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            var fibonacciNumbers = new List<int> { 1, 1 };

            for (int i = 1; i < 20; i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i] + fibonacciNumbers[i - 1]);
            }

            Console.WriteLine(fibonacciNumbers[19]);
        }

        static void Main(string[] args)
        {
            ExploreList();
            // ExploreLoof();
            // ExploreIf();
        }
    }
}
