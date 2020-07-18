using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Students
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;

            while ((input=Console.ReadLine())!="end")
            {
                string[] infoAboutstudents = input.Split();

                string name = infoAboutstudents[0];
                string familyName = infoAboutstudents[1];
                int ageOfStudent = int.Parse(infoAboutstudents[2]);
                string cityOfStudent = infoAboutstudents[3];

                Student student = students.FirstOrDefault(x => x.FirstName == name && x.LastName == familyName);
                if (student == null)
                {
                    students.Add(new Student(){
                     FirstName = name,
                    LastName = familyName,
                    Age = ageOfStudent,
                    City = cityOfStudent,

                });
                }
                else
                {
                    student.FirstName = name;
                    student.LastName = familyName;
                    student.Age = ageOfStudent;
                    student.City = cityOfStudent;

                }

            }
            string requiredInfo = Console.ReadLine();

            students.Where(x => x.City == requiredInfo).ToList()
                .ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old." ));
        }
    }
}
