using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companiesRegister = new SortedDictionary<string, List<string>>();

            string input;
            while ((input=Console.ReadLine())!="End")
            {
                var order = input.Split(" -> ");
                var nameOfCompany = order[0];
                var id = order[1];
                if (!companiesRegister.ContainsKey(nameOfCompany))
                {
                    companiesRegister.Add(nameOfCompany, new List<string>());
                    companiesRegister[nameOfCompany].Add(id);
                }
                else if (companiesRegister[nameOfCompany].Contains(id))
                {
                    continue;
                }
                else
                {
                    companiesRegister[nameOfCompany].Add(id);
                }
            }
            foreach (var element in companiesRegister)
            {
                Console.WriteLine(element.Key);
                foreach (var item in element.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
