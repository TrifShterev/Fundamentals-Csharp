using System;
using System.Linq;
namespace Vowels_Count
{
    class Program
    {static string CountingVowels(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            { 
                if (word[i]=='a'||word[i]=='e'|| word[i] == 'i' || word[i] == 'o' || word[i] == 'u' )
                {
                    count++;
                }
            }
            var result = count.ToString();
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(CountingVowels(input));

        }
    }
}
