using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine(day[0]);
                    break;
                case 2:
                    Console.WriteLine(day[1]);
                    break;
                case 3:
                    Console.WriteLine(day[2]);
                    break;
                case 4:
                    Console.WriteLine(day[3]);
                    break;
                case 5:
                    Console.WriteLine(day[4]);
                    break;
                case 6:
                    Console.WriteLine(day[5]);
                    break;
                case 7:
                    Console.WriteLine(day[6]);
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }
    }
}
