using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
           
            string name;
            double grade;
            for (int i = 0; i < n; i++)
            {
                 name = Console.ReadLine();
                 grade = double.Parse(Console.ReadLine());
                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);

                }
            }
             studentGrades = studentGrades
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value);

            foreach (var item in studentGrades)
            {
                var averageGrade = item.Value.Average();
                if (averageGrade>=4.5)
                {
                    Console.WriteLine($"{item.Key} -> {averageGrade:f2}");
                }
            }
            
        }
    }
}
