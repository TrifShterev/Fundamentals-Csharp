using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerCases = word.ToLower();
                if (count.ContainsKey(lowerCases))
                {
                    count[lowerCases] ++;
                }
                else
                {
                    count.Add(lowerCases, 1);
                }
            }
            var result = count.Where(kvp => kvp.Value % 2 == 1).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Console.WriteLine(String.Join(" ",result.Keys));
            
        }
    }
}
