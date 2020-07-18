using System;

namespace English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num %10 ==0)
            {
                Console.WriteLine("zero");
            }
            else if(num %10==1)
            {
                Console.WriteLine("one");
            }
            else if (num % 10 == 2)
            {
                Console.WriteLine("two");
            }
            else if (num % 10 == 3)
            {
                Console.WriteLine("three");
            }
            else if (num % 10 == 4)
            {
                Console.WriteLine("four");
            }
            else if (num % 10 == 5)
            {
                Console.WriteLine("five");
            }
            else if (num % 10 == 6)
            {
                Console.WriteLine("six");
            }
            else if (num % 10 == 7)
            {
                Console.WriteLine("seven");
            }
            else if (num % 10 == 8)
            {
                Console.WriteLine("eight");
            }
            else if (num % 10 == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
