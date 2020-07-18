using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = "";
            for (int i = name.Length-1; i >=0; i--)
            {
                
                pass += name[i];
            }
          
            for (int i = 0; i < 4; i++)
            { string password = Console.ReadLine();
                if (password==pass)
                {
                    Console.WriteLine($"User {name} logged in.");
                    return;
                }
                else if(i<3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            Console.WriteLine($"User {name} blocked!");
        }
    }
}
