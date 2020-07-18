using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> craftingMaterials = new Dictionary<string, int>();

            craftingMaterials["shards"] = 0;
            craftingMaterials["fragments"] = 0;
            craftingMaterials["motes"] = 0;

            bool readyForCraft = false;
            while (true)
            {
                var input = Console.ReadLine().ToLower().Split().ToList();

                var items = input.Where((x, index) => index % 2 == 1).ToList();
                var amount = input.Where((x, index) => index % 2 == 0).Select(int.Parse).ToList();


                for (int i = 0; i < items.Count; i++)
                {
                    var currentKey = items[i];
                    var currentValue = amount[i];
                    if (!craftingMaterials.ContainsKey(currentKey))
                    {
                        craftingMaterials.Add(currentKey, currentValue);
                    }
                    else
                    {
                        craftingMaterials[currentKey] += currentValue;
                    }
                    if (currentKey == "shards" && craftingMaterials["shards"] >= 250)
                    {
                        craftingMaterials[currentKey] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        readyForCraft = true;
                        break;
                    }
                    if (currentKey == "fragments" && craftingMaterials["fragments"] >= 250)
                    {
                        craftingMaterials[currentKey] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        readyForCraft = true;
                        break;
                    }
                    if (currentKey == "motes" && craftingMaterials["motes"] >= 250)
                    {
                        craftingMaterials[currentKey] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        readyForCraft = true;
                        break;
                    }
                }
                if (readyForCraft)
                {
                    break;
                }
            }
            SortedDictionary<string, int> junks = new SortedDictionary<string, int>();

            foreach (var item in craftingMaterials)
            {
                if (item.Key == "motes" || item.Key == "fragments" || item.Key == "shards")
                {
                    continue;
                }
                junks.Add(item.Key, item.Value);
                craftingMaterials.Remove(item.Key);

            }
            var remains = craftingMaterials.OrderByDescending(kvp => kvp.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in remains)
            {
                if (remains.ContainsValue(item.Value))
                {
                    remains = remains.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(x => x.Key, x => x.Value);
                    break;

                }
            }
           
            foreach (var item in remains)
            {
                
               
               
                    Console.WriteLine($"{item.Key}: {item.Value}");
               

            }
            foreach (var item in junks)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
