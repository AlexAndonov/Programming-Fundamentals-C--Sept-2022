namespace _01._Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Dictionary<int,int> counts = new Dictionary<int,int>(); 

            foreach (int number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 0);
                }
                counts[number]++;
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
