namespace _02._Change_List
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
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmndArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = cmndArgs[0];

                if (type == "Delete")
                {
                    int value = int.Parse(Console.ReadLine());
                    numbers.RemoveAll(x => x == value);
                }
                else if (type == "Insert")
                {
                    int element = int.Parse(cmndArgs[1]);
                    int index = int.Parse(cmndArgs[2]);
                    numbers.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
