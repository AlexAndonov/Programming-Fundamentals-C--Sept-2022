using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double sum = GetStringSum(input[0], input[1]);
            Console.WriteLine(sum);
        }
        static double GetStringSum(string input1, string input2)
        {
            int sum = 0;
            int minLength = Math.Min(input1.Length, input2.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += input1[i] * input2[i];
            }

            if (input1.Length > input2.Length)
            {
                for (int i = minLength; i < input1.Length; i++)
                {
                    sum += input1[i];
                }
            }
            else if (input2.Length > input1.Length)
            {
                for (int i = minLength; i < input2.Length; i++)
                {
                    sum += input2[i];
                }
            }
            return sum;
        }
    }
}
