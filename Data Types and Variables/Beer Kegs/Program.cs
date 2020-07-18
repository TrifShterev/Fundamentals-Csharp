using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beerKegs = int.Parse(Console.ReadLine());
            var volumeResult = 0.00M;
            string name = "";
            for (int i = 0; i < beerKegs; i++)
            {
                string currrentName = Console.ReadLine();
                var radius = decimal.Parse(Console.ReadLine());
                var height = decimal.Parse(Console.ReadLine());
                
                
                decimal volume = 3.14M * (radius * radius) * height;
                if (volume>volumeResult)
                {
                    volumeResult=volume;
                    name=currrentName;
                }

            }
            Console.WriteLine(name);
        }
    }
}
