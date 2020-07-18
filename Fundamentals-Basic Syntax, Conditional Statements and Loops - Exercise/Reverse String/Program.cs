using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            
            string output = "";

            for (int i =input.Length-1; i >=0; i--)
            {char name =input [i];
                
                output+=name;
            }
            Console.WriteLine(output);
        }
    }
}
