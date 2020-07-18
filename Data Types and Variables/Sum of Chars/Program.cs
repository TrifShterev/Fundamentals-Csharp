using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                char bet = char.Parse(Console.ReadLine());
                
                sum += bet;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
