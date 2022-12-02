namespace _06._Student_Academy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!grades.ContainsKey(student))
                {
                    grades.Add(student, new List<double>());
                }
                grades[student].Add(grade);
            }
            Dictionary<string, double> averageGrades = new Dictionary<string, double>();
            foreach (var pair in grades)
            {
                averageGrades.Add(pair.Key, pair.Value.Average());
            }
            foreach (var pair in averageGrades.Where(x => x.Value >= 4.50))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
        }
    }
}
