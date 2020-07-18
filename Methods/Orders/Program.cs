using System;

namespace Orders
{
    class Program
    {
        static void CalculatingOrders (string product, double quantity) {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{quantity*1.50:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity*1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity*1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity*2.00:f2}");
                    break;
               
            }
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            CalculatingOrders(product, quantity);
        }
    }
}
