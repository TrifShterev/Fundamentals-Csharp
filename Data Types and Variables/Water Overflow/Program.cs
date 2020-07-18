using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPours = int.Parse(Console.ReadLine());
            int tank = 0;
            for (int i = 0; i < numOfPours; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                tank += liters;
                if (liters>255||tank>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    tank -= liters;
                }
                
                   
                
            }
            Console.WriteLine(tank);
        }
    }
}
