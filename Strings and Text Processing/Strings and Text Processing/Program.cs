using System;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input=Console.ReadLine())!="end")
            { var reversed = input.Reverse();
                Console.WriteLine($"{input} = {String.Concat(reversed)}");
            }
            
        }
    }
}
