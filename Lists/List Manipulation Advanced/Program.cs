using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _06._List_Manipulation_Advanced
{
    class Program
    {
        static void ReturnsBiggerSmallerOrEqualOfNumber(string condition, int num, List<int> listLength)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < listLength.Count; i++)
            {
                if (condition == "<" && listLength[i] < num)
                {
                    result.Add(listLength[i]);
                }
                else if (condition == ">" && listLength[i] > num)
                {
                    result.Add(listLength[i]);
                }
                else if (condition == "<=" && listLength[i] <= num)
                {
                    result.Add(listLength[i]);
                }
                else if (condition == ">=" && listLength[i] >= num)
                {
                    result.Add(listLength[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));

        }
        static void PrintingOddNumbers(List<int> list)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    oddNumbers.Add(list[i]);
                }

            }
            Console.WriteLine(String.Join(" ", oddNumbers));
        }
        static void PrintingEvenNumbers(List<int> list)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    evenNumbers.Add(list[i]);
                }

            }
            Console.WriteLine(String.Join(" ", evenNumbers));
        }
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            int countPreviewTaskChanges = 0;
            while (command != "end")
            {
                string[] order = command.Split();

                switch (order[0])
                {
                    case "Add":
                        countPreviewTaskChanges++;
                        int num = int.Parse(order[1]);
                        listOfNums.Add(num);
                        break;
                    case "Remove":
                        countPreviewTaskChanges++;
                        int numToRemove = int.Parse(order[1]);
                        listOfNums.Remove(numToRemove);
                        break;
                    case "RemoveAt":
                        countPreviewTaskChanges++;
                        int numOfIndex = int.Parse(order[1]);
                        listOfNums.RemoveAt(numOfIndex);
                        break;
                    case "Insert":
                        countPreviewTaskChanges++;
                        int numToInsert = int.Parse(order[1]);
                        int index = int.Parse(order[2]);
                        listOfNums.Insert(index, numToInsert);
                        break;
                    case "Contains":
                        int containsNum = int.Parse(order[1]);
                        if (listOfNums.Contains(containsNum))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        PrintingEvenNumbers(listOfNums);
                        break;
                    case "PrintOdd":
                        PrintingOddNumbers(listOfNums);
                        break;
                    case "GetSum":
                        Console.WriteLine(listOfNums.Sum());
                        break;
                    case "Filter":
                        int numberToCompare = int.Parse(order[2]);
                        ReturnsBiggerSmallerOrEqualOfNumber(order[1],numberToCompare,listOfNums);
                        break;
                    


                }
                command = Console.ReadLine();
            }
            if (countPreviewTaskChanges>0)
            {
                Console.WriteLine(String.Join(" ", listOfNums));
            }
        }
    }
}
