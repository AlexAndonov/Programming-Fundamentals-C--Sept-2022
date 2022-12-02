using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmndArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = cmndArgs[0];
                string employeeID = cmndArgs[1];

                if (!employees.ContainsKey(company))
                {
                    employees.Add(company, new List<string>());
                }
                if (!employees[company].Contains(employeeID))
                {
                    employees[company].Add(employeeID);
                }
            }
            foreach (var company in employees)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
