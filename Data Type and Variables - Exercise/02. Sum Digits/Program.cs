namespace _02._Sum_Digits
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numCopy = number;
            int totalSum = 0;

            while (numCopy > 0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                totalSum += lastDigit;
            }
            Console.WriteLine(totalSum);
        }
    }
}
