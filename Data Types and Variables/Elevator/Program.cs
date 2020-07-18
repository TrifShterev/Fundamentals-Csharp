using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());

            double courses = people / capacity;
            Console.WriteLine(Math.Ceiling(courses));

        }
    }
}
