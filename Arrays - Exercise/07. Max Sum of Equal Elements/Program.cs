namespace _07._Max_Sum_of_Equal_Elements
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

            int currResult = 0;
            int maxResult = 0;
            int num = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    currResult++;
                }
                else
                {
                    currResult = 0;
                }
                if (currResult > maxResult)
                {
                    maxResult = currResult;
                    num = numbers[i];
                }
            }
            if (maxResult > 0)
            {
                for (int k = 0; k <= maxResult; k++)
                {
                    Console.Write(num + " ");
                }
            }
            else if (maxResult <= 0)
            {
                Console.WriteLine(numbers[0]);
            }
        }
    }
}
