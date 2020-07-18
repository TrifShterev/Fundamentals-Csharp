using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCountedNumbers = 1;
            int counter = 1;
            int numKeeper = arrOfNums[0];

            for (int i = 1; i < arrOfNums.Length; i++)
            {
                int previousNum = arrOfNums[i - 1];
                int currentNum = arrOfNums[i];

                if (previousNum==currentNum)
                {
                    counter++;
                    if (counter>maxCountedNumbers)
                    {
                        maxCountedNumbers=counter;
                        numKeeper=currentNum;
                    }
                    
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < maxCountedNumbers; i++)
            {
                Console.Write(numKeeper+" ");
            }
            Console.WriteLine();
        }
    }
}
