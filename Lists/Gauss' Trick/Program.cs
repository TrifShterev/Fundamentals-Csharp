using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int originalCount = numbers.Count;//this variable keeps the original size of the List and secure against future wrong calculations!!!
            for (int i = 0; i < originalCount/2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1 ];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(String.Join(" ",numbers));
           
        }
    }
}
