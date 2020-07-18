using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList().ForEach(Console.WriteLine);
        }
    }
}
