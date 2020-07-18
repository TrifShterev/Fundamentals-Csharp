using System;

namespace SignOfIntegerNumber
{
    class Program
    { static void DefinesNumbers(int number)
        {
            

            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main(string[] args)
        {
            DefinesNumbers(int.Parse(Console.ReadLine()));
        }
    }
}
