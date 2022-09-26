namespace _07._Water_Overflow
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int liters = 0;
            int currCapacity = 0;

            for (int i = 1; i <= n; i++)
            {
                liters = int.Parse(Console.ReadLine());
                currCapacity += liters;
                if (currCapacity > 255)
                {
                    currCapacity -= liters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currCapacity);
        }
    }
}
