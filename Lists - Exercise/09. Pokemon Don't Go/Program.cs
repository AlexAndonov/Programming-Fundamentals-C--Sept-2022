namespace _09._Pokemon_Don_t_Go
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            bool hasChanged = false;
            int index = int.Parse(Console.ReadLine());
            while (input.Count > 0)
            {
                if (index < 0)
                {
                    index = 0;
                    int copy = input[input.Count - 1];
                    input.RemoveAt(0);
                    input.Insert(0, copy);
                    hasChanged = true;
                }

                if (index > input.Count - 1)
                {
                    int copy = input[0];
                    input.RemoveAt(input.Count - 1);
                    input.Add(copy);
                    index = input.Count - 1;
                    hasChanged = true;
                }

                int num = input[index];
                sum += input[index];
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= num)
                    {
                        input[i] += num;
                    }
                    else if (input[i] > num)
                    {
                        input[i] -= num;
                    }
                }
                if (!hasChanged)
                {
                    input.RemoveAt(index);
                }
                
                if (input.Count > 0)
                {
                    index = int.Parse(Console.ReadLine());
                }
                hasChanged = false;
            }
            Console.WriteLine(sum);
        }
    }
}
