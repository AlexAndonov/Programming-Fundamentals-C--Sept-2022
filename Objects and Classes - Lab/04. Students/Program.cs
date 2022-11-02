namespace _04._Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input= Console.ReadLine()) != "end")
            {
                string[] info = input.Split();
                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string town = info[3];

                Student student = new Student(firstName, lastName, age, town);
                students.Add(student);
            }
            string desiredTown = Console.ReadLine();
            foreach (Student currStudent in students.Where(x => x.Town == desiredTown))
            {
                Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
            }
        }   
    }
   class Student
    {
        public Student(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
    }
}
