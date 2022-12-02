namespace _07._Append_Arrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            numbers.Reverse();

            List<string> result= new List<string>();

            foreach (string currSequence in numbers)
            {
                string[] items = currSequence
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (string numToAdd in items)
                {
                    result.Add(numToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
