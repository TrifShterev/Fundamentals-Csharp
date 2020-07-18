using System;

namespace Greater_of_Two_Values
{
    class Program
    {static string GetMax(string first,string second)
        {
            int compare = first.CompareTo(second);
            if (compare >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            return (char)Math.Max(first, second);
        }
        static int GetMax(int a, int b)
        {


            return (int)Math.Max(a, b);
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int a = int.Parse(first);
                    int b = int.Parse(second);
                    Console.WriteLine( GetMax(a, b));
                    break;
                case "string":
                    Console.WriteLine(GetMax(first, second));
                    break;
                case "char":
                    Console.WriteLine(GetMax(first, second));
                    break;
            }
        }
    }
}
