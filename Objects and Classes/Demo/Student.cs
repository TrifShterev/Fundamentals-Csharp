using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Student
    {
        public string Name;
        public int Age;
        public string[] Skills;

      public  void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name-> {student.Name} Student age-> {student.Age} Student Skills-> {String.Join(" ", student.Skills)}");
        }
    }
}
