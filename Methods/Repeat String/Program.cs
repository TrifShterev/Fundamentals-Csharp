using System;

namespace Repeat_String
{
    class Program
    {static string RepeatString(string input, int counter)
        {
            string result = "";
            for (int i = 0; i < counter; i++)
            {
                result += input;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, counter));
        }
    }
}
