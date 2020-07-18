using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split();

            CharacterMultiplier(str1[0], str1[1]);
        }

        private static void CharacterMultiplier(string str1, string str2)
        {
            int total = 0;
            var shorterStr = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < shorterStr; i++)
            {
                //Няма нужда да се каства.
                //var num1 = (int)str1[i];
                //var num2 = (int)str2[i];

                total += str1[i] * str2[i];
            }
            if (str1.Length != str2.Length)
            {
                var charactersLeft = str1.Length > str2.Length ? str1.Substring(str2.Length) : str2.Substring(str1.Length);
                foreach (var character in charactersLeft)
                {
                    total += (int)character;
                }
            }
            Console.WriteLine(total);
        }
    }
}
