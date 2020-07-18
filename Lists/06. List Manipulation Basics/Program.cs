using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] order = command.Split();

                switch (order[0])
                {
                    case "Add":
                        int num = int.Parse(order[1]);
                        listOfNums.Add(num);
                        break;
                    case "Remove":
                        int numToRemove = int.Parse(order[1]);
                        listOfNums.Remove(numToRemove);
                        break;
                    case "RemoveAt":
                        int numOfIndex = int.Parse(order[1]);
                        listOfNums.RemoveAt(numOfIndex);
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(order[1]);
                        int index = int.Parse(order[2]);
                        listOfNums.Insert(index,numToInsert);
                        break;
                         
                        

                }command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",listOfNums));
        }
    }
}
