using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (var ch in input)
            {
                int currCh = ch;
                currCh += 3;
                sb.Append((char)currCh);
            }
            Console.WriteLine(sb);
        }
    }
}
