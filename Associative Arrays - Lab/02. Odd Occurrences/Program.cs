namespace _02._Odd_Occurrences
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordsInLower = word.ToLower();

                if (counts.ContainsKey(wordsInLower))
                {
                    counts[wordsInLower]++;
                }
                else
                {
                    counts.Add(wordsInLower, 1);
                }
            }

            foreach (var count in counts) 
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
