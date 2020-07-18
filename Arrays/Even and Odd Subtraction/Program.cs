using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sumOdd = 0;
            var sumEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum % 2==0)
                {
                    sumEven += currentNum;
                }
                else
                {
                    sumOdd += currentNum;
                }

            }var result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}
