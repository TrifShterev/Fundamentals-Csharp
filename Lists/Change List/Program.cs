using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Delete":
                        int deleteNums = int.Parse(command[1]);
                        listOfNums.RemoveAll(item => item == deleteNums);
                        input = Console.ReadLine();
                        continue;
                    case "Insert":
                        int element = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        listOfNums.Insert(index, element);
                        input = Console.ReadLine();
                        continue;
                }
               
            }
            Console.WriteLine(String.Join(" ",listOfNums));
        }
    }
}
