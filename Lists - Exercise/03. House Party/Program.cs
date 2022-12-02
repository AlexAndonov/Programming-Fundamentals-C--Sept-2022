namespace _03._House_Party
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = command[0];

                if (command.Length == 3)
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    names.Add(name);
                }
                else if (command.Length == 4)
                {
                    if (!names.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    names.Remove(name);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
