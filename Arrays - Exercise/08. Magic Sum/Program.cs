

namespace _08._Magic_Sum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] + numbers[k] == magicNum)
                    {
                        Console.Write($"{numbers[i]} {numbers[k]}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
