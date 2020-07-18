using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static double CalculateRectangleArea(double width, double lenght)
        {
            return width * lenght;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double area = CalculateRectangleArea(width, lenght);
            Console.WriteLine(area);
        }
    }
}
