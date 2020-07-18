using System;
using System.Linq;


namespace demoExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var length = input.Length;
            var countOfshotedTargets = 0;
            while (true)
            {
                var targetAsString = Console.ReadLine();
                if (targetAsString == "End")
                {
                    break;
                }

                var targetIndex = int.Parse(targetAsString);
                if (targetIndex < 0 || targetIndex >= length || input[targetIndex] == -1)
                {
                    continue;
                }

                countOfshotedTargets++;

                for (int i = 0; i < length; i++)
                {
                    if (input[i] == -1 || targetIndex == i)
                    {
                        continue;
                    }

                    var targetValue = input[targetIndex];
                    if (targetValue >= input[i])
                    {
                        input[i] += targetValue;
                    }
                    else if (targetValue < input[i])
                    {
                        input[i] -= targetValue;
                    }
                }

                input[targetIndex] = -1;
            }

            Console.WriteLine($"Shot targets: {countOfshotedTargets} -> {string.Join(" ", input)}");
        }
    }
}
