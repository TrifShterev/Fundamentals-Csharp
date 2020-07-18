using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombInfo[0];
            int power = bombInfo[1];
            int bombIndex = numbers.IndexOf(bombNumber);

            while (bombIndex!=-1)
            {
                int leftNumbers = bombIndex - power;
                int rightNumbers = bombIndex + power;
                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }
                if (rightNumbers > numbers.Count - 1)
                {
                    rightNumbers = numbers.Count - 1;
                }
               

                numbers.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);
                bombIndex = numbers.IndexOf(bombNumber);
                
            }
            Console.WriteLine(numbers.Sum());

           

        }
    }
}
