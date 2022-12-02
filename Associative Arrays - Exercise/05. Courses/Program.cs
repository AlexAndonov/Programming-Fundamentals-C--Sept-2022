namespace _05._Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmndArgs = input.Split(" : ");
                string course = cmndArgs[0];
                string student = cmndArgs[1];

                if (!courseInfo.ContainsKey(course))
                {
                    courseInfo.Add(course, new List<string>());
                }

                courseInfo[course].Add(student);
            }

            foreach (var kvp in courseInfo.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in courseInfo.Values.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
