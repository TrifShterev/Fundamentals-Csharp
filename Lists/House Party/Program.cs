using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partyList = new List<string>();
            int numOfGuests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfGuests; i++)
            {
                string[] infoAboutGuests = Console.ReadLine().Split();
                string name = infoAboutGuests[0];
                if (infoAboutGuests[1] == "is" && infoAboutGuests[2] == "going!")
                {
                    if (partyList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        partyList.Add(name);
                    }
                }
                else if (infoAboutGuests[1] == "is" && infoAboutGuests[2] == "not" && infoAboutGuests[3] == "going!")
                {
                    if (partyList.Contains(name))
                    {
                        partyList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        
                    }



                }

            }
            foreach (var i in partyList)
            {
                Console.WriteLine( i);
            }
            
        }
    }
}
