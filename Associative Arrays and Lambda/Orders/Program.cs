using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> boughtItems = new Dictionary<string, List<double>>();

            
            string input;
            while ((input=Console.ReadLine())!="buy")
            {
                var itemsAndPrices = input.Split();
                var product = itemsAndPrices[0];

                var price = double.Parse(itemsAndPrices[1]);
                var quantity = double.Parse(itemsAndPrices[2]);



                if (!boughtItems.ContainsKey(product))
                {

                    boughtItems.Add(product, new List<double>() { price, quantity });


                }
                else
                {
                    boughtItems[product][0] = price;
                    boughtItems[product][1] += quantity;
                }
            }
            foreach (var item in boughtItems)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):f2}");
            }
        }
    }
}
