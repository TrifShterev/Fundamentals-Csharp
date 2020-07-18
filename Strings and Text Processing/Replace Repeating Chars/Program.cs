using System;
using System.Linq;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            input.Distinct().Select(c => c.ToString()).ToList()
        .ForEach(c =>
        {
            while (input.Contains(c + c))
                input = input.Replace(c + c, c);
        }
        );
            Console.WriteLine(input);
        }
    }
}
