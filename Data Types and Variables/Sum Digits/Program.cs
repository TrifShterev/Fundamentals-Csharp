using System;
using System.Linq;
namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num>0)
            {
                int number = num % 10;
                sum += number;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
        
    }
}
