using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string[] line = words.Split(" ");
            
            string[] curent = new string[0];

            for (int i = line.Length-1; i >= 0; i--)
            {
                line[i] +=curent ;
               
            }
            string result = string.Join(" ", curent);
            Console.WriteLine(result);

        }
    }
}
