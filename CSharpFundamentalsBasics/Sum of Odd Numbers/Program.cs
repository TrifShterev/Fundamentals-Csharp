using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0.00;
            var lines = num * 2;
            for (int i = 1; i <= lines; i++)
            {
                if (i % 2 !=0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
