using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                var result = num * i;
                Console.WriteLine($"{num} X {i} = {result}");
            }
        }
    }
}
