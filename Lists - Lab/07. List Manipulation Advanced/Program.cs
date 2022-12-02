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

            bool isChanged = false;
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split(" ");

                string command = inputParams[0];

                if (command == "Add")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                    isChanged = true;
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                    isChanged = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(inputParams[1]);
                    numbers.RemoveAt(index);
                    isChanged = true;
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index, value);
                    isChanged = true;
                }
                else if (command == "Contains")
                {
                    int value = int.Parse(inputParams[1]);
                    if (numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = inputParams[1];
                    int value = int.Parse(inputParams[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < value)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > value)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= value)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= value)));
                    }
                }

                input = Console.ReadLine();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
