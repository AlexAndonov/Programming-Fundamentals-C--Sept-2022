namespace _04._SoftUni_Parking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registered = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmndArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = cmndArgs[0];
                string name = cmndArgs[1];

                if (type == "register")
                {
                    string licensePlate = cmndArgs[2];
                    if (!registered.ContainsKey(name))
                    {
                        registered.Add(name, licensePlate);
                        Console.WriteLine($"{name} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (type == "unregister")
                {
                    if (!registered.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        registered.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in registered)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
