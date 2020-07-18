using System;

namespace Characters_in_Range
{
    class Program
    {static void DisplayingCharsInRangebyASCI(char symbolStart,char symbolEnd)
        {
            if (symbolStart < symbolEnd)
            {


                
                for (int i = symbolStart+1; i < symbolEnd; i++)
                {

                    Console.Write((char)i + " ");
                }
            }
            else
            {
                
                for (int i = symbolEnd+1; i < symbolStart; i++)
                {

                    Console.Write((char)i + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            DisplayingCharsInRangebyASCI(start, end);
        }
    }
}
