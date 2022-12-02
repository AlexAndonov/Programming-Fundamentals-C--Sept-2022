namespace _02._Gauss_Trick
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

            List<int> result = new List<int>();
            // 1 2 3 4 5
            // 1 2 3 4
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int sum = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(sum);
            }
            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
