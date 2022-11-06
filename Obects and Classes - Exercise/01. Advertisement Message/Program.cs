namespace _01._Advertisement_Message
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Excellent product.",
                "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.",
                "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] names = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                int phrase = random.Next(0, phrases.Length);
                int nextEvent = random.Next(0, events.Length);
                int name = random.Next(0, names.Length);
                int city = random.Next(0, cities.Length);
                Console.WriteLine($"{phrases[phrase]} {events[nextEvent]} {names[name]} – {cities[city]}.");
            }
        }
    }
}
