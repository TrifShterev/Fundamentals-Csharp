using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringOfNumbers = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();
            //7 8 |4 5 6|1 2 3
            List<int> numbers = new List<int>();
            foreach (var item in stringOfNumbers)
            {
                numbers.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList());
                         
            }
            //7 8 4 5 6 1 2 3

            Console.WriteLine(String.Join(" ",numbers));
        }


    }
}
