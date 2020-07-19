using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regexPattern = new Regex(@"\b(?<date>[0-9]{2})([\/.-])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b");
            MatchCollection matchedDates = regexPattern.Matches(input);

            foreach (Match item in matchedDates)
            {
                Console.WriteLine($"Day: {item.Groups["date"]}, Month: {item.Groups["month"].Value }, Year: { item.Groups["year"].Value}");
            }
            // Since RegEx works differently across different languages, before we continue
            //, we’re going to set our backreference from \2 to \1.--> става въпрос за в паттерна. 
           //В C# групата в поредицата от групи която не е ИМЕНУВАНА(без ИМе) се счита за първа!!! 

        }
    }
}
