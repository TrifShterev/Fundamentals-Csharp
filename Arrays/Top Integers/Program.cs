using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];
                bool topInteger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    if (currentNumber <= nextNumber)
                    {
                        topInteger = false;
                        break;
                    }
                }
                if (topInteger)
                {
                    Console.Write(currentNumber  +" ");
                }
            }
            Console.WriteLine(numbers[numbers.Length-1]);

        }
    }
}
