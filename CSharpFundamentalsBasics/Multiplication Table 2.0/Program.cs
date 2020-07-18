using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            if (multiplier <= 10)
            {

                for (int i = multiplier; i <= 10; i++)
                {
                    var result = num * i;
                    Console.WriteLine($"{num} X {i} = {result}");
                }
            }
            else
            {
                Console.WriteLine($"{num} X {multiplier} = {num*multiplier}");
            }
        }
    }
}
