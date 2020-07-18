using System;

namespace NxN_Matrix
{
    class Program
    {static void DrawingMatrixOfGivenNumber()
        {
          int  num= int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                
                for (int ji = 0; ji < num; ji++)
                {
                    Console.Write(num+" "  );
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
           
            DrawingMatrixOfGivenNumber();
            
        }
    }
}
