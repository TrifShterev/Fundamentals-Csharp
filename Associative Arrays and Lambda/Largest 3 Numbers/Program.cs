using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var largestThree = nums.OrderByDescending(x => x).Take(3).ToList();
            foreach (var item in largestThree )
            {
                Console.Write(item+ " ");
            }
            
        }



    }
}
