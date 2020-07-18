using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");

            foreach (var name in names)
            {
                var currentName = name;
                bool isReal = currentName.Length >= 3 && currentName.Length < 16;
                for (int i = 0; i < currentName.Length; i++)
                {
                    var symbol = currentName[i];
                   
                    
                    
                    if (char.IsDigit(symbol)||symbol=='-'||symbol=='_'|| char.IsLetter(symbol))
                    {
                       
                        continue;
                    }                   
                    else
                    {
                        isReal = false;
                        break;
                    }
                }
                if (isReal)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}