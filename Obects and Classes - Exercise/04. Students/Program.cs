namespace _04._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = command[0];
                string lastName = command[1];
                double grade = double.Parse(command[2]);

                Student currStudent = new Student(firstName, lastName, grade);
                students.Add(currStudent);
            }
            List<Student> orderedStudents = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Grade { get; private set; }
    }
}
