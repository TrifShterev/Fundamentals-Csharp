﻿using System;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digits = "";
            string letters = "";
            string somethingElse = "";

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else
                {
                    somethingElse += symbol;
                }

            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(somethingElse);
        }
    }
}
