namespace _01._Train
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] passengers = new int[n];
            int totalPassengers = 0;
            for (int i = 0; i < passengers.Length; i++)
            {
                int passengersCount = int.Parse(Console.ReadLine());
                passengers[i] = passengersCount;
                totalPassengers += passengersCount;
            }
            for (int i = 0; i < passengers.Length; i++)
            {
                Console.Write(passengers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPassengers);
        }
    }
}
