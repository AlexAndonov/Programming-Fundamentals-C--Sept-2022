namespace _04._List_Operations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmndArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmndType = cmndArgs[0];

                if (cmndType == "Add")
                {
                    int numToAdd = int.Parse(cmndArgs[1]);
                    numbers.Add(numToAdd);
                }
                else if (cmndType == "Insert")
                {
                    int number = int.Parse(cmndArgs[1]);
                    int index = int.Parse(cmndArgs[2]);
                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (cmndType == "Remove")
                {
                    int index = int.Parse(cmndArgs[1]);
                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (cmndType == "Shift")
                {
                    string direction = cmndArgs[1];
                    int count = int.Parse(cmndArgs[2]);
                    if (direction == "left")
                    {
                        ShiftListLeft(numbers, count);
                    }
                    else if (direction == "right")
                    {
                        ShiftListRight(numbers, count);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static bool IsIndexInvalid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;

        static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }

        static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
