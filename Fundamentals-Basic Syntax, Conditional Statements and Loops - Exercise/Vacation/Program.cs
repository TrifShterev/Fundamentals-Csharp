using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupOfPeople = double.Parse(Console.ReadLine());
            string classOfPeople = Console.ReadLine();
            string day = Console.ReadLine();

            double sum = 0.00;

            if (classOfPeople=="Students")
            {
                switch (day)
              { 
                    case "Friday":
                        sum = groupOfPeople * 8.45;
                        break;
                    case "Saturday":
                        sum = groupOfPeople * 9.80;
                        break;
                    case "Sunday":
                        sum = groupOfPeople * 10.46;
                        break;
                }
            }
            else if (classOfPeople=="Business")
            {
                if (groupOfPeople>=100)
                {
                    groupOfPeople -= 10;
                } 
                switch (day)
                {
                    case "Friday":
                        sum = groupOfPeople * 10.90;
                        break;
                    case "Saturday":
                        sum = groupOfPeople * 15.60;
                        break;
                    case "Sunday":
                        sum = groupOfPeople * 16.00;
                        break;
                }
            }
            else if (classOfPeople=="Regular")
            {
                switch (day)
                {
                    case "Friday":
                        sum = groupOfPeople * 15;
                        break;
                    case "Saturday":
                        sum = groupOfPeople * 20;
                        break;
                    case "Sunday":
                        sum = groupOfPeople * 22.50;
                        break;
                }
            }
            if (classOfPeople=="Students"&& groupOfPeople>=30)
            {
                Console.WriteLine($"Total price: {sum*0.85:F2}");
            }
            else if(classOfPeople=="Regular"&&groupOfPeople>=10&&groupOfPeople<=20)
            {
                Console.WriteLine($"Total price: {sum * 0.95:F2}");
            }
            else
            {
                Console.WriteLine($"Total price: {sum:F2}");
            }
        }
    }
}
