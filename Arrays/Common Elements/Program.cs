using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elementsArr1 = Console.ReadLine().Split().ToArray();
            string[] elementsArr2 = Console.ReadLine().Split().ToArray();
            
            for (int i = 0; i < elementsArr1.Length; i++)
            {
                for (int j = 0; j < elementsArr2.Length; j++)
                {
                    if (elementsArr2[j] == elementsArr1[i])
                    { Console.Write(" "+ elementsArr2[j]); }
                }
            }
        }
    }
}











