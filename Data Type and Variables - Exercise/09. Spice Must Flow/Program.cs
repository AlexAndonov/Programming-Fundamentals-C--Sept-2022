using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalYield = 0;
            int days = 0;
            while (startingYield >= 100)
            {
                days++;
                totalYield += startingYield;
                totalYield -= 26;
                startingYield -= 10;
            }
            totalYield -= 26;
            if (totalYield > 0)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalYield);
            }
            else
            {
                Console.WriteLine("0");
                Console.WriteLine("0");
            }
            // END
        }
    }
}
