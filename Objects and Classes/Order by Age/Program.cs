using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[] info = input.Split();

               Person person=new Person(info[0], info[1], int.Parse(info[2]));
                people.Add(person);
            }
            Console.WriteLine(String.Join("\n",people.OrderBy(x=>x.Age)));
        }
    }public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    
}
