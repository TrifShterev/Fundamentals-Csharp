using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input;

            while ((input=Console.ReadLine())!="end")
            {
                var data = input.Split(" : ");
                var course = data[0];
                var student = data[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(student);
                }
                else
                {
                    courses[course].Add(student);
                }
            }
            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
