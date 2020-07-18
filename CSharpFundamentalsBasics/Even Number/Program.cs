using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
           
      
                while (num%2!=0)
                {
                    Console.WriteLine($"Please write an even number.");
                    num = double.Parse(Console.ReadLine());
            }
            if (num % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(num)}");
            }

        }
    }
}
