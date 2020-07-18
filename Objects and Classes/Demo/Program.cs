using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students i SoftUni?");
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            Student student = new Student()
            {
                Name = "pesho",
                Skills = new string[0]
            };
            student.PrintStudent(student);
          
            // Basics za obekti-----------------------
            //Student PeshoStudent = new Student();
            //PeshoStudent.Name = "Pesho";
            //PeshoStudent.Age = 15;
            //PeshoStudent.Skills = new string[] { "nishto", "i ", "polovina" };

            //Student Gosho = new Student();
            //Gosho.Name = "Gosho";
            //Gosho.Age = 16;
            //Gosho.Skills = new string[] { "neshto" };
            //PrintStudent(PeshoStudent);
            //PrintStudent(Gosho);


        }
        //static void PrintStudent(Student student)
        //{
        //    Console.WriteLine($"Student name-> {student.Name} Student age-> {student.Age} Student Skills-> {String.Join(" ", student.Skills)}");
        //}
        static Student ReadStudent()
        {
            Student newStudent = new Student();

            Console.WriteLine("Enter name: ");
            newStudent.Name = Console.ReadLine();
            Console.WriteLine(" Enter Age:");
            newStudent.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Skills.");
            newStudent.Skills = Console.ReadLine().Split();

            return newStudent;

        }
    }
}
