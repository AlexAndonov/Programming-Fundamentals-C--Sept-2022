using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(", ");

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (string person in people)
            {
                keyValuePairs.Add(person, 0);
            }

            string namePattern = @"[\W\d]";
            string distancePattern = @"[\WA-Za-z]";
            Regex nameRegex = new Regex(namePattern);
            Regex distanceRegex = new Regex(distancePattern);

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = nameRegex.Replace(input, "");
                string distance = distanceRegex.Replace(input, "");

                int sum = 0;

                foreach (var digit in distance)
                {
                    int currDigit = int.Parse(digit.ToString());
                    sum += currDigit;
                }

                if (keyValuePairs.ContainsKey(name))
                {
                    keyValuePairs[name] += sum;
                }
            }

            int count = 1;
            foreach (var kvp in keyValuePairs.OrderByDescending(x => x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count++}{text} place: {kvp.Key}");

                if (count > 3)
                {
                    break;
                }
            }
        }
    }
}
