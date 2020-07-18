using System;
using System.Collections.Generic;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                var randomIndex = random.Next(0, input.Length);

                string temp = input[randomIndex];
                input[randomIndex] = input[i];
                input[i] = temp;
            }
            Console.WriteLine(String.Join("\n",input));
        }
    }
}
