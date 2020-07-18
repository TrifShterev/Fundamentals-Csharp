using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                var username = command[1];
                

                switch (command[0])
                {
                    case "register":
                        if (register.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {register[username]}");
                        }
                        else
                        {
                            var carNumber = command[2];
                            register.Add(username, carNumber);
                            Console.WriteLine($"{username} registered {carNumber} successfully");
                        }
                        break;
                    case "unregister":
                        if (register.ContainsKey(username))
                        {
                            register.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        break;
                }
            }
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
