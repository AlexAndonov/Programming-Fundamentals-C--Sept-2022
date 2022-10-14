namespace _06._Equal_Sums
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNum = arr[j];
                    rightSum += rightNum;
                }
                if (i > 0)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        int leftNum = arr[k];
                        leftSum += leftNum;
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
