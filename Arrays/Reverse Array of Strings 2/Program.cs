using System;
using System.Linq;

namespace Reverse_Array_of_Strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < items.Length/2; i++)
            {
                var oldElement = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(string.Join(" ",items));
        }
    }
}
