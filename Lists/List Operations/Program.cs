using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input ;
            bool invalidIndex = false;
            while ((input = Console.ReadLine()) != "End")
            {
                
                string[] command = input.Split();

               

                switch (command[0])
                {
                    case "Add":
                        int numToAdd = int.Parse(command[1]);
                        listOfNums.Add(numToAdd);
                        continue;
                    case "Insert":
                        int numToInsert = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        if (index > listOfNums.Count-1 ||index<0)
                        {
                            invalidIndex = true;
                            break;
                        }
                        listOfNums.Insert(index, numToInsert);
                        continue;
                        
                    case "Remove":
                        int numToRemoveAtIndex = int.Parse(command[1]);
                        if (numToRemoveAtIndex > listOfNums.Count-1 ||numToRemoveAtIndex<0)
                        {
                            invalidIndex = true;
                            break;
                        }
                        listOfNums.RemoveAt(numToRemoveAtIndex);
                        continue;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            int numToleft = int.Parse(command[2]);
                            ShiftingLeftTheFirstNumber(numToleft, listOfNums);
                            continue;

                        }

                        else if (command[1] == "right")
                        {
                            int numToright = int.Parse(command[2]);
                            ShiftingRightTheFirstNumber(numToright, listOfNums);
                            continue;
                        }
                        break;

                }
                if (invalidIndex == true)
                {
                    Console.WriteLine("Invalid index");
                }

            }
            Console.WriteLine(String.Join(" ", listOfNums));
        }
        static List<int> ShiftingLeftTheFirstNumber(int num, List<int> list)
        {
            for (int i = 0; i < num%list.Count; i++)
            {
                int temp = list[0];
                for (int j = 0; j < list.Count-1; j++)
                {
                    list[j] = list[j + 1];
                }
                list[list.Count - 1] = temp;
            }
            return list;
        }
        static List<int> ShiftingRightTheFirstNumber(int num, List<int> list)
        {
           
                
                for (int j = 0; j < num ; j++)
                {
                    int temp = list[list.Count-1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, temp);
                }
               
            
            return list;
        }
    }
}
