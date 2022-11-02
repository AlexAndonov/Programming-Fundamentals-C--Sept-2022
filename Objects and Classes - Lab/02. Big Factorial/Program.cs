

namespace _02._Big_Factorial
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
