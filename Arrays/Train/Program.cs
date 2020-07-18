using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int vagonsNum = int.Parse(Console.ReadLine());
            int[] train = new int[vagonsNum];
            for (int i = 0; i < train.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                train[i] = people;

            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(train.Sum());
        }
    }
}
