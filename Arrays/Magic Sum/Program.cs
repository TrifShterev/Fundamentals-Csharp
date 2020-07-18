using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i <arrNumbers.Length ; i++)
            {
                int numOfPosition1 = arrNumbers[i];

                for (int j = i+1; j < arrNumbers.Length; j++)
                {
                    int numOfPosition2 = arrNumbers[j];
                    if (numOfPosition1+numOfPosition2==magicNum)
                    {
                        Console.WriteLine($"{numOfPosition1} {numOfPosition2}");
                    }
                }
            }
        }
    }
}
