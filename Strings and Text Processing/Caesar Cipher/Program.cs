using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
               
                var asciiNum = (int)input[i];
                var codedNum = asciiNum + 3;
                var symbol = (char)codedNum;
                result += symbol;
            }
            Console.WriteLine(result);
        }
    }
}
