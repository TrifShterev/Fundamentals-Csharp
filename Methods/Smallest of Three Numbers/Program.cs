using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {static int RerurnsSmalestNumOf3Integers(int num1,int num2,int num3)
        {
            int result = 0;
            if (num1>num2&&num1>num3&&num2>num3)
            {
                result = num3;
            }
            else if (num1>num2&&num1>num3&&num3>num2)
            {
                result = num2;
            }
            else if (num2>num1&&num2>num3&&num3>num1)
            {
                result = num1;
            }
            else if (num2>num1&&num2>num3&&num1>num3)
            {
                result = num3;
            }
            else if (num3>num1&&num3>num2&&num1>num2)
            {
                result = num2;
            }
            else if (num3>num1&&num3>num2&&num2>num1)
            {
                result = num1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(RerurnsSmalestNumOf3Integers(number1,number2,number3));
        }
    }
}
