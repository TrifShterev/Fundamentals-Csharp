using System;
using System.Text.RegularExpressions;

namespace RegexBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexCode = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            string names = Console.ReadLine();

            MatchCollection matchedNames = regexCode.Matches(names);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value +" ");
            }
            
        }
    }
}
