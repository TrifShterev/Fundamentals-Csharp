using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Dictionary<char, int> countedCharacters = new Dictionary<char, int>();

            for (int i = 0; i < words.Count; i++)
            {
                char[] charactersInWord = words[i].ToCharArray();
                for (int j = 0; j < charactersInWord.Length; j++)
                {
                    char character = charactersInWord[j];
                    if (!countedCharacters.ContainsKey(character))
                    {
                        countedCharacters.Add(character, 1);
                    }
                    else
                    {
                        countedCharacters[character]++;
                    }
                }

            }
            foreach (var item in countedCharacters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
