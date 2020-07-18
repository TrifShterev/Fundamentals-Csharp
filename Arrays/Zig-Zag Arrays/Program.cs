using System;
using System.Linq;

namespace _03_ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (i % 2 != 0)
                {
                    firstArr[i - 1] = input[0];
                    secondArr[i - 1] = input[1];
                }

                else
                {
                    firstArr[i - 1] = input[1];
                    secondArr[i - 1] = input[0];
                }
            }

            Console.WriteLine(String.Join(" ", firstArr));
            Console.WriteLine(String.Join(" ", secondArr));
        }
    }
}