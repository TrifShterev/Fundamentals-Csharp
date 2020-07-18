using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNum = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
            int leftSum = 0;
            int rightSum = arrayOfNum.Sum();

            for (int i = 0; i < arrayOfNum.Length; i++)
            {
                rightSum -= arrayOfNum[i];
                if (rightSum==leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }leftSum += arrayOfNum[i];
            }
            Console.WriteLine("no");
        }
    }
}
