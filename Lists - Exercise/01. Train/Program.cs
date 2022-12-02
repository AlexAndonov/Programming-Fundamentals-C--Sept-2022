namespace _01._Train
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmndArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmndArgs[0] == "Add")
                {
                    int wagon = int.Parse(cmndArgs[1]);
                    passengers.Add(wagon);
                }
                else
                {
                    int passenegersToAdd = int.Parse(cmndArgs[0]);
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[i] + passenegersToAdd > maxCapacity)
                        {
                            continue;
                        }
                        else
                        {
                            passengers[i] += passenegersToAdd;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",passengers));
        }
    }
}
