using System;

namespace _05._Digits__Letters_and_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (var currDigit in text)
            {
                if (char.IsDigit(currDigit))
                {
                    Console.Write(currDigit);
                }
            }
            Console.WriteLine();
            foreach (var currLetter in text)
            {
                if (char.IsLetter(currLetter))
                {
                    Console.Write(currLetter);
                }
            }
            Console.WriteLine();
            foreach (var currChar in text)
            {
                if (!char.IsLetter(currChar) && !char.IsDigit(currChar))
                {
                    Console.Write(currChar);
                }
            }
        }
    }
}
