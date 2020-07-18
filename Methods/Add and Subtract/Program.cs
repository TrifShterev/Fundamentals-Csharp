using System;

namespace Add_and_Subtract
{
    class Program
    {static int ReturnsResult(int num1,int num2,int num3)
        {
            return ReturnsTheSumOfNum1AndNum2(num1,num2)- num3;
        }
        static int ReturnsTheSumOfNum1AndNum2(int num1,int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnsResult(num1, num2, num3) );
        }
    }

    
}
