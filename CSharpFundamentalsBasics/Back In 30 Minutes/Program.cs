using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var after30min = minutes + 30;


            if (after30min >= 60)
            {
                hours++;
                if (hours >= 24)
                {
                    hours = 0;
                }
                after30min = after30min - 60;

                if (after30min < 10)
                {
                    Console.WriteLine($"{hours}:0{after30min}");
                }
                else
                {
                    Console.WriteLine($"{hours}:{after30min}");

                }

            }
            else
            {
                Console.WriteLine($"{hours}:{after30min}");
            }
        }
            

        }
        }
    

