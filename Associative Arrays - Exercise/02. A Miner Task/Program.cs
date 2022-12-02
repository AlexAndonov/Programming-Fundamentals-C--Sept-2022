namespace _02._A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int qnt = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += qnt;
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} –> {kvp.Value}");
            }
        }
    }
}
