namespace _05._Bomb_Numebrs
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

            int[] bombAndPowNum = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bomb = bombAndPowNum[0];
            int power = bombAndPowNum[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int count = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, count);

                    i = startIndex - 1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
