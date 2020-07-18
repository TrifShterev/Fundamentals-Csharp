using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vagonsInTrain = Console.ReadLine().Split().Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                
                
                    string[] tokens = command.Split();
                if (tokens[0]=="Add")
                {


                    int vagonWithPassangers = int.Parse(tokens[1]);

                    vagonsInTrain.Add(vagonWithPassangers);
                    command = Console.ReadLine();
                    continue;

                }


                int passengers = int.Parse(tokens[0]);

                for (int i = 0; i < vagonsInTrain.Count; i++)
                {
                    if ((vagonsInTrain[i]+passengers) <= capacity)
                    {
                        vagonsInTrain[i] += passengers;
                        break;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",vagonsInTrain));
        }
    }
}
