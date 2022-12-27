namespace _05._Sum_Even_Numbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];
                if (currNumber % 2 == 0)
                {
                    sum += currNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
