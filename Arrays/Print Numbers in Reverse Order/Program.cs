using System;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numpers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numpers[i] = num;
            }
            for (int i = numpers.Length-1; i >=0; i--)
            {
                Console.Write(numpers[i] + " ");
            }
        }
    }
}
