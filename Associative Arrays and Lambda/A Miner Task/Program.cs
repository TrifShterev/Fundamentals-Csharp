using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> colectedItems = new Dictionary<string, long>();

            string resource;
            while ((resource=Console.ReadLine())!="stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (!colectedItems.ContainsKey(resource))
                {
                    colectedItems.Add(resource, quantity);
                }
                else
                {
                    colectedItems[resource] += quantity;
                }
            }
            foreach (var item in colectedItems)
            {
                Console.WriteLine($"{ item.Key} -> { item.Value}");
            }
        }
    }
}
