using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                                          .Split()
                                          .Select(double.Parse)
                                          .ToList();
            List<double> result = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>0)
                {
                    result.Add(numbers[i]);
                }
            }
            if (result.Count==0)
            {
                Console.WriteLine("empty");
                return;
            }
            result.Reverse();
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
