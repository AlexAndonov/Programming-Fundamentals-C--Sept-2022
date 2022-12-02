namespace _06._List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split(" ");

                string command = inputParams[0];

                if (command == "Add")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(inputParams[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index, value);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
