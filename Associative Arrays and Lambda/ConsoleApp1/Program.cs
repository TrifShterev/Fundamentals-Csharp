using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();
            foreach (var item in numbers)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count.Add(item, 1);
                }
                
            }
            foreach (var element in count)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
           
        }
    }
}

