using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
            //Weekday          12$	          18$	           12$
            //Weekend          15$	          20$	           15$
            //Holiday           5$	          12$	           10$

            var day = Console.ReadLine();
            var age = double.Parse(Console.ReadLine());
            var price = 0.00;
            if (age>=0&&age <=18)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 5;
                        break;
                }
            }
            else if (age>18 &&age <=64)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 18;
                        break;
                    case "Weekend":
                        price = 20;
                        break;
                    case "Holiday":
                        price = 12;
                        break;
                }
            }
            else if (age>64 && age<=122)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 10;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.WriteLine(price+"$");
        }
    }
}
