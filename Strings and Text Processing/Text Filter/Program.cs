using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var textToBan = Console.ReadLine().Split(", ");
            var text = Console.ReadLine();
            for (int i = 0; i < textToBan.Length; i++)
            {
                string currentWord = textToBan[i];
                while (text.Contains(currentWord))
                {
                    string wordToReplaceWith = new string('*', currentWord.Length);

                    text = text.Replace(currentWord, wordToReplaceWith);
                }
            }
            Console.WriteLine(text);

        }
    }
}
