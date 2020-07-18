using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                int currentPosition = firstArray[i];
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                sum += currentPosition;
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
