using System;
using System.Runtime.ExceptionServices;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                char third = (char)('a' + i);
                
                for (int j = 0; j < num; j++)
                {
                    char second = (char)('a' + j);
                    
                    for (int k = 0; k < num; k++)
                    {
                        char first = (char)('a' + k);
                        Console.Write((char)third);
                        Console.Write((char)second);
                        Console.Write((char)first);
                       
                        
                        Console.WriteLine();
                    }
                }

            }
        }
    }
}
