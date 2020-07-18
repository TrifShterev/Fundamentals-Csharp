﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < num; i++)
            {
                 products.Add( Console.ReadLine());
            }
            products.Sort();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
            
        }
    }
}
