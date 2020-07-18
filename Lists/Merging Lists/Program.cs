using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();
            List<int> secondList = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();
            List<int> result = new List<int> ();

            int countMax = Math.Max(firstList.Count, secondList.Count);
            for (int i = 0; i < countMax; i++)
            {
                if (i<firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i<secondList.Count)
                {
                    result.Add(secondList[i]);
                }

            }
            Console.WriteLine(String.Join(" ",result));


            
                
               
               

            
           
            

        }
    }
}
