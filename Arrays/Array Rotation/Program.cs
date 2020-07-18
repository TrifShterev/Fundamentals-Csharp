using System;
using System.Linq;


namespace Rotations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNum = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int firstNumber = arrayOfNum[0];

                for (int j = 0; j < arrayOfNum.Length - 1; j++)
                {
                    arrayOfNum[j] = arrayOfNum[j + 1];
                }
                arrayOfNum[arrayOfNum.Length - 1] = firstNumber;
            }
            Console.WriteLine(string.Join(" ", arrayOfNum));
        }
    }
}